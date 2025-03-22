---
Title: Bar Fill Style - ScottPlot 5.0 Cookbook
Description: Each bar may be individually styled.
URL: /cookbook/5.0/Bar/BarFillStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Fill Style"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarFillStyle"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar Fill Style</h1>
</div>

Each bar may be individually styled.

[![](/cookbook/5.0/images/BarFillStyle.png?250322130304)](/cookbook/5.0/images/BarFillStyle.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarFillStyle.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// add bars with sample data
double[] values = { 3, 7, 9 };
var barPlot = myPlot.Add.Bars(values);

// bars may be styled after they have been added
barPlot.Bars[0].FillColor = Colors.Orange;
barPlot.Bars[1].FillColor = Colors.Green;
barPlot.Bars[2].FillColor = Colors.Navy;

barPlot.Bars[0].FillHatch = new ScottPlot.Hatches.Striped();
barPlot.Bars[1].FillHatch = new ScottPlot.Hatches.Dots();
barPlot.Bars[2].FillHatch = new ScottPlot.Hatches.Checker();

foreach (var bar in barPlot.Bars)
{
    bar.LineWidth = 2;
    bar.LineColor = bar.FillColor.Darken(0.5);
    bar.FillHatchColor = bar.FillColor.Lighten(0.1);
}

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


