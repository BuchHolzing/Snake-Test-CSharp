using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    public partial class Form1 : Form
    {
        PictureBox[] snake = new PictureBox[400];

        public Form1()
        {
            InitializeComponent();

            var _snakeHead = new SnakeHead();
            var p = _snakeHead.PropertiesSnake();

            snake[0] = new PictureBox();
            snake[0].Location = new Point(p.X(), p.Y());
            snake[0].Size = new Size(p.SizeHeight(), p.SizeWidth());
            this.Controls.Add(snake[0]);

        }
    }
}
