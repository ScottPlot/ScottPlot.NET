---
Title: Palettes - ScottPlot 5.0 Cookbook
Description: A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.
URL: /cookbook/5.0/Styling/Palette/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Palettes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Palette"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/Palette'>Palettes</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/Palette">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](/cookbook/5.0/images/Palette.png?241029205813)](/cookbook/5.0/images/Palette.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// change the default palette used when adding new plottables
myPlot.Add.Palette = new ScottPlot.Palettes.Nord();

for (int i = 0; i < 5; i++)
{
    double[] data = Generate.Sin(100, phase: -i / 20.0f);
    var sig = myPlot.Add.Signal(data);
    sig.LineWidth = 3;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


