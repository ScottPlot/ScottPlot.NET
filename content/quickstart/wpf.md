---
Title: WPF Quickstart
description: How to create an interactive plot in a C# WPF application
date: 2021-09-26
---

{{< banner-sp5 >}}

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

## Display Scaling Notes

The ScottPlot WPF control requires additional considerations for some features to work properly on high DPI, scaled displays.

### Converting Mouse Position to ScottPlot Pixels

When using mouse events and their cursor positions, the display scale must be applied as necessary before converting into Pixel coordinates.  The conversion is shown in the following mouse tracking event handler example.


{{< code-sp5 >}}

```cs
public partial class MainWindow : Window
{
    readonly ScottPlot.Plottables.Crosshair CH;

    public MainWindow()
    {
        InitializeComponent();

        WpfPlot1.Plot.Add.Signal(Generate.Sin());
        CH = WpfPlot1.Plot.Add.Crosshair(0, 0);

        WpfPlot1.MouseMove += (s, e) =>
        {
            System.Windows.Point position = e.GetPosition(WpfPlot1);
            double x = position.X;
            double y = position.Y;

            if (WpfPlot1.DisplayScale != 1.0)
            {
                x *= WpfPlot1.DisplayScale;
                y *= WpfPlot1.DisplayScale;
            }

            Pixel mousePixel = new(x, y);
            Coordinates mouseCoordinates = WpfPlot1.Plot.GetCoordinates(mousePixel);
            CH.Position = mouseCoordinates;
            WpfPlot1.Refresh();
        };
    }
}
```

{{< /code-sp5 >}}

### Plot Appearance and Display DPI

By default, many of the elements on a plot are sized based on physical display pixels.  Plots will then have such things as labels, ticks and legends rendered very small on a high DPI display.  Set a plot's scale factor to the WPF display scale to make the plot appear the same at all display DPIs.

{{< code-sp5 >}}

```cs
    public MainWindow()
    {
        InitializeComponent();

        WpfPlot1.Plot.ScaleFactor = WpfPlot1.DisplayScale;
    }


```
{{< /code-sp5 >}}
