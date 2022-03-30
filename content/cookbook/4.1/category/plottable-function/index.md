---
Title: Function - ScottPlot 4.1 Cookbook
Description: Plottable - Function recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Function

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

plt.SaveFig("function_quickstart.png");
```

<div class='text-center'>
<a href='../../images/function_quickstart.png'><img src='../../images/function_quickstart.png' /></a>
</div>

