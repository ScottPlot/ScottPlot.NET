---
Title: Polar Axis Spoke Labels - ScottPlot 5.0 Cookbook
Description: Polar axis spokes may be individually labeled.
URL: /cookbook/5.0/Polar/PolarSpokeLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Spoke Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Polar", "/cookbook/5.0/Polar/PolarSpokeLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Polar/PolarSpokeLabels'>Polar Axis Spoke Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Polar/PolarSpokeLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Polar">Category: Polar Axis</a>
</div>

Polar axis spokes may be individually labeled.

[![](/cookbook/5.0/images/PolarSpokeLabels.png?241031194635)](/cookbook/5.0/images/PolarSpokeLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

string[] labels = { "alpha", "beta", "gamma", "delta", "epsilon" };
polarAxis.SetSpokes(labels, 1.1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


