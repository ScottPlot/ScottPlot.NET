---
title: Customizing Ticks - ScottPlot 5.0 Cookbook
description: Advanced customization of tick marks and tick labels
url: /cookbook/5.0/customizing-ticks/
date: 1/2/2023 12:00:28 AM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)


<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.0-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Custom Tick Generators

Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.

[![](custom-tick-generators.png)](custom-tick-generators.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ITickGenerator customTickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(11);

myPlot.XAxis.TickGenerator = customTickGenerator;

myPlot.SavePng("custom-tick-generators.png");
```

