---
Title: Colormap Steps - ScottPlot 5.0 Cookbook
Description: Colormaps can be used to generate a collection of discrete colors that can be applied to plottable objects.
URL: /cookbook/5.0/Styling/ColormapColorSteps/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Colormap Steps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/ColormapColorSteps"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/ColormapColorSteps'>Colormap Steps</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/ColormapColorSteps">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Colormaps can be used to generate a collection of discrete colors that can be applied to plottable objects.

[![](/cookbook/5.0/images/ColormapColorSteps.png?241029205813)](/cookbook/5.0/images/ColormapColorSteps.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

IColormap colormap = new ScottPlot.Colormaps.Turbo();

for (int count = 1; count < 10; count++)
{
    double[] xs = Generate.Consecutive(count);
    double[] ys = Generate.Repeating(count, count);
    Color[] colors = colormap.GetColors(count);

    for (int i = 0; i < count; i++)
    {
        var circle = myPlot.Add.Circle(xs[i], ys[i], 0.45);
        circle.FillColor = colors[i];
        circle.LineWidth = 0;
    }
}

myPlot.YLabel("number of colors");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


