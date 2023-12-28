---
Title: "DataStreamer - ScottPlot 4.1 Cookbook"
Description: "A DataStreamer is a plot type designed for streaming datasets with a fixed length display and even X spacing between Y data points. As new data is shifted in, old data is shifted out, and the displayed trace is always the same size."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/datastreamer_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Data Logger", "DataStreamer"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-datalogger", "/cookbook/4.1/recipes/datastreamer_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/datastreamer_quickstart.png"
---

<h2><a id='datastreamer' href='/cookbook/4.1/recipes/datastreamer_quickstart/'>DataStreamer</a></h2>

A DataStreamer is a plot type designed for streaming datasets with a fixed length display and even X spacing between Y data points. As new data is shifted in, old data is shifted out, and the displayed trace is always the same size.

```cs
var plt = new ScottPlot.Plot(600, 400);

var streamer = plt.AddDataStreamer(length: 20);
streamer.SamplePeriod = 0.2;

for (int i = 0; i < 100; i++)
{
    double y = Math.Sin(i * .2);
    streamer.Add(y); // data remains same length as new data is shifted in
}

// Call different view methods to change the shift behavior
streamer.ViewWipeRight(); // new data overwrites old data left to right
streamer.ViewWipeLeft(); // new data overwrites old data right to left
streamer.ViewScrollRight(); // new data is inserted on the left
streamer.ViewScrollLeft(); // new data is inserted on the right

plt.SaveFig("datastreamer_quickstart.png");
```

<img src='../../images/datastreamer_quickstart.png' class='d-block mx-auto my-5' />


