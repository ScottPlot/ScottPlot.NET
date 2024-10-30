---
Title: SignalXY Generic - ScottPlot 5.0 Cookbook
Description: SignalXY plots support generic data types, although double is typically the most performant.
URL: /cookbook/5.0/SignalXY/SignalXYGeneric/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Generic"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYGeneric"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYGeneric'>SignalXY Generic</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYGeneric">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

SignalXY plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalXYGeneric.png?241029205813)](/cookbook/5.0/images/SignalXYGeneric.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<int> xList = new();
List<float> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x => (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x => (float)x));
}
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


