using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dothi
{
    class Prim
    {
        private int[,] _cayKhung;
        private int[] _parent;
        private int[] _key;
        private bool[] _free;

        public int[,] cayKhung
        {
            get { return _cayKhung; }
        }

        public Prim(Graph doThi)
        {
            _cayKhung = new int[doThi.soDinh, doThi.soDinh];
            _parent = new int[doThi.soDinh];
            _key = new int[doThi.soDinh];
            _free = new bool[doThi.soDinh];
        }

        public void TimCayKhung(int start, Graph doThi)
        {
            for (int i = 0; i < doThi.soDinh; ++i)
            {
                _key[i] = 1000;
                _free[i] = true;
            }
            _key[start] = 0;
            for (int i = 0; i < doThi.soDinh - 1; ++i)
            {
                int dinh = ExtractMin(doThi.soDinh);
                _free[dinh] = false;
                for (int j = 0; j < doThi.soDinh; ++j)
                    if (_free[j] && doThi.maTran[dinh, j] != 0 && doThi.maTran[dinh, j] < _key[j])
                    {
                        _key[j] = doThi.maTran[dinh, j];
                        _parent[j] = dinh;
                    }
            }
            for (int i = 0; i < doThi.soDinh; ++i)
            {
                _cayKhung[_parent[i], i] = doThi.maTran[_parent[i], i];
                _cayKhung[i, _parent[i]] = doThi.maTran[_parent[i], i];
            }
        }

        private int ExtractMin(int soDinh)
        {
            int min = 1000;
            int dinh = 0;
            for (int i = 0; i < soDinh; ++i)
                if (_free[i] && _key[i] < min)
                {
                    min = _key[i];
                    dinh = i;
                }
            return dinh;
        }

        public void VeCayKhung(Graph doThi, Graphics g)
        {
            Pen pen = new Pen(Color.Red, 3.0F);
            Point p1;
            Point p2;
            for (int i = 0; i < doThi.soDinh; ++i)
                for (int j = 0; j < doThi.soDinh; ++j)
                    if (_cayKhung[i, j] != 0)
                    {
                        p1 = new Point(doThi.lstDinh[i].pos.X + 15, doThi.lstDinh[i].pos.Y + 15);
                        p2 = new Point(doThi.lstDinh[j].pos.X + 15, doThi.lstDinh[j].pos.Y + 15);
                        g.DrawLine(pen, p1, p2);
                    }
        }
    }
}