using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    public class Point : IPoint
    {
        private int _x, _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X()
        {
            return _x;
        }

        public int Y()
        {
            return _y;
        }
    }
}
