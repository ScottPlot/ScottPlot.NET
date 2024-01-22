---
Title: Advanced Axis Features - ScottPlot 5.0 Cookbook
Description: How to further customize axes
URL: /cookbook/5.0/AdvancedAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Advanced Axis Features"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AdvancedAxis"]
Date: 2024-01-22
Version: ScottPlot 5.0.20
Version: ScottPlot 5.0.20
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Advanced Axis Features


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'>Inverted Axis</a></h2>

Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.

[![](/cookbook/5.0/images/InvertedAxis.png)](/cookbook/5.0/images/InvertedAxis.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.SetLimitsY(bottom: 1.5, top: -1.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AdvancedAxis/InvertedAutoAxis'>Inverted Auto-Axis</a></h2>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png)](/cookbook/5.0/images/InvertedAutoAxis.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

