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
        public void Given_LiveCell_When_Isolated_Then_Dies(byte[] neighboursStatus)
        {
            var neighbours = neighboursStatus.Select(i => new Cell(Convert.ToBoolean(i))).ToArray();
            var cell = new Cell(true, neighbours);

            cell.Tick();

            Assert.IsFalse(cell.Live);
        }
    }
}