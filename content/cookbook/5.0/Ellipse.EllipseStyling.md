---
Title: Ellipse Styling - ScottPlot 5.0 Cookbook
Description: Ellipses styles can be extensively customized
URL: /cookbook/5.0/Ellipse/EllipseStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/EllipseStyling"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Ellipse/EllipseStyling'>Ellipse Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Ellipse/EllipseStyling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Ellipse">Category: Ellipse</a>
</div>

Ellipses styles can be extensively customized

[![](/cookbook/5.0/images/EllipseStyling.png?241029205813)](/cookbook/5.0/images/EllipseStyling.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var circle = myPlot.Add.Circle(center: Coordinates.Origin, radius: 5);
circle.LineStyle.Width = 5;
circle.LineStyle.Pattern = LinePattern.Dashed;
circle.LineStyle.Color = Colors.Green;
circle.FillStyle.Color = Colors.Navy;
circle.FillStyle.HatchColor = Colors.Red;
circle.FillStyle.Hatch = new ScottPlot.Hatches.Striped();

myPlot.Axes.SetLimits(-10, 10, -10, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


