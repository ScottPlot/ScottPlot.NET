---
Title: Ellipse Quickstart - ScottPlot 5.0 Cookbook
Description: Ellipses can be added to plots
URL: /cookbook/5.0/Ellipse/PlotEllipseQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/PlotEllipseQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Ellipse/PlotEllipseQuickstart'>Ellipse Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Ellipse/PlotEllipseQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Ellipse">Category: Ellipse</a>
</div>

Ellipses can be added to plots

[![](/cookbook/5.0/images/PlotEllipseQuickstart.png?241031194635)](/cookbook/5.0/images/PlotEllipseQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Ellipse(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radiusX: rand.Next(1, 7),
        radiusY: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


