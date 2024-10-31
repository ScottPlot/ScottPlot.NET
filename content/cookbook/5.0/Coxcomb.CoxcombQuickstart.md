---
Title: Coxcomb Plot Quickstart - ScottPlot 5.0 Cookbook
Description: A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.
URL: /cookbook/5.0/Coxcomb/CoxcombQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Coxcomb Plot", "Coxcomb Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Coxcomb", "/cookbook/5.0/Coxcomb/CoxcombQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Coxcomb/CoxcombQuickstart'>Coxcomb Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Coxcomb/CoxcombQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Coxcomb">Category: Coxcomb Plot</a>
</div>

A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.

[![](/cookbook/5.0/images/CoxcombQuickstart.png?241031194635)](/cookbook/5.0/images/CoxcombQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


