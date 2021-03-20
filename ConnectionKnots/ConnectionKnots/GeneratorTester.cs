using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectionKnots
{
    public static class GeneratorTester
    {
        private const int K = 10;

        private static double GetExpectation(double[] data)
        {
            return data.Sum() / data.Length;
        }
        private static double GetDispersion(double[] data, double expectation)
        {
            return (data.Select(x => x * x).Sum() - expectation * expectation) / data.Length; 
        }

        public static void TestEvenly()
        {
            double[] data = new double[100];

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = Generator.EvenlyGenerate(0, 10);
            }

            double[] probability = new double[K];
            
            foreach(double z in data)
            {
                probability[(int)(z / (1.0d / K))]++;
            }

            double expectation = GetExpectation(data);

            GetDispersion(data, expectation);
        }
    }
}
