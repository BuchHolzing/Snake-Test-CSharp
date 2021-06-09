using System.Windows.Forms;
namespace Snakes
{
    interface IEventHandler
    {
        IState Handle(int intUserInput);
        ISnakeBody Handle(PictureBox[] snakeBody);
        IMove Handle(PictureBox[] _snake, int _score);
        IFruit Handle(PictureBox fruit);
    }
}
