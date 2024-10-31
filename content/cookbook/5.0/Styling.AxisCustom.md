---
Title: Axis Customization - ScottPlot 5.0 Cookbook
Description: Axis labels, tick marks, and frame can all be customized.
URL: /cookbook/5.0/Styling/AxisCustom/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Axis Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/AxisCustom"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/AxisCustom'>Axis Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/AxisCustom">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png?241031194635)](/cookbook/5.0/images/AxisCustom.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Title.Label.Text = "Plot Title";
myPlot.Axes.Title.Label.ForeColor = Colors.RebeccaPurple;
myPlot.Axes.Title.Label.FontSize = 32;
myPlot.Axes.Title.Label.FontName = Fonts.Serif;
myPlot.Axes.Title.Label.Rotation = -5;
myPlot.Axes.Title.Label.Bold = false;

myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Left.Label.ForeColor = Colors.Magenta;
myPlot.Axes.Left.Label.Italic = true;

myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Bottom.Label.Bold = false;
myPlot.Axes.Bottom.Label.FontName = Fonts.Monospace;

myPlot.Axes.Bottom.MajorTickStyle.Length = 10;
myPlot.Axes.Bottom.MajorTickStyle.Width = 3;
myPlot.Axes.Bottom.MajorTickStyle.Color = Colors.Magenta;
myPlot.Axes.Bottom.MinorTickStyle.Length = 5;
myPlot.Axes.Bottom.MinorTickStyle.Width = 0.5f;
myPlot.Axes.Bottom.MinorTickStyle.Color = Colors.Green;
myPlot.Axes.Bottom.FrameLineStyle.Color = Colors.Blue;
myPlot.Axes.Bottom.FrameLineStyle.Width = 3;

myPlot.Axes.Right.FrameLineStyle.Width = 0;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


