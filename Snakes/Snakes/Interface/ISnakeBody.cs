using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public interface ISnakeBody
    {
        SortedDictionary<int, IPoint> Points();
    }
}
