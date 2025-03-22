---
Title: Live Data - ScottPlot 5.0 Cookbook
Description: Plottables like DataLogger and DataStreamer are designed for displaying datasets that change in real time. They have the ability to control axis limits to ensure the latest data is always in view. See the ScottPlot Demo for live example of these plot types.
URL: /cookbook/5.0/LiveData/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Live Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LiveData"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Live Data</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataLogger Quickstart</h1>
<a href='/cookbook/5.0/LiveData/DataLoggerQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use a DataLogger to display growing datasets (such as sensor data). This plot type assumes that new data will always be added to the end of the existing data, so like SignalXY new data points must have an X value that is greater to or than or equal than the previous one. See the ScottPlot Demo for a live example of this plot type.

[![](/cookbook/5.0/images/DataLoggerQuickstart.png?250322130304)](/cookbook/5.0/images/DataLoggerQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5.0/images/DataLoggerQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// setup a logger that will grow as data is added
var logger = myPlot.Add.DataLogger();

// simulate live data streaming in
for (int x = 0; x &lt; 10; x++)
{
    double y = Generate.RandomWalker.Next();
    logger.Add(x, y);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataStreamer Quickstart</h1>
<a href='/cookbook/5.0/LiveData/DataStreamerQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use a DataStreamer to display streaming data using a fixed-length display with a fixed horizontal distance between points. This type of plot is ideal for signals like ECG (heart monitor) waveforms. This plot type has advanced customizations for controlling how new data replaces old data (e.g., slide the old data to the left as new data appears on the right or place new data values from left to right, then wrap around to the start and wipe away the oldest data values by replacing them from left to right again). See the ScottPlot Demo for a live example of this plot type.

[![](/cookbook/5.0/images/DataStreamerQuickstart.png?250322130304)](/cookbook/5.0/images/DataStreamerQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5.0/images/DataStreamerQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// setup a streamer that shows the latest 100 points
var streamer = myPlot.Add.DataStreamer(100);

// simulate live data streaming in.
for (int x = 0; x &lt; 123; x++)
{
    double y = Generate.RandomWalker.Next();
    streamer.Add(y);
}

// tell new data to overwrite old data from left to right
streamer.ViewWipeRight();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataLogger Editing</h1>
<a href='/cookbook/5.0/LiveData/DataLoggerEditing' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Values accumulated by a data logger may be edited after they are acquired.

[![](/cookbook/5.0/images/DataLoggerEditing.png?250322130304)](/cookbook/5.0/images/DataLoggerEditing.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5.0/images/DataLoggerEditing.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// setup a logger that will grow as data is added
var logger = myPlot.Add.DataLogger();

// add ten values
logger.Add(Generate.RandomSample(10));

// remove the oldest five values
logger.Data.Coordinates.RemoveRange(0, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


