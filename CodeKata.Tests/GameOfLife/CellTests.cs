using CodeKata.GameOfLife;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class CellTests
    {
        [SetUp]
        public void Setup()
        {
        }
      
        [Test]
        [TestCase(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new byte[] { 1, 0, 0, 0, 0, 0, 0, 0 })]
        [Description("Any live cell with fewer than two live neighbours dies, as if by underpopulation.")]
        public void Given_LiveCellUnderPopulated_When_Ticks_Then_Dies(byte[] neighboursStatus)
        {
            var neighbours = neighboursStatus.Select(i => new Cell(Convert.ToBoolean(i))).ToArray();
            var cell = new Cell(true, neighbours);

            cell.Tick();

            Assert.IsFalse(cell.Live);
        }

        [Test]
        [TestCase(new byte[] { 1, 1, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new byte[] { 1, 1, 1, 0, 0, 0, 0, 0 })]
        [Description("Any live cell with two or three live neighbours lives on to the next generation.")]
        public void Given_LiveCellPopulated_When_Ticks_Then_Lives(byte[] neighboursStatus)
        {
            var neighbours = neighboursStatus.Select(i => new Cell(Convert.ToBoolean(i))).ToArray();
            var cell = new Cell(true, neighbours);

            cell.Tick();

            Assert.IsTrue(cell.Live);
        }

        [Test]
        [TestCase(new byte[] { 1, 1, 1, 1, 0, 0, 0, 0 })]
        [Description("Any live cell with more than three live neighbours dies, as if by overpopulation.")]
        public void Given_LiveCellOverPopulated_When_Ticks_Then_Dies(byte[] neighboursStatus)
        {
            var neighbours = neighboursStatus.Select(i => new Cell(Convert.ToBoolean(i))).ToArray();
            var cell = new Cell(true, neighbours);

            cell.Tick();

            Assert.IsFalse(cell.Live);
        }

        [Test]
        [TestCase(new byte[] { 1, 1, 1, 0, 0, 0, 0, 0 })]
        [Description("Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.")]
        public void Given_DeadCellPopulated_When_Ticks_Then_Lives(byte[] neighboursStatus)
        {
            var neighbours = neighboursStatus.Select(i => new Cell(Convert.ToBoolean(i))).ToArray();
            var cell = new Cell(false, neighbours);

            cell.Tick();

            Assert.IsTrue(cell.Live);
        }
    }
}