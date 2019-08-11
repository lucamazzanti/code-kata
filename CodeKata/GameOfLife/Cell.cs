using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.GameOfLife
{
    public class Cell
    {
        public Cell(bool live, Cell[] neighbours = null)
        {
            Live = live;
            if (neighbours != null)
            {
                Neighbours = neighbours;
            }
        }

        public Cell[] Neighbours { get; set; } = new Cell[8];

        public bool Live { get; set; }

        public void Tick()
        {
            var livingNeighbours = Neighbours.Where(i => i != null && i.Live).Count();

            if (this.Live)
            {
                if (IsUnderPopulated(livingNeighbours))
                {
                    this.Live = false;
                }
                else if (IsOverPopulated(livingNeighbours))
                {
                    this.Live = false;
                }
            }
            else
            {
                if(IsPerfectlyPopulated(livingNeighbours))
                {
                    this.Live = true;
                }
            }
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
    }
}
