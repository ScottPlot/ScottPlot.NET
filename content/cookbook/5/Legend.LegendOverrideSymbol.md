---
Title: Legend Marker Shape Override - ScottPlot 5 Cookbook
Description: Use the legend shape override to force all legend items to display using the given marker shape.
URL: /cookbook/5/Legend/LegendOverrideSymbol/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Legends", "Legend Marker Shape Override"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Legend", "/cookbook/5/Legend/LegendOverrideSymbol"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Marker Shape Override</h1>
</div>

Use the legend shape override to force all legend items to display using the given marker shape.

[![](/cookbook/5/images/LegendOverrideSymbol.png?251011113742)](/cookbook/5/images/LegendOverrideSymbol.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5/images/LegendOverrideSymbol.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// this shape will be used for legend items without defined markers
myPlot.Legend.MarkerShapeOverride = MarkerShape.FilledCircle;

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

LegendItem item1 = new()
{
    MarkerColor = Colors.Red,
    MarkerShape = MarkerShape.Cross,
    LabelText = "Alpha"
};

LegendItem item2 = new()
{
    MarkerColor = Colors.Green,
    MarkerShape = MarkerShape.FilledSquare,
    LabelText = "Beta"
};

myPlot.Legend.ManualItems.Add(item1);
myPlot.Legend.ManualItems.Add(item2);

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Legend'>Legends</a> category</div>


