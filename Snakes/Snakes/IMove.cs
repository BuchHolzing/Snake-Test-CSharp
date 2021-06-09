using System.Windows.Forms;

namespace Snakes
{
    interface IMove
    {
        void Move(PictureBox[] _snake, int _score);
        void OnKeyboardPressed(object sender, KeyEventArgs e);
    }
}
