using System;
using System.Collections.Generic;

namespace ConnectionKnots
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<double> arr = new List<double>();

            for(int i = 0; i < 10001;i++)
            {
                arr.Add(Generator.EvenlyGenerate(0, 20));
            }
            Histogramma.Build(arr);
        }
    }
}
