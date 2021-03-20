using System;

namespace ConnectionKnots
{
    public static class Generator1
    {
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
    }
}
