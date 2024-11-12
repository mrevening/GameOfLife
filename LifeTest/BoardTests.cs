using Life;

namespace LifeTest
{
    public class BoardTests
    {
        [Fact]
        public void Example1()
        {
            var livingCells = new List<LiveCellOnBoard>() { new (1, 1) };
            var sut = new Board(livingCells);
            var newTick = sut.CalculateTick();

            Assert.Equal(new List<LiveCellOnBoard>() { }, newTick);
        }

        [Fact]
        public void Example2()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(0, 2), new(1, 0), new(1, 2) };
            var sut = new Board(livingCells);
            var newTick = sut.CalculateTick();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(0, 1), new(1, 1) }, newTick);
        }

        [Fact]
        public void Example3()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(0, 0), new(0, 1), new(1, 0), new(1, 1) };
            var sut = new Board(livingCells);
            var newTick = sut.CalculateTick();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(0, 0), new(0, 1), new(1, 0), new(1, 1) }, newTick);
        }

        [Fact]
        public void Example4_Tick1()
        {
            var livingCells = new List<LiveCellOnBoard>() { new(1, 1), new(1, 2), new(1, 3) };
            var sut = new Board(livingCells);
            var newTick = sut.CalculateTick();

            Assert.Equivalent(new List<LiveCellOnBoard>() { new(0, 2), new(1, 2), new(2, 2) }, newTick);
        }
    }
}
