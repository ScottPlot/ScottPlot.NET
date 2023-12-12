---
Title: "Repeating Axis Line - ScottPlot 4.1 Cookbook"
Description: "Repeating axis lines allows to plot several axis lines, either horizontal or vertical, draggable or not, whose positions are linked"
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/repeatingaxisline_basics/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Repeating Axis Line"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/repeatingaxisline_basics/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/repeatingaxisline_basics.png"
---

<h2><a id='repeating-axis-line' href='/cookbook/4.1/recipes/repeatingaxisline_basics/'>Repeating Axis Line</a></h2>

Repeating axis lines allows to plot several axis lines, either horizontal or vertical, draggable or not, whose positions are linked

```cs
var plt = new ScottPlot.Plot(600, 400);

//Generate a single signal containing 3 harmonic signals
int sampleCount = 500;
double[] signal1 = ScottPlot.DataGen.Sin(sampleCount, 10);
double[] signal2 = ScottPlot.DataGen.Sin(sampleCount, 20);
double[] signal3 = ScottPlot.DataGen.Sin(sampleCount, 30);

double[] signal = new double[sampleCount];
for (int index = 0; index < sampleCount; index++)
{
    signal[index] = signal1[index] + signal2[index] + signal3[index];
}

// Plot the signal
plt.AddSignal(signal);

// Create a draggable RepeatingVLine with 5 lines spaced evenly by 50 X units, starting at position 0
// The first line will be thicker than the others
ScottPlot.Plottable.RepeatingVLine vlines1 = new();
vlines1.DragEnabled = true;
vlines1.count = 5;
vlines1.shift = 50;
vlines1.Color = System.Drawing.Color.Magenta;
vlines1.LineWidth = 2;
vlines1.LineStyle = LineStyle.Dash;
vlines1.PositionLabel = true;
vlines1.PositionLabelBackground = vlines1.Color;
vlines1.relativeposition = false;
plt.Add(vlines1);

// Create a draggable RepeatingVLine with 5 lines spaced evenly by 50 X units, starting at position 0, with a -4 offset
// The first line will be thicker than the others
ScottPlot.Plottable.RepeatingVLine vlines2 = new();
vlines2.DragEnabled = true;
vlines2.count = 3;
vlines2.shift = 50;
vlines2.offset = -1;
vlines2.Color = System.Drawing.Color.DarkGreen;
vlines2.LineWidth = 2;
vlines2.LineStyle = LineStyle.Dot;
vlines2.PositionLabel = true;
vlines2.PositionLabelBackground = vlines2.Color;
vlines2.relativeposition = false;
plt.Add(vlines2);

plt.SetAxisLimitsX(-100, 300);

plt.SaveFig("repeatingAxisLine_basics.png");
```

<img src='../../images/repeatingaxisline_basics.png' class='d-block mx-auto my-5' />


