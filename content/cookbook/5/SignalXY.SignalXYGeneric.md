---
Title: SignalXY Generic Array - ScottPlot 5 Cookbook
Description: SignalXY plots support arrays with generic data types, although double is typically the most performant.
URL: /cookbook/5/SignalXY/SignalXYGeneric/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "SignalXY Plot", "SignalXY Generic Array"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/SignalXY", "/cookbook/5/SignalXY/SignalXYGeneric"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Generic Array</h1>
</div>

SignalXY plots support arrays with generic data types, although double is typically the most performant.

[![](/cookbook/5/images/SignalXYGeneric.png?260329072039)](/cookbook/5/images/SignalXYGeneric.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5/images/SignalXYGeneric.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List&lt;int&gt; xList = new();
List&lt;float&gt; yList = new();
for (int i = 0; i &lt; 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x =&gt; (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x =&gt; (float)x));
}

// this example converts
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/SignalXY'>SignalXY Plot</a> category</div>


