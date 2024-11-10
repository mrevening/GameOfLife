using Life;

namespace LifeTest
{
    public class CellTests
    {
        [Fact]
        public void Cell_dies_when_one_living_neighbour_cell()
        {
            var uat = new Cell(true, 1);
            var endState = uat.CalculateState();
            Assert.Equal(State.Dies, endState);
        }

        [Fact]
        public void Cell_dies_when_four_or_more_living_neighbour_cells()
        {
            var uat = new Cell(true, 4);
            var endState = uat.CalculateState();
            Assert.Equal(State.Dies, endState);
        }

        [Fact]
        public void Cell_survies_when_two_or_three_neighbour_cells()
        {
            var uat = new Cell(true, 2);
            var endState = uat.CalculateState();
            Assert.Equal(State.Lives, endState);
        }

        [Fact]
        public void Cell_is_born_when_three_neighbour_cells()
        {
            var uat = new Cell(false, 3);
            var endState = uat.CalculateState();
            Assert.Equal(State.Lives, endState);
        }
    }
}