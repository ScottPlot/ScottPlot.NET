---
Title: DataLogger Editing - ScottPlot 5 Cookbook
Description: Values accumulated by a data logger may be edited after they are acquired.
URL: /cookbook/5/LiveData/DataLoggerEditing/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Live Data", "DataLogger Editing"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/LiveData", "/cookbook/5/LiveData/DataLoggerEditing"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DataLogger Editing</h1>
</div>

Values accumulated by a data logger may be edited after they are acquired.

[![](/cookbook/5/images/DataLoggerEditing.png?251011113742)](/cookbook/5/images/DataLoggerEditing.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/LiveData.cs" imageUrl="/cookbook/5/images/DataLoggerEditing.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// setup a logger that will grow as data is added
var logger = myPlot.Add.DataLogger();

// add ten values
logger.Add(Generate.RandomSample(10));

// remove the oldest five values
logger.Data.Coordinates.RemoveRange(0, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/LiveData'>Live Data</a> category</div>


