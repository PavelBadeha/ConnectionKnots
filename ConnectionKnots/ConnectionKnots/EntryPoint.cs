using System;
using System.Collections.Generic;

namespace ConnectionKnots
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<double> arr = new List<double>();

            for(int i = 0; i < 10000;i++)
            {
                arr.Add(Generator.EvenlyGenerate(0, 20));
            }
            //Histogramma.Build(arr);
            double[] arr1 = new double[] {0.1,0.2,0.3,0.5 };
            Histogramma.Build1(arr1);
        }
    }
}
