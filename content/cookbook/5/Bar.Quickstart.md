---
Title: Bar Plot Quickstart - ScottPlot 5 Cookbook
Description: Bar plots can be added from a series of values.
URL: /cookbook/5/Bar/Quickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Bar Plot", "Bar Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Bar", "/cookbook/5/Bar/Quickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar Plot Quickstart</h1>
</div>

Bar plots can be added from a series of values.

[![](/cookbook/5/images/Quickstart.png?260329072039)](/cookbook/5/images/Quickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5/images/Quickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// add bars
double[] values = { 5, 10, 7, 13 };
myPlot.Add.Bars(values);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Bar'>Bar Plot</a> category</div>


