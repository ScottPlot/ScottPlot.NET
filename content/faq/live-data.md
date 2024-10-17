---
title: Plot Live, Changing Data - ScottPlot FAQ
description: Different strategies for displaying live data that changes continuously
date: 2023-12-13
---

# How to Plot Realtime Data

## Use the `DataLogger` to show growing datasets

The DataLogger plot type is a like a scatter plot but it has features for recording and displaying growing datasets.

See the demo and source code on the [ScottPlot Demo](/demo/5.0/#plot-growing-data) page

<img src='/images/faq/live-data/datalogger.gif' class='d-block mx-auto border shadow my-5'>

## Use the `DataStreamer` to show the latest N values

The DataStreamer plot type is a like a signal plot but it has features for displaying the latest N values of a streaming dataset.

See the demo and source code on the [ScottPlot Demo](/demo/5.0/#plot-streaming-data) page

<img src='/images/faq/live-data/datastreamer.gif' class='d-block mx-auto border shadow my-5'>

## Change Values in Fixed-Length Arrays

**After plotting an array you can change its values and re-render at any time.** This is the most performant option for displaying changing fixed-length data. Although this same method can be used for most plot types, Signal plots are almost always the most performant option.

<div class="text-center">

![](/images/faq/live-data/changing-fixed.gif)

</div>

In this example a fixed-length `readonly` array is created and added to the plot, then a `Timer` calls a method to change the values inside that array and re-render the plot.

```cs
readonly double[] Values = new double[25];
readonly Stopwatch Stopwatch = Stopwatch.StartNew();

public Form1()
{
    InitializeComponent();
    
    // add the data to the plot only once
    formsPlot1.Plot.Add.Signal(Values);
}

private void timer1_Tick(object sender, EventArgs e)
{
    // change the values inside the array any time
    double phase = Stopwatch.Elapsed.TotalSeconds;
    double multiplier = 2 * Math.PI / Values.Length;
    for (int i = 0; i < Values.Length; i++)
        Values[i] = Math.Sin(i * multiplier + phase);

    // force a redraw after changing the data values
    formsPlot1.Render();
}
```

## Signal Plot: Partial Array Rendering

**You can create a large array and only display the first N values, increasing N as new data is added.** This gives the illusion of a growing plot, even though its source is a fixed-length array. The range of visible values is controlled by the `MinRenderIndex` and `MaxRenderIndex` fields of Signal plots and Scatter plots.

<div class="text-center">

![](/images/faq/live-data/changing-partial.gif)

</div>

```cs
readonly double[] Values = new double[100_000];
readonly ScottPlot.Plottable.Signal SignalPlot;
int NextPointIndex = 0;

public Form1()
{
    InitializeComponent();
    SignalPlot = formsPlot1.Plot.Add.Signal(Values);
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
    // expand axis limits to ensure new data is always visible
    double currentRightEdge = formsPlot1.Plot.GetAxisLimits().XMax;
    if (NextPointIndex > currentRightEdge)
        formsPlot1.Plot.SetAxisLimits(xMax: currentRightEdge + 100);

    formsPlot1.Refresh();
}
```

Note that this example will crash when the array is full. To prevent this, detect when `NextPointIndex` equals or exceeds the size of the array, and create a new larger array to hold the data. When you do this you will have to copy all the existing values from the old array to the new one.
