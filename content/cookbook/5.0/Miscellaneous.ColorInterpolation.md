---
Title: Color Interpolation - ScottPlot 5.0 Cookbook
Description: Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.
URL: /cookbook/5.0/Miscellaneous/ColorInterpolation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Miscellaneous", "Color Interpolation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Miscellaneous", "/cookbook/5.0/Miscellaneous/ColorInterpolation"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Interpolation</h1>
</div>

Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.

[![](/cookbook/5.0/images/ColorInterpolation.png?241103171511)](/cookbook/5.0/images/ColorInterpolation.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Miscellaneous.cs" imageUrl="/cookbook/5.0/images/ColorInterpolation.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Miscellaneous'>Miscellaneous</a> category</div>


