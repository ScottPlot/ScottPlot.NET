---
Title: Colormaps - ScottPlot 5 Cookbook
Description: A colormap is a continuous gradient of multiple colors. It can be used to color continuous data like heatmaps and images, but colormaps may also be sampled directly to create collections of colors. https://scottplot.net/cookbook/5/colormaps/ displays all colormaps included with ScottPlot.
URL: /cookbook/5/Styling/Colormaps/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Colormaps"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/Colormaps"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colormaps</h1>
</div>

A colormap is a continuous gradient of multiple colors. It can be used to color continuous data like heatmaps and images, but colormaps may also be sampled directly to create collections of colors. https://scottplot.net/cookbook/5/colormaps/ displays all colormaps included with ScottPlot.

[![](/cookbook/5/images/Colormaps.png?251011113742)](/cookbook/5/images/Colormaps.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/Colormaps.png?251011113742" >}}ScottPlot.Plot myPlot = new();

var colormap1 = new ScottPlot.Colormaps.Viridis();
var colormap2 = colormap1.Invert();
var colormap3 = colormap1.InvertHue();

int steps = 20;
for (int x = 0; x &lt; steps; x++)
{
    CoordinateRect rect1 = CoordinateRect.UnitSquare.WithTranslation(x, 4);
    CoordinateRect rect2 = CoordinateRect.UnitSquare.WithTranslation(x, 2);
    CoordinateRect rect3 = CoordinateRect.UnitSquare.WithTranslation(x, 0);
    var shape1 = myPlot.Add.Rectangle(rect1);
    var shape2 = myPlot.Add.Rectangle(rect2);
    var shape3 = myPlot.Add.Rectangle(rect3);

    // set color using the colormap
    double fraction = (double)x / (steps - 1);
    shape1.FillColor = colormap1.GetColor(fraction);
    shape2.FillColor = colormap2.GetColor(fraction);
    shape3.FillColor = colormap3.GetColor(fraction);

    shape1.LineColor = shape1.FillColor;
    shape2.LineColor = shape2.FillColor;
    shape3.LineColor = shape3.FillColor;
}

myPlot.Add.Text("Standard", 0, 5.5);
myPlot.Add.Text("Inverted", 0, 3.5);
myPlot.Add.Text("Inverted Hue", 0, 1.5);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


