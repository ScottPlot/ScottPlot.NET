---
Title: Curve Fitting - ScottPlot FAQ
Description: How to create curve fitting plots
date: 2024-10-27
---

## Exponential

Create Excel-like exponential curve fitting plots.

![](/images/faq/curve-fitting/exponential.png)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`MathNet.Numerics`](https://www.nuget.org/packages/MathNet.Numerics/)

```cs
using MathNet.Numerics;

ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
(double a, double r) = MathNet.Numerics.Fit.Exponential(xs, ys);

// curve fitting equation
double f(double x)
{
    return a * Math.Exp(r * x);
}

double[] fx = xs.Select(f).ToArray();

// plot the regression line
var line = myPlot.Add.ScatterLine(xs, fx);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
double r2 = MathNet.Numerics.GoodnessOfFit.RSquared(ys, fx);
string formulaWithRSquared = $"y = {a:F3}e^{r:F3}x (r²={r2:F3})";
myPlot.Title(formulaWithRSquared);

myPlot.SavePng("demo.png", 400, 300);
```

## Linear

Create Excel-like linear curve fitting plots.

![](/images/faq/curve-fitting/linear.png)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`MathNet.Numerics`](https://www.nuget.org/packages/MathNet.Numerics/)

```cs
using MathNet.Numerics;

ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
(double a, double r) = MathNet.Numerics.Fit.Linear(xs, ys);

// curve fitting equation
double f(double x)
{
    return a * Math.Exp(r * x);
}

double[] fx = xs.Select(f).ToArray();

// plot the regression line
var line = myPlot.Add.ScatterLine(xs, fx);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
double r2 = MathNet.Numerics.GoodnessOfFit.RSquared(ys, fx);
string formulaWithRSquared = $"y = {a:F3}e^{r:F3}x (r²={r2:F3})";
myPlot.Title(formulaWithRSquared);

myPlot.SavePng("demo.png", 400, 300);
```

## Logarithmic

Create Excel-like logarithmic curve fitting plots.

![](/images/faq/curve-fitting/logarithmic.png)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`MathNet.Numerics`](https://www.nuget.org/packages/MathNet.Numerics/)

```cs
using MathNet.Numerics;

ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
(double a, double r) = MathNet.Numerics.Fit.Logarithmic(xs, ys);

// curve fitting equation
double f(double x)
{
    return a * Math.Exp(r * x);
}

double[] fx = xs.Select(f).ToArray();

// plot the regression line
var line = myPlot.Add.ScatterLine(xs, fx);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
double r2 = MathNet.Numerics.GoodnessOfFit.RSquared(ys, fx);
string formulaWithRSquared = $"y = {a:F3}e^{r:F3}x (r²={r2:F3})";
myPlot.Title(formulaWithRSquared);

myPlot.SavePng("demo.png", 400, 300);
```

## Polynomial

Create Excel-like polynomial curve fitting plots.

![](/images/faq/curve-fitting/polynomial.png)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`MathNet.Numerics`](https://www.nuget.org/packages/MathNet.Numerics/)

```cs
using MathNet.Numerics;

ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
double[] coefficients = MathNet.Numerics.Fit.Polynomial(xs, ys, 4);

// curve fitting equation
double f(double x)
{
    return MathNet.Numerics.Polynomial.Evaluate(x, coefficients);
}

double[] fx = xs.Select(f).ToArray();

// plot the regression line
var line = myPlot.Add.ScatterLine(xs, fx);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
var superscript = new string[] { "⁰", "¹", "²", "³", "⁴" };
var formulaWithRSquared = new StringBuilder("y = ");
for (int i = coefficients.Length - 1; i >= 0; i--)
{
    if (i < coefficients.Length - 1)
    {
        if (coefficients[i] < 0)
            formulaWithRSquared.Append(" - ");
        else
            formulaWithRSquared.Append(" + ");
    }
    else if (coefficients[i] < 0)
    {
        formulaWithRSquared.Append('-');
    }

    if (i > 0)
        formulaWithRSquared.Append($"{Math.Abs(coefficients[i]):F3}x{superscript[i]}");
    else
        formulaWithRSquared.Append($"{Math.Abs(coefficients[i]):F3}");
}

double r2 = MathNet.Numerics.GoodnessOfFit.RSquared(ys, fx);
formulaWithRSquared.Append($" (r²={r2:F3})");

myPlot.Title(formulaWithRSquared.ToString());

myPlot.SavePng("demo.png", 400, 300);
```

## Power

Create Excel-like power curve fitting plots.

![](/images/faq/curve-fitting/power.png)

This example requires these NuGet packages:
* [`ScottPlot`](https://www.nuget.org/packages/ScottPlot)
* [`MathNet.Numerics`](https://www.nuget.org/packages/MathNet.Numerics/)

```cs
using MathNet.Numerics;

ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
(double a, double b) = MathNet.Numerics.Fit.Power(xs, ys);

// curve fitting equation
double f(double x)
{
    return a * Math.Pow(x, b);
}

// plot the regression line
Coordinates pt1 = new(xs.First(), f(xs.First()));
Coordinates pt2 = new(xs.Last(), f(xs.Last()));
var line = myPlot.Add.Line(pt1, pt2);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
double r2 = MathNet.Numerics.GoodnessOfFit.RSquared(ys, xs.Select(x => f(x)));
string formulaWithRSquared = $"y = {a:F3}x^{b:F3} (r²={r2:F3})";
myPlot.Title(formulaWithRSquared);

myPlot.SavePng("demo.png", 400, 300);
```