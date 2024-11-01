---
Title: Population Groups - ScottPlot 5.0 Cookbook
Description: Groups of populations can be achieved by customizing position, color, axis labels, and legend items.
URL: /cookbook/5.0/Population/PopulationGroups/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Groups"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationGroups"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Groups</h1>
</div>

Groups of populations can be achieved by customizing position, color, axis labels, and legend items.

[![](/cookbook/5.0/images/PopulationGroups.png?241101192719)](/cookbook/5.0/images/PopulationGroups.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// define the groups
string[] groupNames = { "Gen X", "Gen Y", "Gen Z" };
string[] categoryNames = { "Python", "C#", "Rust" };
Color[] categoryColors = { Colors.C0, Colors.C1, Colors.C2 };

// add random data to the plot
for (int groupIndex = 0; groupIndex < groupNames.Length; groupIndex++)
{
    for (int categoryIndex = 0; categoryIndex < categoryNames.Length; categoryIndex++)
    {
        double[] values = Generate.RandomNormal(10, mean: 2 + groupIndex * 2);
        double x = groupIndex * (categoryNames.Length + 1) + categoryIndex;
        var pop = myPlot.Add.Population(values, x);
        pop.Marker.MarkerLineColor = categoryColors[categoryIndex].WithAlpha(.75);
        pop.Marker.Size = 7;
        pop.Marker.LineWidth = 1.5f;
        pop.Bar.FillColor = categoryColors[categoryIndex];
    }
}

// apply group names to horizontal tick labels
double tickDelta = categoryNames.Length + 1;
double[] tickPositions = Enumerable.Range(0, groupNames.Length)
    .Select(x => x * tickDelta + tickDelta / 2 - 1)
    .ToArray();
myPlot.Axes.Bottom.SetTicks(tickPositions, groupNames);
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;

// show category colors in the legend
for (int i = 0; i < categoryNames.Length; i++)
{
    LegendItem item = new()
    {
        FillColor = categoryColors[i],
        LabelText = categoryNames[i]
    };
    myPlot.Legend.ManualItems.Add(item);
}
myPlot.Legend.Orientation = Orientation.Horizontal;
myPlot.Legend.Alignment = Alignment.UpperLeft;

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0, top: 0.3);
myPlot.YLabel("Bugs per Hour");
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Population'>Population Plot</a> category</div>


