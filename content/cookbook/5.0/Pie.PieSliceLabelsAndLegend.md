---
Title: Pie with Different Labels - ScottPlot 5.0 Cookbook
Description: Pie slices may have labels independent from those displayed in the legend.
URL: /cookbook/5.0/Pie/PieSliceLabelsAndLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie with Different Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSliceLabelsAndLegend"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabelsAndLegend'>Pie with Different Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabelsAndLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Pie slices may have labels independent from those displayed in the legend.

[![](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241029205813)](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create a pie chart
double[] values = [6, 8, 10];
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = 0.1;
pie.SliceLabelDistance = 0.5;

// set different labels for slices and legend
double total = pie.Slices.Select(x => x.Value).Sum();
for (int i = 0; i < pie.Slices.Count; i++)
{
    pie.Slices[i].LabelFontSize = 20;
    pie.Slices[i].Label = $"{pie.Slices[i].Value}";
    pie.Slices[i].LegendText = $"{pie.Slices[i].Value} " +
        $"({pie.Slices[i].Value / total:p1})";
}

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


