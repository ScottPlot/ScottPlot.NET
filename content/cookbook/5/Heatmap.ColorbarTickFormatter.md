---
Title: Colorbar Tick Formatter - ScottPlot 5 Cookbook
Description: Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.
URL: /cookbook/5/Heatmap/ColorbarTickFormatter/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Heatmap", "Colorbar Tick Formatter"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Heatmap", "/cookbook/5/Heatmap/ColorbarTickFormatter"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colorbar Tick Formatter</h1>
</div>

Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.

[![](/cookbook/5/images/ColorbarTickFormatter.png?251011113742)](/cookbook/5/images/ColorbarTickFormatter.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5/images/ColorbarTickFormatter.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm = myPlot.Add.Heatmap(data);
var cb = myPlot.Add.ColorBar(hm);
cb.MinimumSize = 80; // reserve space for the colorbar and tick labels

// create a static function containing the string formatting logic
static string CustomFormatter(double position)
{
    return $"{Math.Round(position / 2.55)} %";
}

// create a custom tick generator using your custom label formatter
ScottPlot.TickGenerators.NumericAutomatic myTickGenerator = new()
{
    LabelFormatter = CustomFormatter
};

// tell the colorbar to use the custom tick generator
cb.Axis.TickGenerator = myTickGenerator;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Heatmap'>Heatmap</a> category</div>


