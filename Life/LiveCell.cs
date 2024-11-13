namespace Life
{
    public class LiveCell : ICell
    {
        public LiveCell() { }

        public State CalculateState(int livingNeighbours)
        {
            return livingNeighbours switch
            {
                2 or 3 => State.Lives,
                _ => State.Dies,
            };
        }
    }
}
