---
Title: Random Colors - ScottPlot 5 Cookbook
Description: The simplest way to generate random colors is to create colors which have same saturation and luminosity but random hue.
URL: /cookbook/5/ColorRecipes/ColorRandom/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Color", "Random Colors"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/ColorRecipes", "/cookbook/5/ColorRecipes/ColorRandom"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Random Colors</h1>
</div>

The simplest way to generate random colors is to create colors which have same saturation and luminosity but random hue.

[![](/cookbook/5/images/ColorRandom.png?260329072039)](/cookbook/5/images/ColorRandom.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5/images/ColorRandom.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/ColorRecipes'>Color</a> category</div>


