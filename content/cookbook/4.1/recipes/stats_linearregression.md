---
Title: "Linear Regression - ScottPlot 4.1 Cookbook"
Description: "A regression module is available to simplify the act of creating a linear regression line fitted to the data."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/stats_linearregression/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Linear Regression"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_linearregression/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_linearregression.png"
---

<h2><a id='linear-regression' href='/cookbook/4.1/recipes/stats_linearregression/'>Linear Regression</a></h2>

A regression module is available to simplify the act of creating a linear regression line fitted to the data.

```cs
var plt = new ScottPlot.Plot(600, 400);

// Create some linear but noisy data
double[] ys = DataGen.NoisyLinear(null, pointCount: 100, noise: 30);
double[] xs = DataGen.Consecutive(ys.Length);
double x1 = xs[0];
double x2 = xs[xs.Length - 1];

// use the linear regression fitter to fit these data
var model = new ScottPlot.Statistics.LinearRegressionLine(xs, ys);

// plot the original data and add the regression line
plt.Title("Linear Regression\n" +
    $"Y = {model.slope:0.0000}x + {model.offset:0.0} " +
    $"(R² = {model.rSquared:0.0000})");
plt.AddScatter(xs, ys, lineWidth: 0);
plt.AddLine(model.slope, model.offset, (x1, x2), lineWidth: 2);

plt.SaveFig("stats_linearRegression.png");
```

<img src='../../images/stats_linearregression.png' class='d-block mx-auto my-5' />


