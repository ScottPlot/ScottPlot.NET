---
Title: Interpolating Colors - ScottPlot 5.0 Cookbook
Description: A collection of colors can be generated from the linear interpolation between two colors.
URL: /cookbook/5.0/ColorRecipes/ColorInterpolate/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Interpolating Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorInterpolate"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interpolating Colors</h1>
</div>

A collection of colors can be generated from the linear interpolation between two colors.

[![](/cookbook/5.0/images/ColorInterpolate.png?250322130304)](/cookbook/5.0/images/ColorInterpolate.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorInterpolate.png?250322130304" >}}ScottPlot.Plot myPlot = new();

Color[] colors = Color.InterpolateRgbArray(Colors.Blue, Colors.Green, steps: 20);

for (int i = 0; i &lt; colors.Length; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin());
    sig.Data.XOffset = i * 3;
    sig.Data.YOffset = i * .1;
    sig.LineWidth = 3;
    sig.LineColor = colors[i];
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


