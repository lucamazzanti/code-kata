using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Tests.Wardrobe
{
    public class WardrobeTests
    {
        [Test]
        public void GetCombinations_InexistentRoomSize_ThrowsArgumentException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentException>(() =>
            {
                wardrobe.GetCombinations(0, null);
            });
        }

        [Test]
        public void GetCombinations_InexistentElement_ThrowsArgumentException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentException>(() =>
            {
                wardrobe.GetCombinations(1, new uint[] { 0 });
            });
        }

        [Test]
        public void GetCombinations_NullElementsArray_ThrowsArgumentNullException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentNullException>(() =>
            {
                wardrobe.GetCombinations(1, null);
            });
        }

        [Test]
        public void GetCombinations_NoElementThatFit_ReturnsEmpty()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.GetCombinations(1, new uint[] { 2 });
            CollectionAssert.AreEqual(new uint[][] { }, result);
        }

        [Test]
        public void GetCombinations_SingleElementThatFit_ReturnsThatCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.GetCombinations(1, new uint[] { 1 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 1 } }, result);
        }

        [Test]
        public void GetCombinations_TwoElementsThatFit_ReturnsTwoCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(2, new uint[] { 1, 2 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 2 }, new uint[] { 1, 1 } }, results);
        }

        [Test]
        public void GetCombinations_TwoElementsThatFitOnlyTogheter_ReturnsOneCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(5, new uint[] { 2, 3 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 3, 2 } }, results);
        }

        [Test]
        public void GetCombinations_MoreElements_ReturnsMultipleCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(5, new uint[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new uint[][] {
                new uint[] { 3, 2 },
                new uint[] { 3, 1, 1 },
                new uint[] { 2, 2, 1 },
                new uint[] { 2, 1, 1, 1 },
                new uint[] { 1, 1, 1, 1, 1 } }, results);
        }

        [Test]
        public void GetCombinations_CodeKataUseCase()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(250, new uint[] { 50, 75, 100, 120 });
            CollectionAssert.AreEqual(new uint[][] {
                new uint[] { 100, 100, 50 },
                new uint[] { 100, 75, 75 },
                new uint[] { 100, 50, 50, 50 },
                new uint[] { 75, 75, 50, 50 },
                new uint[] { 50, 50, 50, 50, 50 } }, results);
        }

        [Test]
        public void GetCheaperCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.GetCheaperCombination(250, new uint[] { 50, 75, 100, 120 }, new uint[] { 59, 62, 90, 111 });
            CollectionAssert.AreEqual(new uint[] { 100, 75, 75 }, result);
        }
    }
}