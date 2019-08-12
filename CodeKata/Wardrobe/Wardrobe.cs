using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Wardrobe
{
    public class Wardrobe
    {
        public uint[][] GetCombinations(uint roomSize, uint[] elements)
        {
            if (roomSize == 0) throw new ArgumentException("roomSize must be greater than 0.", nameof(roomSize));
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            if (elements.Length == 0) throw new ArgumentException("elements must contain at least one item.", nameof(elements));
            if (elements.Any(i => i == 0)) throw new ArgumentException("every elements item must be greater than 0.", nameof(elements));

            var results = Algorithms.SubsetSums.SubsetSums
                .AllSumsUnordered((int)roomSize, elements.Select(i => (int)i).ToArray());

            return ConvertToUintResult(results);
        }

        private static uint[][] ConvertToUintResult(int[][] results)
        {
            var convertedResults = new List<uint[]>();
            foreach (var result in results)
            {
                var convertedResult = new List<uint>();
                foreach (var item in result)
                {
                    convertedResult.Add((uint)item);
                }
                convertedResults.Add(convertedResult.ToArray());
            }
            return convertedResults.ToArray();
        }

        public uint[] GetCheaperCombination(uint roomSize, uint[] elements, uint[] prices)
        {
            var combinations = this.GetCombinations(roomSize, elements);

            var combinationsWithPrice = new List<Tuple<uint[], uint>>();
            foreach (var combination in combinations)
            {
                uint price = 0;
                foreach (var item in combination)
                {
                    var itemIndex = Array.IndexOf(elements, item);
                    price += prices[itemIndex];
                }
                combinationsWithPrice.Add(new Tuple<uint[], uint>(combination, price));
            }

            return combinationsWithPrice.OrderBy(i => i.Item2).Take(1).FirstOrDefault()?.Item1;
        }
    }
}
