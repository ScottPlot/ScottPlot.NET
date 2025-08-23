---
Title: Labels on Top - ScottPlot 5.0 Cookbook
Description: Bars with labels are rendered one at a time by default, but this makes it possible for bar labels to get overlapped by other bars. Bar chars may be configured to render labels last, even above other plottables.
URL: /cookbook/5.0/Bar/BarLabelsLast/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Labels on Top"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarLabelsLast"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Labels on Top</h1>
</div>

Bars with labels are rendered one at a time by default, but this makes it possible for bar labels to get overlapped by other bars. Bar chars may be configured to render labels last, even above other plottables.

[![](/cookbook/5.0/images/BarLabelsLast.png?250822231048)](/cookbook/5.0/images/BarLabelsLast.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarLabelsLast.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Consecutive(5, first: 1);

// create two bar plots
var bars1 = myPlot.Add.Bars(values);
var bars2 = myPlot.Add.Bars(values);

// enable the LabelsOnTop feature on one of the bars
bars2.LabelsOnTop = true;

// give each bar a label and style it to demonstrate the effect
static void StyleBar(ScottPlot.Plottables.BarPlot barPlot, double xOffset)
{
    barPlot.ValueLabelStyle.FontSize = 32;
    for (int i = 0; i &lt; barPlot.Bars.Count; i++)
    {
        var bar = barPlot.Bars[i];
        bar.Label = i.ToString();
        bar.CenterLabel = true;
        bar.Position = i * .5 + xOffset;
        bar.FillColor = bar.FillColor.WithAlpha(.9);
    }
}

StyleBar(bars1, 0);
StyleBar(bars2, 4);

myPlot.Add.Text("Default", 0, 6);
myPlot.Add.Text("LabelsOnTop", 4, 6);

myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


