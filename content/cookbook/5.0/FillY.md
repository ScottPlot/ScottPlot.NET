---
Title: FillY plot - ScottPlot 5.0 Cookbook
Description: FillY plots display the vertical range between two Y values at defined X positions
URL: /cookbook/5.0/FillY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>FillY plot</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/FillYFromArrays'>FillY From Array Data</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/FillYFromArrays">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png?241031194635)](/cookbook/5.0/images/FillYFromArrays.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var fill = myPlot.Add.FillY(xs, ys1, ys2);
fill.FillColor = Colors.Blue.WithAlpha(100);
fill.LineColor = Colors.Blue;
fill.MarkerColor = Colors.Blue;
fill.LineWidth = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/FillYFromScatters'>FillY From Scatter Plots</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/FillYFromScatters">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be created from two scatter plots that share the same X values.

[![](/cookbook/5.0/images/FillYFromScatters.png?241031194635)](/cookbook/5.0/images/FillYFromScatters.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var scatter1 = myPlot.Add.Scatter(xs, ys1);
var scatter2 = myPlot.Add.Scatter(xs, ys2);

var fill = myPlot.Add.FillY(scatter1, scatter2);
fill.FillColor = Colors.Blue.WithAlpha(.1);
fill.LineWidth = 0;

// push the fill behind the scatter plots
myPlot.MoveToBack(fill);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/Function'>FillY with Custom Type</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/Function">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be created from data of any type if a conversion function is supplied.

[![](/cookbook/5.0/images/Function.png?241031194635)](/cookbook/5.0/images/Function.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create source data in a nonstandard data type
List<(int, int, int)> data = new();
Random rand = new(0);
for (int i = 0; i < 10; i++)
{
    int x = i;
    int y1 = rand.Next(0, 10);
    int y2 = rand.Next(20, 30);
    data.Add((x, y1, y2));
}

// create a custom converter for the source data type
static (double, double, double) MyConverter((int, int, int) s) => (s.Item1, s.Item2, s.Item3);

// create a filled plot from source data using the custom converter
var fill = myPlot.Add.FillY(data, MyConverter);
fill.FillColor = Colors.Blue.WithAlpha(.2);
fill.LineColor = Colors.Blue;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/FillY/Styling'>FillY Plot Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/FillY/Styling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/FillY">Category: FillY plot</a>
</div>

FillY plots can be customized using public properties.

[![](/cookbook/5.0/images/Styling.png?241031194635)](/cookbook/5.0/images/Styling.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RandomDataGenerator dataGen = new(0);

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = dataGen.RandomWalk(count, offset: -5);
double[] ys2 = dataGen.RandomWalk(count, offset: 5);

var fill = myPlot.Add.FillY(xs, ys1, ys2);
fill.MarkerShape = MarkerShape.FilledDiamond;
fill.MarkerSize = 15;
fill.MarkerColor = Colors.Blue;
fill.LineColor = Colors.Blue;
fill.LinePattern = LinePattern.Dotted;
fill.LineWidth = 2;
fill.FillColor = Colors.Blue.WithAlpha(.2);
fill.FillHatch = new ScottPlot.Hatches.Striped(ScottPlot.Hatches.StripeDirection.DiagonalUp);
fill.FillHatchColor = Colors.Blue.WithAlpha(.4);
fill.LegendText = "Filled Area";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


