---
Title: ScottPlot - Interactive Plotting Library for .NET
Description: ScottPlot is a free and open-source plotting library for .NET that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.
---

# ScottPlot

**ScottPlot is a free and open-source plotting library for .NET** that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.

<div class="text-center">
  <a href='cookbook'>
    <img src='assets/images/scottplot.gif' />
  </a>
</div>

## Quickstart

* [**Windows Forms**](quickstart/winforms)
* [**WPF**](quickstart/wpf)
* [**Avalonia**](quickstart/avalonia)
* [**Console Application**](console)


```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](quickstart/console/scottplot-quickstart-console.png)


## Cookbook and Demo

The [**ScottPlot Cookbook**](cookbook) demonstrates how to create line plots, bar charts, pie graphs, scatter plots, and more with just a few lines of code. 

The [**ScottPlot Demo**](demo) is a click-to-run application that demonstrates mouse-interactive versions of every cookbook recipe.

<div class="text-center">
  <a href='cookbook'>
    <img src='assets/images/cookbook.jpg' />
  </a>
</div>

## Plot in the Cloud

**ScottPlot does not require a GUI so it can be used to create plots in cloud applications.** The images below are regenerated hourly using Azure Functions to update star metrics from the GitHub API and download count from the NuGet API. The data is plotted with ScottPlot and saved as an image file in blob storage.

**Try it out!** [Give us a star](https://github.com/scottplot/scottplot) and come back in an hour and your name will appear here:

<div class="text-center">

  <a href="https://stargraph.z20.web.core.windows.net/scottplot-stars.png" target="_blank">
    <img src="https://stargraph.z20.web.core.windows.net/scottplot-stars.png?">
  </a>

  <a href='https://nugetppt.z20.web.core.windows.net/plots/scottplot.png'>
    <img src='https://nugetppt.z20.web.core.windows.net/plots/scottplot.png'>
  </a>

</div>