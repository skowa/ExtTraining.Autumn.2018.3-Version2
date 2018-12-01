﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.AverageCalculator
{
    public class AverageCalculatorByMedian : IAverageCalculator
    {
        public double CalculateAverage(List<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}