---
Title: Manual Legend Items - ScottPlot 5.0 Cookbook
Description: Legends may be constructed manually.
URL: /cookbook/5.0/Legend/ManualLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Manual Legend Items"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/ManualLegend"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/ManualLegend'>Manual Legend Items</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/ManualLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Legends may be constructed manually.

[![](/cookbook/5.0/images/ManualLegend.png?241029205813)](/cookbook/5.0/images/ManualLegend.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));
myPlot.Legend.IsVisible = true;

LegendItem item1 = new()
{
    LineColor = Colors.Magenta,
    MarkerFillColor = Colors.Magenta,
    MarkerLineColor = Colors.Magenta,
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

<hr class='my-5 invisible'>


