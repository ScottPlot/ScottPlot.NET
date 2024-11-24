---
Title: DataStreamer Quickstart - ScottPlot 5.0 Cookbook
Description: Use a DataStreamer to display streaming data using a fixed-length display with a fixed horizontal distance between points. This type of plot is ideal for signals like ECG (heart monitor) waveforms. This plot type has advanced customizations for controlling how new data replaces old data (e.g., slide the old data to the left as new data appears on the right or place new data values from left to right, then wrap around to the start and wipe away the oldest data values by replacing them from left to right again). See the ScottPlot Demo for a live example of this plot type.
URL: /cookbook/5.0/LiveData/DataStreamerQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Live Data", "DataStreamer Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LiveData", "/cookbook/5.0/LiveData/DataStreamerQuickstart"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataStreamer Quickstart</h1>
</div>

Use a DataStreamer to display streaming data using a fixed-length display with a fixed horizontal distance between points. This type of plot is ideal for signals like ECG (heart monitor) waveforms. This plot type has advanced customizations for controlling how new data replaces old data (e.g., slide the old data to the left as new data appears on the right or place new data values from left to right, then wrap around to the start and wipe away the oldest data values by replacing them from left to right again). See the ScottPlot Demo for a live example of this plot type.

[![](/cookbook/5.0/images/DataStreamerQuickstart.png?241124170640)](/cookbook/5.0/images/DataStreamerQuickstart.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5.0/images/DataStreamerQuickstart.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/LiveData'>Live Data</a> category</div>


