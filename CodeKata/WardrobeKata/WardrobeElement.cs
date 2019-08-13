using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.WardrobeKata
{
    public class WardrobeElement
    {
        public WardrobeElement(uint sizeInCm, decimal priceInDollars = 0m)
        {
#pragma warning disable CA1303 // Non passare valori letterali come parametri localizzati
            if (sizeInCm == 0) throw new ArgumentException("Element size must be greater than 0.", nameof(sizeInCm));
#pragma warning restore CA1303 // Non passare valori letterali come parametri localizzati

            SizeInCm = sizeInCm;
            PriceInDollars = priceInDollars;
        }

        public uint SizeInCm { get; private set; }

        public decimal PriceInDollars { get; private set; }

        public override bool Equals(object obj)
        {
            var wardrobeElement = obj as WardrobeElement;
            if (wardrobeElement == null) return false;

            if (wardrobeElement.PriceInDollars == this.PriceInDollars
                && wardrobeElement.SizeInCm == this.SizeInCm)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(SizeInCm, PriceInDollars);
        }
    }
}