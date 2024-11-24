---
Title: Horizontal Range Chart - ScottPlot 5.0 Cookbook
Description: Range charts may be created using horizontally oriented bars
URL: /cookbook/5.0/Bar/RangeChartHozontal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Horizontal Range Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/RangeChartHozontal"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Horizontal Range Chart</h1>
</div>

Range charts may be created using horizontally oriented bars

[![](/cookbook/5.0/images/RangeChartHozontal.png?241124170640)](/cookbook/5.0/images/RangeChartHozontal.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/RangeChartHozontal.png?241124170640" >}}ScottPlot.Plot myPlot = new();

List&lt;(string name, CoordinateRange range)&gt; ranges =
[
    ("Ontario", new(-9, 51)),
    ("England", new(0, 63)),
    ("Kentucky", new(-4, 72)),
];

myPlot.Add.Ranges(ranges, horizontal: true);

myPlot.XLabel("Temperature (ºF)");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


