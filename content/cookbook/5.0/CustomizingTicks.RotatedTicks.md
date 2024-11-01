---
Title: Rotated Tick Labels - ScottPlot 5.0 Cookbook
Description: Users can customize tick label rotation.
URL: /cookbook/5.0/CustomizingTicks/RotatedTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Rotated Tick Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/RotatedTicks"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rotated Tick Labels</h1>
</div>

Users can customize tick label rotation.

[![](/cookbook/5.0/images/RotatedTicks.png?241101192719)](/cookbook/5.0/images/RotatedTicks.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


