---
title: What's New in ScottPlot 5.0
description: Notable changes between ScottPlot 4.1 and 5.0
date: 2023-12-13
url: /faq/version-5.0/
---

<div class='mt-3'>
<h3 class='m-0'>ScottPlot 5.0 was released in January, 2024! 🚀</h3>
<p>This page describes what's new in ScottPlot 5.0 vs. ScottPlot 4.1</p>
</div>

<div class="alert alert-primary my-5" role="alert" id="new-projects-should-use-scottplot-5">
    <h4 class="alert-heading my-0">
        <a href ='#new-projects-should-use-scottplot-5'>
            New projects should use ScottPlot 5
        </a>
    </h4>
    <ul class='my-0' id="existing-projects-can-keep-using-scottplot-4">
        <li>ScottPlot 5 offers the best performance and long-term cross-platform support</li>
        <li>Review the <a href='/quickstart'>Quickstart</a>, <a href='/cookbook/5.0/'>Cookbook</a>, <a href='/demo'>Demo</a>, and information below to learn how to use it</li>
        <li>If there is a feature you would like to see added or a behavior you are unsure how to achieve using ScottPlot 5, <a href='https://github.com/ScottPlot/ScottPlot/issues'>create a GitHub issue</a> or raise the topic in the <a href='/discord'>ScottPlot Discord Channel</a></li>
    </ul>
</div>

<div class="alert alert-success my-5" role="alert">
    <h4 class="alert-heading my-0">
        <a href='#existing-projects-can-keep-using-scottplot-4'>
            Existing projects can keep using ScottPlot 4.1
        </a>
    </h4>
    <ul class='my-0'>
        <li>ScottPlot 4 has many features, works well, has been extensively tested in production</li>
        <li>ScottPlot 4 continues to be supported although development is no longer focused on adding new features</li>
        <li>Upgrading to ScottPlot 5 requires some code modification because the APIs are not identical</li>
        <li>If your app works well with ScottPlot 4 there is no need to upgrade</li>
    </ul>
</div>

## Major New Features

* **Improved Graphics Performance** - ScottPlot 5 uses the `SkiaSharp` package to render graphics which is significantly faster than previous versions of ScottPlot which used `System.Drawing.Common`.

* **Improved Cross-Platform Support** - ScottPlot 4's cross-platform support was undercut when Microsoft [dropped cross-platform support for `System.Drawing.Common`](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only) in .NET 7, but ScottPlot 5 is supported on all platforms.

* **Packages for Additional Platforms** - In addition to supporting Windows Forms, WPF, Avalonia, and Eto, ScottPlot 5 now supports WinUI, Android, and Blazor!

* **Expanded support for various data types** - Previous versions of ScottPlot could only display data in `double` arrays, but many plot types in ScottPlot 5 support other data types like `float`, `int`, and `DateTime`, and can work with data in fixed-length arrays or variable-length lists.

* **Customizable User Interactions** - User controls now have classes that let developers modify what mouse and keyboard buttons map to which actions (panning, zooming, opening menus, etc.)

* **Simplified Multi-Axis Support** - Plotting data on multiple axes can be complicated, but ScottPlot 5 was designed from the ground up to make it easier for developers to create and manipulate plots with data plotted on multiple axes.

* **Axis Rules** - The `Plot.Axes` class contains a list of `Rules` which users can add to so custom logic is applied within the render system. Common rules include limiting how far users can zoom in or out of a plot, locking a horizontal or vertical axis, or ensuring that horizontal and vertical axes have the same scale so squares always appear as squares.

* **Vector Rendering** - ScottPlot 5's new rendering system makes it easier to scale plots (e.g., increasing the size of all elements in accordance with the system's display scaling settings) and also allows exporting plots as scalar vector graphic (SVG) files.

* **Customizable Rendering System** - Advanced users can achieve total control of rendering by manipulating the `Plot.RenderManager.RenderActions` list to remove default actions and/or add their own. This allows developers to extensively modify how plots are rendered without having to edit ScottPlot's source code to create their own custom version of the package.

## Major Changes from ScottPlot 4

### Cookbook Search

The ScottPlot 5 cookbook has a search feature (https://scottplot.net/cookbook/5.0/search/) which makes it easy to locate code samples for common features. Efforts were made to ensure the correct ScottPlot 5 cookbook recipes when searching for names of ScottPlot 4 features.

### Plots do not store a size

Instead of creating a plot with a given size, size is passed as arguments only when an image is to be rendered.

```cs
// ScottPlot 4
ScottPlot.Plot myPlot = new(600, 400);
myPlot.SaveFig("demo.png");
```

```cs
// ScottPlot 5
ScottPlot.Plot myPlot = new();
myPlot.SavePng("demo.png", 600, 400);
```

### Adding Plottables

To reduce the surface area of the `Plot` API, helper methods which create plottables and add them to plots are all methods inside the `Plot.Add` class.

```cs
// ScottPlot 4
myPlot.AddScatter(xs, ys);
```

```cs
// ScottPlot 5
myPlot.Add.Scatter(xs, ys);
```

### Support for Generic Types

In ScottPlot 4 most plot types could only work with `double[]`, but in ScottPlot 5 many plot types can work with any numeric data type. This is even true for `DateTime` which is useful when plotting data with a date axis.

```cs
// ScottPlot 5
int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(xs, ys);
```

### Signal Plots accept Period (not Sample Rate)

Signal plots display evenly-spaced data. ScottPlot 4 defined the spacing as a sample rate (points per unit) but ScottPlot 5 defines the spacing as a period (units between points).

```cs
// ScottPlot 4
double pointsPerSecond = 100;
myPlot.Add.Signal(ys, pointsPerSecond);
```

```cs
// ScottPlot 5
double secondsPerPoint = 0.01;
myPlot.Add.Signal(ys, secondsPerPoint);
```