---
Title: Polar Axis Styling - ScottPlot 5.0 Cookbook
Description: The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).
URL: /cookbook/5.0/PolarAxis/PolarAxisStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarAxisStyling"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Styling</h1>
</div>

The lines of polar axes may be extensively styled. Polar axes have radial spokes (straight lines that extend from the origin to the maximum radius) and circular axis lines (concentric circles centered at the origin).

[![](/cookbook/5.0/images/PolarAxisStyling.png?250822231048)](/cookbook/5.0/images/PolarAxisStyling.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarAxisStyling.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

// style the spokes (straight lines extending from the center to mark rotations)
var radialPalette = new ScottPlot.Palettes.Category10();
for (int i = 0; i &lt; polarAxis.Spokes.Count; i++)
{
    polarAxis.Spokes[i].LineColor = radialPalette.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineWidth = 4;
    polarAxis.Spokes[i].LabelStyle.ForeColor = radialPalette.GetColor(i);
    polarAxis.Spokes[i].LabelStyle.FontSize = 16;
    polarAxis.Spokes[i].LabelStyle.Bold = true;
}

// style the circles (concentric circles marking radius positions)
var circularColormap = new ScottPlot.Colormaps.Rain();
for (int i = 0; i &lt; polarAxis.Circles.Count; i++)
{
    double fraction = (double)i / (polarAxis.Circles.Count - 1);
    polarAxis.Circles[i].LineColor = circularColormap.GetColor(fraction).WithAlpha(.5);
    polarAxis.Circles[i].LineWidth = 2;
    polarAxis.Circles[i].LinePattern = LinePattern.Dashed;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


