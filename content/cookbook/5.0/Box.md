---
Title: Box Plot - ScottPlot 5.0 Cookbook
Description: Box plots show a distribution at a glance
URL: /cookbook/5.0/Box/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box"]
Date: 2024-04-27
Version: ScottPlot 5.0.31
Version: ScottPlot 5.0.31
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Box Plot


<h2><a href='/cookbook/5.0/Box/BoxPlotQuickstart'>Box Plot Quickstart</a></h2>

Box plots can be created individually and added to the plot.

[![](/cookbook/5.0/images/BoxPlotQuickstart.png?240427161103)](/cookbook/5.0/images/BoxPlotQuickstart.png?240427161103)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

ScottPlot.Box box = new()
{
    Position = 5,
    BoxMin = 81,
    BoxMax = 93,
    WhiskerMin = 76,
    WhiskerMax = 107,
    BoxMiddle = 84,
};

myPlot.Add.Box(box);

myPlot.Axes.SetLimits(0, 10, 70, 110);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Box/BoxPlotGroups'>Box Plot Groups</a></h2>

Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.

[![](/cookbook/5.0/images/BoxPlotGroups.png?240427161103)](/cookbook/5.0/images/BoxPlotGroups.png?240427161103)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

List<ScottPlot.Box> boxes1 = new() {
    Generate.RandomBox(1),
    Generate.RandomBox(2),
    Generate.RandomBox(3),
};

List<ScottPlot.Box> boxes2 = new() {
    Generate.RandomBox(5),
    Generate.RandomBox(6),
    Generate.RandomBox(7),
};

var bp1 = myPlot.Add.Boxes(boxes1);
bp1.LegendText = "Group 1";

var bp2 = myPlot.Add.Boxes(boxes2);
bp2.LegendText = "Group 2";

myPlot.ShowLegend(Alignment.UpperRight);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

