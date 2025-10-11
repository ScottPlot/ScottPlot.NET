---
Title: Hairline Mode - ScottPlot 5 Cookbook
Description: Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.
URL: /cookbook/5/Styling/Hairline/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Hairline Mode"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/Hairline"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hairline Mode</h1>
</div>

Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.

[![](/cookbook/5/images/Hairline.png?251011113742)](/cookbook/5/images/Hairline.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/Hairline.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Hairline(true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


