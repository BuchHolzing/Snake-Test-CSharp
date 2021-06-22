using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    public partial class Form1 : Form
    {
        private ISnake snake;
        private IFruit fruit;
        private PictureBox[] pbSnake = new PictureBox[400];
        private PictureBox pbFruit;


        public Form1()
        {
            InitializeComponent();
            snake = new Snake();
            fruit = new Fruit();
            CreateSnake();
            CreateFruit();
            this.KeyDown += new KeyEventHandler(OnKeyPressed);
        }

        public void CreateSnake()
        {
            this.Controls.Clear();
            pbSnake[0] = new PictureBox();
            pbSnake[0].Location = new System.Drawing.Point(snake.Head().Point().X() + 20, snake.Head().Point().Y() + 20);
            pbSnake[0].Size = new Size(20, 20);
            pbSnake[0].BackColor = Color.Red;
            this.Controls.Add(pbSnake[0]);
        }

        public void CreateFruit()
        {
            pbFruit = new PictureBox();
            pbFruit.Location = new System.Drawing.Point(fruit.Fruits().Point().X(), fruit.Fruits().Point().Y());
            pbFruit.Size = new Size(20, 20);
            pbFruit.BackColor = Color.Black;
            this.Controls.Add(pbFruit);
        }

        private void OnKeyPressed(object sender, KeyEventArgs direction)
        {
            snake.Move(direction.KeyCode.ToString());
            CreateSnake();
            CreateFruit();
        }

        private void update()
        {
            for (int i = 0; i < snake.Body().Points().Count; i++)
            {
                var point = snake.Body().Points()[i];
                pbSnake[i + 1] = new PictureBox();
                pbSnake[i + 1].Location = new System.Drawing.Point(point.X(), point.Y());
                pbSnake[i + 1].Size = new Size(20, 20);
                pbSnake[i + 1].BackColor = Color.Green;
                this.Controls.Add(pbSnake[i + 1]);
            }
        }
    }
}
