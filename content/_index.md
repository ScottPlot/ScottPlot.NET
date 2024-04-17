---
Title: ScottPlot - Interactive Plotting Library for .NET
Description: ScottPlot is a free and open-source plotting library for .NET that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.
date: 2021-09-06
layout: single
---

<h1 class='border-0 mt-4 mb-0'>ScottPlot</h1>

[![](https://img.shields.io/nuget/dt/scottplot?color=29ab47&label=Downloads&logo=NuGet)](https://www.nuget.org/packages/ScottPlot/)
[![](https://img.shields.io/nuget/vpre/scottplot?color=044577&label=NuGet&logo=nuget)](https://www.nuget.org/packages/ScottPlot/)
[![](https://badgen.net/discord/members/Dru6fnY2UX?color=5562ea&icon=discord&label=Discord)](https://scottplot.net/discord/)

**ScottPlot is a free and open-source plotting library for .NET** that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.

<a href='cookbook'>
  <img src='/images/scottplot.gif' class="d-block mx-auto my-5" />
</a>

## Quickstart 

Quickstart pages exist for [console applications](/quickstart/console/), [Windows Forms](/quickstart/winforms/), [WPF](/quickstart/wpf/), [WinUI](/quickstart/winui/), [Blazor](/quickstart/blazor/), and more!

```cs
double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };
ScottPlot.Plot myPlot = new(400, 300);
myPlot.Add.Scatter(xs, ys);
myPlot.SavePng("quickstart.png");
```

![](/images/quickstart/scottplot-quickstart-console.png)


## Cookbook

The [**ScottPlot Cookbook**](cookbook/) demonstrates how to create line plots, bar charts, pie graphs, scatter plots, and more with just a few lines of code. 

<a href='cookbook/'>
  <img src='images/cookbook.jpg' class="d-block mx-auto my-5" />
</a>

## Demo

The [**ScottPlot Demo**](demo/) is a click-to-run application that provides mouse-interactive versions of every cookbook recipe and demonstrates how to perform advanced interactive customizations.

<a href='demo'>
  <img src='/images/demo/5.0/demo.png' class="d-block mx-auto my-5" />
</a>

## Plot in the Cloud

**ScottPlot does not require a GUI so it can be used to create plots in cloud applications.** The images below are regenerated hourly using Azure Functions to update star metrics from the GitHub API and download count from the NuGet API. The data is plotted with ScottPlot and saved as an image file in blob storage. Try it out!

**Try it out:** If you [**give us a star** ⭐](https://github.com/scottplot/scottplot) and come back in an hour and your name will appear in the graph below!


<a href="https://scottplotstatsstorage.z20.web.core.windows.net/stars.png" target="_blank">
  <img src="https://scottplotstatsstorage.z20.web.core.windows.net/stars.png" class="d-block mx-auto my-5" >
</a>

<a href='https://scottplotstatsstorage.z20.web.core.windows.net/scottplot-download-count.png'>
  <img src='https://scottplotstatsstorage.z20.web.core.windows.net/scottplot-download-count.png' class="d-block mx-auto my-5" >
</a>