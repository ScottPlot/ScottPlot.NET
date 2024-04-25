---
Title: Pie - ScottPlot 5.0 Cookbook
Description: Pie charts illustrate numerical proportions as slices of a circle.
URL: /cookbook/5.0/Pie/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie"]
Date: 2024-04-25
Version: ScottPlot 5.0.28
Version: ScottPlot 5.0.28
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Pie


<h2><a href='/cookbook/5.0/Pie/PieQuickstart'>Pie Chart from Values</a></h2>

A pie chart can be created from a few values.

[![](/cookbook/5.0/images/PieQuickstart.png?240425082609)](/cookbook/5.0/images/PieQuickstart.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Pie/PieSlices'>Pie Chart from Slices</a></h2>

A pie chart can be created from a collection of slices.

[![](/cookbook/5.0/images/PieSlices.png?240425082609)](/cookbook/5.0/images/PieSlices.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

List<PieSlice> slices = new()
{
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue" },
};

var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Pie/PieDonut'>Donut from Slices</a></h2>

A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.

[![](/cookbook/5.0/images/PieDonut.png?240425082609)](/cookbook/5.0/images/PieDonut.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

List<PieSlice> slices = new()
{
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue" },
};

var pie = myPlot.Add.Pie(slices);
pie.DonutFraction = .5;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Pie/PieSliceLabels'>Pie Slice Labels</a></h2>

Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.

[![](/cookbook/5.0/images/PieSliceLabels.png?240425082609)](/cookbook/5.0/images/PieSliceLabels.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

PieSlice slice1 = new() { Value = 5, FillColor = Colors.Red, Label = "Red" };
PieSlice slice2 = new() { Value = 2, FillColor = Colors.Orange, Label = "Orange" };
PieSlice slice3 = new() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" };
PieSlice slice4 = new() { Value = 4, FillColor = Colors.Green, Label = "Green" };
PieSlice slice5 = new() { Value = 8, FillColor = Colors.Blue, Label = "Blue" };
List<PieSlice> slices = new() { slice1, slice2, slice3, slice4, slice5 };

// setup the pie to display slice labels
var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;
pie.ShowSliceLabels = true;
pie.SliceLabelDistance = 1.3;

// styling can be customized for individual slices
slice5.LabelStyle.FontSize = 22;
slice5.LabelStyle.ForeColor = Colors.Magenta;
slice5.LabelStyle.Bold = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

