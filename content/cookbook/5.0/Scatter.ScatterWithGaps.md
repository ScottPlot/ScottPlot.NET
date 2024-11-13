---
Title: Scatter with Gaps - ScottPlot 5.0 Cookbook
Description: NaN values in a scatter plot's data will appear as gaps in the line.
URL: /cookbook/5.0/Scatter/ScatterWithGaps/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter with Gaps"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterWithGaps"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter with Gaps</h1>
</div>

NaN values in a scatter plot's data will appear as gaps in the line.

[![](/cookbook/5.0/images/ScatterWithGaps.png?241112193154)](/cookbook/5.0/images/ScatterWithGaps.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterWithGaps.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

// long stretch of empty data
for (int i = 10; i &lt; 20; i++)
    ys[i] = double.NaN;

// single missing data point
ys[30] = double.NaN;

// single floating data point
for (int i = 35; i &lt; 40; i++)
    ys[i] = double.NaN;
for (int i = 40; i &lt; 45; i++)
    ys[i] = double.NaN;

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


