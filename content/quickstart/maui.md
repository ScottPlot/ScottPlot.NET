---
Title: .NET MAUI Quickstart
description: How to create an interactive plot in a .NET MAUI application
date: 2023-07-06
---

# .NET MAUI Quickstart

**Step 0**: Create a new .NET MAUI Application

**Step 1**: Install the [ScottPlot.Maui](https://www.nuget.org/packages/ScottPlot.Maui) NuGet package

_Linux & MacOS users may need to take [additional steps](https://scottplot.net/faq/dependencies)_

**Step 2**: Edit the `.xaml` file to add the ScottPlot xmlns attribute to the Window element:

```xml
xmlns:ScottPlot="clr-namespace:ScottPlot.Maui;assembly=ScottPlot.Maui"
```

**Step 3**: Edit the `.xaml` file to add a MauiPlot to your layout:

```xml
<ScottPlot:MauiPlot x:Name="MauiPlot1" />
```


**Step 4**: Edit the `.xaml.cs` file to add data to the plot:

```
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

MauiPlot1.Plot.Add.Scatter(dataX, dataY);
MauiPlot1.Refresh();
```