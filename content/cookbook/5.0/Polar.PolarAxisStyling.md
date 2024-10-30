---
Title: Polar Axis Styling - ScottPlot 5.0 Cookbook
Description: The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).
URL: /cookbook/5.0/Polar/PolarAxisStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarAxisStyling"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarAxisStyling'>Polar Axis Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarAxisStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).

[![](/cookbook/5.0/images/PolarAxisStyling.png?241029205813)](/cookbook/5.0/images/PolarAxisStyling.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

// style the spokes (straight lines extending from the center to mark rotations)
var radialPalette = new ScottPlot.Palettes.Category10();
for (int i = 0; i < polarAxis.Spokes.Count; i++)
{
    polarAxis.Spokes[i].LineColor = radialPalette.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineWidth = 4;
    polarAxis.Spokes[i].LabelStyle.ForeColor = radialPalette.GetColor(i);
    polarAxis.Spokes[i].LabelStyle.FontSize = 16;
    polarAxis.Spokes[i].LabelStyle.Bold = true;
}

// style the circles (concentric circles marking radius positions)
var circularColormap = new ScottPlot.Colormaps.Rain();
for (int i = 0; i < polarAxis.Circles.Count; i++)
{
    double fraction = (double)i / (polarAxis.Circles.Count - 1);
    polarAxis.Circles[i].LineColor = circularColormap.GetColor(fraction).WithAlpha(.5);
    polarAxis.Circles[i].LineWidth = 2;
    polarAxis.Circles[i].LinePattern = LinePattern.Dashed;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


