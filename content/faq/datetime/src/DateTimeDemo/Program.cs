using System;
using System.Linq;

void PlotScatter()
{
    // generate sample data (arrays of individual DateTimes and values)
    int pointCount = 100;
    Random rand = new Random(0);
    double[] values = ScottPlot.DataGen.RandomWalk(rand, pointCount);
    DateTime[] dates = Enumerable.Range(0, pointCount)
                                 .Select(x => new DateTime(2016, 06, 27).AddDays(x))
                                 .ToArray();

    // use LINQ and DateTime.ToOADate() to convert DateTime[] to double[]
    double[] xs = dates.Select(x => x.ToOADate()).ToArray();

    // plot the double arrays using a traditional scatter plot
    var plt = new ScottPlot.Plot(600, 400);
    plt.AddScatter(xs, values);

    // indicate the horizontal axis tick labels should display DateTime units
    plt.XAxis.DateTimeFormat(true);

    // add padding to the right to prevent long dates from flowing off the figure
    plt.YAxis2.SetSizeLimit(min: 40);

    // save the output
    plt.Title("Scatter Plot with DateTime Axis");
    plt.SaveFig("../../../datetime-scatter.png");
}

void PlotSignalMinutes()
{
    // generate sample data (arrays of individual DateTimes and values)
    int pointCount = 100;
    Random rand = new Random(1);
    double[] values = ScottPlot.DataGen.RandomWalk(rand, pointCount);
    DateTime firstDay = new DateTime(2016, 06, 27);
    double samplesPerDay = (24 * 60); // one sample per minute

    // plot the double arrays using a traditional scatter plot
    var plt = new ScottPlot.Plot(600, 400);
    var sig = plt.AddSignal(values, sampleRate: samplesPerDay);
    sig.OffsetX = firstDay.ToOADate();

    // indicate the horizontal axis tick labels should display DateTime units
    plt.XAxis.DateTimeFormat(true);

    // add padding to the right to prevent long dates from flowing off the figure
    plt.YAxis2.SetSizeLimit(min: 40);

    // save the output
    plt.Title("Signal Plot with DateTime Axis");
    plt.SaveFig("../../../datetime-signal.png");
}

PlotScatter();
PlotSignalMinutes();