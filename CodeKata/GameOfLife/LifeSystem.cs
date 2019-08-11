using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeKata.GameOfLife
{
    public class LifeSystem
    {
        public LifeSystem(byte[,] seed)
        {
            Cells = GetCells(seed);
        }

        private Cell[,] GetCells(byte[,] seed)
        {
            if (seed == null) throw new ArgumentNullException(nameof(seed));

            var width = seed.GetLength(0);
            var heigth = seed.GetLength(1);

            var cells = new Cell[width, heigth];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    cells[i, j] = new Cell(Convert.ToBoolean(seed[i, j]));
                }
            }

            return cells;
        }

        public Cell[,] Cells { get; private set; }
    }
}
