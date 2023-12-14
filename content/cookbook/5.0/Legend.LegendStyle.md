---
Title: Legend Customization - ScottPlot 5.0 Cookbook
Description: The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.
URL: /cookbook/5.0/Legend/LegendStyle/index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Configuring Legends", "Legend Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendStyle"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# Legend Customization



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.

[![](/cookbook/5.0/images/LegendStyle.png)](/cookbook/5.0/images/LegendStyle.png)

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(ScottPlot.Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;
myPlot.Legend.OutlineStyle.Color = Colors.Navy;
myPlot.Legend.OutlineStyle.Width = 2;
myPlot.Legend.BackgroundFill.Color = Colors.LightBlue;
myPlot.Legend.ShadowFill.Color = Colors.Blue.WithOpacity(.5);
myPlot.Legend.Font.Size = 16;
myPlot.Legend.Font.Name = Fonts.Serif;
myPlot.Legend.Alignment = Alignment.UpperCenter;

myPlot.SavePng("demo.png");

```

