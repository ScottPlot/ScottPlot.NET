---
Title: "Bubble Plot - ScottPlot 4.1 Cookbook"
Description: "Bubble plots display circles at specific X/Y locations. Each circle can be individually customized. Save the object that is returned when the bubble plot is created and call its Add() method to add bubbles."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bubble_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bubble Plot", "Bubble Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bubble", "/cookbook/4.1/recipes/bubble_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bubble_quickstart.png"
---

<h2><a id='bubble-plot' href='/cookbook/4.1/recipes/bubble_quickstart/'>Bubble Plot</a></h2>

Bubble plots display circles at specific X/Y locations. Each circle can be individually customized. Save the object that is returned when the bubble plot is created and call its Add() method to add bubbles.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(31);
double[] ys = DataGen.Sin(31);
var colormap = Drawing.Colormap.Viridis;

var myBubblePlot = plt.AddBubblePlot();
for (int i = 0; i < xs.Length; i++)
{
    double fraction = (double)i / xs.Length;
    myBubblePlot.Add(
        x: xs[i],
        y: ys[i],
        radius: 10 + i,
        fillColor: colormap.GetColor(fraction, alpha: .8),
        edgeColor: System.Drawing.Color.Black,
        edgeWidth: 2
    );
}

plt.Title("Advanced Bubble Plot");
plt.AxisAuto(.2, .25); // zoom out to accommodate large bubbles

plt.SaveFig("bubble_quickstart.png");
```

<img src='../../images/bubble_quickstart.png' class='d-block mx-auto my-5' />


