---
Title: "Function - ScottPlot 4.1 Cookbook"
Description: "Function plots are defined by a function (not X/Y data points) so the curve is continuous and can be zoomed in and out infinitely"
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/function_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Function", "Function"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-function", "/cookbook/4.1/recipes/function_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/function_quickstart.png"
---

<h2><a id='function' href='/cookbook/4.1/recipes/function_quickstart/'>Function</a></h2>

Function plots are defined by a function (not X/Y data points) so the curve is continuous and can be zoomed in and out infinitely

```cs
var plt = new ScottPlot.Plot(600, 400);

// Functions are defined as delegates with an input and output
var func1 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 2));
var func2 = new Func<double, double?>((x) => Math.Sin(x) * Math.Sin(x / 3));
var func3 = new Func<double, double?>((x) => Math.Cos(x) * Math.Sin(x / 5));

// Add functions to the plot
plt.AddFunction(func1, lineWidth: 2);
plt.AddFunction(func2, lineWidth: 2, lineStyle: LineStyle.Dot);
plt.AddFunction(func3, lineWidth: 2, lineStyle: LineStyle.Dash);

// Manually set axis limits because functions do not have discrete data points
plt.SetAxisLimits(-10, 10, -1.5, 1.5);

plt.SaveFig("function_quickstart.png");
```

<img src='../../images/function_quickstart.png' class='d-block mx-auto my-5' />


