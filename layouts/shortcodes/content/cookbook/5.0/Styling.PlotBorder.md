---
Title: Plot Border - ScottPlot 5.0 Cookbook
Description: Plots can be assigned borders to draw around the figure or data area.
URL: /cookbook/5.0/Styling/PlotBorder/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Plot Border"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/PlotBorder"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Plot Border</h1>
</div>

Plots can be assigned borders to draw around the figure or data area.

[![](/cookbook/5.0/images/PlotBorder.png?250822231048)](/cookbook/5.0/images/PlotBorder.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/PlotBorder.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


