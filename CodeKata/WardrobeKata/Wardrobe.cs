using CodeKata.Algorithms;
using System;
using System.Linq;

namespace CodeKata.WardrobeKata
{
    public static class Wardrobe
    {
        public static WardrobeElement[][] GetCombinations(uint size, WardrobeElement[] elements)
        {
#pragma warning disable CA1303 // Non passare valori letterali come parametri localizzati
            if (size == 0) throw new ArgumentException("roomSize must be greater than 0.", nameof(size));
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            if (elements.Length == 0) throw new ArgumentException("elements must contain at least one item.", nameof(elements));
            if (elements.Any(i => i == null)) throw new ArgumentException("every elements item must be not null.", nameof(elements));
            if (elements.Any(i => i.SizeInCm == 0)) throw new ArgumentException("every elements item must be greater than 0.", nameof(elements));
#pragma warning restore CA1303 // Non passare valori letterali come parametri localizzati

            return SubsetSums.AllSumsUnordered((int)size, elements, i => (int) i.SizeInCm);
        }

        public static WardrobeElement[] GetCheaperCombination(uint roomSize, WardrobeElement[] elements)
        {
            var combinations = Wardrobe.GetCombinations(roomSize, elements);
            return combinations.OrderBy(i => i.Sum(ii => ii.PriceInDollars)).Take(1).First();
        }
    }
}