using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.LifeKata
{
    public class Cell
    {
        public Cell(bool live)
        {
            Live = live;
        }

        public bool Live { get; set; }

        public bool GetNextGeneration(int livingNeighbours)
        {
            if (this.Live)
            {
                if (IsUnderPopulated(livingNeighbours))
                {
                    return false;
                }
                else if (IsOverPopulated(livingNeighbours))
                {
                    return false;
                }
            }
            else
            {
                if (IsPerfectlyPopulated(livingNeighbours))
                {
                    return true;
                }
            }

            return this.Live;
        }

        private static bool IsPerfectlyPopulated(int livingNeighbours)
        {
            return livingNeighbours == 3;
        }
        private static bool IsUnderPopulated(int livingNeighbours)
        {
            return livingNeighbours < 2;
        }
        private static bool IsOverPopulated(int livingNeighbours)
        {
            return livingNeighbours > 3;
        }

        public override string ToString()
        {
#pragma warning disable CA1305 // Specificare IFormatProvider
            return Convert.ToByte(Live).ToString();
#pragma warning restore CA1305 // Specificare IFormatProvider
        }
    }
}