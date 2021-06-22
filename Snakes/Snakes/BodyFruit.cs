using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public class BodyFruit : IBodyFruit
    {
        private IPoint _point;

        public BodyFruit(IPoint point)
        {
            _point = point;
        }

        public IPoint Point()
        {
            return _point;
        }
    }
}
