---
Title: SignalXY Plot - ScottPlot 5.0 Cookbook
Description: SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).
URL: /cookbook/5.0/SignalXY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY"]
Date: 2024-01-10
Version: ScottPlot 5.0.13-beta
Version: ScottPlot 5.0.13-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# SignalXY Plot



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.13-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



<h2><a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'>SignalXY Quickstart</a></h2>

SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.

[![](/cookbook/5.0/images/SignalXYQuickstart.png)](/cookbook/5.0/images/SignalXYQuickstart.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<double> xList = new();
List<double> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i));
    yList.AddRange(Generate.RandomSample(1000));
}
double[] xs = xList.ToArray();
double[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/SignalXY/SignalXYGeneric'>SignalXY Generic</a></h2>

SignalXY plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalXYGeneric.png)](/cookbook/5.0/images/SignalXYGeneric.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 13);
ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<int> xList = new();
List<float> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x => (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x => (float)x));
}
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png");

```

<hr class='my-5 invisible'>

