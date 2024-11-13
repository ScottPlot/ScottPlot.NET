---
Title: SignalXY Generic - ScottPlot 5.0 Cookbook
Description: SignalXY plots support generic data types, although double is typically the most performant.
URL: /cookbook/5.0/SignalXY/SignalXYGeneric/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Generic"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYGeneric"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Generic</h1>
</div>

SignalXY plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalXYGeneric.png?241112193154)](/cookbook/5.0/images/SignalXYGeneric.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYGeneric.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List&lt;int&gt; xList = new();
List&lt;float&gt; yList = new();
for (int i = 0; i &lt; 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x =&gt; (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x =&gt; (float)x));
}
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


