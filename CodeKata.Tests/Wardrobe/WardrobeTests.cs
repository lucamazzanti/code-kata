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
        public void Customize_InexistentRoomSize_ThrowsArgumentException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentException>(() =>
            {
                wardrobe.Customize(0, null);
            });
        }

        [Test]
        public void Customize_InexistentElement_ThrowsArgumentException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentException>(() =>
            {
                wardrobe.Customize(1, new uint[] { 0 });
            });
        }

        [Test]
        public void Customize_NullElementsArray_ThrowsArgumentNullException()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            Assert.Throws<ArgumentNullException>(() =>
            {
                wardrobe.Customize(1, null);
            });
        }

        [Test]
        public void Customize_NoElementThatFit_ReturnsEmpty()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.Customize(1, new uint[] { 2 });
            CollectionAssert.AreEqual(new uint[][] { }, result);
        }

        [Test]
        public void Customize_SingleElementThatFit_ReturnsThatCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.Customize(1, new uint[] { 1 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 1 } }, result);
        }

        [Test]
        public void Customize_TwoElementsThatFit_ReturnsTwoCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.Customize(2, new uint[] { 1, 2 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 2 }, new uint[] { 1, 1 } }, results);
        }

        [Test]
        public void Customize_TwoElementsThatFitOnlyTogheter_ReturnsOneCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.Customize(5, new uint[] { 2, 3 });
            CollectionAssert.AreEqual(new uint[][] { new uint[] { 3, 2 } }, results);
        }

        [Test]
        public void Customize_MoreElements_ReturnsMultipleCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.Customize(5, new uint[] { 1, 2, 3 });
            CollectionAssert.AreEqual(new uint[][] {
                new uint[] { 3, 2 },
                new uint[] { 3, 1, 1 },
                new uint[] { 2, 2, 1 },
                new uint[] { 2, 1, 1, 1 },
                new uint[] { 1, 1, 1, 1, 1 } }, results);
        }
    }
}