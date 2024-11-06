---
Title: Scatter Plot of List Data - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.
URL: /cookbook/5.0/Scatter/ScatterList/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Plot of List Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterList"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot of List Data</h1>
</div>

Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.

[![](/cookbook/5.0/images/ScatterList.png?241105214550)](/cookbook/5.0/images/ScatterList.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterList.png?241105214550" >}}ScottPlot.Plot myPlot = new();

List&lt;double&gt; xs = new() { 1, 2, 3, 4, 5 };
List&lt;double&gt; ys = new() { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


