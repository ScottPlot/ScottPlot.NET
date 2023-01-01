---
title: Customizing Ticks - ScottPlot 5.0 Cookbook
description: Advanced customization of tick marks and tick labels
url: /cookbook/5.0/customizing-ticks/
date: 1/1/2023 6:56:53 PM
---

This page is part of the [ScottPlot 5.0 Cookbook](../)

<div class="alert alert-warning" role="alert">
<strong>⚠️ WARNING:</strong> This page describes <code>ScottPlot 5.0.0-beta</code>, a preview version of ScottPlot available on NuGet. This package is not recommended for production use, and the API may change in future releases. Visit the <a href='/cookbook/4.1/'>ScottPlot 4.1 Cookbook</a> for information about the current stable version of ScottPlot.
</div>


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

