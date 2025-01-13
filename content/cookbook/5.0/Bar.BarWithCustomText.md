---
Title: Bar with Custom Text - ScottPlot 5.0 Cookbook
Description: Full control over bar labels may be achieved by placing fully customizable text objects on top of bars according to their dimensions.
URL: /cookbook/5.0/Bar/BarWithCustomText/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar with Custom Text"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarWithCustomText"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar with Custom Text</h1>
</div>

Full control over bar labels may be achieved by placing fully customizable text objects on top of bars according to their dimensions.

[![](/cookbook/5.0/images/BarWithCustomText.png?250112204022)](/cookbook/5.0/images/BarWithCustomText.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarWithCustomText.png?250112204022" >}}ScottPlot.Plot myPlot = new();

ScottPlot.Palettes.Category10 palette = new();

// create 5 groups of stacked bars
for (int i = 0; i &lt; 5; i++)
{
    // create 3 individual bars with stacking
    List&lt;ScottPlot.Bar&gt; bars = [];
    double valueBase = 0;
    for (int j = 0; j &lt; 3; j++)
    {
        double barSize = Generate.RandomInteger(10, 20);
        ScottPlot.Bar bar1 = new()
        {
            FillColor = palette.GetColor(j),
            Position = i,
            ValueBase = valueBase,
            Value = valueBase + barSize,
            Label = $"{barSize}",
            CenterLabel = true,
        };

        bars.Add(bar1);
        valueBase += barSize;
    }

    // plot the stacked bars
    var barPlot = myPlot.Add.Bars(bars);
    barPlot.Horizontal = true;
}

// style the plot so the bars start on the left edge
myPlot.Axes.Margins(left: 0);

// add custom group labels
double[] tickPositions = Generate.Consecutive(5);
string[] tickLabels = Enumerable.Range(1, 5).Select(x =&gt; $"Worker #{x}").ToArray();
myPlot.Axes.Left.SetTicks(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


