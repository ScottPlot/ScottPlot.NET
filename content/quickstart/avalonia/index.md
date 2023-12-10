---
Title: Avalonia Quickstart
url: "quickstart/avalonia"
description: How to create an interactive plot in a C# Avalonia application
date: 2021-09-26
lastmod: 2021-12-29
---

# Avalonia Quickstart

**Step 1:** Install the [`ScottPlot.Avalonia`](https://www.nuget.org/packages/ScottPlot.Avalonia) NuGet package. Linux & MacOS users must take [these additional steps](/faq/dependencies).

**Step 2:** Import the `ScottPlot.Avalonia` namespace by adding this to your `Window` element:

```xml
xmlns:ScottPlot="clr-namespace:ScottPlot.Avalonia;assembly=ScottPlot.Avalonia"
```

Your `Window` element should look something like this:

```xml
<Window xmlns="https://github.com/avaloniaui"
        <!-- More attributes -->
        x:Class="ScottPlot.Demo.Avalonia.MainWindow"
        xmlns:ScottPlot="clr-namespace:ScottPlot.Avalonia;assembly=ScottPlot.Avalonia"
        Title="Avalonia Quickstart" Width="500" Height="350">
```


**Step 3:** Add an AvaPlot to your layout and give it a unique name
```xml
<ScottPlot:AvaPlot Name="AvaPlot1"/>
```

**Step 4:** Plot some data in your start-up sequence

{{< code-sp4sp5 >}}

double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };

AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
avaPlot1.Plot.AddScatter(dataX, dataY);
avaPlot1.Refresh();

---

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
avaPlot1.Plot.Add.Scatter(dataX, dataY);
avaPlot1.Refresh();

{{< /code-sp4sp5 >}}

<img src="scottplot-quickstart-avalonia.png" class="d-block mx-auto shadow my-5">