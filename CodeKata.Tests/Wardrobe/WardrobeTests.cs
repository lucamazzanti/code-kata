using CodeKata.Wardrobe;
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
                wardrobe.GetCombinations(1, new WardrobeElement[] { new WardrobeElement(0) });
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
            var result = wardrobe.GetCombinations(1, new[] { new WardrobeElement(2) });
            CollectionAssert.AreEqual(new WardrobeElement[][] { }, result);
        }

        [Test]
        public void GetCombinations_SingleElementThatFit_ReturnsThatCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.GetCombinations(1, new[] {
                new WardrobeElement(1)
            });
            CollectionAssert.AreEqual(new WardrobeElement[][] {
                new [] { new WardrobeElement(1) }
            }, result);
        }

        [Test]
        public void GetCombinations_TwoElementsThatFit_ReturnsTwoCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(2, new [] {
                new WardrobeElement(1),
                new WardrobeElement(2)
            });
            CollectionAssert.AreEqual(new WardrobeElement[][] {
                new [] { new WardrobeElement(2) },
                new [] { new WardrobeElement(1), new WardrobeElement(1) }
            }, results);
        }

        [Test]
        public void GetCombinations_TwoElementsThatFitOnlyTogheter_ReturnsOneCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(5, new [] {
                new WardrobeElement(3),
                new WardrobeElement(2)
            });
            CollectionAssert.AreEqual(new WardrobeElement[][] {
                new [] { new WardrobeElement(3), new WardrobeElement(2) }
            }, results);
        }

        [Test]
        public void GetCombinations_MoreElements_ReturnsMultipleCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(5, new [] {
                new WardrobeElement(1),
                new WardrobeElement(2),
                new WardrobeElement(3)
            });
            CollectionAssert.AreEqual(new WardrobeElement[][] {
                new [] { new WardrobeElement(3), new WardrobeElement(2) },
                new [] { new WardrobeElement(3), new WardrobeElement(1), new WardrobeElement(1) },
                new [] { new WardrobeElement(2), new WardrobeElement(2), new WardrobeElement(1) },
                new [] { new WardrobeElement(2), new WardrobeElement(1), new WardrobeElement(1), new WardrobeElement(1) },
                new [] { new WardrobeElement(1), new WardrobeElement(1), new WardrobeElement(1), new WardrobeElement(1), new WardrobeElement(1) } }, results);
        }

        [Test]
        public void GetCombinations_CodeKataUseCase()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.GetCombinations(250, new [] {
                new WardrobeElement(50),
                new WardrobeElement(75),
                new WardrobeElement(100),
                new WardrobeElement(120) });
            CollectionAssert.AreEqual(new WardrobeElement[][] {
                new [] { new WardrobeElement(100), new WardrobeElement(100), new WardrobeElement(50) },
                new [] { new WardrobeElement(100), new WardrobeElement(75), new WardrobeElement(75) },
                new [] { new WardrobeElement(100), new WardrobeElement(50), new WardrobeElement(50), new WardrobeElement(50) },
                new [] { new WardrobeElement(75), new WardrobeElement(75), new WardrobeElement(50), new WardrobeElement(50) },
                new [] { new WardrobeElement(50), new WardrobeElement(50), new WardrobeElement(50), new WardrobeElement(50), new WardrobeElement(50) } }, results);
        }

        [Test]
        public void GetCheaperCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.GetCheaperCombination(250, new[] {
                new WardrobeElement(50,59),
                new WardrobeElement(75,62),
                new WardrobeElement(100,90),
                new WardrobeElement(120,111)});               
            CollectionAssert.AreEqual(new [] { new WardrobeElement(100, 90), new WardrobeElement(75, 62), new WardrobeElement(75, 62) }, result);
        }
    }
}