---
Title: WPF Quickstart
url: "quickstart/wpf"
description: How to create an interactive plot in a C# WPF application
date: 2021-09-26
---

# WPF Quickstart

**Step 1:** Install the [`ScottPlot.WPF`](https://www.nuget.org/packages/ScottPlot.WPF) NuGet package

**Step 2:** Add this to the root element of your XAML file:

{{< code-sp4sp5 >}}

xmlns:ScottPlot="clr-namespace:ScottPlot;assembly=ScottPlot.WPF"

---

xmlns:ScottPlot="clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPF"

{{< /code-sp4sp5 >}}

**Step 3:** Add a `WpfPlot` to your layout and give it a unique name
```xml
<ScottPlot:WpfPlot x:Name="WpfPlot1" />
```

**Step 4:** Plot some data in your start-up sequence

{{< code-sp4sp5 >}}

double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
WpfPlot1.Plot.AddScatter(dataX, dataY);
WpfPlot1.Refresh();

---

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
WpfPlot1.Plot.Add.Scatter(dataX, dataY);
WpfPlot1.Refresh();

{{< /code-sp4sp5 >}}

![](scottplot-quickstart-wpf.png)

**Tip:** You may experience better startup behavior if you plot after the Window has loaded

```cs
public MainWindow()
{
    InitializeComponent();

    Loaded += (s, e) =>
    {
        double[] dataX = { 1, 2, 3, 4, 5 };
        double[] dataY = { 1, 4, 9, 16, 25 };
        WpfPlot1.Plot.Add.Scatter(dataX, dataY);
        WpfPlot1.Refresh();
    };
}
```
