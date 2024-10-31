---
Title: Horizontal Lollipop Plot - ScottPlot 5.0 Cookbook
Description: Change the lollipop plot's Orientation to Horizontal to cause stems to be drawn horizontally instead of vertically.
URL: /cookbook/5.0/Lollipop/LollipopHorizontal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Horizontal Lollipop Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/LollipopHorizontal"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/LollipopHorizontal'>Horizontal Lollipop Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/LollipopHorizontal">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

Change the lollipop plot's Orientation to Horizontal to cause stems to be drawn horizontally instead of vertically.

[![](/cookbook/5.0/images/LollipopHorizontal.png?241031194635)](/cookbook/5.0/images/LollipopHorizontal.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Sin(21);
double[] ys = Generate.Consecutive(21);
Coordinates[] coordinates = Coordinates.Zip(xs, ys);

var lollipop = myPlot.Add.Lollipop(coordinates);
lollipop.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


