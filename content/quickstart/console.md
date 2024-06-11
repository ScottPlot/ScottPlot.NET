---
Title: Console Application Quickstart
description: How to create a plot and save it as an image from a C# console application
date: 2023-12-13
---

# Console Application Quickstart

**Step 1:** Install the [ScottPlot](https://www.nuget.org/packages/ScottPlot) NuGet package.
Linux & MacOS users may need to [install additional packages](/faq/dependencies).

**Step 2:** Write some code to plot data and save it as an image file.

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new();
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("quickstart.png", 400, 300);
```

![](/images/quickstart/scottplot-quickstart-console.png)