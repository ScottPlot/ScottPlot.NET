---
Title: Polar Axis Line Customization - ScottPlot 5.0 Cookbook
Description: The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.
URL: /cookbook/5.0/PolarAxis/PolarAxisLineCustomizations/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Line Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarAxisLineCustomizations"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Line Customization</h1>
</div>

The angle and length of spokes and position of circles can be manually defined. Each spoke and circle may also be individually styled.

[![](/cookbook/5.0/images/PolarAxisLineCustomizations.png?250822231048)](/cookbook/5.0/images/PolarAxisLineCustomizations.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarAxisLineCustomizations.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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
for (int i = 0; i &lt; 3; i++)
{
    polarAxis.Circles[i].LineColor = pal.GetColor(i).WithAlpha(.5);
    polarAxis.Spokes[i].LineColor = pal.GetColor(i).WithAlpha(.5);

    polarAxis.Circles[i].LineWidth = 2 + i * 2;
    polarAxis.Spokes[i].LineWidth = 2 + i * 2;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


