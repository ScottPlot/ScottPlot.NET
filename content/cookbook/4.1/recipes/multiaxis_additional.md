---
Title: "Additional Y Axis - ScottPlot 4.1 Cookbook"
Description: "Additional axes can be added on any edge. Additional axes stack away from the plot area."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/multiaxis_additional/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Multi-Axis", "Additional Y Axis"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/multi-axis", "/cookbook/4.1/recipes/multiaxis_additional/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/multiaxis_additional.png"
---

<h2><a id='additional-y-axis' href='/cookbook/4.1/recipes/multiaxis_additional/'>Additional Y Axis</a></h2>

Additional axes can be added on any edge. Additional axes stack away from the plot area.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot one set of data using the primary Y axis
var sigSmall = plt.AddSignal(DataGen.Sin(51, mult: 1));
sigSmall.YAxisIndex = plt.LeftAxis.AxisIndex;
plt.YAxis.Label("Primary Axis");
plt.YAxis.Color(sigSmall.Color);

// plot another set of data using an additional axis
var sigBig = plt.AddSignal(DataGen.Cos(51, mult: 100));
var yAxis3 = plt.AddAxis(Renderable.Edge.Left);
sigBig.YAxisIndex = yAxis3.AxisIndex;
yAxis3.Label("Additional Axis");
yAxis3.Color(sigBig.Color);

plt.SaveFig("multiAxis_additional.png");
```

<img src='../../images/multiaxis_additional.png' class='d-block mx-auto my-5' />


