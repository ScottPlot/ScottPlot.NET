---
Title: Hairline Mode - ScottPlot 5.0 Cookbook
Description: Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.
URL: /cookbook/5.0/Styling/Hairline/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Hairline Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Hairline"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hairline Mode</h1>
</div>

Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.

[![](/cookbook/5.0/images/Hairline.png?241112193154)](/cookbook/5.0/images/Hairline.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/Hairline.png?241112193154" >}}ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Hairline(true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


