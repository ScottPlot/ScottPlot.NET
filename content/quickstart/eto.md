---
Title: Eto Quickstart
date: 2021-12-29
description: How to create an interactive plot in a C# Eto application
url: "/quickstart/eto/"
---

{{< banner-sp5 >}}

# Eto Quickstart

**Step 1:** Install the [`ScottPlot.Eto`](https://www.nuget.org/packages/ScottPlot.Eto) NuGet package. Linux & MacOS users must take [these additional steps](/faq/dependencies).

**Step 2:** Add a `ScottPlot.Eto.PlotView` Control to your Form:

{{< code-sp5 >}}

```cs
var plotView = new ScottPlot.Eto.PlotView();

double[] xs = new double[] { 1, 2, 3, 4, 5 };
double[] ys = new double[] { 1, 4, 9, 16, 25 };
plotView.Plot.Add.Scatter(xs, ys);

this.Content = plotView;
```

{{< /code-sp5 >}}

<div class="container">
    <div class="row">
        <div class="col-md">
            <h3>WPF</h3>
            <img src="/images/quickstart/eto-quickstart-wpf.png">
        </div>
        <div class="col-md">
            <h3>GTK</h3>
            <img src="/images/quickstart/eto-quickstart-gtk.png">
        </div>
        <div class="col-md">
            <h3>OSX</h3>
            <img src="/images/quickstart/eto-quickstart-osx.png">
        </div>
    </div>
</div>