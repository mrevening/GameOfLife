namespace Life
{
    public class CellOnBoard
    {
        public int Row { get; }
        public int Col { get; }
        public CellOnBoard(int row, int column) 
        {
            Row = row;
            Col = column;
        }
    }
}
