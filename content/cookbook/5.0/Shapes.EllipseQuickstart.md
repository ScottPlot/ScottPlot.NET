---
Title: Ellipse - ScottPlot 5.0 Cookbook
Description: An ellipse can be placed on the plot and styled as desired.
URL: /cookbook/5.0/Shapes/EllipseQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Ellipse"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/EllipseQuickstart"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse</h1>
</div>

An ellipse can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/EllipseQuickstart.png?241102170938)](/cookbook/5.0/images/EllipseQuickstart.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Shapes.cs" imageUrl="/cookbook/5.0/images/EllipseQuickstart.png?241102170938" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 10; i++)
{
    var el = myPlot.Add.Ellipse(0, 0, 1, 10, rotation: i * 10);
    double fraction = i / 10.0;
    el.LineColor = Colors.Blue.WithAlpha(fraction);
}

// force circles to remain circles
ScottPlot.AxisRules.SquareZoomOut squareRule = new(myPlot.Axes.Bottom, myPlot.Axes.Left);
myPlot.Axes.Rules.Add(squareRule);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Shapes'>Shapes</a> category</div>


