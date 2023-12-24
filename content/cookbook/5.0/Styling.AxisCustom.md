---
Title: Axis Customization - ScottPlot 5.0 Cookbook
Description: Axis labels, tick marks, and frame can all be customized.
URL: /cookbook/5.0/Styling/AxisCustom
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Axis Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/AxisCustom"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Axis Customization



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png)](/cookbook/5.0/images/AxisCustom.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.TitlePanel.Label.Text = "Plot Title";
myPlot.TitlePanel.Label.Font.Color = Colors.RebeccaPurple;
myPlot.TitlePanel.Label.Font.Size = 32;
myPlot.TitlePanel.Label.Font.Name = Fonts.Serif;
myPlot.TitlePanel.Label.Rotation = -5;
myPlot.TitlePanel.Label.Font.Bold = false;

myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.YAxis.Label.ForeColor = Colors.Magenta;
myPlot.YAxis.Label.Italic = true;

myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.XAxis.Label.Bold = false;
myPlot.XAxis.Label.FontName = Fonts.Monospace;

myPlot.XAxis.MajorTickLength = 10;
myPlot.XAxis.MajorTickWidth = 3;
myPlot.XAxis.MajorTickColor = Colors.Magenta;
myPlot.XAxis.MinorTickLength = 5;
myPlot.XAxis.MinorTickWidth = 0.5f;
myPlot.XAxis.MinorTickColor = Colors.Green;
myPlot.XAxis.FrameLineStyle.Color = Colors.LightBlue;

myPlot.SavePng("demo.png");

```

