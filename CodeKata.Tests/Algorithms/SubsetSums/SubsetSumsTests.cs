using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Tests.Algorithms.SubsetSums
{
    public class SubsetSumsTests
    {
        public static object[] UseCases = new object[]
        {
            new object[] { 1, new int[] { 1 }, new int[][] {
                new int[] { 1 }
            } },
            new object[] { 2, new int[] { 1, 2 }, new int[][] {
                new int[] { 1, 1 },
                new int[] { 2 }
            } },
            new object[] { 5, new int[] { 1, 2, 3 }, new int[][] {
                new int[] { 3, 2 },
                new int[] { 3, 1, 1 },
                new int[] { 2, 2, 1 },
                new int[] { 2, 1, 1, 1 },
                new int[] { 1, 1, 1, 1, 1 }
            } },
        };

        [Test]
        [TestCaseSource(nameof(UseCases))]
        public void AllSumsUnordered_UseCases(int sum, int[] numbers, int[][] expectedResult)
        {
            var result = CodeKata.Algorithms.SubsetSums.SubsetSums.AllSumsUnordered(sum, numbers);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}