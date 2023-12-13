---
Title: Box Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Box plots can be added from a series of values.
URL: /cookbook/5.0/Box/BoxPlotQuickstart
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot", "Box Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box", "/cookbook/5.0/Box/BoxPlotQuickstart"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Box Plot Quickstart



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Box plots can be added from a series of values.

[![](/cookbook/5.0/images/BoxPlotQuickstart.png)](/cookbook/5.0/images/BoxPlotQuickstart.png)

```cs
ScottPlot.Plot myPlot = new();

// TODO: move this functionality to the RandomDataGenerator class
Random rand = new(0);
ScottPlot.Plottables.Box CreateRandomBox()
{
    int N = 50;
    double mean = rand.NextDouble() * 3;
    double stdDev = rand.NextDouble() * 3;

    double[] values = ScottPlot.Generate.RandomNormal(N, mean, stdDev);
    Array.Sort(values);
    double min = values[0];
    double q1 = values[N / 4];
    double median = values[N / 2];
    double q3 = values[3 * N / 4];
    double max = values[N - 1];

    return new ScottPlot.Plottables.Box
    {
        WhiskerMin = min,
        BoxMin = q1,
        BoxMiddle = median,
        BoxMax = q3,
        WhiskerMax = max,
    };
}

// TODO: construct 3 boxes manually with hard-coded numerical values for simplicity
List<ScottPlot.Plottables.Box> boxes = Enumerable.Range(0, 5)
    .Select(x => CreateRandomBox())
    .ToList();

myPlot.Add.Box(boxes);

myPlot.SavePng("demo.png");

```

