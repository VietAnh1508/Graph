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
    public partial class FormNhapTrongSo : Form
    {
        private int _nhapTrongSo;
        public int nhapTrongSo
        {
            get { return _nhapTrongSo; }
            set { _nhapTrongSo = value; }
        }
        public FormNhapTrongSo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                _nhapTrongSo = int.Parse(txtTrongSo.Text);
                if (_nhapTrongSo == 0)
                {
                    MessageBox.Show("Trọng số phải khác 0!!!");
                    txtTrongSo.Clear();
                    txtTrongSo.Focus();
                }
                else
                    this.Close();
            }
            catch
            {
                MessageBox.Show("Kiểu dữ liệu không hợp lệ!!");
            }
        }

        private void FormNhapTrongSo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTrongSo.Text == "")
                e.Cancel = true;
            else
            {
                try
                {
                    _nhapTrongSo = int.Parse(txtTrongSo.Text);
                    if (_nhapTrongSo == 0)
                    {
                        MessageBox.Show("Trọng số phải khác 0!!!");
                        txtTrongSo.Clear();
                        txtTrongSo.Focus();
                    }
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