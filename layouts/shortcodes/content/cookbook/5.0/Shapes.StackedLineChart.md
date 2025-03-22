---
Title: Stacked Line Chart - ScottPlot 5.0 Cookbook
Description: A stacked line chart may be achieved by combining primitive shapes onto a plot.
URL: /cookbook/5.0/Shapes/StackedLineChart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Stacked Line Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/StackedLineChart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Line Chart</h1>
</div>

A stacked line chart may be achieved by combining primitive shapes onto a plot.

[![](/cookbook/5.0/images/StackedLineChart.png?250322130304)](/cookbook/5.0/images/StackedLineChart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/StackedLineChart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// prepare values for each line
double[] values1 = [8.4, 6.9, 6.5, 4.4];
double[] values2 = [7.9, 6.6, 6.4, 6.2];
double[] values3 = [6.2, 7.3, 5.5, 3.7];

// create a collection holding values for each line
double[][] allValues = [values1, values2, values3];

// calculate step points for each like by storing each point twice
double[] runningSum = new double[values1.Length];
for (int i = 0; i &lt; allValues.Length; i++)
{
    // add values on top of the running sum to achieve stacking effect
    runningSum = DataOperations.SumVertically([runningSum, allValues[i]]);

    List&lt;Coordinates&gt; points = [];
    for (int j = 0; j &lt; runningSum.Length; j++)
    {
        points.Add(new(j, runningSum[j]));
        points.Add(new(j + 1, runningSum[j]));
    }

    // plot the points as it is to show a line
    Coordinates[] lineCoordinates = [.. points];

    // add the start and end points
    points.Add(new(points.Last().X, 0));
    points.Add(new(points.First().X, 0));
    Coordinates[] fillCoordinates = [.. points];

    // add the polygon then top it with a line
    var line = myPlot.Add.ScatterLine(lineCoordinates);
    line.Color = ScottPlot.Palette.Default.GetColor(i);
    line.LineWidth = 2;

    var poly = myPlot.Add.Polygon(fillCoordinates);
    poly.FillColor = line.Color.Lighten(.5);
    poly.LineWidth = 0;
}

// reverse the order of everything so the smallest polygons
// (the first that were added) to be displayed on top and rendered last
myPlot.PlottableList.Reverse();

// use tight margins to prevent padding between the data and edge of the plot
myPlot.Axes.Margins(0, 0, 0, 0.1);

// add group labels
double[] positions = [0.5, 1.5, 2.5, 3.5];
string[] labels = { "Alfred", "Ralph", "Don", "James" };
myPlot.Axes.Bottom.SetTicks(positions, labels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


