using CodeKata.GameOfLife;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeKata.Tests.GameOfLife
{
    public class LifeSystemTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("000 000 000", 3, 3)]
        [TestCase("0000 0000 0000 0000", 4, 4)]
        [Description("Given a starting seed, calculate the system.")]
        public void Given_Ctor_When_SeedNotNull_Then_Create(string seed, int expectedWidth, int expectedHeigth)
        {
            var system = new LifeSystem(seed);

            Assert.AreEqual(expectedWidth, system.Cells.GetLength(0));
            Assert.AreEqual(expectedHeigth, system.Cells.GetLength(1));
        }

        [Test]
        [Description("Given a starting seed, calculate the system.")]
        public void Given_Ctor_When_SeedNotNull_Then_CreateCorrectCells()
        {
            var system = new LifeSystem("010 101 001");

            Assert.AreEqual(false, system.Cells[0, 0].Live);
            Assert.AreEqual(true,  system.Cells[0, 1].Live);
            Assert.AreEqual(false,  system.Cells[0, 2].Live);
                                   
            Assert.AreEqual(true,  system.Cells[1, 0].Live);
            Assert.AreEqual(false,  system.Cells[1, 1].Live);
            Assert.AreEqual(true,  system.Cells[1, 2].Live);
                                   
            Assert.AreEqual(false,  system.Cells[2, 0].Live);
            Assert.AreEqual(false,  system.Cells[2, 1].Live);
            Assert.AreEqual(true,  system.Cells[2, 2].Live);
        }

        [Test]
        public void Given_Ctor_When_SeedNull_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new LifeSystem(default(string));
            });
        }

        [Test]
        [TestCase("000 000 000", "000 000 000")]
        [TestCase("000 010 000", "000 000 000")]
        [TestCase("000 111 000", "010 010 010")]
        [TestCase("010 111 010", "111 101 111")]
        public void Given_System_When_Tick_Then_Apply(string startingSeed, string expectedSeed)
        {
            var system = new LifeSystem(startingSeed);

            system.Tick();

            Assert.AreEqual(expectedSeed, system.ToString());        
        }
    }
}