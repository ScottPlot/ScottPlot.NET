---
Title: Lollipop Plot - ScottPlot 5.0 Cookbook
Description: A lollipop chart is a variation of a bar chart that uses a line (stem) extending from a baseline to a marker (head) to represent data points. Lollipop highlight individual data points with less visual clutter than to traditional bar charts.
URL: /cookbook/5.0/Lollipop/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Lollipop Plot</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/LollipopQuickStart'>Lollipop Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/LollipopQuickStart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5.0/images/LollipopQuickStart.png?241031194635)](/cookbook/5.0/images/LollipopQuickStart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/LollipopPositions'>Lollipop Positions</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/LollipopPositions">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

The position of each lollipop may be defined.

[![](/cookbook/5.0/images/LollipopPositions.png?241031194635)](/cookbook/5.0/images/LollipopPositions.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/BarLollipopCustom'>Lollipop Plot Customizations</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/BarLollipopCustom">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

The stem line and head marker can be extensively customized.

[![](/cookbook/5.0/images/BarLollipopCustom.png?241031194635)](/cookbook/5.0/images/BarLollipopCustom.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(21);
var lollipop = myPlot.Add.Lollipop(values);

lollipop.MarkerColor = Colors.Red;
lollipop.MarkerSize = 15;
lollipop.MarkerShape = MarkerShape.FilledDiamond;

lollipop.LineColor = Colors.Green;
lollipop.LineWidth = 3;
lollipop.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



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


