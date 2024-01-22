---
Title: Pie - ScottPlot 5.0 Cookbook
Description: Pie charts illustrate numerical proportions as slices of a circle.
URL: /cookbook/5.0/Pie/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie"]
Date: 2024-01-22
Version: ScottPlot 5.0.20
Version: ScottPlot 5.0.20
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Pie


<h2><a href='/cookbook/5.0/Pie/PieQuickstart'>Pie Chart from Values</a></h2>

A pie chart can be created from a few values.

[![](/cookbook/5.0/images/PieQuickstart.png)](/cookbook/5.0/images/PieQuickstart.png)

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

[![](/cookbook/5.0/images/PieSlices.png)](/cookbook/5.0/images/PieSlices.png)

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

