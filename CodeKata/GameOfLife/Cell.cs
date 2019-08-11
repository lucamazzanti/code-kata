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
            if (Neighbours.Where(i => i != null && i.Live).Count() < 2)
            {
                this.Live = false;
            }    
        }
    }
}
