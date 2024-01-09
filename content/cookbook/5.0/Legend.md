---
Title: Configuring Legends - ScottPlot 5.0 Cookbook
Description: A legend is a key typically displayed in the corner of a plot
URL: /cookbook/5.0/Legend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Configuring Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend"]
Date: 2024-01-09
Version: ScottPlot 5.0.12-beta
Version: ScottPlot 5.0.12-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Configuring Legends



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.12-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/Legend/LegendStyle'>Legend Customization</a></h2>

The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.

[![](/cookbook/5.0/images/LegendStyle.png)](/cookbook/5.0/images/LegendStyle.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
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
myPlot.Legend.Location = Alignment.UpperCenter;

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Legend/ManualLegend'>Manual Legend</a></h2>

Legends may be constructed manually.

[![](/cookbook/5.0/images/ManualLegend.png)](/cookbook/5.0/images/ManualLegend.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 12);
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

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

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

