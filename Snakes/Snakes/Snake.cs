using System.Collections.Generic;

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

        public void Move(string direction)
        {
            var oldHead = _head;
            MoveHead(direction, oldHead);
            MoveBody(oldHead.Point());
        }

        private void MoveHead(string direction, ISnakeHead _oldHead)
        {
            var x = _oldHead.Point().X();
            var y = _oldHead.Point().Y();

            switch (direction)
            {
                case "Up":
                    _head = new SnakeHead(new Point(x, y - 1));
                    break;
                case "Down":
                    _head = new SnakeHead(new Point(x, y + 1));
                    break;
                case "Right":
                    _head = new SnakeHead(new Point(x + 1, y));
                    break;
                case "Left":
                    _head = new SnakeHead(new Point(x - 1, y));
                    break;
            }
        }

        private void MoveBody(IPoint _oldHeadPoint)
        {
            var _oldBody = _body;
            var points = new SortedDictionary<int, IPoint>();
            points.Add(0, _oldHeadPoint);
            if (_oldBody.Points().Count != 0)
            {
                for (int i = 1; i < _oldBody.Points().Count; i++)
                {
                    points.Add(i, _oldBody.Points()[i - 1]);
                }
                _body = new SnakeBody(points);
            }
        }
    }
}
