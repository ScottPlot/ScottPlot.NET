---
Title: "Manual Ticks - ScottPlot 4.1 Cookbook"
Description: "Full customization of ticks can be achieved using the ManualTickCollection helper class."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_manual/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Manual Ticks"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_manual/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_manual.png"
---

<h2><a id='manual-ticks' href='/cookbook/4.1/recipes/ticks_manual/'>Manual Ticks</a></h2>

Full customization of ticks can be achieved using the ManualTickCollection helper class.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// use a helper class to build a colelction of major and minor ticks
ScottPlot.Ticks.ManualTickCollection tc = new();

// add major ticks with their labels
tc.AddMajor(0, "zero");
tc.AddMajor(20, "twenty");
tc.AddMajor(50, "fifty");

// add minor ticks
tc.AddMinor(22);
tc.AddMinor(25);
tc.AddMinor(32);
tc.AddMinor(35);
tc.AddMinor(42);
tc.AddMinor(45);

// get the tick array and apply it to the axis
ScottPlot.Ticks.Tick[] ticks = tc.GetTicks();
plt.BottomAxis.SetTicks(ticks);

plt.SaveFig("ticks_manual.png");
```

<img src='../../images/ticks_manual.png' class='d-block mx-auto my-5' />


