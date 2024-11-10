namespace Life
{
    public class DeadCell : ICell
    {
        public DeadCell() {}

        public State CalculateState(int livingNeighbours)
        {
            if (livingNeighbours == 3)
            {
                return State.Lives;
            }
            return State.Dies;
        }
    }
}
