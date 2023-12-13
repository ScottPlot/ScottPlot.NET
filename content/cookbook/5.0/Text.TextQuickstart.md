---
Title: Text Quickstart - ScottPlot 5.0 Cookbook
Description: Text can be placed anywhere in coordinate space.
URL: /cookbook/5.0/Text/TextQuickstart
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/TextQuickstart"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Text Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png)](/cookbook/5.0/images/TextQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin());
myPlot.Add.Signal(ScottPlot.Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png");

```

