---
Title: DataLogger Quickstart - ScottPlot 5.0 Cookbook
Description: Use a DataLogger to display growing datasets (such as sensor data). This plot type assumes that new data will always be added to the end of the existing data, so like SignalXY new data points must have an X value that is greater to or than or equal than the previous one. See the ScottPlot Demo for a live example of this plot type.
URL: /cookbook/5.0/LiveData/DataLoggerQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Live Data", "DataLogger Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LiveData", "/cookbook/5.0/LiveData/DataLoggerQuickstart"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataLogger Quickstart</h1>
</div>

Use a DataLogger to display growing datasets (such as sensor data). This plot type assumes that new data will always be added to the end of the existing data, so like SignalXY new data points must have an X value that is greater to or than or equal than the previous one. See the ScottPlot Demo for a live example of this plot type.

[![](/cookbook/5.0/images/DataLoggerQuickstart.png?250105183901)](/cookbook/5.0/images/DataLoggerQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5.0/images/DataLoggerQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/LiveData'>Live Data</a> category</div>


