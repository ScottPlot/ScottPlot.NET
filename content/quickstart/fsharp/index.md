---
Title: F# Quickstart
description: How to plot data using ScottPlot in a F# .NET application
url: "quickstart/fsharp"
---

# F# Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

```fs
let dataX = [| 1.0 .. 5.0 |]
let dataY = [| for x in dataX -> x * x |]
let plt = Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](../console/scottplot-quickstart-console.png)
