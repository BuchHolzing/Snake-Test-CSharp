using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    interface ISnakeHead
    {
        void MoveHead();
        void EatFruit();
        void EatItSelf();
        void Bump();
    }
}
