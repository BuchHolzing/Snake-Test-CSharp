using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snakes
{
    public class PropertiesSnake : IPropertiesSnake
    {
        private int _x, _y, _sizeWidth, _sizeHeight;

        public PropertiesSnake(int x, int y, int sizeWidth, int sizeHeight)
        {
            _x = x;
            _y = y;
            _sizeWidth = sizeWidth;
            _sizeHeight = sizeHeight;
        }

        public int X()
        {
            return _x;
        }

        public int Y()
        {
            return _y;
        }

        public int SizeWidth()
        {
            return _sizeWidth;
        }

        public int SizeHeight()
        {
            return _sizeHeight;
        }
    }
}
