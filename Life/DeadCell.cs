namespace Life
{
    public class DeadCell
    {
        private int LivingNeighbours { get; }
        public DeadCell(int livingNeighbours)
        {
            LivingNeighbours = livingNeighbours;
        }

        public State CalculateState()
        {
            if (LivingNeighbours == 3)
            {
                return State.Lives;
            }
            return State.Dies;
        }
    }
}
