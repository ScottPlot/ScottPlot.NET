---
Title: Console Application Quickstart
description: How to create a plot and save it as an image from a C# console application
url: "quickstart/console"
---

**Step 1:** Install the current [ScottPlot 4 package](https://www.nuget.org/packages/ScottPlot) from NuGet. 
Linux & MacOS users may need to [install additional packages](/faq/dependencies).

**Step 2:** Plot some data and save the figure as an image file

{{< code-sp4sp5 >}}

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new(400, 300);
myPlot.AddScatter(dataX, dataY);

myPlot.SaveFig("quickstart.png");

---

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new(400, 300);
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("quickstart.png")

{{< /code-sp4sp5 >}}

![](scottplot-quickstart-console.png)

# Interactive Window

Plots created in console applications can be launched in a pop-up window allowing interactive pan and zoom.

**Step 1:**  Install the current [ScottPlot.WinForms package](https://www.nuget.org/packages/ScottPlot.WinForms) (or WPF, Eto, etc.)

**Step 2:**  Create a `Plot` and populate it with data

**Step 3:**  Create a `PlotViewer` and `Show()` it

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new(400, 300);
myPlot.AddScatter(dataX, dataY);

new ScottPlot.FormsPlotViewer(myPlot).ShowDialog();
```

![](scottplot-quickstart-winforms.png)

> 💡 Interactive plots using the WinForms and WPF controls require the console application to target Windows, but a strategy for launching interactive plots from console applications running on Linux using Avalonia is described in [#1769](https://github.com/ScottPlot/ScottPlot/issues/1769#issuecomment-1093504868)