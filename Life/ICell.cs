namespace Life
{
    public interface ICell
    {
        public State CalculateState(int livingNeighbours);
    }
}
