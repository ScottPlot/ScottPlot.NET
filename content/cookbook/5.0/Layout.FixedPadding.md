---
Title: Fixed Padding - ScottPlot 5.0 Cookbook
Description: The plot can be arranged to achieve a fixed amount of padding on each side of the data area
URL: /cookbook/5.0/Layout/FixedPadding/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Layout", "Fixed Padding"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Layout", "/cookbook/5.0/Layout/FixedPadding"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Layout/FixedPadding'>Fixed Padding</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Layout/FixedPadding">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Layout">Category: Layout</a>
</div>

The plot can be arranged to achieve a fixed amount of padding on each side of the data area

[![](/cookbook/5.0/images/FixedPadding.png?241031194635)](/cookbook/5.0/images/FixedPadding.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add sample data to the plot
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// use a fixed amount of of pixel padding on each side
PixelPadding padding = new(100, 50, 100, 50);
myPlot.Layout.Fixed(padding);

// darken the figure background so we can observe its dimensions
myPlot.FigureBackground.Color = Colors.LightBlue;
myPlot.DataBackground.Color = Colors.White;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


