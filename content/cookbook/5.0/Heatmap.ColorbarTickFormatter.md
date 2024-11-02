---
Title: Colorbar Tick Formatter - ScottPlot 5.0 Cookbook
Description: Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.
URL: /cookbook/5.0/Heatmap/ColorbarTickFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Colorbar Tick Formatter"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/ColorbarTickFormatter"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colorbar Tick Formatter</h1>
</div>

Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.

[![](/cookbook/5.0/images/ColorbarTickFormatter.png?241102170938)](/cookbook/5.0/images/ColorbarTickFormatter.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/ColorbarTickFormatter.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[,] data = SampleData.MonaLisa();

var hm = myPlot.Add.Heatmap(data);
var cb = myPlot.Add.ColorBar(hm);

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


