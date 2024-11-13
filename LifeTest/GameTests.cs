using Life;

namespace LifeTest
{
    public class GameTests
    {
        [Fact]
        public void Example4_Tick2()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1,1), new(1,2), new(1,3) };
            var board = new Board(livingCells);
            var sut = new Game(board, 2);
            sut.Start();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(1, 1), new(1, 2), new(1, 3) }, sut.CurrentBoard.LiveCells);
        }

        [Fact]
        public void Example5_Tick2()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1, 1), new(1, 2), new(1, 3), new(1, 4) };
            var board = new Board(livingCells);
            var sut = new Game(board, 2);
            sut.Start();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(1, 1), new(0, 2), new(0, 3), new(2, 2), new(2, 3), new(1, 4), }, sut.CurrentBoard.CalculateTick());
        }

        [Fact]
        public void Example6_Tick1()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1, 2), new(2, 3), new(3, 1), new(3, 2), new(3, 3) };
            var board = new Board(livingCells);
            var sut = new Game(board, 1);
            sut.Start();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(2, 1), new(2, 3), new(3, 2), new(3, 3), new(4, 2) }, sut.CurrentBoard.LiveCells);
        }

        //[Fact]
        //public void Example6_Tick1()
        //{
        //    var livingCells = new List<LiveCellOnBoard>() { new(0, 1), new(1, 2), new(2, 0), new(2, 1), new(2, 2) };
        //    var board = new Board(livingCells);
        //    var sut = new Game(board, 1);
        //    sut.Start();

        //    Assert.Equivalent(new List<LiveCellOnBoard>() { new(1, 0), new(1, 2), new(2, 1), new(2, 2), new(3, 1) }, sut.CurrentBoard.CalculateTick());
        //}




        [Fact]
        public void Example6_Tick5()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1, 2), new(2, 3), new(3, 1), new(3, 2), new(3, 3) };
            var board = new Board(livingCells);
            var sut = new Game(board, 4);
            sut.Start();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(2,3), new(3,4), new(4,2), new(4,3 ), new(4,4) }, sut.CurrentBoard.LiveCells);
        }
    }
}
