using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dothi
{
    public enum Mode
    {
        DocTuFile,
        NhapTrucTiep,
        VeTrucTiep
    }
    public enum Tool
    {
        VeNode,
        VeCanh,
        DiChuyen,
        Xoa
    }
    public partial class Form1 : Form
    {
        private Graph _doThi;
        private static Pen pen;
        private static SolidBrush sb;
        private Graphics grs;
        private bool isOpenFile;
        private Mode mode;
        private Tool tool;
        private Point mouseDownLocation, mouseUpLocation;
        private bool isMouseDown;
        private int curSelectedNode, curNodeAmount, nameUnicode, nodeDau, nodeCuoi;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            _doThi = new Graph();
            curNodeAmount = 0;
            nodeDau = -1;
            nodeCuoi = -1;
            nameUnicode = 65;
            curSelectedNode = -1;
            isOpenFile = false;
            isMouseDown = false;
            pen = new Pen(Color.Black, 3.0F);
            sb = new SolidBrush(Color.BurlyWood);
            grs = pnlGraph.CreateGraphics();
            
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbDocTuFile.Checked = true;
            txtDisplayMatrix.Enabled = false;
            dgvCanhCung.Enabled = false;
            btnReset.Enabled = false;
            btnDisplay.Enabled = false;
            rdbVeNode.Enabled = false;
            rdbVeCanh.Enabled = false;
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt File |*.txt";
            openFileDialog1.InitialDirectory = @"D:\Lý thuyết đồ thị";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isOpenFile = true;
                txtPath.Text = openFileDialog1.FileName;
                if (_doThi.KiemTraMaTranHopLe(File.ReadAllText(openFileDialog1.FileName)))
                {
                    _doThi.DocFile(txtPath.Text);
                    btnDisplay.Enabled = true;
                    btnOpen.Enabled = false;
                    MessageBox.Show("Nhập thành công");
                }
                else
                    MessageBox.Show("Ma trận không hợp lệ");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;
            btnReset.Enabled = true;
            btnChuyenDoi.Enabled = true;
            if (_doThi.maTran != null)
            {
                if (txtDisplayMatrix.Text == "")
                {
                    for (int i = 0; i < _doThi.soDinh; ++i)
                    {
                        for (int j = 0; j < _doThi.soDinh; ++j)
                            txtDisplayMatrix.Text += (_doThi.maTran[i, j].ToString() + " ");
                        txtDisplayMatrix.Text += "\r\n";
                    }
                }
                _doThi.XetHuong();
                _doThi.XetTrongSo();
                if (mode == Mode.DocTuFile || mode == Mode.NhapTrucTiep)
                {
                    
                    if (_doThi.coHuong)
                        cmbHuong.Items.Add("Có hướng");
                    else
                        cmbHuong.Items.Add("Vô hướng");
                    if (_doThi.coTrongSo)
                        cmbTrongSo.Items.Add("Có trọng số");
                    else
                        cmbTrongSo.Items.Add("Không có trọng số");
                    cmbHuong.SelectedIndex = 0;
                    cmbTrongSo.SelectedIndex = 0;
                    _doThi.CreatePoint(pnlGraph.Width, pnlGraph.Height);
                    btnDrawGraph.Enabled = true;
                }
                if (mode == Mode.VeTrucTiep)
                    _doThi.TinhBac();
                _doThi.TimBacMaxMin();
                lblSoDinh.Text += _doThi.soDinh.ToString();
                lblSoBac.Text += _doThi.tongBac.ToString();
                lblSoCanh.Text += (_doThi.tongBac / 2).ToString();
                lblDinhBacMax.Text += _doThi.bacMax.ToString();
                lblDinhBacMin.Text += _doThi.bacMin.ToString();
                HienThiThongTinListView();
            }
            else
                MessageBox.Show("Chưa có thông tin ma trận", "Thông báo");
        }

        private void HienThiThongTinListView()
        {
            ListViewItem item;
            string[] thongTin = new string[4];
            for (int i = 0; i < _doThi.soDinh; ++i)
            {
                thongTin[0] = _doThi.lstDinh[i].tenDinh;
                thongTin[1] = _doThi.lstDinh[i].bacCuaDinh.ToString();
                thongTin[2] = _doThi.lstDinh[i].banBacVao.ToString();
                thongTin[3] = _doThi.lstDinh[i].banBacRa.ToString();
                item = new ListViewItem(thongTin);
                lsvThongTinDoThi.Items.Add(item);
            }
        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            if (mode == Mode.DocTuFile)
            {
                if (isOpenFile)
                {
                    for (int i = 0; i < _doThi.soDinh; ++i)
                    {
                        _doThi.Draw(grs, sb, pen);
                    }
                    btnDrawGraph.Enabled = false;
                }
                else
                    MessageBox.Show("Chưa có thông tin đồ thị!!", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (mode == Mode.NhapTrucTiep)
            {
                for (int i = 0; i < _doThi.soDinh; ++i)
                    _doThi.Draw(grs, sb, pen);
                btnDrawGraph.Enabled = false;
            }
            rdbDiChuyen.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _doThi = new Graph();
            curNodeAmount = 0;
            btnReset.Enabled = false;
            btnChuyenDoi.Enabled = false;
            btnOpen.Enabled = true;
            rdbDocTuFile.Checked = true;
            isOpenFile = false;
            txtPath.Clear();
            txtDisplayMatrix.Clear();
            dgvCanhCung.Rows.Clear();
            lsvThongTinDoThi.Items.Clear();
            cmbHuong.Items.Clear();
            cmbTrongSo.Items.Clear();
            grs.Clear(Color.White);
            lblSoDinh.Text = "Số đỉnh:";
            lblSoBac.Text = "Số bậc: ";
            lblSoCanh.Text = "Số cạnh: ";
            lblDinhBacMax.Text = "Đỉnh có bậc lớn nhất:";
            lblDinhBacMin.Text = "Đỉnh có bậc nhỏ nhất:";
            lblGraphType.Text = "Loại đồ thị:";
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < _doThi.soDinh; ++i)
                _doThi.Draw(grs, sb, pen);
        }

        private void pnlGraph_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
            isMouseDown = true;
            if (tool == Tool.DiChuyen)
            {
                for (int i = 0; i < _doThi.soDinh; ++i)
                {
                    int x = _doThi.lstDinh[i].pos.X;
                    int y = _doThi.lstDinh[i].pos.Y;
                    if (mouseDownLocation.X > x && mouseDownLocation.X < x + 30
                        && mouseDownLocation.Y > y && mouseDownLocation.Y < y + 30)
                    {
                        curSelectedNode = i;
                        break;
                    }
                }
            }
            if (tool == Tool.VeNode && mode == Mode.VeTrucTiep)
            {
                if (curNodeAmount == 0)
                    _doThi.lstDinh = new List<Dinh>();
                Dinh dinh = new Dinh(((char)(nameUnicode + curNodeAmount)).ToString(), 0, 0, 0, e.Location);
                dinh.DrawNode(grs, sb);
                dinh.AddNodeName(grs);
                curNodeAmount++;
                _doThi.lstDinh.Add(dinh);
                if (_doThi.MaTranBangKhong())
                {
                    _doThi.maTran = new int[curNodeAmount, curNodeAmount];
                    for (int i = 0; i < curNodeAmount; ++i)
                        for (int j = 0; j < curNodeAmount; ++j)
                            _doThi.maTran[i, j] = 0;
                }
                else
                {
                    int[,] temMatrix = new int[curNodeAmount - 1, curNodeAmount - 1];
                    for (int i = 0; i < curNodeAmount - 1; ++i)
                        for (int j = 0; j < curNodeAmount - 1; ++j)
                            temMatrix[i, j] = _doThi.maTran[i, j];
                    _doThi.maTran = new int[curNodeAmount, curNodeAmount];
                    for (int i = 0; i < curNodeAmount - 1; ++i)
                        for (int j = 0; j < curNodeAmount - 1; ++j)
                            _doThi.maTran[i, j] = temMatrix[i, j];
                }
                _doThi.soDinh = curNodeAmount;
            }
            if (tool == Tool.VeCanh)
            {
                for (int i = 0; i < curNodeAmount; ++i)
                {
                    int x = _doThi.lstDinh[i].pos.X;
                    int y = _doThi.lstDinh[i].pos.Y;
                    if (mouseDownLocation.X > x && mouseDownLocation.X < x + 30
                        && mouseDownLocation.Y > y && mouseDownLocation.Y < y + 30)
                    {
                        nodeDau = i;
                        break;
                    }
                }
            }
        }

        private void pnlGraph_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && curSelectedNode != -1 && tool == Tool.DiChuyen)
            {
                _doThi.lstDinh[curSelectedNode].pos = new Point(e.X, e.Y);
                pnlGraph.Invalidate();
            }
        }

        private void pnlGraph_MouseUp(object sender, MouseEventArgs e)
        {
            if (mode == Mode.DocTuFile)
                curSelectedNode = -1;
            if (mode == Mode.VeTrucTiep)
            {
                if (tool == Tool.VeCanh)
                {
                    mouseUpLocation = e.Location;
                    for (int i = 0; i < curNodeAmount; ++i)
                    {
                        int x = _doThi.lstDinh[i].pos.X;
                        int y = _doThi.lstDinh[i].pos.Y;
                        if (mouseUpLocation.X > x && mouseUpLocation.X < x + 30
                            && mouseUpLocation.Y > y && mouseUpLocation.Y < y + 30)
                        {
                            nodeCuoi = i;
                            break;
                        }
                    }
                    if ((nodeCuoi != -1) && (nodeCuoi != nodeDau))
                    {
                        if (cmbHuong.SelectedIndex == 0)
                        {
                            _doThi.DrawLine(grs, pen, _doThi.lstDinh[nodeDau].pos, _doThi.lstDinh[nodeCuoi].pos);
                            if (cmbTrongSo.SelectedIndex == 0)
                            {
                                _doThi.maTran[nodeDau, nodeCuoi] = 1;
                                _doThi.maTran[nodeCuoi, nodeDau] = 1;
                            }
                            if (cmbTrongSo.SelectedIndex == 1)
                            {
                                FormNhapTrongSo frm = new FormNhapTrongSo();
                                frm.ShowDialog();
                                _doThi.maTran[nodeDau, nodeCuoi] = frm.nhapTrongSo;
                                _doThi.maTran[nodeCuoi, nodeDau] = frm.nhapTrongSo;
                                _doThi.VeTrongSo(grs, frm.nhapTrongSo,
                                    _doThi.lstDinh[nodeDau].pos, _doThi.lstDinh[nodeCuoi].pos);
                            }
                        }
                        if (cmbHuong.SelectedIndex == 1)
                        {
                            _doThi.DrawVector(grs, pen, _doThi.lstDinh[nodeDau].pos, _doThi.lstDinh[nodeCuoi].pos);
                            if (cmbTrongSo.SelectedIndex == 0)
                                _doThi.maTran[nodeDau, nodeCuoi] = 1;
                            if (cmbTrongSo.SelectedIndex == 1)
                            {
                                FormNhapTrongSo frm = new FormNhapTrongSo();
                                frm.ShowDialog();
                                _doThi.maTran[nodeDau, nodeCuoi] = frm.nhapTrongSo;
                                _doThi.VeTrongSo(grs, frm.nhapTrongSo,
                                    _doThi.lstDinh[nodeDau].pos, _doThi.lstDinh[nodeCuoi].pos);
                            }
                        }
                    }
                    nodeCuoi = -1;
                }
            }
            isMouseDown = false;
            _doThi.XetHuong();
            _doThi.XetTrongSo();
        }

        private void rdbDocTuFile_CheckedChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnHoanThanh.Enabled = false;
            txtDisplayMatrix.Enabled = false;
            dgvCanhCung.Enabled = false;
            rdbVeNode.Enabled = false;
            rdbVeCanh.Enabled = false;
            rdbDiChuyen.Enabled = false;
            mode = Mode.DocTuFile;
            cmbHuong.Refresh();
            cmbTrongSo.Refresh();
        }

        private void rdbNhapTrucTiep_CheckedChanged(object sender, EventArgs e)
        {
            rdbVeNode.Enabled = false;
            rdbVeCanh.Enabled = false;
            btnOpen.Enabled = false;
            btnHoanThanh.Enabled = true;
            btnChuyenDoi.Enabled = true;
            txtDisplayMatrix.Enabled = true;
            dgvCanhCung.Enabled = true;
            mode = Mode.NhapTrucTiep;
            cmbHuong.Refresh();
            cmbTrongSo.Refresh();
        }

        private void rdbVeTrucTiep_CheckedChanged(object sender, EventArgs e)
        {
            _doThi = new Graph();
            curNodeAmount = 0;
            mode = Mode.VeTrucTiep;
            btnDrawGraph.Enabled = false;
            btnDisplay.Enabled = true;
            btnOpen.Enabled = false;
            btnHoanThanh.Enabled = false;
            btnReset.Enabled = true;

            rdbVeNode.Enabled = true;
            rdbVeCanh.Enabled = true;
            rdbDiChuyen.Enabled = true;
            rdbVeNode.Checked = true;
            txtDisplayMatrix.Enabled = false;
            dgvCanhCung.Enabled = false;
            pnlGraph.Enabled = true;
            
            cmbHuong.Visible = true;
            cmbTrongSo.Visible = true;
            cmbHuong.Enabled = true;
            cmbTrongSo.Enabled = true;
            cmbTrongSo.Items.Add("Không có trọng số");
            cmbTrongSo.Items.Add("Có trọng số");
            cmbHuong.Items.Add("Vô hướng");
            cmbHuong.Items.Add("Có hướng");
            cmbTrongSo.SelectedIndex = 0;
            cmbHuong.SelectedIndex = 0;
        }
        // Take image tool
        private void editGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Files (.png)|*.png|All Files (*.*)|*.*";
            Size size = new Size(pnlGraph.Width, pnlGraph.Height);
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                int x = Screen.PrimaryScreen.Bounds.X + this.Location.X + pnlGraph.Location.X + 9;
                int y = Screen.PrimaryScreen.Bounds.Y + this.Location.Y + pnlGraph.Location.Y + 31;
                Bitmap bitmap = new Bitmap(pnlGraph.Width - 3, pnlGraph.Height - 3);
                Graphics screenGraphics = Graphics.FromImage(bitmap);
                screenGraphics.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy);
                bitmap.Save(saveDialog.FileName, ImageFormat.Png);
                MessageBox.Show("Lưu ảnh thành công!!");
            }
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            _doThi = new Graph();
            if (txtDisplayMatrix.Text != null)
            {
                if (_doThi.KiemTraMaTranHopLe(txtDisplayMatrix.Text))
                {
                    _doThi.CreateMatrix(txtDisplayMatrix.Text);
                    MessageBox.Show("Nhập thành công!!!");
                    btnHoanThanh.Enabled = false;
                }
                else
                    MessageBox.Show("Ma trận không hợp lệ!", "Thông báo");
            }
            btnDisplay.Enabled = true;
            btnDrawGraph.Enabled = true;
        }

        private void btnVeDinh_Click(object sender, EventArgs e)
        {
            tool = Tool.VeNode;
        }
        private void btnVeCanh_Click(object sender, EventArgs e)
        {
            tool = Tool.VeCanh;
        }
        private void btnDiChuyen_Click(object sender, EventArgs e)
        {
            tool = Tool.DiChuyen;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            tool = Tool.Xoa;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.No)
                e.Cancel = true;
            else
            {
                grs.Dispose();
                pen.Dispose();
                sb.Dispose();
            }
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            dgvCanhCung.Enabled = true;
            if (txtDisplayMatrix.Text == "" && dgvCanhCung.Rows[0].Cells[0].Value != null)
            {
                int[,] dsCanhCung = new int[dgvCanhCung.RowCount - 1, 3];
                for (int i = 0; i < dgvCanhCung.RowCount - 1; ++i) // Chuyển dữ liệu từ DGV sang danh sách cạnh cung
                {
                    for (int j = 0; j < 3; ++j)
                        dsCanhCung[i, j] = int.Parse((dgvCanhCung.Rows[i].Cells[j].Value).ToString());
                }
                int max = -1;
                for (int i = 0; i < dgvCanhCung.RowCount - 1; ++i) // Tìm số đỉnh của danh sách cạnh cung
                    for (int j = 0; j < 2; ++j)
                        if (max < dsCanhCung[i, j])
                            max = dsCanhCung[i, j];
                bool coTrongSo = false;
                for (int i = 0; i < dgvCanhCung.RowCount - 1; ++i) // Kiểm tra có trọng số hay không
                    if (dsCanhCung[i, 2] > 1)
                    {
                        coTrongSo = true;
                        break;
                    }
                int[,] maTranKe = new int[max, max]; // Khởi tạo ma trận kề
                for (int i = 0; i < max; ++i) // Set ma trận kề full 0
                    for (int j = 0; j < max; ++j)
                        maTranKe[i, j] = 0;
                if (coTrongSo) // Chuyển danh sách cạnh cung sang ma trận kề
                {
                    for (int i = 0; i < dgvCanhCung.RowCount - 1; ++i)
                        maTranKe[dsCanhCung[i, 0] - 1, dsCanhCung[i, 1] - 1] = dsCanhCung[i, 2];
                }
                else
                {
                    for (int i = 0; i < dgvCanhCung.RowCount - 1; ++i)
                        maTranKe[dsCanhCung[i, 0] - 1, dsCanhCung[i, 1] - 1] = 1;
                }
                for (int i = 0; i < max; ++i) // Đưa ma trận kề ra textbox
                {
                    for (int j = 0; j < max; ++j)
                        txtDisplayMatrix.Text += (maTranKe[i, j].ToString() + " ");
                    txtDisplayMatrix.Text += "\r\n";
                }
            }
            if (txtDisplayMatrix.Text != null && dgvCanhCung.Rows[0].Cells[0].Value == null)
            {
                int _soCanh = _doThi.tongBac / 2;
                int index = 0;
                if (_doThi.coHuong)
                {
                    for (int i = 0; i < _soCanh; ++i)
                        dgvCanhCung.Rows.Add();
                    for (int i = 0; i < _doThi.soDinh; ++i)
                        for (int j = 0; j < _doThi.soDinh; ++j)
                            if (_doThi.maTran[i, j] != 0)
                            {
                                dgvCanhCung.Rows[index].Cells[0].Value = i + 1;
                                dgvCanhCung.Rows[index].Cells[1].Value = j + 1;
                                if (_doThi.coTrongSo)
                                    dgvCanhCung.Rows[index].Cells[2].Value = _doThi.maTran[i, j];
                                else
                                    dgvCanhCung.Rows[index].Cells[2].Value = 0;
                                index++;
                            }
                }
                else
                {
                    for (int i = 0; i < _soCanh; ++i)
                        dgvCanhCung.Rows.Add();
                    for (int i = 0; i < _doThi.soDinh - 1; ++i)
                        for (int j = i + 1; j < _doThi.soDinh; ++j)
                            if (_doThi.maTran[i, j] != 0)
                            {
                                dgvCanhCung.Rows[index].Cells[0].Value = i + 1;
                                dgvCanhCung.Rows[index].Cells[1].Value = j + 1;
                                if (_doThi.coTrongSo)
                                    dgvCanhCung.Rows[index].Cells[2].Value = _doThi.maTran[i, j];
                                else
                                    dgvCanhCung.Rows[index].Cells[2].Value = 0;
                                index++;
                            }
                }
            }
        }
        // Xuất đồ thị ra file text (đặt tên nhầm)
        private void tablePictrureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode == Mode.NhapTrucTiep || mode == Mode.VeTrucTiep)
            {
                if (txtDisplayMatrix.Text != "")
                {
                    saveFileDialog1.Filter = "RichTextFile |*.rtf|Text file (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.InitialDirectory = @":D";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, txtDisplayMatrix.Text);
                        txtPath.Text = saveFileDialog1.FileName;
                        MessageBox.Show("Lưu ma trận thành công!!!");
                    }
                }
                else
                    MessageBox.Show("Ma trận không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rdbVeNode_CheckedChanged(object sender, EventArgs e)
        {
            tool = Tool.VeNode;
        }

        private void rdbVeCanh_CheckedChanged(object sender, EventArgs e)
        {
            tool = Tool.VeCanh;
        }

        private void rdbDiChuyen_CheckedChanged(object sender, EventArgs e)
        {
            tool = Tool.DiChuyen;
        }

        private void primToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapTenDinh frm = new FormNhapTenDinh();
            frm.ShowDialog();
            Prim prim;
            string tenDinh = frm.nhapTenDinh;
            bool isFind = false;
            int index = -1;
            for (int i = 0; i < _doThi.soDinh; ++i)
                if (tenDinh == _doThi.lstDinh[i].tenDinh)
                {
                    isFind = true;
                    index = i;
                    break;
                }
            if (isFind)
            {
                prim = new Prim(_doThi);
                prim.TimCayKhung(index, _doThi);
                prim.VeCayKhung(_doThi, grs);
                txtDisplayMatrix.Clear();
                for (int i = 0; i < _doThi.soDinh; ++i)
                {
                    for (int j = 0; j < _doThi.soDinh; ++j)
                        txtDisplayMatrix.Text += (prim.cayKhung[i, j].ToString() + " ");
                    txtDisplayMatrix.Text += "\r\n";
                }
            }
            else
                MessageBox.Show("Tên đỉnh không tồn tại!");
        }
    }
}