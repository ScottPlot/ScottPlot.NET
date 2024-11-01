---
Title: Pie - ScottPlot 5.0 Cookbook
Description: Pie charts illustrate numerical proportions as slices of a circle.
URL: /cookbook/5.0/Pie/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Pie</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart from Values</h1>
<a href='/cookbook/5.0/Pie/PieQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A pie chart can be created from a few values.

[![](/cookbook/5.0/images/PieQuickstart.png?241101192719)](/cookbook/5.0/images/PieQuickstart.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart from Slices</h1>
<a href='/cookbook/5.0/Pie/PieSlices' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A pie chart can be created from a collection of slices.

[![](/cookbook/5.0/images/PieSlices.png?241101192719)](/cookbook/5.0/images/PieSlices.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Donut from Slices</h1>
<a href='/cookbook/5.0/Pie/PieDonut' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.

[![](/cookbook/5.0/images/PieDonut.png?241101192719)](/cookbook/5.0/images/PieDonut.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Chart Rotation</h1>
<a href='/cookbook/5.0/Pie/PieRotation' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Pie charts may be rotated to control where the first slice begins.

[![](/cookbook/5.0/images/PieRotation.png?241101192719)](/cookbook/5.0/images/PieRotation.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie Slice Labels</h1>
<a href='/cookbook/5.0/Pie/PieSliceLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.

[![](/cookbook/5.0/images/PieSliceLabels.png?241101192719)](/cookbook/5.0/images/PieSliceLabels.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie with Percent Labels</h1>
<a href='/cookbook/5.0/Pie/PieSliceLabelsPercent' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Slice labels may be adapted to display any text (including numerical values) centered over each slice.

[![](/cookbook/5.0/images/PieSliceLabelsPercent.png?241101192719)](/cookbook/5.0/images/PieSliceLabelsPercent.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Pie with Different Labels</h1>
<a href='/cookbook/5.0/Pie/PieSliceLabelsAndLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Pie slices may have labels independent from those displayed in the legend.

[![](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241101192719)](/cookbook/5.0/images/PieSliceLabelsAndLegend.png?241101192719)

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


