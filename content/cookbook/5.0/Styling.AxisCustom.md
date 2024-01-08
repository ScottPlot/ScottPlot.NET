---
Title: Axis Customization - ScottPlot 5.0 Cookbook
Description: Axis labels, tick marks, and frame can all be customized.
URL: /cookbook/5.0/Styling/AxisCustom/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Axis Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/AxisCustom"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Axis Customization



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png)](/cookbook/5.0/images/AxisCustom.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Title.Label.Text = "Plot Title";
myPlot.Axes.Title.Label.Font.Color = Colors.RebeccaPurple;
myPlot.Axes.Title.Label.Font.Size = 32;
myPlot.Axes.Title.Label.Font.Name = Fonts.Serif;
myPlot.Axes.Title.Label.Rotation = -5;
myPlot.Axes.Title.Label.Font.Bold = false;

myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Left.Label.ForeColor = Colors.Magenta;
myPlot.Axes.Left.Label.Italic = true;

myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Bottom.Label.Bold = false;
myPlot.Axes.Bottom.Label.FontName = Fonts.Monospace;

myPlot.Axes.Bottom.MajorTickLength = 10;
myPlot.Axes.Bottom.MajorTickWidth = 3;
myPlot.Axes.Bottom.MajorTickColor = Colors.Magenta;
myPlot.Axes.Bottom.MinorTickLength = 5;
myPlot.Axes.Bottom.MinorTickWidth = 0.5f;
myPlot.Axes.Bottom.MinorTickColor = Colors.Green;
myPlot.Axes.Bottom.FrameLineStyle.Color = Colors.LightBlue;

myPlot.SavePng("demo.png");

```

