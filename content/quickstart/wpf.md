---
Title: WPF Quickstart
description: How to create an interactive plot in a C# WPF application
date: 2021-09-26
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

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
WpfPlot1.Plot.Add.Scatter(dataX, dataY);
WpfPlot1.Refresh();
```

![](/images/quickstart/scottplot-quickstart-wpf.png)

### Startup in .NET Framework Apps

Projects targeting .NET Framework should setup their plot inside the `Loaded` event.

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



# Plot using MVVM

WPF applications may be created using MVVM ([Model–view–viewmodel](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93viewmodel)) pattern to improve separation between the GUI layer and business logic.

* All code accessing the `WpfPlot` object can be kept in the view model - the class set as the `DataContext`

* Your concrete implementation can be adapted to the framework, like using attributes when defining the `PlotControl` property, and the use-case


### MVVM Example

**View:** Add a `ContentControl` instead of `WpfPlot` in the layout
```xml
    <ContentControl Content={Binding PlotControl, Mode=OneTime}/>
```

**View Model:** Add a `PlotControl` property to the view model
```cs
    WpfPlot PlotControl { get; } = new WpfPlot();
```

**Code-behind:** Create the plot in the view model's constructor

```cs
void Plot()
{
    double[] dataX = { 1, 2, 3, 4, 5 };
    double[] dataY = { 1, 4, 9, 16, 25 };
    PlotControl.Plot.Add.Scatter(dataX, dataY);
    PlotControl.Refresh();
}
```

**Updating the Plot:**
* Access the control by using the `PlotControl` property in the view model

* Plot updates would most likely be done as a reaction to an event or modification of an other property. 

* When to update the plot depends on your use-case. Note that rendering large amounts of data frequently may negatively impact performance.