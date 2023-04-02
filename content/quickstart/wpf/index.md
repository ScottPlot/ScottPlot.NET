---
Title: WPF Quickstart
url: "quickstart/wpf"
description: How to create an interactive plot in a C# WPF application
date: 2021-09-26
---

**Step 1:** Install the [`ScottPlot.WPF`](https://www.nuget.org/packages/ScottPlot.WPF) NuGet package

**Step 2:** Add this to the root element of your XAML file:
```xml
xmlns:ScottPlot="clr-namespace:ScottPlot;assembly=ScottPlot.WPF"
```

**Step 3:** Add a `WpfPlot` to your layout and give it a unique name
```xml
<WpfPlot Name="WpfPlot1" />
```

**Step 4:** Plot some data in your start-up sequence

```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
WpfPlot1.Plot.AddScatter(dataX, dataY);
WpfPlot1.Refresh();
```

![](scottplot-quickstart-wpf.png)
