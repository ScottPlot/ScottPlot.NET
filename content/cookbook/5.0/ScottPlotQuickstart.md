---
Title: Quickstart - ScottPlot 5.0 Cookbook
Description: A survey of basic functionality in ScottPlot 5
URL: /cookbook/5.0/ScottPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Quickstart</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter'>Scatter Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

A scatter plot can be used to display X/Y data points.

[![](/cookbook/5.0/images/QuickstartScatter.png?241031194635)](/cookbook/5.0/images/QuickstartScatter.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables'>Customizing Plottables</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.

[![](/cookbook/5.0/images/CustomizingPlottables.png?241031194635)](/cookbook/5.0/images/CustomizingPlottables.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot (and save what is returned)
var myScatter = myPlot.Add.Scatter(dataX, dataY);

// customize the scatter plot
myScatter.Color = Colors.Green;
myScatter.LineWidth = 5;
myScatter.MarkerSize = 15;
myScatter.MarkerShape = MarkerShape.FilledDiamond;
myScatter.LinePattern = LinePattern.DenselyDashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal'>Signal Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.

[![](/cookbook/5.0/images/QuickstartSignal.png?241031194635)](/cookbook/5.0/images/QuickstartSignal.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] sin = Generate.Sin(51);

// add a signal plot to the plot
myPlot.Add.Signal(sin);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance'>Signal Plot Performance</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/SignalPerformance">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Signal plots are so performant that they can interactively display millions of data points in real time.

[![](/cookbook/5.0/images/SignalPerformance.png?241031194635)](/cookbook/5.0/images/SignalPerformance.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data with one million points
double[] data = Generate.RandomWalk(1_000_000);

// add a signal plot to the plot
myPlot.Add.Signal(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels'>Axis Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Plots have helper methods for quickly setting axis labels. Refer to other cookbook pages for additional axis customization options.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png?241031194635)](/cookbook/5.0/images/QuickstartAxisLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// customize axis labels
myPlot.XLabel("Horizonal Axis");
myPlot.YLabel("Vertical Axis");
myPlot.Title("Plot Title");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


