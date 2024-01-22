---
Title: "Labeled Marker - ScottPlot 4.1 Cookbook"
Description: "Markers have an optional text label."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/marker_labeled/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Labeled Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_labeled/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_labeled.png"
---

<h2><a id='labeled-marker' href='/cookbook/4.1/recipes/marker_labeled/'>Labeled Marker</a></h2>

Markers have an optional text label.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));

var marker = plt.AddMarker(35, 0.6);
marker.Text = "Interesting Point";
marker.TextFont.Color = Color.Magenta;
marker.TextFont.Alignment = Alignment.UpperCenter;
marker.TextFont.Size = 28;

plt.SaveFig("marker_labeled.png");
```

{{< /code-sp4 >}}

<img src='../../images/marker_labeled.png' class='d-block mx-auto my-5' />


