---
Title: Text - ScottPlot 5.0 Cookbook
Description: Text lables placed on the plot in coordinate space
URL: /cookbook/5.0/Text
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Text



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Text Quickstart

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png)](/cookbook/5.0/images/TextQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin());
myPlot.Add.Signal(ScottPlot.Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png");

```


## Text Formatting

Text formatting can be extensively customized.

[![](/cookbook/5.0/images/Formatting.png)](/cookbook/5.0/images/Formatting.png)

```cs
ScottPlot.Plot myPlot = new();

var text = myPlot.Add.Text("Hello, World", 42, 69);
text.Label.FontSize = 26;
text.Label.Bold = true;
text.Label.Rotation = -45;
text.Label.ForeColor = Colors.Yellow;
text.Label.BackColor = Colors.Navy.WithAlpha(.5);
text.Label.BorderColor = Colors.Magenta;
text.Label.BorderWidth = 3;
text.Label.Padding = 10;
text.Label.Alignment = Alignment.MiddleCenter;

myPlot.SavePng("demo.png");

```

