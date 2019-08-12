using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Algorithms.SubsetSums
{
    public class SubsetSums
    {
        public static int[][] AllSums(int total, int[] items)
        {
            return AllSums(total, items, new int[] { }, new int[][] { });
        }

        private static int[][] AllSums(int total, int[] items, int[] row, int[][] result)
        {
            if (total == 0) result = result.Concat(new int[][] { row }).ToArray();
            if (total <= 0) return result;

            foreach (var item in items.OrderBy(i => i))
                result = AllSums(total - item, items, row.Concat(new[] { item }).ToArray(), result);

            return result;
        }

        public static int[][] AllSumsUnordered(int total, int[] items)
        {
            return AllSumsUnordered(total, items, new int[] { }, new int[][] { });
        }

        private static int[][] AllSumsUnordered(int total, int[] items, int[] row, int[][] result)
        {
            if (total == 0) result = result.Concat(new int[][] { row }).ToArray();
            if (total <= 0) return result;

            foreach (var item in items.OrderByDescending(i => i))
                result = AllSumsUnordered(
                    total - item,
                    items.Where(i => i <= item).ToArray(),
                    row.Concat(new[] { item }).ToArray(),
                    result);

            return result;
        }
    }
}