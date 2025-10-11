---
Title: Colormap Steps - ScottPlot 5 Cookbook
Description: Colormaps can be used to generate a collection of discrete colors that can be applied to plottable objects.
URL: /cookbook/5/Styling/ColormapColorSteps/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Colormap Steps"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/ColormapColorSteps"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colormap Steps</h1>
</div>

Colormaps can be used to generate a collection of discrete colors that can be applied to plottable objects.

[![](/cookbook/5/images/ColormapColorSteps.png?251011113742)](/cookbook/5/images/ColormapColorSteps.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/ColormapColorSteps.png?251011113742" >}}ScottPlot.Plot myPlot = new();

IColormap colormap = new ScottPlot.Colormaps.Turbo();

for (int count = 1; count &lt; 10; count++)
{
    double[] xs = Generate.Consecutive(count);
    double[] ys = Generate.Repeating(count, count);
    Color[] colors = colormap.GetColors(count);

    for (int i = 0; i &lt; count; i++)
    {
        var circle = myPlot.Add.Circle(xs[i], ys[i], 0.45);
        circle.FillColor = colors[i];
        circle.LineWidth = 0;
    }
}

myPlot.YLabel("number of colors");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


