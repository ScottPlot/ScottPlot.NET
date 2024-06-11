---
Title: Eto Quickstart
date: 2021-12-29
description: How to create an interactive plot in a C# Eto application
---

# Eto Quickstart

**Step 1:** Install the [`ScottPlot.Eto`](https://www.nuget.org/packages/ScottPlot.Eto) NuGet package. Linux & MacOS users must take [these additional steps](/faq/dependencies).

**Step 2:** Add a `ScottPlot.Eto.PlotView` Control to your Form:

```cs
var plotView = new ScottPlot.Eto.PlotView();

double[] xs = new double[] { 1, 2, 3, 4, 5 };
double[] ys = new double[] { 1, 4, 9, 16, 25 };
plotView.Plot.Add.Scatter(xs, ys);

this.Content = plotView;
```

<div class="container">
    <div class="row">
        <div class="col-md">
            <h3>WPF</h3>
            <a href="/images/quickstart/eto-quickstart-wpf.png"><img src="/images/quickstart/eto-quickstart-wpf.png"></a>
        </div>
        <div class="col-md">
            <h3>GTK</h3>
            <a href="/images/quickstart/eto-quickstart-gtk.png"><img src="/images/quickstart/eto-quickstart-gtk.png"></a>
        </div>
        <div class="col-md">
            <h3>OSX</h3>
            <a href="/images/quickstart/eto-quickstart-osx.png"><img src="/images/quickstart/eto-quickstart-osx.png"></a>
        </div>
    </div>
</div>