using System.Windows.Forms;

namespace Snakes
{
     public interface ISnake
    {
        ISnakeHead Head();
        ISnakeBody Body();
        void Move();
        bool Eat(IPoint point);       
    }
}
