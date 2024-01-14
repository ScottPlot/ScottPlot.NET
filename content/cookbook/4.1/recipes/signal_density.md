---
Title: "Display data density - ScottPlot 4.1 Cookbook"
Description: "When plotting extremely high density data, you can't always see the trends underneath all those overlapping data points. If you send an array of colors to PlotSignal(), it will use those colors to display density."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signal_density/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Display data density"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_density/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_density.png"
---

<h2><a id='display-data-density' href='/cookbook/4.1/recipes/signal_density/'>Display data density</a></h2>

When plotting extremely high density data, you can't always see the trends underneath all those overlapping data points. If you send an array of colors to PlotSignal(), it will use those colors to display density.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create an extremely noisy signal with a subtle sine wave beneath it
Random rand = new Random(0);
int pointCount = 100_000;
double[] signal1 = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 5);
double[] data = new double[pointCount];
for (int i = 0; i < data.Length; i++)
    data[i] = signal1[i] + noise[i];

// plot the noisy signal using the traditional method
var sp1 = plt.AddSignal(data);
sp1.OffsetY = -40;
sp1.Color = Color.Red;

// use a custom colors to display data of different densities
string[] colorCodes = { "#440154", "#39568C", "#1F968B", "#73D055" };
Color[] colors = colorCodes.Select(x => ColorTranslator.FromHtml(x)).ToArray();

var sp2 = plt.AddSignal(data);
sp2.DensityColors = colors;
sp2.Color = colors[0];

plt.Title("Color by Density vs. Solid Color");
plt.AxisAuto(0, .1);

plt.SaveFig("signal_density.png");
```

{{< /code-sp4 >}}

<img src='../../images/signal_density.png' class='d-block mx-auto my-5' />


