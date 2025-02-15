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



# WPF Quickstart (Alternative)
This is an alternative way which can be used in code models like MVVM. In that way all code accessing the `WpfPlot` object can be kept in the view model - the class set as the DataContext.
Your concrete implementation can of course be adapted to the used framework, like using attributes when defining the `PlotControl` property, and the use-case.

Follow steps 1 and 2 above.

**Step 3:** Add a `ContentControl` instead of `WpfPlot` in the layout where the control should be located
```xml
    <ContentControl Content={Binding PlotControl, Mode=OneTime}/>
```

**Step 4:** In the view model add the `PlotControl` property
```cs
    WpfPlot PlotControl { get; } = new WpfPlot();
```

**Usage Example**

You can then access the control by using the `PlotControl` property in the view model like in the following example. When to update the plot depends on your use-case.
This would most likely be done as a reaction to an event or modification of an other property. As a start you can add a call to this `Plot()` method in the constructor of the view model class.
```cs
    void Plot()
    {
        double[] dataX = { 1, 2, 3, 4, 5 };
        double[] dataY = { 1, 4, 9, 16, 25 };
        PlotControl.Plot.Add.Scatter(dataX, dataY);
        PlotControl.Refresh();
    }
```
