---
Title: FillY plot - ScottPlot 5.0 Cookbook
Description: FillY plots display the vertical range between two Y values at defined X positions
URL: /cookbook/5.0/FillY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>FillY plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY From Array Data</h1>
<a href='/cookbook/5.0/FillY/FillYFromArrays' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

FillY plots can be created from X, Y1, and Y2 arrays.

[![](/cookbook/5.0/images/FillYFromArrays.png?250822231048)](/cookbook/5.0/images/FillYFromArrays.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/FillYFromArrays.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY From Scatter Plots</h1>
<a href='/cookbook/5.0/FillY/FillYFromScatters' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

FillY plots can be created from two scatter plots that share the same X values.

[![](/cookbook/5.0/images/FillYFromScatters.png?250822231048)](/cookbook/5.0/images/FillYFromScatters.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/FillYFromScatters.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY with Custom Type</h1>
<a href='/cookbook/5.0/FillY/Function' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

FillY plots can be created from data of any type if a conversion function is supplied.

[![](/cookbook/5.0/images/Function.png?250822231048)](/cookbook/5.0/images/Function.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/Function.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// create source data in a nonstandard data type
List&lt;(int, int, int)&gt; data = new();
Random rand = new(0);
for (int i = 0; i &lt; 10; i++)
{
    int x = i;
    int y1 = rand.Next(0, 10);
    int y2 = rand.Next(20, 30);
    data.Add((x, y1, y2));
}

// create a custom converter for the source data type
static (double, double, double) MyConverter((int, int, int) s) =&gt; (s.Item1, s.Item2, s.Item3);

// create a filled plot from source data using the custom converter
var fill = myPlot.Add.FillY(data, MyConverter);
fill.FillColor = Colors.Blue.WithAlpha(.2);
fill.LineColor = Colors.Blue;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY Plot Styling</h1>
<a href='/cookbook/5.0/FillY/Styling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

FillY plots can be customized using public properties.

[![](/cookbook/5.0/images/Styling.png?250822231048)](/cookbook/5.0/images/Styling.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/Styling.png?250822231048" >}}ScottPlot.Plot myPlot = new();

int count = 20;
double[] xs = Generate.Consecutive(count);
double[] ys1 = Generate.RandomWalk(count, offset: -5);
double[] ys2 = Generate.RandomWalk(count, offset: 5);

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Filled Error</h1>
<a href='/cookbook/5.0/FillY/FilledError' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A line plot with shaded error range may be achieved by layering a FillY beneath a ScatterLine.

[![](/cookbook/5.0/images/FilledError.png?250822231048)](/cookbook/5.0/images/FilledError.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/FilledError.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// create sample Y values
double[] xs = Generate.Range(0, Math.PI, 0.05);
double[] ys = xs.Select(x =&gt; Math.Sin(x) + Generate.RandomNumber(0.1)).ToArray();

// create sample error data
double[] yErr = ys.Select(x =&gt; x * Generate.RandomNumber(0.5) + 0.05).ToArray();

// calculate Y ± error
double[] yErrNeg = Enumerable.Range(0, ys.Length).Select(x =&gt; ys[x] - yErr[x]).ToArray();
double[] yErrPos = Enumerable.Range(0, ys.Length).Select(x =&gt; ys[x] + yErr[x]).ToArray();

// add a shaded area between the error limits
var errFill = myPlot.Add.FillY(xs, yErrNeg, yErrPos);
errFill.LineWidth = 0;
errFill.FillColor = Colors.Blue.WithAlpha(0.2);
errFill.LegendText = "Error";

// add the Y values as a line plot
var meanLine = myPlot.Add.ScatterLine(xs, ys);
meanLine.LineColor = Colors.Blue;
meanLine.LineWidth = 2;
meanLine.LegendText = "Mean";

// configure the location of the legend
myPlot.Legend.Alignment = Alignment.UpperRight;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


