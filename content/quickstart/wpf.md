---
Title: WPF Quickstart
description: How to create an interactive plot in a C# WPF application
date: 2021-09-26
url: /quickstart/wpf/
---

# WPF Quickstart

**Step 1:** Install the [`ScottPlot.WPF`](https://www.nuget.org/packages/ScottPlot.WPF) NuGet package

**Step 2:** Add this to the root element of your XAML file:

```xml
xmlns:ScottPlot="clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPF"
```

**Step 3:** Add a `WpfPlot` to your layout and give it a unique name
```xml
<ScottPlot:WpfPlot x:Name="WpfPlot1" />
```

**Step 4:** Plot some data in your start-up sequence

{{< code-sp5 >}}

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
WpfPlot1.Plot.Add.Scatter(dataX, dataY);
WpfPlot1.Refresh();
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-quickstart-wpf.png)

## .NET Framework Notes

Projects targeting .NET Framework should setup their plot inside the `Loaded` event.

{{< code-sp5 >}}

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

{{< /code-sp5 >}}