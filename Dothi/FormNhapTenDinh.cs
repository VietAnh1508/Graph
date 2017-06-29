using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dothi
{
    public partial class FormNhapTenDinh : Form
    {
        private string _nhapTenDinh;
        public string nhapTenDinh
        {
            get { return _nhapTenDinh; }
        }
        public FormNhapTenDinh()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _nhapTenDinh = txtTenDinh.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu không hợp lệ!!");
            }
        }

        private void FormNhapTenDinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTenDinh.Text == "")
                e.Cancel = true;
            else
            {
                try
                {
                    _nhapTenDinh = txtTenDinh.Text;
                }
                catch
                {
                    MessageBox.Show("Kiểu dữ liệu không hợp lệ!!");
                    e.Cancel = true;
                }
            }
        }
    }
}