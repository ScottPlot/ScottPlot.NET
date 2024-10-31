---
Title: Circle Quickstart - ScottPlot 5.0 Cookbook
Description: Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.
URL: /cookbook/5.0/Ellipse/PlotCircleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Circle Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/PlotCircleQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Ellipse/PlotCircleQuickstart'>Circle Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Ellipse/PlotCircleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Ellipse">Category: Ellipse</a>
</div>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

[![](/cookbook/5.0/images/PlotCircleQuickstart.png?241031194635)](/cookbook/5.0/images/PlotCircleQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


