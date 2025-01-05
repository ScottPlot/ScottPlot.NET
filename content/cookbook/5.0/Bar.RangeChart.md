---
Title: Range Chart - ScottPlot 5.0 Cookbook
Description: A range chart displays a discrete set of named value ranges
URL: /cookbook/5.0/Bar/RangeChart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Range Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/RangeChart"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Range Chart</h1>
</div>

A range chart displays a discrete set of named value ranges

[![](/cookbook/5.0/images/RangeChart.png?250105183901)](/cookbook/5.0/images/RangeChart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/RangeChart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

List&lt;(string name, CoordinateRange range)&gt; ranges =
[
    ("Africa", new(-35, 37)),
    ("Antarctica", new(-90, -60)),
    ("Asia", new(-11, 81)),
    ("Europe", new(-36, 71)),
    ("North America", new(-7, 83)),
    ("South America", new(-56, 13)),
    ("Australia", new(-47, -28)),
];
myPlot.Add.Ranges(ranges);

// style the axes
myPlot.Title("Latitude Range of the Continents");
myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;
myPlot.Axes.Bottom.MinimumSize = 100;

// use tick labels with a degree symbol
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
myPlot.Axes.Left.TickGenerator = tickGen;
tickGen.LabelFormatter = (x) =&gt; $"{x}º";

// add a horizontal line at zero and push it beneath the range plot
var hl = myPlot.Add.HorizontalLine(0, 1, Colors.Black, LinePattern.DenselyDashed);
myPlot.MoveToBack(hl);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


