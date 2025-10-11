---
Title: Frameless Plot - ScottPlot 5 Cookbook
Description: How to create a plot containing only the data area and no axes.
URL: /cookbook/5/Layout/Frameless/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Layout", "Frameless Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Layout", "/cookbook/5/Layout/Frameless"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Frameless Plot</h1>
</div>

How to create a plot containing only the data area and no axes.

[![](/cookbook/5/images/Frameless.png?251011113742)](/cookbook/5/images/Frameless.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/LayoutRecipes.cs" imageUrl="/cookbook/5/images/Frameless.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// make the data area cover the full figure
myPlot.Layout.Frameless();

// set the data area background so we can observe its size
myPlot.DataBackground.Color = Colors.WhiteSmoke;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Layout'>Layout</a> category</div>


