using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Tests.Wardrobe
{
    public class WardrobeTests
    {
        [Test]
        public void Customize_SingleElementThatFit_ReturnsThatCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var result = wardrobe.Customize(1, new int[] { 1 });
            CollectionAssert.AreEqual(new int[][] { new int[] { 1 } }, result);
        }

        [Test]
        public void Customize_TwoElementsThatFit_ReturnsTwoCombination()
        {
            var wardrobe = new CodeKata.Wardrobe.Wardrobe();
            var results = wardrobe.Customize(2, new int[] { 1, 2 });
            CollectionAssert.AreEqual(new int[][] { new int[] { 2 }, new int[] { 1, 1 } }, results);
        }
    }
}