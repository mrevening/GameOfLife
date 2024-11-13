namespace Life
{
    public class DeadCell : ICell
    {
        public DeadCell() {}

        public State CalculateState(int livingNeighbours)
        {
            return livingNeighbours == 3 ? State.Lives : State.Dies;
        }
    }
}
