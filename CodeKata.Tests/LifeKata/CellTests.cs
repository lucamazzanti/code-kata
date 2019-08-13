using NUnit.Framework;
using CodeKata.LifeKata;

namespace CodeKata.Tests.LifeKata
{
    public class CellTests
    {
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [Description("Any live cell with fewer than two live neighbours dies, as if by underpopulation.")]
        public void Given_LiveCellUnderPopulated_When_Ticks_Then_Dies(int liveNeighbours)
        {
            var cell = new Cell(true);
            var status = cell.GetNextGeneration(liveNeighbours);
            Assert.IsFalse(status);
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [Description("Any live cell with two or three live neighbours lives on to the next generation.")]
        public void Given_LiveCellPopulated_When_Ticks_Then_Lives(int liveNeighbours)
        {
            var cell = new Cell(true);
            var status = cell.GetNextGeneration(liveNeighbours);
            Assert.IsTrue(status);
        }

        [Test]
        [TestCase(4)]
        [Description("Any live cell with more than three live neighbours dies, as if by overpopulation.")]
        public void Given_LiveCellOverPopulated_When_Ticks_Then_Dies(int liveNeighbours)
        {
            var cell = new Cell(true);
            var status = cell.GetNextGeneration(liveNeighbours);
            Assert.IsFalse(status);
        }

        [Test]
        [TestCase(3)]
        [Description("Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.")]
        public void Given_DeadCellPopulated_When_Ticks_Then_Lives(int liveNeighbours)
        {
            var cell = new Cell(false);
            var status = cell.GetNextGeneration(liveNeighbours);
            Assert.IsTrue(status);
        }
    }
}