using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeKata.GameOfLife
{
    public class LifeSystem
    {
        public LifeSystem(string seed) : this(GetData(seed))
        {
        }

        public LifeSystem(byte[,] matrix)
        {
            Cells = GetCells(matrix);
        }

        private static byte[,] GetData(string seed)
        {
            if (string.IsNullOrWhiteSpace(seed)) throw new ArgumentNullException(nameof(seed));

            int? rowLength = null;
            var resultList = new List<byte[]>();
            foreach (var row in seed.Split(" "))
            {
                if (rowLength.HasValue && row.Length != rowLength.Value) throw new FormatException();
                if (!rowLength.HasValue) rowLength = row.Length;

                var resultRow = new List<byte>();
                foreach (var item in row.ToCharArray())
                {
                    switch (item)
                    {
                        case '0':
                            resultRow.Add(0);
                            break;
                        case '1':
                            resultRow.Add(1);
                            break;
                        default:
                            throw new FormatException();
                            break;
                    }
                }
                resultList.Add(resultRow.ToArray());
            }

            var result = new byte[resultList.Count, resultList[0].Length];

            for (int i = 0; i < resultList.Count; i++)
            {
                for (int j = 0; j < resultList[0].Length; j++)
                {
                    result[i, j] = resultList[i][j];
                }
            }

            return result;
        }

        private Cell[,] GetCells(byte[,] matrix)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));

            var width = matrix.GetLength(0);
            var heigth = matrix.GetLength(1);

            var cells = new Cell[width, heigth];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    cells[i, j] = new Cell(Convert.ToBoolean(matrix[i, j]));
                }
            }

            return cells;
        }

        public Cell[,] Cells { get; private set; }
    }
}
