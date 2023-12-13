---
Title: Individual Box Plots - ScottPlot 5.0 Cookbook
Description: One can easily create a box plot with only a single box.
URL: /cookbook/5.0/Box/IndividualBox
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot", "Individual Box Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box", "/cookbook/5.0/Box/IndividualBox"]
Date: 12/13/2023 2:24:04 PM
Version: ScottPlot 5.0.10-beta
---

# Individual Box Plots



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



One can easily create a box plot with only a single box.

[![](/cookbook/5.0/images/IndividualBox.png)](/cookbook/5.0/images/IndividualBox.png)

```cs
ScottPlot.Plot myPlot = new();

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
List<ScottPlot.Plottables.Box> boxes = new() { CreateRandomBox() };

myPlot.Add.Box(boxes);

myPlot.SavePng("demo.png");

```

