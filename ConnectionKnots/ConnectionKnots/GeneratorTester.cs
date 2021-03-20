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
            Console.WriteLine($"Равномерное n = 100, M = {expectation}");

            Console.WriteLine($"D = {GetDispersion(data, expectation)}");

            data = new double[10000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = Generator.EvenlyGenerate(0, 10);
            }

            Console.WriteLine($"Вероятность по {K} карманам");
            foreach(double p in probability)
            {
                Console.Write($"{p}   ");
            }
            Console.WriteLine();

            probability = new double[K];

            foreach (double z in data)
            {
                probability[(int)(z / (1.0d / K))]++;
            }

            expectation = GetExpectation(data);
            Console.WriteLine($"Равномерное n = 10000, M = {expectation}");

            Console.WriteLine($"D = {GetDispersion(data, expectation)}");

            Console.WriteLine($"Вероятность по {K} карманам");
            foreach (double p in probability)
            {
                Console.Write($"{p}   ");
            }
            Console.WriteLine();
        }
    }
}
