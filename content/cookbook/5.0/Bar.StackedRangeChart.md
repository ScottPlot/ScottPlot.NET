---
Title: Stacked Range Chart - ScottPlot 5.0 Cookbook
Description: Stacked range charts depict multiple ranges for a discrete set of items
URL: /cookbook/5.0/Bar/StackedRangeChart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Range Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/StackedRangeChart"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Range Chart</h1>
</div>

Stacked range charts depict multiple ranges for a discrete set of items

[![](/cookbook/5.0/images/StackedRangeChart.png?250105183901)](/cookbook/5.0/images/StackedRangeChart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/StackedRangeChart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// prepare a custom color palette
string[] colorCodes = ["#3369cc", "#95bce3", "#f4a861", "#fd8d00"];
ScottPlot.Palettes.Custom palette = new(colorCodes);

// create a stacked bar chart with a collection of named ranges
string[] rangeNames = ["Yearly Low", "Mean Daily Low", "Mean Daily High", "Yearly High"];
List&lt;(string name, double[] edges)&gt; ranges =
[
    ("Ontario", [-9, 3, 7, 13, 27]),
    ("England", [4, 7, 12, 16, 24]),
    ("Kentucky", [-4, 7, 13, 20, 30]),
];
myPlot.Add.StackedRanges(ranges, palette);

// use tick labels with a degree symbol
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
myPlot.Axes.Left.TickGenerator = tickGen;
tickGen.LabelFormatter = (x) =&gt; $"{x}º";

// display the legend outside the data area
myPlot.ShowLegend(Edge.Right);

// add items to the legend manually
for (int i = 0; i &lt; rangeNames.Length; i++)
{
    LegendItem item = new()
    {
        LabelText = rangeNames[i],
        FillColor = palette.GetColor(i),
    };
    myPlot.Legend.ManualItems.Add(item);
}
myPlot.Legend.ManualItems.Reverse();

// improve styling and alignment
myPlot.Legend.OutlineStyle.IsVisible = false;
myPlot.Legend.ShadowColor = Colors.Transparent;
myPlot.Legend.Padding = new(0);
myPlot.Axes.Right.MaximumSize = 0;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


