namespace Life
{
    public class Cell
    {
        private State StartState { get; }
        private int LivingNeighbours { get; }
        public Cell(bool isAlive, int livingNeighbours)
        {
            StartState = isAlive ? State.Lives : State.Dies;
            LivingNeighbours = livingNeighbours;
        }

        public State CalculateState()
        {
            if (StartState == State.Dies)
            {
                if (LivingNeighbours == 3)
                {
                    return State.Lives;
                }
                return State.Dies;
            }

            switch (LivingNeighbours)
            {
                case 0:
                case 1:
                    return State.Dies;
                case 2:
                case 3:
                    return State.Lives;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    return State.Dies;
                default:
                    return State.Dies;
            }
        }
    }
}
