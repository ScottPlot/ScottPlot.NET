---
Title: "Labeled Marker - ScottPlot 4.1 Cookbook"
Description: "Markers have an optional text label."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/marker_labeled/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Labeled Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_labeled/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_labeled.png"
---

<h2><a href='/cookbook/4.1/recipes/marker_labeled/'>Labeled Marker</a></h2>

Markers have an optional text label.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));

var marker = plt.AddMarker(35, 0.6);
marker.Text = "Interesting Point";
marker.TextFont.Color = Color.Magenta;
marker.TextFont.Alignment = Alignment.UpperCenter;
marker.TextFont.Size = 28;

plt.SaveFig("marker_labeled.png");
```

<img src='../../images/marker_labeled.png' class='d-block mx-auto my-5' />


