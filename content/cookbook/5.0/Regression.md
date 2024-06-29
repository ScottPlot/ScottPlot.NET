---
Title: Regression - ScottPlot 5.0 Cookbook
Description: Statistical operations to fit lines to data
URL: /cookbook/5.0/Regression/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Regression"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Regression"]
Date: 2024-06-29
Version: ScottPlot 5.0.36
Version: ScottPlot 5.0.36
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Regression


<h2><a href='/cookbook/5.0/Regression/Linear'>LinearRegression</a></h2>

Fit a line to a collection of X/Y data points.

[![](/cookbook/5.0/images/Linear.png?240629072232)](/cookbook/5.0/images/Linear.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = new double[] { 1, 2, 3, 4, 5, 6, 7 };
double[] ys = new double[] { 2, 2, 3, 3, 3.8, 4.2, 4 };

// plot original data as a scatter plot
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;
sp.MarkerSize = 10;

// calculate the regression line
ScottPlot.Statistics.LinearRegression reg = new(xs, ys);

// plot the regression line
Coordinates pt1 = new(xs.First(), reg.GetValue(xs.First()));
Coordinates pt2 = new(xs.Last(), reg.GetValue(xs.Last()));
var line = myPlot.Add.Line(pt1, pt2);
line.MarkerSize = 0;
line.LineWidth = 2;
line.LinePattern = LinePattern.Dashed;

// note the formula at the top of the plot
myPlot.Title(reg.FormulaWithRSquared);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

