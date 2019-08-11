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
        [Test]
        [Description("Given a starting seed, calculate the system.")]
        public void Given_Ctor_When_SeedNotNull_Then_Create()
        {
            var seed = new byte[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            var system = new LifeSystem(seed);

            Assert.AreEqual(3, system.Cells.GetLength(0));
            Assert.AreEqual(3, system.Cells.GetLength(1));
        }

        [Test]
        public void Given_Ctor_When_SeedNull_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new LifeSystem(null);
            });
        }
    }
}
