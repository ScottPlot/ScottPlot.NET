---
Title: Style Helper Functions - ScottPlot 5.0 Cookbook
Description: Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.
URL: /cookbook/5.0/Styling/StyleClass/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Style Helper Functions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/StyleClass"]
Date: 2023-12-28
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Style Helper Functions



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.

[![](/cookbook/5.0/images/StyleClass.png)](/cookbook/5.0/images/StyleClass.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.XAxis.Label.Text = "Horizontal Axis";
myPlot.YAxis.Label.Text = "Vertical Axis";
myPlot.TitlePanel.Label.Text = "Plot Title";

// the Style object contains helper methods to easily style many items at once
myPlot.Style.Background(figure: Color.FromHex("#07263b"), data: Color.FromHex("#0b3049"));
myPlot.Style.ColorAxes(Color.FromHex("#a0acb5"));
myPlot.Style.ColorGrids(Color.FromHex("#0e3d54"));

myPlot.SavePng("demo.png");

```

