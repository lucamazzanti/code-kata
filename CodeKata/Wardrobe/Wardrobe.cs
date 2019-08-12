using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKata.Wardrobe
{
    public class Wardrobe
    {
        public uint[][] Customize(uint roomSize, uint[] elements)
        {
            if (roomSize == 0) throw new ArgumentException("roomSize must be greater than 0.", nameof(roomSize));
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            if (elements.Length == 0) throw new ArgumentException("elements must contain at least one item.", nameof(elements));
            if (elements.Any(i => i == 0)) throw new ArgumentException("every elements item must be greater than 0.", nameof(elements));

            var results = new List<uint[]>();
            foreach (var item in elements)
            {
                if(roomSize % item == 0)
                {
                    var result = new List<uint>();
                    var times = roomSize / item;
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
