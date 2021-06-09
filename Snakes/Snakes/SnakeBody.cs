using System.Drawing;
using System.Windows.Forms;


namespace Snakes
{
    class SnakeBody : ISnakeBody
    {
        PictureBox[] _snakeBody;

        PictureBox[] ISnakeBody.SnakeBody(PictureBox[] snakeBody)
        {
            snakeBody[0] = new PictureBox();
            snakeBody[0].Location = new Point(200, 200);
            snakeBody[0].Size = new Size(20, 20);
            snakeBody[0].BackColor = Color.Red;
            _snakeBody = snakeBody;

            return _snakeBody;
        }     
    }
}
