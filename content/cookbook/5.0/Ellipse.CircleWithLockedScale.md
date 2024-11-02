---
Title: Circle with Locked Scale - ScottPlot 5.0 Cookbook
Description: For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.
URL: /cookbook/5.0/Ellipse/CircleWithLockedScale/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Circle with Locked Scale"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/CircleWithLockedScale"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle with Locked Scale</h1>
</div>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

[![](/cookbook/5.0/images/CircleWithLockedScale.png?241102170938)](/cookbook/5.0/images/CircleWithLockedScale.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/CircleWithLockedScale.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Ellipse'>Ellipse</a> category</div>


