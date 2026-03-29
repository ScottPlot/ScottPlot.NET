---
Title: Horizontal Lollipop Plot - ScottPlot 5 Cookbook
Description: Change the lollipop plot's Orientation to Horizontal to cause stems to be drawn horizontally instead of vertically.
URL: /cookbook/5/Lollipop/LollipopHorizontal/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Lollipop Plot", "Horizontal Lollipop Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Lollipop", "/cookbook/5/Lollipop/LollipopHorizontal"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Horizontal Lollipop Plot</h1>
</div>

Change the lollipop plot's Orientation to Horizontal to cause stems to be drawn horizontally instead of vertically.

[![](/cookbook/5/images/LollipopHorizontal.png?260329072039)](/cookbook/5/images/LollipopHorizontal.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/LollipopHorizontal.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Sin(21);
double[] ys = Generate.Consecutive(21);
Coordinates[] coordinates = Coordinates.Zip(xs, ys);

var lollipop = myPlot.Add.Lollipop(coordinates);
lollipop.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Lollipop'>Lollipop Plot</a> category</div>


