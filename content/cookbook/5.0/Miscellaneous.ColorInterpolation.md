---
Title: Color Interpolation - ScottPlot 5.0 Cookbook
Description: Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.
URL: /cookbook/5.0/Miscellaneous/ColorInterpolation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Color Interpolation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/ColorInterpolation"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Miscellaneous/ColorInterpolation'>Color Interpolation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Miscellaneous/ColorInterpolation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Miscellaneous">Category: Miscellaneous</a>
</div>

Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.

[![](/cookbook/5.0/images/ColorInterpolation.png?241029205813)](/cookbook/5.0/images/ColorInterpolation.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i <= 10; i++)
{
    double fraction = (double)i / 10;
    double x = i;
    double y = Math.Sin(Math.PI * 2 * fraction);
    var circle = myPlot.Add.Circle(x, y, 2);
    circle.FillColor = Colors.Blue.MixedWith(Colors.Green, fraction);
    circle.LineColor = Colors.Black.WithAlpha(.5);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


