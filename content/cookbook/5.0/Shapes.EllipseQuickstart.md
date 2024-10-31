---
Title: Ellipse - ScottPlot 5.0 Cookbook
Description: An ellipse can be placed on the plot and styled as desired.
URL: /cookbook/5.0/Shapes/EllipseQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Shapes", "Ellipse"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Shapes", "/cookbook/5.0/Shapes/EllipseQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Shapes/EllipseQuickstart'>Ellipse</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Shapes/EllipseQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Shapes">Category: Shapes</a>
</div>

An ellipse can be placed on the plot and styled as desired.

[![](/cookbook/5.0/images/EllipseQuickstart.png?241031194635)](/cookbook/5.0/images/EllipseQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


