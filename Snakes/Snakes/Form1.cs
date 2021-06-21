using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    public partial class Form1 : Form
    {
        private ISnake snake;
        private PictureBox[] pbSnake = new PictureBox[400];

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
            CreateSnake();
            update();
        }

        public void CreateSnake()
        {
            snake = new Snake();
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            snake.Move();
                update();
        }

        private void update()
        {
            this.Controls.Clear();
            pbSnake[0] = new PictureBox();
            pbSnake[0].Location = new System.Drawing.Point(snake.Head().Point().X() + 20, snake.Head().Point().Y() + 20);
            pbSnake[0].Size = new Size(20, 20);
            pbSnake[0].BackColor = Color.Red;
            this.Controls.Add(pbSnake[0]);

            for (int i = 0; i < snake.Body().Points().Count; i++)
            {
                var point = snake.Body().Points()[i];
                pbSnake[i + 1] = new PictureBox();
                pbSnake[i + 1].Location = new System.Drawing.Point(point.X() + 20, point.Y() + 20);
                pbSnake[i + 1].Size = new Size(20, 20);
                pbSnake[i + 1].BackColor = Color.Green;
                this.Controls.Add(pbSnake[i + 1]);
            }
        }
    }
}
