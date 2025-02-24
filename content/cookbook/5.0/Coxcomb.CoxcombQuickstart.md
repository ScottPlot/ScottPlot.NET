---
Title: Coxcomb Plot Quickstart - ScottPlot 5.0 Cookbook
Description: A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.
URL: /cookbook/5.0/Coxcomb/CoxcombQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Coxcomb Plot", "Coxcomb Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Coxcomb", "/cookbook/5.0/Coxcomb/CoxcombQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Coxcomb Plot Quickstart</h1>
</div>

A Coxcomb chart is a pie graph where the angle of slices is constant but the radii are not.

[![](/cookbook/5.0/images/CoxcombQuickstart.png?250126165944)](/cookbook/5.0/images/CoxcombQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Coxcomb.cs" imageUrl="/cookbook/5.0/images/CoxcombQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Coxcomb'>Coxcomb Plot</a> category</div>


