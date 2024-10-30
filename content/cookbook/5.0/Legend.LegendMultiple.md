---
Title: Multiple Legends - ScottPlot 5.0 Cookbook
Description: Multiple legends may be added to a plot
URL: /cookbook/5.0/Legend/LegendMultiple/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Multiple Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendMultiple"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendMultiple'>Multiple Legends</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendMultiple">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Multiple legends may be added to a plot

[![](/cookbook/5.0/images/LegendMultiple.png?241029205813)](/cookbook/5.0/images/LegendMultiple.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i <= 5; i++)
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

<hr class='my-5 invisible'>


