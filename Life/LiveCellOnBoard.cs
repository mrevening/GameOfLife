namespace Life
{
    public class LiveCellOnBoard
    {
        public int Row { get; }
        public int Col { get; }
        public LiveCellOnBoard(int row, int column) 
        {
            Row = row;
            Col = column;
        }
    }
}
