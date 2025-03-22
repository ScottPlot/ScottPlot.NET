---
Title: Random Colors - ScottPlot 5.0 Cookbook
Description: The simplest way to generate random colors is to create colors which have same saturation and luminosity but random hue.
URL: /cookbook/5.0/ColorRecipes/ColorRandom/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Random Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorRandom"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Random Colors</h1>
</div>

The simplest way to generate random colors is to create colors which have same saturation and luminosity but random hue.

[![](/cookbook/5.0/images/ColorRandom.png?250322130304)](/cookbook/5.0/images/ColorRandom.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorRandom.png?250322130304" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 20; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin());
    sig.Data.XOffset = i * 3;
    sig.Data.YOffset = i * .1;
    sig.LineWidth = 3;
    sig.LineColor = Color.RandomHue();
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


