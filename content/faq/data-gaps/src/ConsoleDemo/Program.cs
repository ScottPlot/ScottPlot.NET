using System;
using System.Drawing;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var plt = new ScottPlot.Plot(400, 300);

            double[] xs1 = { 1, 2, 3 };
            double[] ys1 = { 5, 4, 8 };
            plt.AddScatter(xs1, ys1, Color.Blue);

            double[] xs2 = { 5, 6, 7, 8 };
            double[] ys2 = { 6, 9, 4, 7 };
            plt.AddScatter(xs2, ys2, Color.Blue);

            double[] xs3 = { 10, 11, 12 };
            double[] ys3 = { 8, 3, 7 };
            plt.AddScatter(xs3, ys3, Color.Blue);

            plt.Title("Discontinuous Scatter Plot");
            plt.SaveFig("demo.png");
        }
    }
}
