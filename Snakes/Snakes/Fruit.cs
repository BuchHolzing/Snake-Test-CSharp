using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    class Fruit : IFruit
    {
        int _sizeOfSides = 20;
        int rI, rJ;
        int _height = 400;
        int _width = 400;
        private PictureBox fruit;
        public void GenerationFruit(PictureBox fruit)
        {
            fruit = new PictureBox();
            fruit.BackColor = Color.Black;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);

            Random r = new Random();
            rI = r.Next(0, _height - _sizeOfSides);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, _width - _sizeOfSides);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            fruit.Location = new Point(rI, rJ);
        }
    }
}
