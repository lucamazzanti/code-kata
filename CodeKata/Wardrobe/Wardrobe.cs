using CodeKata.Algorithms.SubsetSums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Wardrobe
{
    public class Wardrobe
    {
        public WardrobeElement[][] GetCombinations(uint size, WardrobeElement[] elements)
        {
            if (size == 0) throw new ArgumentException("roomSize must be greater than 0.", nameof(size));
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            if (elements.Length == 0) throw new ArgumentException("elements must contain at least one item.", nameof(elements));
            if (elements.Any(i => i == null)) throw new ArgumentException("every elements item must be not null.", nameof(elements));
            if (elements.Any(i => i.SizeInCm == 0)) throw new ArgumentException("every elements item must be greater than 0.", nameof(elements));

            return SubsetSums.AllSumsUnordered((int)size, elements);
        }

        public WardrobeElement[] GetCheaperCombination(uint roomSize, WardrobeElement[] elements)
        {
            var combinations = this.GetCombinations(roomSize, elements);
            return combinations.OrderBy(i => i.Sum(ii => ii.PriceInDollars)).Take(1).First();
        }
    }
}