using System.Drawing;
using System.Windows.Forms;


namespace Snakes
{
    public class Snake : ISnake
    {
        private ISnakeHead _snakeHead;

        public ISnakeHead SnakeHead()
        {
            return _snakeHead;
        }
    }
}
