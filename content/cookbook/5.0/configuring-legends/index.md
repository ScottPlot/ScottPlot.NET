---
Title: Configuring Legends - ScottPlot 5.0 Cookbook
Description: A legend is a key typically displayed in the corner of a plot
URL: /cookbook/5.0/configuring-legends/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Configuring Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/configuring-legends/"]
Date: 12/11/2023 2:09:58 PM
Version: ScottPlot 5.0.10-beta
---

# Configuring Legends



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Legend Customization

The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.

[![](legend-customization.png)](legend-customization.png)

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;
myPlot.Legend.OutlineStyle.Color = Colors.Navy;
myPlot.Legend.OutlineStyle.Width = 2;
myPlot.Legend.BackgroundFill.Color = Colors.LightBlue;
myPlot.Legend.ShadowFill.Color = Colors.Blue.WithOpacity(.5);
myPlot.Legend.Font.Size = 16;
myPlot.Legend.Font.Name = Fonts.Serif;
myPlot.Legend.Alignment = Alignment.UpperCenter;

myPlot.SavePng("legend-customization.png");
```


## Manual Legend

Legends may be constructed manually.

[![](manual-legend.png)](manual-legend.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Legend.IsVisible = true;

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LineColor = Colors.Magenta,
    LineWidth = 2,
    Label = "Alpha"
});

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LineColor = Colors.Green,
    LineWidth = 4,
    Label = "Beta"
});

myPlot.SavePng("manual-legend.png");
```

