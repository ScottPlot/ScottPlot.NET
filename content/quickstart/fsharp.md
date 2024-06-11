---
Title: F# Quickstart
description: How to plot data using ScottPlot in a F# .NET application
date: 2023-12-13
---

# F# Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

```fs
let dataX = [| 1.0 .. 5.0 |]
let dataY = [| for x in dataX -> x * x |]
let plt = Plot();
plt.Add.Scatter(dataX, dataY);
plt.SaveFig("quickstart.png", 400, 300);
```

![](/images/quickstart/scottplot-quickstart-console.png)
