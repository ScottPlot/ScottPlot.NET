---
Title: Pie with Percent Labels - ScottPlot 5.0 Cookbook
Description: Slice labels may be adapted to display any text (including numerical values) centered over each slice.
URL: /cookbook/5.0/Pie/PieSliceLabelsPercent/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie with Percent Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSliceLabelsPercent"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabelsPercent'>Pie with Percent Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabelsPercent">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Slice labels may be adapted to display any text (including numerical values) centered over each slice.

[![](/cookbook/5.0/images/PieSliceLabelsPercent.png?241029205813)](/cookbook/5.0/images/PieSliceLabelsPercent.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create a pie chart
double[] values = [6, 8, 10];
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 0.5;

// determine percentages for each slice
double total = pie.Slices.Select(x => x.Value).Sum();
double[] percentages = pie.Slices.Select(x => x.Value / total * 100).ToArray();

// set each slice label to its percentage
for (int i = 0; i < pie.Slices.Count; i++)
{
    pie.Slices[i].Label = $"{percentages[i]:0.0}%";
    pie.Slices[i].LabelFontSize = 20;
    pie.Slices[i].LabelBold = true;
    pie.Slices[i].LabelFontColor = Colors.Black.WithAlpha(.5);
}

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


