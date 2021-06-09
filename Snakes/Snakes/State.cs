namespace Snakes
{
    class State : IState
    {
        private int _score;
       
          public State(int score)
        {
            _score = score;         
        }

        public int Score()
        {
            return _score;
        }

        
    }
}
