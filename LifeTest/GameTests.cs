using Life;

namespace LifeTest
{
    public class GameTests
    {
        [Fact]
        public void Test()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1,1), new(1,2), new(1,3) };
            var board = new Board(livingCells);
            var sut = new Game(board, 1);
            sut.Start();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(0, 2), new(1, 2), new(2, 2) }, sut.CurrentBoard.CalculateTick());
        }
    }
}
