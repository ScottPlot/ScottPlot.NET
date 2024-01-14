---
Title: "SignalConst Step Mode - ScottPlot 4.1 Cookbook"
Description: "Data points can be connected with steps (instead of straight lines)."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalxyconst_step/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalXY", "SignalConst Step Mode"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalxy", "/cookbook/4.1/recipes/signalxyconst_step/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalxyconst_step.png"
---

<h2><a id='signalconst-step-mode' href='/cookbook/4.1/recipes/signalxyconst_step/'>SignalConst Step Mode</a></h2>

Data points can be connected with steps (instead of straight lines).

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// generate random, unevenly-spaced data
Random rand = new Random(0);
int pointCount = 100_000;
double[] ys = new double[pointCount];
double[] xs = new double[pointCount];
for (int i = 1; i < ys.Length; i++)
{
    ys[i] = ys[i - 1] + rand.NextDouble() - .5;
    xs[i] = xs[i - 1] + rand.NextDouble();
}

var sigxyconst = plt.AddSignalXYConst(xs, ys);
sigxyconst.StepDisplay = true;
plt.SetAxisLimits(18700, 18730, -49.25, -46.75);

plt.SaveFig("signalxyconst_step.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalxyconst_step.png' class='d-block mx-auto my-5' />


