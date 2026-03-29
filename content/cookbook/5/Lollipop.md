---
Title: Lollipop Plot - ScottPlot 5 Cookbook
Description: A lollipop chart is a variation of a bar chart that uses a line (stem) extending from a baseline to a marker (head) to represent data points. Lollipop highlight individual data points with less visual clutter than to traditional bar charts.
URL: /cookbook/5/Lollipop/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Lollipop Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Lollipop"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---

<h1>Lollipop Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Plot Quickstart</h1>
<a href='/cookbook/5/Lollipop/LollipopQuickStart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5/images/LollipopQuickStart.png?260329072039)](/cookbook/5/images/LollipopQuickStart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/LollipopQuickStart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Positions</h1>
<a href='/cookbook/5/Lollipop/LollipopPositions' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The position of each lollipop may be defined.

[![](/cookbook/5/images/LollipopPositions.png?260329072039)](/cookbook/5/images/LollipopPositions.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/LollipopPositions.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Range(0, 6.28, 0.314);
double[] ys = xs.Select(Math.Sin).ToArray();
var lollipop = myPlot.Add.Lollipop(ys, xs);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Plot Customizations</h1>
<a href='/cookbook/5/Lollipop/BarLollipopCustom' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The stem line and head marker can be extensively customized.

[![](/cookbook/5/images/BarLollipopCustom.png?260329072039)](/cookbook/5/images/BarLollipopCustom.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/BarLollipopCustom.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Horizontal Lollipop Plot</h1>
<a href='/cookbook/5/Lollipop/LollipopHorizontal' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
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

<hr class='my-5 invisible'>


