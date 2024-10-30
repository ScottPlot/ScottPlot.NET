---
Title: Bar Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Bar plots can be added from a series of values.
URL: /cookbook/5.0/Bar/Quickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/Quickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/Quickstart'>Bar Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/Quickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Bar plots can be added from a series of values.

[![](/cookbook/5.0/images/Quickstart.png?241029205813)](/cookbook/5.0/images/Quickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add bars
double[] values = { 5, 10, 7, 13 };
myPlot.Add.Bars(values);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


