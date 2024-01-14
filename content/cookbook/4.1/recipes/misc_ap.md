---
Title: "Action Potential - ScottPlot 4.1 Cookbook"
Description: "The raw trace (voltage) and first derivative (voltage change / time) of a mammalian action potential."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/misc_ap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Miscellaneous", "Action Potential"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/misc", "/cookbook/4.1/recipes/misc_ap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_ap.png"
---

<h2><a id='action-potential' href='/cookbook/4.1/recipes/misc_ap/'>Action Potential</a></h2>

The raw trace (voltage) and first derivative (voltage change / time) of a mammalian action potential.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// obtain a signal for the voltage
double[] ap = DataGen.ActionPotential();
plt.Title("Neuronal Action Potential");

// data is sampled at 20 kHz but we want to display ms units
int sampleRate = 20;
plt.XAxis.Label("Time (milliseconds)");

// plot the voltage in blue on the primary Y axis
var sig1 = plt.AddSignal(ap, sampleRate);
sig1.YAxisIndex = 0;
sig1.LineWidth = 3;
sig1.Color = Color.Blue;
plt.YAxis.Label("Membrane Potential (mV)");
plt.YAxis.Color(Color.Blue);

// calculate the first derivative
double[] deriv = new double[ap.Length];
for (int i = 1; i < deriv.Length; i++)
    deriv[i] = (ap[i] - ap[i - 1]) * sampleRate;
deriv[0] = deriv[1];

// plot the first derivative in red on the secondary Y axis
var sig2 = plt.AddSignal(deriv, sampleRate);
sig2.YAxisIndex = 1;
sig2.LineWidth = 3;
sig2.Color = Color.FromArgb(120, Color.Red);
plt.YAxis2.Label("Rate of Change (mV/ms)");
plt.YAxis2.Color(Color.Red);
plt.YAxis2.Ticks(true);

// zoom in on the interesting area
plt.SetAxisLimits(40, 60);

plt.SaveFig("misc_ap.png");
```

{{< /code-sp4 >}}

<img src='../../images/misc_ap.png' class='d-block mx-auto my-5' />


