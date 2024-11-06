---
Title: Axis with Subtitle - ScottPlot 5.0 Cookbook
Description: Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.
URL: /cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Axis with Subtitle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis with Subtitle</h1>
</div>

Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.

[![](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241105214550)](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


