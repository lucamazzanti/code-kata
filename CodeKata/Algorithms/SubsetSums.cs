using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Algorithms
{
    public static class SubsetSums
    {
        public static int[][] AllSums(int total, int[] items)
        {
            return AllSums(total, items, Array.Empty<int>(), Array.Empty<int[]>());
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
            return AllSumsUnordered(total, items, Array.Empty<int>(), Array.Empty<int[]>());
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

        public static T[][] AllSumsUnordered<T>(int total, T[] items, Func<T, int> getValueCallback)
        {
            return AllSumsUnordered<T>(total, items, getValueCallback, Array.Empty<T>(), Array.Empty<T[]>());
        }

        private static T[][] AllSumsUnordered<T>(int total, T[] items, Func<T,int> getValueCallback, T[] row, T[][] result)
        {
            if (total == 0) result = result.Concat(new T[][] { row }).ToArray();
            if (total <= 0) return result;

            foreach (var item in items.OrderByDescending(i => getValueCallback(i)))
                result = AllSumsUnordered<T>(
                    total - getValueCallback(item),
                    items.Where(i => getValueCallback(i) <= getValueCallback(item)).ToArray(),
                    getValueCallback,
                    row.Concat(new[] { item }).ToArray(),
                    result);

            return result;
        }
    }
}