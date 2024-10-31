---
Title: Pie - ScottPlot 5.0 Cookbook
Description: Pie charts illustrate numerical proportions as slices of a circle.
URL: /cookbook/5.0/Pie/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Pie</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieQuickstart'>Pie Chart from Values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

A pie chart can be created from a few values.

[![](/cookbook/5.0/images/PieQuickstart.png?241031194635)](/cookbook/5.0/images/PieQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSlices'>Pie Chart from Slices</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSlices">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

A pie chart can be created from a collection of slices.

[![](/cookbook/5.0/images/PieSlices.png?241031194635)](/cookbook/5.0/images/PieSlices.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<PieSlice> slices =
[
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red", LegendText = "R" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green", LegendText = "G" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue", LegendText = "B" },
];

var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 1.4;

myPlot.ShowLegend();

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieDonut'>Donut from Slices</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieDonut">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.

[![](/cookbook/5.0/images/PieDonut.png?241031194635)](/cookbook/5.0/images/PieDonut.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<PieSlice> slices = new()
{
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue" },
};

var pie = myPlot.Add.Pie(slices);
pie.DonutFraction = .5;

myPlot.ShowLegend();

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieRotation'>Pie Chart Rotation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieRotation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Pie charts may be rotated to control where the first slice begins.

[![](/cookbook/5.0/images/PieRotation.png?241031194635)](/cookbook/5.0/images/PieRotation.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 2, 8, 4, 8 };
var pie = myPlot.Add.Pie(values);
pie.ExplodeFraction = .1;
pie.Rotation = Angle.FromDegrees(90);

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabels'>Pie Slice Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.

[![](/cookbook/5.0/images/PieSliceLabels.png?241031194635)](/cookbook/5.0/images/PieSliceLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

PieSlice slice1 = new() { Value = 5, FillColor = Colors.Red, Label = "alpha" };
PieSlice slice2 = new() { Value = 2, FillColor = Colors.Orange, Label = "beta" };
PieSlice slice3 = new() { Value = 8, FillColor = Colors.Gold, Label = "gamma" };
PieSlice slice4 = new() { Value = 4, FillColor = Colors.Green, Label = "delta" };
PieSlice slice5 = new() { Value = 8, FillColor = Colors.Blue, Label = "epsilon" };

List<PieSlice> slices = new() { slice1, slice2, slice3, slice4, slice5 };

// setup the pie to display slice labels
var pie = myPlot.Add.Pie(slices);
pie.ExplodeFraction = .1;
pie.SliceLabelDistance = 1.3;

// color each label's text to match the slice
slices.ForEach(x => x.LabelFontColor = x.FillColor.Darken(.5));

// styling can be customized for individual slices
slice2.LabelStyle.FontSize = 18;
slice2.LabelStyle.Bold = true;
slice2.LabelStyle.Italic = true;

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabelsPercent'>Pie with Percent Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabelsPercent">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Slice labels may be adapted to display any text (including numerical values) centered over each slice.

[![](/cookbook/5.0/images/PieSliceLabelsPercent.png?241031194635)](/cookbook/5.0/images/PieSliceLabelsPercent.png?241031194635)

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



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieSliceLabelsAndLegend'>Pie with Different Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieSliceLabelsAndLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

Pie slices may have labels independent from those displayed in the legend.

[![](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241031194635)](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241031194635)

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


