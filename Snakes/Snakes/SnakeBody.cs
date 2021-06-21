using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public class SnakeBody : ISnakeBody
    {
        private SortedDictionary<int, IPoint> _points;

        public SnakeBody()
        {
            _points = new SortedDictionary<int, IPoint>();
        }

        public SnakeBody(SortedDictionary<int, IPoint> points)
        {
            _points = points;
        }

        public SortedDictionary<int, IPoint> Points()
        {
            return _points;
        }
    }
}
