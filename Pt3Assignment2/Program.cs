using System;
using System.Collections.Generic;

namespace Pt3Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var splitInput = input.Split(' ');

            var numItems = long.Parse(splitInput[0]);
            var capacity = ulong.Parse(splitInput[1]);
            double value = 0;

            var Items = new List<Item>();

            for (var i = 0; i < numItems; i++)
            {
                input = Console.ReadLine();
                if (input == null) return;
                splitInput = input.Split(' ');
                Items.Add(new Item {Value = ulong.Parse(splitInput[0]), Weight = ulong.Parse(splitInput[1])});
            }
            
            Items.Sort(new ItemComparer());

            var j = 0;
            while (capacity > 0 && j < Items.Count)
            {
                if (Items[j].Weight <= capacity)
                {
                    capacity -= Items[j].Weight;
                    value += Items[j].Value;
                }
                else
                {
                    var ratio = (double)capacity / (double)Items[j].Weight;
                    value += Items[j].Value * ratio;
                    capacity = 0;
                }

                j++;
            }
            
            Console.WriteLine(value.ToString("0.0000"));
        }

        class Item
        {
            public ulong Weight { get; set; }
            public ulong Value { get; set; }

            public double UnitValue()
            {
                return (double)Value / (double)Weight;
            }
        }

        class ItemComparer : Comparer<Item>
        {
            public override int Compare(Item x, Item y)
            {
                return y.UnitValue().CompareTo(x.UnitValue());
            }
        }
    }
}