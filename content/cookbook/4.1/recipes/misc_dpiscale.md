---
Title: "Display Scaling - ScottPlot 4.1 Cookbook"
Description: "When display scaling is enabled the dots per inch (DPI) is changed so images appear larger. When scaling is increased bitmap images are stretched to appear larger, but may appear blurry as a result. Alternatively images could be increased in size when DPI scaling is enabled, but fonts and lines may appear small. This example shows how to increase the size of common plot components so they look good on high resolution scaled displays (e.g., 4K monitors). DPI stretching can be set in the user control's Configuration module."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/misc_dpiscale/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Miscellaneous", "Display Scaling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/misc", "/cookbook/4.1/recipes/misc_dpiscale/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/misc_dpiscale.png"
---

<h2><a id='display-scaling' href='/cookbook/4.1/recipes/misc_dpiscale/'>Display Scaling</a></h2>

When display scaling is enabled the dots per inch (DPI) is changed so images appear larger. When scaling is increased bitmap images are stretched to appear larger, but may appear blurry as a result. Alternatively images could be increased in size when DPI scaling is enabled, but fonts and lines may appear small. This example shows how to increase the size of common plot components so they look good on high resolution scaled displays (e.g., 4K monitors). DPI stretching can be set in the user control's Configuration module.

```cs
var plt = new ScottPlot.Plot(600, 400);

var sig1 = plt.AddSignal(DataGen.Sin(51));
sig1.Label = "Sin";
sig1.MarkerSize = 7;
sig1.LineWidth = 2;

var sig2 = plt.AddSignal(DataGen.Cos(51));
sig2.Label = "Cos";
sig2.MarkerSize = 7;
sig2.LineWidth = 2;

var legend = plt.Legend();
legend.FontSize = 24;

plt.Title("Plot with Large Features");
plt.YLabel("Vertical Axis");
plt.XLabel("Horizontal Axis");

plt.YAxis.LabelStyle(fontSize: 24);
plt.XAxis.LabelStyle(fontSize: 24);
plt.XAxis2.LabelStyle(fontSize: 36);

plt.YAxis.TickLabelStyle(fontSize: 18);
plt.XAxis.TickLabelStyle(fontSize: 18);

plt.YAxis.MajorGrid(lineWidth: 2);
plt.XAxis.MajorGrid(lineWidth: 2);

plt.SaveFig("misc_dpiScale.png");
```

<img src='../../images/misc_dpiscale.png' class='d-block mx-auto my-5' />


