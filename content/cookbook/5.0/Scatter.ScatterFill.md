---
Title: Scatter Plot with Fill - ScottPlot 5.0 Cookbook
Description: The area beneath a scatter plot can be filled.
URL: /cookbook/5.0/Scatter/ScatterFill/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot with Fill"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterFill"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Fill</h1>
</div>

The area beneath a scatter plot can be filled.

[![](/cookbook/5.0/images/ScatterFill.png?241124170640)](/cookbook/5.0/images/ScatterFill.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFill.png?241124170640" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYColor = sp.Color.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


