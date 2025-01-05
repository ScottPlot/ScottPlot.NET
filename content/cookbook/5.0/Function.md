---
Title: Function - ScottPlot 5.0 Cookbook
Description: Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.
URL: /cookbook/5.0/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Function</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Quickstart</h1>
<a href='/cookbook/5.0/Function/FunctionQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Create a function plot from a formula.

[![](/cookbook/5.0/images/FunctionQuickstart.png?250105183901)](/cookbook/5.0/images/FunctionQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

// Functions are defined as delegates with an input and output
static double func1(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 2));
static double func2(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 3));
static double func3(double x) =&gt; (Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
myPlot.Add.Function(func1);
myPlot.Add.Function(func2);
myPlot.Add.Function(func3);

// Manually set axis limits because functions do not have discrete data points
myPlot.Axes.SetLimits(-10, 10, -1.5, 1.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Function Limit X</h1>
<a href='/cookbook/5.0/Function/FunctionLimitX' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A function can be limited to a range of X values.

[![](/cookbook/5.0/images/FunctionLimitX.png?250105183901)](/cookbook/5.0/images/FunctionLimitX.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionLimitX.png?250105183901" >}}ScottPlot.Plot myPlot = new();

static double func1(double x) =&gt; (Math.Sin(x) * Math.Sin(x / 2));

var f = myPlot.Add.Function(func1);
f.MinX = -3;
f.MaxX = 3;

myPlot.Axes.SetLimits(-5, 5, -.2, 1.0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Dynamically Generated Functions</h1>
<a href='/cookbook/5.0/Function/FunctionDynamic' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

When a function cannot be represented as a static method (e.g., one that requires custom parameters) it can be represented as variable of type Func<double, double> and plotted accordingly.

[![](/cookbook/5.0/images/FunctionDynamic.png?250105183901)](/cookbook/5.0/images/FunctionDynamic.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionDynamic.png?250105183901" >}}ScottPlot.Plot myPlot = new();

static double LogNormalDist(double x, double a, double b)
{
    double expNum = Math.Log(x / a);
    double exp = Math.Exp(-(expNum * expNum) / (2 * b * b));
    double y = Math.Sqrt(2 * Math.PI) * b * x * exp;
    return double.IsNaN(y) ? 0 : y;
}

double[] testValues = Generate.Range(0.8, 1.2, 0.05);
Color[] colors = new ScottPlot.Colormaps.MellowRainbow().GetColors(testValues.Length);
for (int i = 0; i &lt; testValues.Length; i++)
{
    double testValue = testValues[i];
    var myFunc = new Func&lt;double, double&gt;((x) =&gt; LogNormalDist(x, testValue, 0.5));
    var funcPlot = myPlot.Add.Function(myFunc);
    funcPlot.LegendText = $"{testValue:0.00}";
    funcPlot.LineWidth = 2;
    funcPlot.LineColor = colors[i];
}

myPlot.ShowLegend();
myPlot.Legend.Orientation = Orientation.Horizontal;

myPlot.Axes.SetLimitsX(-0.5, 4);
myPlot.Axes.SetLimitsY(-0.8, 2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


