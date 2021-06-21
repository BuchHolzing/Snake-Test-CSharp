using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snakes
{
    public class Snake : ISnake
    {
        private ISnakeHead _head;
        private ISnakeBody _body;

        public Snake()
        {
            _head = new SnakeHead(new Point(100, 100));
            _body = new SnakeBody();
        }

        public ISnakeBody Body()
        {
            return _body;
        }

        public bool Eat(IPoint point)
        {
            throw new System.NotImplementedException();
        }

        public ISnakeHead Head()
        {
            return _head;
        }

        public void Move()
        {
            var oldHead = _head;
            MoveHead(oldHead);
            MoveBody(oldHead.Point());
         
        }

        private void MoveHead(ISnakeHead _oldHead)
        {
            var x = _oldHead.Point().X();
            var y = _oldHead.Point().Y();
           _head = new SnakeHead(new Point(x, y - 1), _oldHead.Heading());
        }

        private void MoveBody(IPoint _oldHeadPoint)
        {
            var _oldBody = _body;
            var points = new SortedDictionary<int, IPoint>();
            points.Add(0, _oldHeadPoint);
            for (int i = 1; i < _oldBody.Points().Count; i++)
            {
                points.Add(i, _oldBody.Points()[i - 1]);
            }
            _body = new SnakeBody(points);
        }
    }
}
