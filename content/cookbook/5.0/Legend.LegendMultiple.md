---
Title: Multiple Legends - ScottPlot 5.0 Cookbook
Description: Multiple legends may be added to a plot
URL: /cookbook/5.0/Legend/LegendMultiple/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Multiple Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendMultiple"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Legends</h1>
</div>

Multiple legends may be added to a plot

[![](/cookbook/5.0/images/LegendMultiple.png?250112204022)](/cookbook/5.0/images/LegendMultiple.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendMultiple.png?250112204022" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double[] data = Generate.Sin(51, phase: .02 * i);
    var sig = myPlot.Add.Signal(data);
    sig.LegendText = $"Signal #{i}";
    sig.LineWidth = 2;
}

// default legend
var leg1 = myPlot.ShowLegend();
leg1.Alignment = Alignment.LowerRight;
leg1.Orientation = Orientation.Vertical;

// additional legend
var leg2 = myPlot.Add.Legend();
leg2.Alignment = Alignment.UpperCenter;
leg2.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


