---
Title: Circle with Locked Scale - ScottPlot 5.0 Cookbook
Description: For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.
URL: /cookbook/5.0/Ellipse/CircleWithLockedScale/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Circle with Locked Scale"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/CircleWithLockedScale"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Ellipse/CircleWithLockedScale'>Circle with Locked Scale</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Ellipse/CircleWithLockedScale">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Ellipse">Category: Ellipse</a>
</div>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

[![](/cookbook/5.0/images/CircleWithLockedScale.png?241029205813)](/cookbook/5.0/images/CircleWithLockedScale.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


