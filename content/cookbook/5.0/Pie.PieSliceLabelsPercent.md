---
Title: Pie with Percent Labels - ScottPlot 5.0 Cookbook
Description: Slice labels may be adapted to display any text (including numerical values) centered over each slice.
URL: /cookbook/5.0/Pie/PieSliceLabelsPercent/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Pie with Percent Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieSliceLabelsPercent"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie with Percent Labels</h1>
</div>

Slice labels may be adapted to display any text (including numerical values) centered over each slice.

[![](/cookbook/5.0/images/PieSliceLabelsPercent.png?250112204022)](/cookbook/5.0/images/PieSliceLabelsPercent.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Pie.cs" imageUrl="/cookbook/5.0/images/PieSliceLabelsPercent.png?250112204022" >}}ScottPlot.Plot myPlot = new();

// create a pie chart
double[] values = [6, 8, 10];
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 0.5;

// determine percentages for each slice
double total = pie.Slices.Select(x =&gt; x.Value).Sum();
double[] percentages = pie.Slices.Select(x =&gt; x.Value / total * 100).ToArray();

// set each slice label to its percentage
for (int i = 0; i &lt; pie.Slices.Count; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Pie'>Pie</a> category</div>


