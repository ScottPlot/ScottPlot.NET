---
Title: SignalXY Generic List - ScottPlot 5.0 Cookbook
Description: SignalXY plots support generic lists.
URL: /cookbook/5.0/SignalXY/SignalXYGenericList/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Generic List"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYGenericList"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Generic List</h1>
</div>

SignalXY plots support generic lists.

[![](/cookbook/5.0/images/SignalXYGenericList.png?250822231048)](/cookbook/5.0/images/SignalXYGenericList.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYGenericList.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// create X and Y list with initial data
List&lt;double&gt; xs = new(Generate.Consecutive(count: 10, first: 0));
List&lt;double&gt; ys = new(Generate.RandomSample(10));

// create a signal plot from our X and Y lists
myPlot.Add.SignalXY(xs, ys);

// data can be added to lists later
xs.AddRange(Generate.Consecutive(count: 10, first: 50));
ys.AddRange(Generate.RandomSample(10));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


