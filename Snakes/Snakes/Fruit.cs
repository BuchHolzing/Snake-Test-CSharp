using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    public class Fruit : IFruit
    {
        private IBodyFruit _bodyFruit;
        int rI = 0;
        int rJ = 0;
        int _sizeOfSides = 20;
        ISnake snk;

        public Fruit()
        {
            Random r = new Random();
            rI = r.Next(0, 100);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, 100);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            _bodyFruit = new BodyFruit(new Point(rI, rJ));
        }

       public IBodyFruit Fruits()
        {
            return _bodyFruit;
        }
    }
}
