using Life;

namespace LifeTest
{
    public class CellTests
    {
        [Fact]
        public void Cell_dies_when_one_living_neighbour_cell()
        {
            var sut = new LiveCell();
            var endState = sut.CalculateState(1);
            Assert.Equal(State.Dies, endState);
        }

        [Fact]
        public void Cell_dies_when_four_or_more_living_neighbour_cells()
        {
            var sut = new LiveCell();
            var endState = sut.CalculateState(4);
            Assert.Equal(State.Dies, endState);
        }

        [Fact]
        public void Cell_survies_when_two_or_three_neighbour_cells()
        {
            var sut = new LiveCell();
            var endState = sut.CalculateState(2);
            Assert.Equal(State.Lives, endState);
        }

        [Fact]
        public void Cell_is_born_when_three_neighbour_cells()
        {
            var sut = new DeadCell();
            var endState = sut.CalculateState(3);
            Assert.Equal(State.Lives, endState);
        }
    }
}