---
Title: Console Application Quickstart
description: How to create a plot and save it as an image from a C# console application
url: "quickstart/console"
date: 2021-09-26
lastmod: 2021-12-29
---

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](scottplot-quickstart-console.png)

## MacOS & Linux

ScottPlot relies on [`System.Drawing.Common`](https://www.nuget.org/packages/System.Drawing.Common) which requires [libgdiplus](https://www.mono-project.com/docs/gui/libgdiplus/) on non-Windows systems:

* **MacOS:** `brew install mono-libgdiplus`

* **Linux:** `apt-get install -y libgdiplus`

You may also need to specifically add the [`System.Drawing.Common`](https://www.nuget.org/packages/System.Drawing.Common) package to your project:

```
dotnet add package System.Drawing.Common
```