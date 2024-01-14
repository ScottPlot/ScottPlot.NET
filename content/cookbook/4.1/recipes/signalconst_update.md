---
Title: "SignalConst Data Updates - ScottPlot 4.1 Cookbook"
Description: "SignalConst is fast because it pre-processes data, but changing data requires additional processing before it can be rendered properly. Use the SignalPlot's Update() function to update data values instead of modifying contents of the original array that was used to create the signal plot."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalconst_update/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalConst", "SignalConst Data Updates"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalconst", "/cookbook/4.1/recipes/signalconst_update/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalconst_update.png"
---

<h2><a id='signalconst-data-updates' href='/cookbook/4.1/recipes/signalconst_update/'>SignalConst Data Updates</a></h2>

SignalConst is fast because it pre-processes data, but changing data requires additional processing before it can be rendered properly. Use the SignalPlot's Update() function to update data values instead of modifying contents of the original array that was used to create the signal plot.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.Sin(51);
var sig = plt.AddSignalConst(values);

// update a single point
sig.Update(20, 3);

// update a small range of values
double[] newYs = { 4, 3, 2, 1 };
sig.Update(30, newYs);

plt.SaveFig("signalconst_update.png");
```

{{< /code-sp4 >}}

<img src='../../images/signalconst_update.png' class='d-block mx-auto my-5' />


