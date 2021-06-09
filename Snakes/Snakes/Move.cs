using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    class Move : IMove
    {
        int _score;
        int dirX = 1;
        int dirY = 0;
        int _sizeOfSides = 20;

        void IMove.Move(PictureBox[] _snake, int _score)
        {
            for (int i = _score; i >= 1; i--)
            {
                _snake[i].Location = _snake[i - 1].Location;
            }
            _snake[0].Location = new Point(_snake[0].Location.X + dirX * _sizeOfSides, _snake[0].Location.Y + dirY * _sizeOfSides);
        }
    
        void IMove.OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
            }
        }
    }
}
