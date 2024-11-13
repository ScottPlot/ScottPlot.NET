---
Title: Stacked Bar Chart - ScottPlot 5.0 Cookbook
Description: Bars can be stacked to present data in groups.
URL: /cookbook/5.0/Bar/StackedBars/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Stacked Bar Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/StackedBars"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Bar Chart</h1>
</div>

Bars can be stacked to present data in groups.

[![](/cookbook/5.0/images/StackedBars.png?241112193154)](/cookbook/5.0/images/StackedBars.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/StackedBars.png?241112193154" >}}ScottPlot.Plot myPlot = new();

string[] categoryNames = { "Phones", "Computers", "Tablets" };
Color[] categoryColors = { Colors.C0, Colors.C1, Colors.C2 };

for (int x = 0; x &lt; 4; x++)
{
    double[] values = Generate.RandomSample(categoryNames.Length, 1000, 5000);

    double nextBarBase = 0;

    for (int i = 0; i &lt; values.Length; i++)
    {
        ScottPlot.Bar bar = new()
        {
            Value = nextBarBase + values[i],
            FillColor = categoryColors[i],
            ValueBase = nextBarBase,
            Position = x,
        };

        myPlot.Add.Bar(bar);

        nextBarBase += values[i];
    }
}

// use custom tick labels on the bottom
ScottPlot.TickGenerators.NumericManual tickGen = new();
for (int x = 0; x &lt; 4; x++)
{
    tickGen.AddMajor(x, $"Q{x + 1}");
}
myPlot.Axes.Bottom.TickGenerator = tickGen;

// display groups in the legend
for (int i = 0; i &lt; 3; i++)
{
    LegendItem item = new()
    {
        LabelText = categoryNames[i],
        FillColor = categoryColors[i]
    };
    myPlot.Legend.ManualItems.Add(item);
}
myPlot.Legend.Orientation = Orientation.Horizontal;
myPlot.ShowLegend(Alignment.UpperRight);

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0, top: .3);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


