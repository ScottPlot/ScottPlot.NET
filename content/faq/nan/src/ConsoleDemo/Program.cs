using System;
using System.Drawing;
using System.Linq;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var plt = new ScottPlot.Plot(400, 300);

            // create original data with unplottable values
            double[] originalYs = { 3, double.NaN, 5, double.PositiveInfinity, double.NegativeInfinity, 4, 6 };
            double[] originalXs = { 1, 2, 3, 4, 5, 6, 7 };

            // Attempting to plot these arrays would throw an exception at render time
            //plt.AddScatter(originalXs, originalYs);

            // isolate and plot real data values
            var plottableIndexes =
                Enumerable
                .Range(0, originalYs.Length)
                .Where(i => !double.IsNaN(originalYs[i]))
                .Where(i => !double.IsInfinity(originalYs[i]));
            double[] plottableXs = plottableIndexes.Select(i => originalXs[i]).ToArray();
            double[] plottableYs = plottableIndexes.Select(i => originalYs[i]).ToArray();
            plt.AddScatter(plottableXs, plottableYs);

            plt.Title("Data Containing NaN and Infinity");
            plt.SaveFig("../../../output.png");
        }
    }
}
