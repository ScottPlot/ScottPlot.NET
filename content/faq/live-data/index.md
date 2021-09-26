---
title: Plot Live, Changing Data - ScottPlot FAQ
description: How to display data plots of live data that changes continuously.
---

# Plot Live, Changing Data

**What is the best way to plot data that is constantly changing or growing?** Several options are available to the developer. To choose the best one, consider these important points:

1. **After you plot an array, you can continue to modify its values.** For example, if you load an array into a Signal plot you can continue to modify that array's values after it has been plotted. Whenever the plot renders again, the latest values will appear on the plot. This is the best option for fixed-length datasets and it is always thread safe.

2. **Call `Render()` after modifying data.** Rendering the plot can be costly, so it is not called automatically when data is modified. You control when you update data, and you control when renders occur by calling the user control's `Render()` method. For plots which update data at a high frequency it may be wise to trigger renders using a timer to achieve an acceptable frame rate instead of forcing renders to occur every time the data is modified.

3. **Adjust axis limits to accommodate new data.** If you add new data and request a render it is possible that the new data will run off the plot area. You probably want to adjust the axis limits as new data is added to ensure new data stays in the plot area. `AxisAuto()` could be used to automatically set axis limits to the boundaries of the latest data, but this method call is not performant for large datasets, calling it too frequently is jarring for users who wish to use the mouse to adjust the zooming and panning, and ever-changing axis limits can be confusing for the user. Consider implementing something custom, such as detecting when the latest data point runs outside the data area, and only then adjusting the axis limits by setting the right axis limit to the current span of the data plus 20%. This will ensure the newest data is always on the screen and minimizes the number of times the axis limits change.

4. **In multi-threaded environments** use `RenderLock()` to ensure you do not modify the length of data arrays in a Plottable while it is actively rendering. Since rendering iterates through every value in an array, changing the length of that array mid-render can produce array index exceptions. This is typically not a concern in single-thread GUI applications (WinForms), but can arise as an issue when multi-threading is used (WPF).

## Changing Fixed-Length Data

**After plotting an array you can change its values and re-render at any time.** This is the most performant option for displaying changing fixed-length data. Although this same method can be used for most plot types, Signal plots are almost always the most performant option.

<div class="text-center">

![](src/ChangingFixedSignal-WinForms/screenshot.gif)

</div>

* [**Download this example project**](https://github.com/ScottPlot/Website/tree/main/src/faq/live-data/src/ChangingFixedSignal-WinForms)

In this example a fixed-length `readonly` array is created and added to the plot, then a `Timer` calls a method to change the values inside that array and re-render the plot.

```cs
readonly double[] Values = new double[25];
readonly Stopwatch Stopwatch = Stopwatch.StartNew();

public Form1()
{
    InitializeComponent();
    UpdateValues();
    formsPlot1.Plot.AddSignal(Values);
}

public void UpdateValues()
{
    double phase = Stopwatch.Elapsed.TotalSeconds;
    double multiplier = 2 * Math.PI / Values.Length;
    for (int i = 0; i < Values.Length; i++)
        Values[i] = Math.Sin(i * multiplier + phase);
}

private void timer1_Tick(object sender, EventArgs e)
{
    UpdateValues();
    formsPlot1.Render();
}
```

## Rolling Fixed-Length Data

An alternative way to display data is to update a single point at a time, and when the data runs off the screen "roll" it back to the start. This is similar to how an oscilloscope displays a waveform, and sometimes is described as a circular buffer.

In this example a single scatter plot is created with a fixed-length array. New values are added at a position tracked by `NextIndex`, and when that position becomes larger than the array it rolls over to zero. To make this more obvious a vertical line is often added at the roll point to make it more obvious where the break occurs.

<div class="text-center">

![](src/RollFixedSignal-WinForms/screenshot.gif)

</div>

* [**Download this example project**](https://github.com/ScottPlot/Website/tree/main/src/faq/live-data/src/RollFixedSignal-WinForms)

```cs
readonly double[] Values = new double[500];
readonly Stopwatch Stopwatch = Stopwatch.StartNew();
readonly ScottPlot.Plottable.VLine VerticalLine;
int NextIndex = 0;

public Form1()
{
    InitializeComponent();
    formsPlot1.Plot.AddSignal(Values);
    VerticalLine = formsPlot1.Plot.AddVerticalLine(0, Color.Red, 2);
    formsPlot1.Plot.SetAxisLimits(0, Values.Length, -2, 2);
}

public void AddDataPoint()
{
    Values[NextIndex] = Math.Sin(Stopwatch.Elapsed.TotalSeconds * 3);

    NextIndex += 1;
    if (NextIndex >= Values.Length)
        NextIndex = 0;

    VerticalLine.X = NextIndex;
}

// This timer adds data frequently (every 1 ms)
private void timer1_Tick(object sender, EventArgs e)
{
    AddDataPoint();
}

// This timer renders infrequently (every 20 ms)
private void timer2_Tick(object sender, EventArgs e)
{
    formsPlot1.Render();
}
```

## Growing Data with Partial Array Rendering

**You can create a large array and only display the first N values, increasing N as new data is added.** This gives the illusion of a growing plot, even though its source is a fixed-length array. The range of visible values is controlled by the `MinRenderIndex` and `MaxRenderIndex` fields of Signal plots and Scatter plots.

<div class="text-center">

![](src/MaxRenderIndex-WinForms/screenshot.gif)

</div>

* [**Download this example project**](https://github.com/ScottPlot/Website/tree/main/src/faq/live-data/src/MaxRenderIndex-WinForms)

```cs
readonly double[] Values = new double[100_000];
readonly ScottPlot.Plottable.SignalPlot SignalPlot;
int NextPointIndex = 0;

public Form1()
{
    InitializeComponent();
    SignalPlot = formsPlot1.Plot.AddSignal(Values);
    formsPlot1.Plot.SetAxisLimits(0, 100, -2, 2);
}

// This timer adds data frequently (1000 times / second)
private void timer1_Tick(object sender, EventArgs e)
{
    Values[NextPointIndex] = Math.Sin(NextPointIndex * .05);
    SignalPlot.MaxRenderIndex = NextPointIndex;
    NextPointIndex += 1;
}

// This timer renders infrequently (10 times per second)
private void timer2_Tick(object sender, EventArgs e)
{
    // adjust the axis limits only when needed
    double currentRightEdge = formsPlot1.Plot.GetAxisLimits().XMax;
    if (NextPointIndex > currentRightEdge)
        formsPlot1.Plot.SetAxisLimits(xMax: currentRightEdge + 100);

    formsPlot1.Render();
}
```

**⚠️ WARNING: This example will crash when the array is full.** To prevent this, detect when `NextPointIndex` equals or exceeds the size of the array, and create a new larger array to hold the data. When you do this you will have to copy all the existing values from the old array to the new one.

## Growing Data with ScatterPlotList

The `ScatterPlotList` plot type uses `List<double>` instead of `double[]` to store data, so it is easy to `Add()` data to. After adding new data the user can set the axis limits as desired and request a render. Scatter plots are slow for large datasets, so the Signal plot methods described above are almost always preferred.

## Growing Data with SignalPlotList

TODO: create this plot type