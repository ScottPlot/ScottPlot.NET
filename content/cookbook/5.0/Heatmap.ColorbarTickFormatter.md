---
Title: Colorbar Tick Formatter - ScottPlot 5.0 Cookbook
Description: Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.
URL: /cookbook/5.0/Heatmap/ColorbarTickFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Colorbar Tick Formatter"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/ColorbarTickFormatter"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Heatmap/ColorbarTickFormatter'>Colorbar Tick Formatter</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Heatmap/ColorbarTickFormatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Heatmap">Category: Heatmap</a>
</div>

Colorbars have an optional custom tick formatter that allows users to control the string format of tick labels.

[![](/cookbook/5.0/images/ColorbarTickFormatter.png?241031194635)](/cookbook/5.0/images/ColorbarTickFormatter.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


