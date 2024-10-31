---
Title: Frameless Plot - ScottPlot 5.0 Cookbook
Description: How to create a plot containing only the data area and no axes.
URL: /cookbook/5.0/Layout/Frameless/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Layout", "Frameless Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Layout", "/cookbook/5.0/Layout/Frameless"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Layout/Frameless'>Frameless Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Layout/Frameless">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Layout">Category: Layout</a>
</div>

How to create a plot containing only the data area and no axes.

[![](/cookbook/5.0/images/Frameless.png?241031194635)](/cookbook/5.0/images/Frameless.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// make the data area cover the full figure
myPlot.Layout.Frameless();

// set the data area background so we can observe its size
myPlot.DataBackground.Color = Colors.WhiteSmoke;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


