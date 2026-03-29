---
Title: FillY with Custom Type - ScottPlot 5 Cookbook
Description: FillY plots can be created from data of any type if a conversion function is supplied.
URL: /cookbook/5/FillY/Function/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "FillY plot", "FillY with Custom Type"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/FillY", "/cookbook/5/FillY/Function"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>FillY with Custom Type</h1>
</div>

FillY plots can be created from data of any type if a conversion function is supplied.

[![](/cookbook/5/images/Function.png?260329072039)](/cookbook/5/images/Function.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5/images/Function.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// create source data in a nonstandard data type
List&lt;(int, int, int)&gt; data = new();
Random rand = new(0);
for (int i = 0; i &lt; 10; i++)
{
    int x = i;
    int y1 = rand.Next(0, 10);
    int y2 = rand.Next(20, 30);
    data.Add((x, y1, y2));
}

// create a custom converter for the source data type
static (double, double, double) MyConverter((int, int, int) s) =&gt; (s.Item1, s.Item2, s.Item3);

// create a filled plot from source data using the custom converter
var fill = myPlot.Add.FillY(data, MyConverter);
fill.FillColor = Colors.Blue.WithAlpha(.2);
fill.LineColor = Colors.Blue;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/FillY'>FillY plot</a> category</div>


