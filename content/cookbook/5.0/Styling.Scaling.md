---
Title: Scale Factor - ScottPlot 5.0 Cookbook
Description: All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.
URL: /cookbook/5.0/Styling/Scaling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Scale Factor"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/Scaling"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scale Factor</h1>
</div>

All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.

[![](/cookbook/5.0/images/Scaling.png?241101192719)](/cookbook/5.0/images/Scaling.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


