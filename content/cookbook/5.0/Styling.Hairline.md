---
Title: Hairline Mode - ScottPlot 5.0 Cookbook
Description: Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.
URL: /cookbook/5.0/Styling/Hairline/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Hairline Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Hairline"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/Hairline'>Hairline Mode</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/Hairline">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Hairline mode allows axis frames, tick marks, and grid lines to always be rendered a single pixel wide regardless of scale factor. Enable hairline mode to allow interactive plots to feel smoother when a large scale factor is in use.

[![](/cookbook/5.0/images/Hairline.png?241029205813)](/cookbook/5.0/images/Hairline.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Hairline(true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


