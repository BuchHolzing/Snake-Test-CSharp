using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public interface IField
    {
        int width { get; }
        int height { get; }
        int sizeOfSides { get; }
        void Drawing();
    }
}
