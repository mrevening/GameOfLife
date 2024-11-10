﻿namespace Life
{
    public class LiveCell
    {
        private int LivingNeighbours { get; }
        public LiveCell(int livingNeighbours)
        {
            LivingNeighbours = livingNeighbours;
        }

        public State CalculateState()
        {
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