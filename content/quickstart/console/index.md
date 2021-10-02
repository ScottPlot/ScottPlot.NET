---
Title: Console Application Quickstart
---

# Console Application Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

**C#:**
```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```
**F#:**
```fs
let dataX = [| 1.0 .. 5.0 |]
let dataY = [| for x in dataX -> x * x |]
let plt = Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](scottplot-quickstart-console.png)
