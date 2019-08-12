﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Wardrobe
{
    public class WardrobeElement : Algorithms.SubsetSums.SubsetSums.IValue
    {
        public WardrobeElement(uint sizeInCm, decimal priceInDollars = 0m)
        {
            if (sizeInCm == 0) throw new ArgumentException("Element size must be greater than 0.", nameof(sizeInCm));

            SizeInCm = sizeInCm;
            PriceInDollars = priceInDollars;
        }

        public uint SizeInCm { get; private set; }

        public decimal PriceInDollars { get; private set; }

        public int GetValue()
        {
            return (int) SizeInCm;
        }

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