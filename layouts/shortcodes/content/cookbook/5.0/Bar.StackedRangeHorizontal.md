---
Title: Stacked Horizontal Range Chart - ScottPlot 5.0 Cookbook
Description: Horizontally oriented stacked range charts may be created
URL: /cookbook/5.0/Bar/StackedRangeHorizontal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Horizontal Range Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/StackedRangeHorizontal"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Horizontal Range Chart</h1>
</div>

Horizontally oriented stacked range charts may be created

[![](/cookbook/5.0/images/StackedRangeHorizontal.png?250822231048)](/cookbook/5.0/images/StackedRangeHorizontal.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/StackedRangeHorizontal.png?250822231048" >}}ScottPlot.Plot myPlot = new();

List&lt;(string name, double[] edges)&gt; ranges =
[
    ("Ontario", [-9, 3, 7, 13, 27]),
    ("England", [4, 7, 12, 16, 24]),
    ("Kentucky", [-4, 7, 13, 20, 30]),
];

myPlot.Add.StackedRanges(ranges, horizontal: true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


