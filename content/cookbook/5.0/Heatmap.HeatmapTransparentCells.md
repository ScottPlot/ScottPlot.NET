---
Title: Transparent Cells - ScottPlot 5.0 Cookbook
Description: Assign double.NaN to a heatmap cell to make it transparent.
URL: /cookbook/5.0/Heatmap/HeatmapTransparentCells/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Transparent Cells"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapTransparentCells"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Transparent Cells</h1>
</div>

Assign double.NaN to a heatmap cell to make it transparent.

[![](/cookbook/5.0/images/HeatmapTransparentCells.png?241101192719)](/cookbook/5.0/images/HeatmapTransparentCells.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// start with 2D data and set some cells to NaN
double[,] data = SampleData.MonaLisa();
for (int y = 20; y < 80; y++)
{
    for (int x = 20; x < 60; x++)
    {
        data[y, x] = double.NaN;
    }
}

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm1 = myPlot.Add.Heatmap(data);
hm1.Position = new(10, 35, -1.5, .5);

// the NaN transparency color can be customized
var hm2 = myPlot.Add.Heatmap(data);
hm2.Position = new(40, 55, -.5, .75);
hm2.NaNCellColor = Colors.Magenta.WithAlpha(.4);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


