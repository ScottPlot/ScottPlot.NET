---
Title: Eto Quickstart
url: "quickstart/eto"
date: 2021-12-29
description: How to create an interactive plot in a C# Eto application
---

**Step 1:** Install the [`ScottPlot.Eto`](https://www.nuget.org/packages/ScottPlot.Eto) NuGet package

**Step 2:** Add a `ScottPlot.Eto.PlotView` Control to your Form:

```cs
var plotView = new ScottPlot.Eto.PlotView();

double[] xs = new double[] { 1, 2, 3, 4, 5 };
double[] ys = new double[] { 1, 4, 9, 16, 25 };
plotView.Plot.AddScatter(xs, ys);

this.Content = plotView;
```

WPF | GTK | OSX
---|---|---
![](eto-quickstart-wpf.png)|![](eto-quickstart-gtk.png)|![](eto-quickstart-osx.png)

## MacOS & Linux

ScottPlot relies on [`System.Drawing.Common`](https://www.nuget.org/packages/System.Drawing.Common) which requires [libgdiplus](https://www.mono-project.com/docs/gui/libgdiplus/) on non-Windows systems:

* **MacOS:** `brew install mono-libgdiplus`

* **Linux:** `apt-get install -y libgdiplus`

You may also need to specifically add the [`System.Drawing.Common`](https://www.nuget.org/packages/System.Drawing.Common) package to your project:

```
dotnet add package System.Drawing.Common
```