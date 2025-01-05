---
Title: Moving plottables - ScottPlot 5.0 Cookbook
Description: The plottable list contains all plottables which will be rendered in order. Helper methods are available to move plottables to the front.
URL: /cookbook/5.0/PlottableManagement/ChangeOrder/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Plottable Management", "Moving plottables"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PlottableManagement", "/cookbook/5.0/PlottableManagement/ChangeOrder"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Moving plottables</h1>
</div>

The plottable list contains all plottables which will be rendered in order. Helper methods are available to move plottables to the front.

[![](/cookbook/5.0/images/ChangeOrder.png?250105183901)](/cookbook/5.0/images/ChangeOrder.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/PlottableManagement.cs" imageUrl="/cookbook/5.0/images/ChangeOrder.png?250105183901" >}}ScottPlot.Plot myPlot = new();

CoordinateRect wideRect = new(-2, 2, -1, 1);
CoordinateRect tallRect = new(-1, 1, -2, 2);

// rect1 is added first, so plottables added later will appear on top
var rect1 = myPlot.Add.Rectangle(wideRect);
var rect2 = myPlot.Add.Rectangle(tallRect);

// plottables may be moved to the front so they always appear on top
myPlot.MoveToTop(rect1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PlottableManagement'>Plottable Management</a> category</div>


