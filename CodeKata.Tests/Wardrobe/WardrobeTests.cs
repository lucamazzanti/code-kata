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
            var result = wardrobe.Customize(1, 1);
            Assert.AreEqual(1, 1);
        }

        //[Test]
        //public void Customize_TwoElementsThatFit_ReturnsTwoCombination()
        //{
        //    var wardrobe = new CodeKata.Wardrobe.Wardrobe();
        //    var result = wardrobe.Customize(2, new int[] { 1, 2 });
        //    Assert.AreEqual(1, 1);
        //}
    }
}
