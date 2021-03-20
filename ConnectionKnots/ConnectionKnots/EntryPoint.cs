using System;
using System.Collections.Generic;

namespace ConnectionKnots
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<double> arr = new List<double>();

            for(int i = 0; i < 10;i++)
            {
                arr.Add(Generator.EvenlyGenerate(0, 5));
            }
            Histogramma.Build(arr);

            Console.WriteLine
        }
    }
}
