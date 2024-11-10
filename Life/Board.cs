namespace Life
{
    public class Board
    {
        private List<LiveCellOnBoard> LiveCells { get; } = new List<LiveCellOnBoard>();

        public Board(List<LiveCellOnBoard> liveCells)
        {
            LiveCells = liveCells;
        }

        public List<LiveCellOnBoard> CalculateTick()
        {
            var newBoardState = new List<LiveCellOnBoard>();

            var minRow = LiveCells.Min(cell => cell.Row);
            var maxRow = LiveCells.Max(cell => cell.Row);
            var minCol = LiveCells.Min(col => col.Col);
            var maxCol = LiveCells.Max(col => col.Col);

            for(var row = minRow - 1; row == maxRow + 1; row++)
            {
                for(var col = minCol - 1; col == maxCol + 1; col++)
                {
                    var state = CalculateCell(row, col);
                    if (state == State.Lives)
                    {
                        newBoardState.Add(new LiveCellOnBoard(row, col));
                    }
                }
            }
            return newBoardState;
        }

        private State CalculateCell(int row, int col)
        {
            var isUpLeftCellAlive = LiveCells.Any(cell => cell.Row == row - 1 && cell.Col == col - 1);
            var isUpCenterCellAlive = LiveCells.Any(cell => cell.Row == row - 1 && cell.Col == col);
            var isUpRightCellAlive = LiveCells.Any(cell => cell.Row == row - 1 && cell.Col == col + 1);
            var isLeftCellAlive = LiveCells.Any(cell => cell.Row == row && cell.Col == col - 1);
            var isCentralCellAlive = LiveCells.Any(cell => cell.Row == row && cell.Col == col);
            var isRightCellAlive = LiveCells.Any(cell => cell.Row == row && cell.Col == col + 1);
            var isDownLeftCellAlive = LiveCells.Any(cell => cell.Row == row + 1 && cell.Col == col - 1);
            var isDownCenterCellAlive = LiveCells.Any(cell => cell.Row == row + 1 && cell.Col == col);
            var isDownRightCellAlive = LiveCells.Any(cell => cell.Row == row + 1 && cell.Col == col + 1);

            var livingNeighbours = new List<bool>
                    {
                        isUpLeftCellAlive,
                        isUpCenterCellAlive,
                        isUpRightCellAlive,
                        isLeftCellAlive,
                        isRightCellAlive,
                        isDownLeftCellAlive,
                        isDownCenterCellAlive,
                        isDownRightCellAlive
                    };

            var livingNeighboursCount = livingNeighbours.Count(x => x == true);

            var cellState = isCentralCellAlive
                ? new LiveCell().CalculateState(livingNeighboursCount)
                : new DeadCell().CalculateState(livingNeighboursCount);

            return cellState;
        }
    }
}
