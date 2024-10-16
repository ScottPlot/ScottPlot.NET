---
Title: Population Groups - ScottPlot 5.0 Cookbook
Description: Groups of populations can be achieved by customizing position, color, axis labels, and legend items.
URL: /cookbook/5.0/Population/PopulationGroups/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Groups"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationGroups"]
Date: 2024-10-16
Version: ScottPlot 5.0.40
Version: ScottPlot 5.0.40
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Population Groups


Groups of populations can be achieved by customizing position, color, axis labels, and legend items.

[![](/cookbook/5.0/images/PopulationGroups.png?241016194708)](/cookbook/5.0/images/PopulationGroups.png?241016194708)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

