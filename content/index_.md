---
Title: ScottPlot
Description: Interactive Plotting Library for .NET
url: /
date: 2021-09-06
lastmod: 2022-03-29
---

[![ScottPlot 4 CI](https://github.com/ScottPlot/ScottPlot/actions/workflows/ci-v4.yaml/badge.svg)](https://github.com/ScottPlot/ScottPlot/actions/workflows/ci-v4.yaml)
[![](https://img.shields.io/nuget/dt/scottplot?color=004880&label=Downloads&logo=NuGet)](https://www.nuget.org/packages/ScottPlot/)
[![](https://img.shields.io/nuget/vpre/scottplot?color=%23004880&label=NuGet&logo=nuget)](https://www.nuget.org/packages/ScottPlot/)
[![Discord](https://badgen.net/discord/members/Dru6fnY2UX?icon=discord&color=5562ea&label=Discord)](https://scottplot.net/discord/)

**ScottPlot is a free and open-source plotting library for .NET** that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.

<a href='cookbook'>
  <img src='/images/scottplot.gif' class="d-block mx-auto my-4" />
</a>

## Quickstart

* [**Windows Forms**](quickstart/winforms)
* [**WPF**](quickstart/wpf)
* [**Avalonia**](quickstart/avalonia)
* [**Console Application**](quickstart/console)
* [**PowerShell**](quickstart/powershell)
* [**.NET Interactive Notebook**](quickstart/notebook)


```cs
double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(xs, ys);
plt.SaveFig("quickstart.png");
```

![](quickstart/console/scottplot-quickstart-console.png)


## Cookbook and Demo

The [**ScottPlot Cookbook**](cookbook) demonstrates how to create line plots, bar charts, pie graphs, scatter plots, and more with just a few lines of code. 

The [**ScottPlot Demo**](demo) is a click-to-run application that demonstrates mouse-interactive versions of every cookbook recipe.

<a href='cookbook'>
  <img src='images/cookbook.jpg' class="d-block mx-auto my-5" />
</a>

## Plot in the Cloud

**ScottPlot does not require a GUI so it can be used to create plots in cloud applications.** The images below are regenerated hourly using Azure Functions to update star metrics from the GitHub API and download count from the NuGet API. The data is plotted with ScottPlot and saved as an image file in blob storage.

**Try it out!** [Give us a star](https://github.com/scottplot/scottplot) and come back in an hour and your name will appear here:


<a href="https://stargraph.z20.web.core.windows.net/scottplot-stars.png" target="_blank">
  <img src="https://stargraph.z20.web.core.windows.net/scottplot-stars.png?" class="d-block mx-auto my-4" >
</a>

<a href='https://nugetppt.z20.web.core.windows.net/plots/scottplot.png'>
  <img src='https://nugetppt.z20.web.core.windows.net/plots/scottplot.png' class="d-block mx-auto my-4" >
</a>
