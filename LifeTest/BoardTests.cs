using Life;
using System.Collections.Generic;

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
            var livingCells = new List<LiveCellOnBoard>() { new(1, 1), new(1, 2), new(1, 3) };
            var sut = new Board(livingCells);
            var newTick = sut.CalculateTick();

            Assert.Equal(new List<LiveCellOnBoard>() { new(1, 2) }, newTick);
        }
    }
}
