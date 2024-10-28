---
Title: Coxcomb Plot - ScottPlot 5.0 Cookbook
Description: A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.
URL: /cookbook/5.0/Coxcomb/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Coxcomb Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Coxcomb"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Coxcomb Plot


<h2><a href='/cookbook/5.0/Coxcomb/CoxcombQuickstart'>Coxcomb Plot Quickstart</a></h2>

A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.

[![](/cookbook/5.0/images/CoxcombQuickstart.png?241027220842)](/cookbook/5.0/images/CoxcombQuickstart.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

List<PieSlice> slices = new()
{
    new() { Value = 5, Label = "Red", FillColor = Colors.Red },
    new() { Value = 2, Label = "Orange", FillColor = Colors.Orange },
    new() { Value = 8, Label = "Gold", FillColor = Colors.Gold },
    new() { Value = 4, Label = "Green", FillColor = Colors.Green.WithOpacity(0.5) },
    new() { Value = 8, Label = "Blue",  FillColor = Colors.Blue.WithOpacity(0.5) },
};

var cox = myPlot.Add.Coxcomb(slices);
cox.SliceLabelDistance = 1.5;

myPlot.Axes.Frameless();
myPlot.ShowLegend();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

