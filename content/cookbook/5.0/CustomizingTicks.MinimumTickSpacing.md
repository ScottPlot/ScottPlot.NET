---
Title: Minimum Tick Spacing - ScottPlot 5.0 Cookbook
Description: Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).
URL: /cookbook/5.0/CustomizingTicks/MinimumTickSpacing/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Minimum Tick Spacing"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/MinimumTickSpacing"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/MinimumTickSpacing'>Minimum Tick Spacing</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/MinimumTickSpacing">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).

[![](/cookbook/5.0/images/MinimumTickSpacing.png?241029205813)](/cookbook/5.0/images/MinimumTickSpacing.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.MinimumTickSpacing = 50;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.MinimumTickSpacing = 25;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


