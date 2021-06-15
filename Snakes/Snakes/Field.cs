using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snakes
{
    public class Field : IField
    {
       
        public int width { get; set; }
        public int height { get;  set; }
        public int sizeOfSides { get; set; }
 
        public Field()
        {
            width = 800;
            height = 800;
            sizeOfSides = 20;
            Drawing();
        }

        public void Drawing()
        {
            WriteHorizontalLine();
            WriteVerticalLine();
        }

        private void WriteVerticalLine()
        {
            for (int i = 0; i <= width / sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, 760);
                pic.Size = new Size(height, 1);
                this.Controls.Add(pic);
                
            }
        }

        private void WriteHorizontalLine()
        {
            for (int i = 0; i <= height / sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(800, 0);
                pic.Size = new Size(1, width - 140);
                this.Controls.Add(pic);
            }
        }
    }
}
