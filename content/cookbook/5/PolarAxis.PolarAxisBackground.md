---
Title: Polar Axis Background - ScottPlot 5 Cookbook
Description: The background style of polar axes may be customized
URL: /cookbook/5/PolarAxis/PolarAxisBackground/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Axis Background"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarAxisBackground"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Background</h1>
</div>

The background style of polar axes may be customized

[![](/cookbook/5/images/PolarAxisBackground.png?251011113742)](/cookbook/5/images/PolarAxisBackground.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarAxisBackground.png?251011113742" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.FillColor = Colors.Blue.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


