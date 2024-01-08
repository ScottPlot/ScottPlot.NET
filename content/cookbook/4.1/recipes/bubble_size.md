---
Title: "Bubble Size - ScottPlot 4.1 Cookbook"
Description: "The size of bubbles are defined in pixel units by default. However, it is possible to define the size of bubbles using the same units the coordinate system and axes use. If using axis units, users may want to enable the axis scale lock feature to enforce bubble circularity."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bubble_size/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bubble Plot", "Bubble Size"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bubble", "/cookbook/4.1/recipes/bubble_size/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bubble_size.png"
---

<h2><a id='bubble-size' href='/cookbook/4.1/recipes/bubble_size/'>Bubble Size</a></h2>

The size of bubbles are defined in pixel units by default. However, it is possible to define the size of bubbles using the same units the coordinate system and axes use. If using axis units, users may want to enable the axis scale lock feature to enforce bubble circularity.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(31);
double[] ys = DataGen.Sin(31, mult: 5);
var colormap = Drawing.Colormap.Viridis;

var myBubblePlot = plt.AddBubblePlot();
for (int i = 0; i < xs.Length; i++)
{
    double fraction = (double)i / xs.Length;
    myBubblePlot.Add(
        x: xs[i],
        y: ys[i],
        radius: .5 + i * .05f,
        fillColor: colormap.GetColor(fraction, alpha: .8),
        edgeColor: System.Drawing.Color.Black,
        edgeWidth: 2
    );
}

// indicate radius is coordinate units
myBubblePlot.RadiusIsPixels = false;

// Enable the axis scale lock to force bubbles to be circular:
//plt.AxisScaleLock(true, EqualScaleMode.PreserveLargest);

plt.Title("Advanced Bubble Plot");

plt.SaveFig("bubble_size.png");
```

<img src='../../images/bubble_size.png' class='d-block mx-auto my-5' />


