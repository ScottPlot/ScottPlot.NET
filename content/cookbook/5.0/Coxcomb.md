---
Title: Coxcomb Plot - ScottPlot 5.0 Cookbook
Description: A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.
URL: /cookbook/5.0/Coxcomb/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Coxcomb Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Coxcomb"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Coxcomb Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Coxcomb Plot Quickstart</h1>
<a href='/cookbook/5.0/Coxcomb/CoxcombQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.

[![](/cookbook/5.0/images/CoxcombQuickstart.png?250112204022)](/cookbook/5.0/images/CoxcombQuickstart.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Coxcomb.cs" imageUrl="/cookbook/5.0/images/CoxcombQuickstart.png?250112204022" >}}ScottPlot.Plot myPlot = new();

List&lt;PieSlice&gt; slices = new()
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


