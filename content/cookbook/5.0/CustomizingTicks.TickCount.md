---
Title: Tick Count - ScottPlot 5.0 Cookbook
Description: A target number of ticks can be provided and the automatic tick generator will attempt to place that number of ticks. This strategy allows tick density to decrease as the image size increases.
URL: /cookbook/5.0/CustomizingTicks/TickCount/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Tick Count"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/TickCount"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/TickCount'>Tick Count</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/TickCount">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

A target number of ticks can be provided and the automatic tick generator will attempt to place that number of ticks. This strategy allows tick density to decrease as the image size increases.

[![](/cookbook/5.0/images/TickCount.png?241031194635)](/cookbook/5.0/images/TickCount.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TargetTickCount = 3;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TargetTickCount = 3;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


