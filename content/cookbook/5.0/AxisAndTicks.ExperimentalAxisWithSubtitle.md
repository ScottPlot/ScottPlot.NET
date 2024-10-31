---
Title: Axis with Subtitle - ScottPlot 5.0 Cookbook
Description: Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.
URL: /cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Axis with Subtitle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle'>Axis with Subtitle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.

[![](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241031194635)](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Plot some sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Instantiate a custom axis and customize it as desired
ScottPlot.AxisPanels.Experimental.LeftAxisWithSubtitle customAxisY = new()
{
    LabelText = "My Custom Y Axis",
    SubLabelText = "It comes with a subtitle for the axis"
};

// Remove the default Y axis and add the custom one to the plot
myPlot.Axes.Remove(myPlot.Axes.Left);
myPlot.Axes.AddLeftAxis(customAxisY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


