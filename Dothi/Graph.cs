using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dothi
{
    class Graph
    {
        private int _soDinh;
        private int _tongBac;
        private int[,] _maTran;
        private string _bacMax;
        private string _bacMin;
        private bool _coHuong;
        private bool _coTrongSo;
        private List<Dinh> _lstDinh;

        public Graph()
        {
            _soDinh = 0;
            _tongBac = 0;
        }
        #region Properties
        public int[,] maTran
        {
            get { return _maTran; }
            set { _maTran = value; }
        }
        public int tongBac
        {
            get { return _tongBac; }
            set { _tongBac = value; }
        }
        public string bacMax
        {
            get { return _bacMax; }
            set { _bacMax = value; }
        }
        public string bacMin
        {
            get { return _bacMin; }
            set { _bacMin = value; }
        }
        public int soDinh
        {
            get { return _soDinh; }
            set { _soDinh = value; }
        }
        public bool coHuong
        {
            get { return _coHuong; }
            set { _coHuong = value; }
        }
        public bool coTrongSo
        {
            get { return _coTrongSo; }
        }
        public List<Dinh> lstDinh
        {
            get { return _lstDinh; }
            set { _lstDinh = value; }
        }
        #endregion
        #region XuLiDoThi
        public bool MaTranBangKhong()
        {
            for (int i = 0; i < _soDinh; ++i)
                for (int j = 0; j < _soDinh; ++j)
                    if (_maTran[i, j] != 0)
                        return false;
            return true;
        }

        public bool KiemTraMaTranHopLe(string text)
        {
            foreach (char c in text)
                if (!Char.IsDigit(c) && c != ' ' && c != '\n' && c != '\r')
                    return false;
            string[] array = text.Replace("\r\n", " ").Replace("  ", " ").Split(' ');
            int can = (int)Math.Sqrt(array.Length);
            if (can * can == array.Length)
                return true;
            return false;
        }

        public void DocFile(string path)
        {
            StreamReader doc = new StreamReader(path);
            string[] temp = doc.ReadToEnd().Replace("\r\n", " ").Split(' ');
            _soDinh = (int)Math.Sqrt(temp.Length);
            _maTran = new int[_soDinh, _soDinh];
            for (int i = 0; i < _soDinh; ++i)
                for (int j = 0; j < _soDinh; ++j)
                    _maTran[i, j] = int.Parse(temp[i * _soDinh + j].ToString());
            doc.Close();
        }

        public void CreateMatrix(string text)
        {
            text = text.Replace("\r\n", " ");
            text = text.Replace("  ", " ");
            text = text.Trim();
            string[] temp = text.Split(' ');
            int length = (int)Math.Sqrt(temp.Length);
            _soDinh = length;
            _maTran = new int[_soDinh, _soDinh];
            for (int i = 0; i < length; ++i)
                for (int j = 0; j < length; ++j)
                    _maTran[i, j] = int.Parse(temp[i * length + j].ToString());
        }

        public void CreatePoint(int width, int heigth)
        {
            if (_lstDinh == null)
                _lstDinh = new List<Dinh>();
            int nameUnicode = 65;
            int bacCuaDinh, banBacVao = 0, banBacRa = 0;
            Dinh item;
            Random rand = new Random();
            Point pRand = new Point();
            for (int i = 0; i < _soDinh; ++i)
            {
                pRand.X = rand.Next(width - 30);
                pRand.Y = rand.Next(heigth - 30);
                if (_coHuong)
                {
                    banBacVao = 0;
                    banBacRa = 0;
                    for (int j = 0; j < _soDinh; ++j)
                    {
                        if (_maTran[i, j] != 0)
                            banBacRa++;
                        if (_maTran[j, i] != 0)
                            banBacVao++;
                    }
                    bacCuaDinh = banBacVao + banBacRa;
                    _tongBac += bacCuaDinh;
                }
                else
                {
                    bacCuaDinh = 0;
                    for (int j = 0; j < _soDinh; ++j)
                        if (_maTran[i, j] != 0)
                            bacCuaDinh++;
                    _tongBac += bacCuaDinh;
                }
                item = new Dinh(((char)(nameUnicode + i)).ToString(), bacCuaDinh, banBacVao, banBacRa, pRand);
                lstDinh.Add(item);
            }
        }

        public void TinhBac()
        {
            int bacCuaDinh, banBacVao, banBacRa;
            for (int i = 0; i < _soDinh; ++i)
            {
                if (_coHuong)
                {
                    banBacVao = 0;
                    banBacRa = 0;
                    for (int j = 0; j < _soDinh; ++j)
                    {
                        if (_maTran[i, j] != 0)
                            banBacRa++;
                        if (_maTran[j, i] != 0)
                            banBacVao++;
                    }
                    _lstDinh[i].banBacRa = banBacRa;
                    _lstDinh[i].banBacVao = banBacVao;
                    _lstDinh[i].bacCuaDinh = banBacVao + banBacRa;
                    _tongBac += (banBacVao + banBacRa);
                }
                else
                {
                    bacCuaDinh = 0;
                    for (int j = 0; j < _soDinh; ++j)
                        if (_maTran[i, j] != 0)
                            bacCuaDinh++;
                    _lstDinh[i].bacCuaDinh = bacCuaDinh;
                    _tongBac += bacCuaDinh;
                }
            }
        }

        public void TimBacMaxMin()
        {
            int max = lstDinh[0].bacCuaDinh;
            _bacMax = lstDinh[0].tenDinh;
            int min = lstDinh[0].bacCuaDinh;
            _bacMin = lstDinh[0].tenDinh;
            for (int i = 1; i < _soDinh; ++i)
            {
                if (_lstDinh[i].bacCuaDinh > max)
                {
                    max = _lstDinh[i].bacCuaDinh;
                    _bacMax = lstDinh[i].tenDinh;
                }
                if (_lstDinh[i].bacCuaDinh < min)
                {
                    min = _lstDinh[i].bacCuaDinh;
                    _bacMin = lstDinh[i].tenDinh;
                }
            }
        }

        private bool MaTranDoiXung()
        {
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    if (_maTran[i, j] != _maTran[j, i])
                        return false;
            return true;
        }

        public void XetHuong()
        {
            if (MaTranDoiXung())
                _coHuong = false;
            else
                _coHuong = true;
        }

        public void XetTrongSo()
        {
            for (int i = 0; i < _soDinh; i++)
                for (int j = 0; j < _soDinh; j++)
                    if (_maTran[i, j] > 1)
                    {
                        _coTrongSo = true;
                        return;
                    }
            _coTrongSo = false;
        }
        #endregion
        #region VeDoThi
        public void Draw(Graphics g, SolidBrush sb, Pen p)
        {
            SolidBrush s = new SolidBrush(Color.Black);
            if (_coHuong)
            {
                for (int i = 0; i < _soDinh; ++i)
                    for (int j = 0; j < _soDinh; ++j)
                        if (_maTran[i, j] != 0)
                            DrawVector(g, p, _lstDinh[i].pos, _lstDinh[j].pos);
            }
            else
            {
                for (int i = 0; i < _soDinh; ++i)
                    for (int j = 0; j < _soDinh; ++j)
                        if (_maTran[i, j] != 0)
                            DrawLine(g, p, _lstDinh[i].pos, _lstDinh[j].pos);
            }

            for (int k = 0; k < _soDinh; ++k)
            {
                lstDinh[k].DrawNode(g, sb);
                lstDinh[k].AddNodeName(g);
            }

            if (_coTrongSo)
                for (int i = 0; i < _soDinh; ++i)
                    for (int j = 0; j < _soDinh; ++j)
                        if (_maTran[i, j] != 0)
                            VeTrongSo(g, _maTran[i, j], _lstDinh[i].pos, _lstDinh[j].pos);
            s.Dispose();
        }

        public void DrawLine(Graphics g, Pen pen, Point dau, Point cuoi)
        {
            dau.X += 15;
            dau.Y += 15;
            cuoi.X += 15;
            cuoi.Y += 15;
            g.DrawLine(pen, dau, cuoi);
        }

        public void DrawVector(Graphics g, Pen pen, Point dau, Point cuoi)
        {
            Point trungDiem = new Point();
            Pen customPen = new Pen(Color.Black, 3);
            GraphicsPath customEndPath = new GraphicsPath();
            customEndPath.AddLine(0, 0, -4, -4);
            customEndPath.AddLine(0, 0, 4, -4);
            customPen.CustomEndCap = new CustomLineCap(null, customEndPath);
            dau.X += 15;
            dau.Y += 15;
            cuoi.X += 15;
            cuoi.Y += 15;
            trungDiem.X = (dau.X + cuoi.X) / 2;
            trungDiem.Y = (dau.Y + cuoi.Y) / 2;
            g.DrawLine(customPen, dau, trungDiem);
            g.DrawLine(pen, trungDiem, cuoi);
            customPen.Dispose();
            customEndPath.Dispose();
        }

        public void VeTrongSo(Graphics g, int trongSo, Point p1, Point p2)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Point trungDiem = new Point();
            Font f = new Font("Arial", 13);
            p1.X += 15;
            p1.Y += 15;
            p2.X += 15;
            p2.Y += 15;
            trungDiem.X = ((p1.X + p2.X) / 2) - 20;
            trungDiem.Y = ((p1.Y + p2.Y) / 2) - 20;
            g.DrawString(trongSo.ToString(), f, sb, trungDiem);
            f.Dispose();
        }
        #endregion
    }
}