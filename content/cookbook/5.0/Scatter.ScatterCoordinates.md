---
Title: Scatter Plot Coordinates - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created from a collection of Coordinates.
URL: /cookbook/5.0/Scatter/ScatterCoordinates/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot Coordinates"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterCoordinates"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Coordinates</h1>
</div>

Scatter plots can be created from a collection of Coordinates.

[![](/cookbook/5.0/images/ScatterCoordinates.png?241101192719)](/cookbook/5.0/images/ScatterCoordinates.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

Coordinates[] coordinates =
{
    new(1, 1),
    new(2, 4),
    new(3, 9),
    new(4, 16),
    new(5, 25),
};

myPlot.Add.Scatter(coordinates);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


