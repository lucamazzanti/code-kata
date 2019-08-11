using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.GameOfLife
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

        private bool IsPerfectlyPopulated(int livingNeighbours)
        {
            return livingNeighbours == 3;
        }
        private bool IsUnderPopulated(int livingNeighbours)
        {
            return livingNeighbours < 2;
        }
        private bool IsOverPopulated(int livingNeighbours)
        {
            return livingNeighbours > 3;
        }

        public override string ToString()
        {
            return Convert.ToByte(this.Live).ToString();
        }
    }
}