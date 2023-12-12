---
Title: "NonLinear Tick Spacing - ScottPlot 4.1 Cookbook"
Description: "Plot data on regular cartesian space then manually control axis labels to give the appearance of non-linear spacing between points."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_nonlinearx/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "NonLinear Tick Spacing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_nonlinearx/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_nonlinearx.png"
---

<h2><a id='nonlinear-tick-spacing' href='/cookbook/4.1/recipes/ticks_nonlinearx/'>NonLinear Tick Spacing</a></h2>

Plot data on regular cartesian space then manually control axis labels to give the appearance of non-linear spacing between points.

```cs
var plt = new ScottPlot.Plot(600, 400);

// these are our nonlinear data values we wish to plot
double[] amplitudes = { 23.9, 24.2, 24.3, 24.5, 25.3, 26.3, 27.6, 31.4, 33.7, 36,
38.4, 42, 43.5, 46.1, 48.8, 51.5, 53.2, 55, 56.9, 58.7, 60.6 };
double[] frequencies = { 50, 63, 80, 100, 125, 160, 200, 250, 315, 400, 500, 630,
 800, 1000, 1250, 1600, 2000, 2500, 3150, 4000, 5000 };

// ignore the "real" X values and plot data at consecutive X values (0, 1, 2, 3...)
double[] positions = DataGen.Consecutive(frequencies.Length);
plt.AddScatter(positions, amplitudes);

// then define tick labels based on "real" X values, rotate them, and give them extra space
string[] labels = frequencies.Select(x => x.ToString()).ToArray();
plt.XAxis.ManualTickPositions(positions, labels);
plt.XAxis.TickLabelStyle(rotation: 45);
plt.XAxis.SetSizeLimit(min: 50); // extra space for rotated ticks

// apply axis labels, trigging a layout reset
plt.Title("Vibrational Coupling");
plt.YLabel("Amplitude (dB)");
plt.XLabel("Frequency (Hz)");

plt.SaveFig("ticks_nonLinearX.png");
```

<img src='../../images/ticks_nonlinearx.png' class='d-block mx-auto my-5' />


