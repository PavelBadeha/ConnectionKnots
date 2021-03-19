using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionKnots
{
    public static class Generator
    {
        public static double PuassonGenerate(double lambda)
        {
            Random rand = new Random();
            int k = 0;
            double p = Math.Exp(--lambda);
            double G = p;
            double z = rand.NextDouble();
            while(z <= G)
            {
                p = p * lambda / (k + 1);
                G = G + p;
                k++;
            }

            return z;
        }
    }
}
