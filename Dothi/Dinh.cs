using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dothi
{
    class Dinh
    {
        const int size = 25;
        private string _tenDinh;
        private int _bacCuaDinh;
        private int _banBacVao;
        private int _banBacRa;
        private Point _pos;

        public Dinh()
        {
            _tenDinh = null;
            _bacCuaDinh = 0;
            _banBacRa = 0;
            _banBacVao = 0;
        }

        public Dinh(string tenDinh, int bac, int banBacVao, int banBacRa, Point pos)
        {
            _tenDinh = tenDinh;
            _bacCuaDinh = bac;
            _banBacVao = banBacVao;
            _banBacRa = banBacRa;
            _pos = pos;
        }

        public Dinh(string tenDinh, Point pos)
        {
            _tenDinh = tenDinh;
            _pos = pos;
        }

        public string tenDinh
        {
            get { return _tenDinh; }
            set { _tenDinh = value; }
        }

        public int bacCuaDinh
        {
            get { return _bacCuaDinh; }
            set { _bacCuaDinh = value; }
        }

        public int banBacVao
        {
            get { return _banBacVao; }
            set { _banBacVao = value; }
        }

        public int banBacRa
        {
            get { return _banBacRa; }
            set { _banBacRa = value; }
        }

        public Point pos
        {
            get { return _pos; }
            set { _pos = value; }
        }

        public void DrawNode(Graphics g, SolidBrush sb)
        {
            g.FillEllipse(sb, _pos.X, _pos.Y, size, size);
        }

        public void AddNodeName(Graphics g)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Font f = new Font("Arial", 11);
            g.DrawString(_tenDinh, f, sb, _pos.X + 6, _pos.Y + 6);
            f.Dispose();
        }
    }
}