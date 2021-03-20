using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectionKnots
{
    public static class Histogramma
    {
        public static void Build(List<double> arr)
        {
            double average = (arr[0] + arr[arr.Count - 1]) / 2;
            int max = 10;
            List<double> arr1 = new List<double>(5);

            arr1.Add(arr[0]);
            arr1.Add((arr[0] + average) / 2);
            arr1.Add(average);
            arr1.Add((arr[arr.Count - 1] + average)/2);

            foreach(var el in arr1)
            {
                Console.WriteLine(el);
            }
        }
    }
}
