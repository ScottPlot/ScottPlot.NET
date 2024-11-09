---
Title: Minimum Tick Spacing - ScottPlot 5.0 Cookbook
Description: Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).
URL: /cookbook/5.0/CustomizingTicks/MinimumTickSpacing/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Minimum Tick Spacing"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/MinimumTickSpacing"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Minimum Tick Spacing</h1>
</div>

Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).

[![](/cookbook/5.0/images/MinimumTickSpacing.png?241109132219)](/cookbook/5.0/images/MinimumTickSpacing.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/MinimumTickSpacing.png?241109132219" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


