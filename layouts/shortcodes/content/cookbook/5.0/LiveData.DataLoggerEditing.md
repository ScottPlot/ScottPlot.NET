---
Title: DataLogger Editing - ScottPlot 5.0 Cookbook
Description: Values accumulated by a data logger may be edited after they are acquired.
URL: /cookbook/5.0/LiveData/DataLoggerEditing/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Live Data", "DataLogger Editing"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LiveData", "/cookbook/5.0/LiveData/DataLoggerEditing"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataLogger Editing</h1>
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/LiveData'>Live Data</a> category</div>


