---
Title: Legend Marker Shape Override with auto color - ScottPlot 5 Cookbook
Description: Use the legend shape override to force all legend items to display using the given marker shape. Color is determined automatically in this example.
URL: /cookbook/5/Legend/LegendOverrideSymbolAutoColor/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Legends", "Legend Marker Shape Override with auto color"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Legend", "/cookbook/5/Legend/LegendOverrideSymbolAutoColor"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Marker Shape Override with auto color</h1>
</div>

Use the legend shape override to force all legend items to display using the given marker shape. Color is determined automatically in this example.

[![](/cookbook/5/images/LegendOverrideSymbolAutoColor.png?260329072039)](/cookbook/5/images/LegendOverrideSymbolAutoColor.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5/images/LegendOverrideSymbolAutoColor.png?260329072039" >}}ScottPlot.Plot myPlot = new();

List&lt;PieSlice&gt; slices =
[
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red", LegendText = "R" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green", LegendText = "G" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue", LegendText = "B" },
];

myPlot.Legend.MarkerShapeOverride = MarkerShape.FilledCircle;

var pie = myPlot.Add.Pie(slices);

myPlot.Axes.Frameless();
myPlot.HideGrid();
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Legend'>Legends</a> category</div>


