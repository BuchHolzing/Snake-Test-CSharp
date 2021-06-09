using System.Windows.Forms;

namespace Snakes
{
    class EventHandler : IEventHandler
    {
        private IState _state;
        private ISnakeBody _snakeBody;
        private IMove _snake, _score;
        private IFruit _fruit;

        public EventHandler(IState state)
        {
            _state = state;
            
        }

        public EventHandler (ISnakeBody snakeBody)
        {
            _snakeBody = snakeBody;
        }

        public EventHandler (IMove snake, IMove score)
        {
            _snake = snake;
            _score = score;
        }

        public EventHandler(IFruit fruit)
        {
            _fruit = fruit;
        }

        public IState Handle(int intUserInput)
        {
    
            return new State(_state.Score());
        }

        ISnakeBody IEventHandler.Handle(PictureBox[] snakeBody)
        {
            return new SnakeBody();
        }

        public IMove Handle(PictureBox[] _snakeBody, int _score)
        {
            return new Move();
        }

        public IFruit Handle(PictureBox fruit)
        {
            return new Fruit();
        }
    }
}
