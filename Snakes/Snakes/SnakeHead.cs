using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snakes
{
    class SnakeHead : ISnakeHead
    {
        public IPropertiesSnake _propertiesSnake;

        public SnakeHead()
        {
            _propertiesSnake = new PropertiesSnake(50, 50, 20, 20);
        }

        public IPropertiesSnake PropertiesSnake()
        {
            return _propertiesSnake;
        }
    }
}
