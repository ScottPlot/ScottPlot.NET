---
Title: Line Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Line plots are placed with a start and end location in coordinate space. Their styles can be customized.
URL: /cookbook/5.0/LinePlot/LineQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Line Plot", "Line Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/LinePlot", "/cookbook/5.0/LinePlot/LineQuickStart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/LinePlot/LineQuickStart'>Line Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/LinePlot/LineQuickStart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/LinePlot">Category: Line Plot</a>
</div>

Line plots are placed with a start and end location in coordinate space. Their styles can be customized.

[![](/cookbook/5.0/images/LineQuickStart.png?241031194635)](/cookbook/5.0/images/LineQuickStart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Line(1, 12, 12, 0);
myPlot.Add.Line(7, 9, 42, 9);
myPlot.Add.Line(30, 17, 30, 1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


