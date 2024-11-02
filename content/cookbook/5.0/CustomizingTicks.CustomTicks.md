---
Title: Custom Tick Positions - ScottPlot 5.0 Cookbook
Description: Users desiring more control over major and minor tick positions and labels can instantiate a manual tick generator, set it up as desired, then assign it to the axis being customized
URL: /cookbook/5.0/CustomizingTicks/CustomTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Custom Tick Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/CustomTicks"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Tick Positions</h1>
</div>

Users desiring more control over major and minor tick positions and labels can instantiate a manual tick generator, set it up as desired, then assign it to the axis being customized

[![](/cookbook/5.0/images/CustomTicks.png?241102170938)](/cookbook/5.0/images/CustomTicks.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/CustomTicks.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// create a manual tick generator and add ticks
ScottPlot.TickGenerators.NumericManual ticks = new();

// add major ticks with their labels
ticks.AddMajor(0, "zero");
ticks.AddMajor(20, "twenty");
ticks.AddMajor(50, "fifty");

// add minor ticks
ticks.AddMinor(22);
ticks.AddMinor(25);
ticks.AddMinor(32);
ticks.AddMinor(35);
ticks.AddMinor(42);
ticks.AddMinor(45);

// tell the horizontal axis to use the custom tick generator
myPlot.Axes.Bottom.TickGenerator = ticks;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


