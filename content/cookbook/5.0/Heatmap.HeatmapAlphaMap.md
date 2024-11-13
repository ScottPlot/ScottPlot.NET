---
Title: Alpha Map - ScottPlot 5.0 Cookbook
Description: An alpha map (a 2d array of byte values) can be used to apply custom transparency to each cell of a heatmap.
URL: /cookbook/5.0/Heatmap/HeatmapAlphaMap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Alpha Map"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapAlphaMap"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Alpha Map</h1>
</div>

An alpha map (a 2d array of byte values) can be used to apply custom transparency to each cell of a heatmap.

[![](/cookbook/5.0/images/HeatmapAlphaMap.png?241112193154)](/cookbook/5.0/images/HeatmapAlphaMap.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapAlphaMap.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// data values are translated to color based on the heatmap's colormap
double[,] data = SampleData.MonaLisa();

// an alpha map controls transparency of each cell
byte[,] alphaMap = new byte[data.GetLength(0), data.GetLength(1)];

// fill the alpha map with values from 0 (transparent) to 255 (opaque)
for (int y = 0; y &lt; alphaMap.GetLength(0); y++)
{
    for (int x = 0; x &lt; alphaMap.GetLength(1); x++)
    {
        double fractionAcross = (double)x / alphaMap.GetLength(1);
        alphaMap[y, x] = (byte)(fractionAcross * 255);
    }
}

// create a line chart
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// plot the heatmap on top of the line chart
var hm = myPlot.Add.Heatmap(data);
hm.Position = new(10, 35, -1.5, .5);
hm.AlphaMap = alphaMap;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


