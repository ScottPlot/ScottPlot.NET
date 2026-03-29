---
Title: Plot Border - ScottPlot 5 Cookbook
Description: Plots can be assigned borders to draw around the figure or data area.
URL: /cookbook/5/Styling/PlotBorder/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Plot Border"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/PlotBorder"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Plot Border</h1>
</div>

Plots can be assigned borders to draw around the figure or data area.

[![](/cookbook/5/images/PlotBorder.png?260329072039)](/cookbook/5/images/PlotBorder.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/PlotBorder.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.FigureBorder = new()
{
    Color = Colors.Magenta,
    Width = 3,
    Pattern = LinePattern.Dotted,
};

myPlot.DataBorder = new()
{
    Color = Colors.Green,
    Width = 3,
    Pattern = LinePattern.DenselyDashed,
};

// the hide axis frame lines so our custom border is the only one
myPlot.Axes.Frame(false);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


