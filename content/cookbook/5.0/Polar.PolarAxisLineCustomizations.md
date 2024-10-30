---
Title: Polar Axis Line Customization - ScottPlot 5.0 Cookbook
Description: The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.
URL: /cookbook/5.0/Polar/PolarAxisLineCustomizations/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Line Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarAxisLineCustomizations"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarAxisLineCustomizations'>Polar Axis Line Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarAxisLineCustomizations">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.

[![](/cookbook/5.0/images/PolarAxisLineCustomizations.png?241029205813)](/cookbook/5.0/images/PolarAxisLineCustomizations.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

// define spoke angle and length
polarAxis.Spokes.Clear();
polarAxis.Spokes.Add(new(Angle.FromDegrees(0), 0.5));
polarAxis.Spokes.Add(new(Angle.FromDegrees(45), 0.75));
polarAxis.Spokes.Add(new(Angle.FromDegrees(90), 1.0));

// define circle radius
polarAxis.Circles.Clear();
polarAxis.Circles.Add(new(0.5));
polarAxis.Circles.Add(new(0.75));
polarAxis.Circles.Add(new(1.0));

// style individual spokes and circles
ScottPlot.Palettes.Category10 pal = new();
for (int i = 0; i < 3; i++)
{
    polarAxis.Circles[i].LineColor = pal.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineColor = pal.GetColor(i).WithAlpha(.5);

    polarAxis.Circles[i].LineWidth = 2 + i * 2;
    polarAxis.Spokes[i].LineWidth = 2 + i * 2;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


