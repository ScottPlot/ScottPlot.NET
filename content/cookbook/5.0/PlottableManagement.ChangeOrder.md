---
Title: Moving plottables - ScottPlot 5.0 Cookbook
Description: The plottable list contains all plottables which will be rendered in order. Helper methods are available to move plottables to the front.
URL: /cookbook/5.0/PlottableManagement/ChangeOrder/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Moving plottables"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/ChangeOrder"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/PlottableManagement/ChangeOrder'>Moving plottables</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/PlottableManagement/ChangeOrder">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/PlottableManagement">Category: Plottable Management</a>
</div>

The plottable list contains all plottables which will be rendered in order. Helper methods are available to move plottables to the front.

[![](/cookbook/5.0/images/ChangeOrder.png?241029205813)](/cookbook/5.0/images/ChangeOrder.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

CoordinateRect wideRect = new(-2, 2, -1, 1);
CoordinateRect tallRect = new(-1, 1, -2, 2);

// rect1 is added first, so plottables added later will appear on top
var rect1 = myPlot.Add.Rectangle(wideRect);
var rect2 = myPlot.Add.Rectangle(tallRect);

// plottables may be moved to the front so they always appear on top
myPlot.MoveToTop(rect1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


