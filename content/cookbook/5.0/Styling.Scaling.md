---
Title: Scale Factor - ScottPlot 5.0 Cookbook
Description: All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.
URL: /cookbook/5.0/Styling/Scaling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Scale Factor"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Scaling"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/Scaling'>Scale Factor</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/Scaling">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.

[![](/cookbook/5.0/images/Scaling.png?241031194635)](/cookbook/5.0/images/Scaling.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


