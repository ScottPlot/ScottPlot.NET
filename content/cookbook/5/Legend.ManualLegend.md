---
Title: Manual Legend Items - ScottPlot 5 Cookbook
Description: Legends may be constructed manually and markers customized.
URL: /cookbook/5/Legend/ManualLegend/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Legends", "Manual Legend Items"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Legend", "/cookbook/5/Legend/ManualLegend"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Manual Legend Items</h1>
</div>

Legends may be constructed manually and markers customized.

[![](/cookbook/5/images/ManualLegend.png?260329072039)](/cookbook/5/images/ManualLegend.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5/images/ManualLegend.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));
myPlot.Legend.IsVisible = true;

LegendItem item1 = new()
{
    LineColor = Colors.Magenta,
    MarkerFillColor = Colors.Magenta,
    MarkerLineColor = Colors.Magenta,
    MarkerShape = MarkerShape.Cross,
    LineWidth = 2,
    LabelText = "Alpha"
};

LegendItem item2 = new()
{
    LineColor = Colors.Green,
    MarkerFillColor = Colors.Green,
    MarkerLineColor = Colors.Green,
    LineWidth = 4,
    LabelText = "Beta"
};

LegendItem[] items = { item1, item2 };
myPlot.ShowLegend(items);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Legend'>Legends</a> category</div>


