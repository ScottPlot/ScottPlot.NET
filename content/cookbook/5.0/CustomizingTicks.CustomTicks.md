---
Title: Custom Tick Positions - ScottPlot 5.0 Cookbook
Description: Users can define ticks to be placed at specific locations.
URL: /cookbook/5.0/CustomizingTicks/CustomTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Custom Tick Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/CustomTicks"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Custom Tick Positions



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Users can define ticks to be placed at specific locations.

[![](/cookbook/5.0/images/CustomTicks.png)](/cookbook/5.0/images/CustomTicks.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

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

// tell the horizontal axis to use the custom tick genrator
myPlot.Axes.Bottom.TickGenerator = ticks;

myPlot.SavePng("demo.png");

```

