﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionKnots
{
    public static class Generator
    {
        public static int EvenlyGenerate(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }

        public static double ExpGenerate(double lambda)
        {
            Random random = new Random();
            return (-(1 / lambda)) * Math.Log(random.NextDouble());
        }

        public static double PuassonGenerate()
        {
            return double.Epsilon;
        }

        public static double GaussGenerate(double m, double sigma)
        {
            Random random = new Random();
            double y12 = 0;
            for (int i = 0; i < 12; i++) 
            {
                y12 += random.NextDouble();
            }
        }



    }
}
