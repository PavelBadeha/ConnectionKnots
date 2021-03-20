using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectionKnots
{
    public static class Histogramma
    {
        public static void Build1(double[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write("p" + (Array.IndexOf(arr, el)+1).ToString().PadRight(5));

                for (int i = 0; i < el*10; i++)
                {
                    Console.Write("#");
                }
                Console.Write(" " + el);
                Console.WriteLine();
            }
        }

        public static void Build(List<double> arr)
        {
            int x = arr.Count/10;
           
            arr = arr.OrderBy(i => i).ToList();
            double average = Math.Round((arr[0] + arr[arr.Count - 1]) / 2);
            int max = 10;
            List<double> arr1 = new List<double>(5);

            arr1.Add(arr[0]);
            arr1.Add(Math.Round((arr[0] + average) / 2));
            arr1.Add(average);
            arr1.Add(arr[arr.Count - 1]);
            arr1.Add(Math.Round((arr[arr.Count - 1] + average) / 2));

            arr1 = arr1.OrderBy(i => i).ToList();
            foreach (var el in arr1)
            {
                Console.Write(el.ToString().PadRight(5));
                for(int i = 0; i < ((double)arr.FindAll(x => x == el).Count/arr.Count)*100; i++ )
                {
                    Console.Write("#");
                }
                Console.Write(" " + arr.FindAll(x=>x==el).Count);
                Console.WriteLine();
            }
        }
    }
}
