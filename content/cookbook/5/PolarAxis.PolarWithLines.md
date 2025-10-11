---
Title: Polar Axis with Lines - ScottPlot 5 Cookbook
Description: This is an example of a polar axis with lines instead of points
URL: /cookbook/5/PolarAxis/PolarWithLines/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Axis with Lines"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarWithLines"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis with Lines</h1>
</div>

This is an example of a polar axis with lines instead of points

[![](/cookbook/5/images/PolarWithLines.png?251011113742)](/cookbook/5/images/PolarWithLines.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarWithLines.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// add a polar axis to the plot
var polarAxis = myPlot.Add.PolarAxis(radius: 100);

IColormap colormap = new ScottPlot.Colormaps.Turbo();
Coordinates? previousPt = null;

foreach (double fraction in ScottPlot.Generate.Range(0, 1, 0.02))
{
    // use the polar axis to get X/Y coordinates given a position in polar space
    double radius = 100 * fraction;
    double degrees = 360 * fraction;
    Coordinates pt = polarAxis.GetCoordinates(radius, degrees);

    if (previousPt != null)
    {
        ScottPlot.Plottables.LinePlot lp = myPlot.Add.Line(previousPt.Value.X, previousPt.Value.Y, pt.X, pt.Y);
        lp.LineWidth = 5;
        lp.Color = Colors.Red;
        previousPt = pt;
    }
    else
    {
        previousPt = pt;
    }
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


