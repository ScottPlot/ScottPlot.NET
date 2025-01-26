---
Title: Quickstart - ScottPlot 5.0 Cookbook
Description: A survey of basic functionality in ScottPlot 5
URL: /cookbook/5.0/ScottPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Quickstart</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot</h1>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A scatter plot can be used to display X/Y data points.

[![](/cookbook/5.0/images/QuickstartScatter.png?250126165944)](/cookbook/5.0/images/QuickstartScatter.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartScatter.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Customizing Plottables</h1>
<a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.

[![](/cookbook/5.0/images/CustomizingPlottables.png?250126165944)](/cookbook/5.0/images/CustomizingPlottables.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/CustomizingPlottables.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot</h1>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots display Y values at evenly spaced X positions. Signal plots should be used instead of Scatter plots whenever possible.

[![](/cookbook/5.0/images/QuickstartSignal.png?250126165944)](/cookbook/5.0/images/QuickstartSignal.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartSignal.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] sin = Generate.Sin(51);

// add a signal plot to the plot
myPlot.Add.Signal(sin);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Performance</h1>
<a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots are so performant that they can interactively display millions of data points in real time.

[![](/cookbook/5.0/images/SignalPerformance.png?250126165944)](/cookbook/5.0/images/SignalPerformance.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/SignalPerformance.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample data with one million points
double[] data = Generate.RandomWalk(1_000_000);

// add a signal plot to the plot
myPlot.Add.Signal(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Labels</h1>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Plots have helper methods for quickly setting axis labels. Refer to other cookbook pages for additional axis customization options.

[![](/cookbook/5.0/images/QuickstartAxisLabels.png?250126165944)](/cookbook/5.0/images/QuickstartAxisLabels.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartAxisLabels.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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


