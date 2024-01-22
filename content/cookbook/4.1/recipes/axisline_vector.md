---
Title: "Axis Line Vector - ScottPlot 4.1 Cookbook"
Description: "An AxisLineVector allows to setup a series of VLines or HLines, without hassle.These lines can optionally be dragged as their counterparts"
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/axisline_vector/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Axis Line Vector"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_vector/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_vector.png"
---

<h2><a id='axis-line-vector' href='/cookbook/4.1/recipes/axisline_vector/'>Axis Line Vector</a></h2>

An AxisLineVector allows to setup a series of VLines or HLines, without hassle.These lines can optionally be dragged as their counterparts

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
double[] xs = DataGen.Random(rand, 50);
double[] ys = DataGen.Random(rand, 50);

var scatter = plt.AddScatterPoints(xs, ys, Color.Blue, 10);

var vlines = new ScottPlot.Plottable.VLineVector();
vlines.Xs = new double[] { xs[1], xs[12], xs[35] };
vlines.Color = Color.Red;
vlines.PositionLabel = true;
vlines.PositionLabelBackground = vlines.Color;

var hlines = new ScottPlot.Plottable.HLineVector();
hlines.Ys = new double[] { ys[1], ys[12], ys[35] };
hlines.Color = Color.DarkCyan;
hlines.PositionLabel = true;
hlines.PositionLabelBackground = hlines.Color;
hlines.DragEnabled = true;

plt.Add(scatter);
plt.Add(vlines);
plt.Add(hlines);

plt.SaveFig("axisLine_Vector.png");
```

{{< /code-sp4 >}}

<img src='../../images/axisline_vector.png' class='d-block mx-auto my-5' />


