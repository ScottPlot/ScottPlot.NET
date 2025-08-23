---
Title: Polar Axis with Lines - ScottPlot 5.0 Cookbook
Description: This is an example of a polar axis with lines instead of points
URL: /cookbook/5.0/PolarAxis/PolarWithLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis with Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarWithLines"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis with Lines</h1>
</div>

This is an example of a polar axis with lines instead of points

[![](/cookbook/5.0/images/PolarWithLines.png?250822231048)](/cookbook/5.0/images/PolarWithLines.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarWithLines.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


