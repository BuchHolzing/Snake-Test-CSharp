using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    class SnakeHead : ISnakeHead
    {
        private IPoint _point;
        private Heading _heading;

        public SnakeHead(IPoint point)
        {
            _point = point;
           // _heading = Snakes.Heading.Down;

        }

        public SnakeHead(IPoint point, Heading heading)
        {
            _point = point;
            _heading = heading;
        }

        public Heading Heading()
        {
            return _heading;
        }

        public IPoint Point()
        {
            return _point;
        }

    }
}
