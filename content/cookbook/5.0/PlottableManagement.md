---
Title: Plottable Management - ScottPlot 5.0 Cookbook
Description: How to add, remove, and reorder items in plots
URL: /cookbook/5.0/PlottableManagement/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Plottable Management


<h2><a href='/cookbook/5.0/PlottableManagement/AddPlottablesManually'>Add Plottables Manually</a></h2>

Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This strategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.

[![](/cookbook/5.0/images/AddPlottablesManually.png?241027221943)](/cookbook/5.0/images/AddPlottablesManually.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create a plottable and modify it as desired
ScottPlot.Plottables.LinePlot line = new()
{
    Start = new Coordinates(1, 2),
    End = new Coordinates(3, 4),
};

// add the custom plottable to the plot
myPlot.Add.Plottable(line);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/PlottableManagement/Clear'>Clearing Plots</a></h2>

Use Clear() to remove all plottables.

[![](/cookbook/5.0/images/Clear.png?241027221943)](/cookbook/5.0/images/Clear.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add plottables
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// remove all plottables
myPlot.Clear();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/PlottableManagement/Remove'>Removing a Plottable</a></h2>

Individual items may be removed from the plot.

[![](/cookbook/5.0/images/Remove.png?241027221943)](/cookbook/5.0/images/Remove.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add plottables
var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

// remove a specific plottable
myPlot.Remove(sig1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/PlottableManagement/RemoveAll'>Removing all Plottables of a Type</a></h2>

All plottables of a given type may be removed from a plot with a single command.

[![](/cookbook/5.0/images/RemoveAll.png?241027221943)](/cookbook/5.0/images/RemoveAll.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Scatter(Generate.Consecutive(51), Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.HorizontalLine(0.75);

// remove every instance of a specific plottable type
myPlot.Remove<ScottPlot.Plottables.Signal>();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/PlottableManagement/ChangeOrder'>Moving plottables</a></h2>

The plottable list contains all plottables which will be rendered in order. Helper methods are available to move plottables to the front.

[![](/cookbook/5.0/images/ChangeOrder.png?241027221943)](/cookbook/5.0/images/ChangeOrder.png?241027221943)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

CoordinateRect wideRect = new(-2, 2, -1, 1);
CoordinateRect tallRect = new(-1, 1, -2, 2);

// rect1 is added first, so plottables added later will appear on top
var rect1 = myPlot.Add.Rectangle(wideRect);
var rect2 = myPlot.Add.Rectangle(tallRect);

// plottables may be moved to the front so they always appear on top
myPlot.MoveToTop(rect1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

