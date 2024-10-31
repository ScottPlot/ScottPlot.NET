---
Title: Rotated Tick Labels - ScottPlot 5.0 Cookbook
Description: Users can customize tick label rotation.
URL: /cookbook/5.0/CustomizingTicks/RotatedTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Rotated Tick Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/RotatedTicks"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/RotatedTicks'>Rotated Tick Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/RotatedTicks">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Users can customize tick label rotation.

[![](/cookbook/5.0/images/RotatedTicks.png?241031194635)](/cookbook/5.0/images/RotatedTicks.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


