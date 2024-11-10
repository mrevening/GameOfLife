namespace Life
{
    public class Game
    {
        private int MaxIteration { get; }
        private int CurrentIteration { get; set; }
        public Board CurrentBoard { get; private set; }
        public Game(Board InitBoard, int maxIterations) 
        {
            CurrentBoard = InitBoard;
            MaxIteration = maxIterations;
            CurrentIteration = 0;
        }

        public void Start()
        {
            while (CurrentIteration <= MaxIteration)
            {
                CurrentIteration++;
                CurrentBoard = new Board(CurrentBoard.CalculateTick());
            }
        }
    }
}
