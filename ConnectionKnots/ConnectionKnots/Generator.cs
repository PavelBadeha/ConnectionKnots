using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionKnots
{
    public static class Generator
    {
        public static double EvenlyGenerate(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max + 1);
        }

        public static double ExpGenerate(double lambda)
        {
            Random random = new Random();
            return (-(1 / lambda)) * Math.Log(random.NextDouble());
        }

        public static double PuassonGenerate(double lambda)
        {
            Random rand = new Random();
            int k = 0;
            double p = Math.Exp(--lambda);
            double G = p;
            double z = rand.NextDouble();

            while (z <= G)
            {
                p = p * lambda / (k + 1);
                G = G + p;
                k++;
            }

            return k;
        }

        public static double ErlangGenerate(double lambda)
        {
            double t = 0;
            for (int i = 1; i <= 3; i++)
            {
                t += Generator.ExpGenerate(lambda);
            }

            return t;
        }

        public static double GaussGenerate(double m, double sigma)
        {
            Random random = new Random();
            double y12 = 0;
            for (int i = 0; i < 12; i++) 
            {
                y12 += random.NextDouble();
            }
            y12 -= 6;

            return m + sigma * y12;
        }

        public static double LogNormalGenerate(double m, double sigma)
        {
            return Math.Exp(GaussGenerate(m, sigma));
        }
    }
}
