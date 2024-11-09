---
Title: Tick Density - ScottPlot 5.0 Cookbook
Description: Tick density can be adjusted as a fraction of the default value. Unlike MinimumTickSpacing, this strategy is aware of the size of tick labels and adjusts accordingly.
URL: /cookbook/5.0/CustomizingTicks/TickDensity/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Tick Density"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/TickDensity"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tick Density</h1>
</div>

Tick density can be adjusted as a fraction of the default value. Unlike MinimumTickSpacing, this strategy is aware of the size of tick labels and adjusts accordingly.

[![](/cookbook/5.0/images/TickDensity.png?241109132219)](/cookbook/5.0/images/TickDensity.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/TickDensity.png?241109132219" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TickDensity = 0.2;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TickDensity = 0.2;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


