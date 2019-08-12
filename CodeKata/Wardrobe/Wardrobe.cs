using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Wardrobe
{
    public class Wardrobe
    {
        public int[][] Customize(int size, int[] elements)
        {
            var results = new List<int[]>();
            foreach (var item in elements)
            {
                if(size % item == 0)
                {
                    var result = new List<int>();
                    var times = size / item;
                    for (int i = 0; i < times; i++)
                    {
                        result.Add(item);
                    }
                    results.Add(result.ToArray());
                }
            }
            return results.OrderBy(i => i.Length).ToArray();
        }
    }
}
