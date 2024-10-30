---
Title: Population Plot - ScottPlot 5.0 Cookbook
Description: Population plots display collections of individual values.
URL: /cookbook/5.0/Population/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Population Plot</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationQuickstart'>Population Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

A Population can be created from a collection of values, styled as desired, and placed anywhere on the plot.

[![](/cookbook/5.0/images/PopulationQuickstart.png?241029205813)](/cookbook/5.0/images/PopulationQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    myPlot.Add.Population(values, x: i);
}

// make the bottom of the plot snap to zero by default
myPlot.Axes.Margins(bottom: 0);

// replace the default numeric ticks with custom ones
double[] tickPositions = Generate.Consecutive(5);
string[] tickLabels = Enumerable.Range(1, 5).Select(x => $"Group {x}").ToArray();
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

// refine appearance of the plot
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBox'>Population Box Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBox">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

Population statistics can be displayed using box plots.

[![](/cookbook/5.0/images/PopulationBox.png?241029205813)](/cookbook/5.0/images/PopulationBox.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    // disable visibility of the bar symbol
    pop.Bar.IsVisible = false;

    // enable visibility of the box symbol
    pop.Box.IsVisible = true;
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBoxValues'>Population Box Values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBoxValues">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The values displayed by the box midline, body, and whisker can be configured by assigning a static function to the box value configuration property.

[![](/cookbook/5.0/images/PopulationBoxValues.png?241029205813)](/cookbook/5.0/images/PopulationBoxValues.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);
    pop.Bar.IsVisible = false;
    pop.Box.IsVisible = true;

    pop.BoxValueConfig = PopulationSymbol.BoxValueConfigurator_MeanStdErrStDev;
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBarStyle'>Population Bar Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBarStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The bar symbol in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationBarStyle.png?241029205813)](/cookbook/5.0/images/PopulationBarStyle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.Bar.FillColor = pop.Marker.MarkerLineColor.WithAlpha(.5);
    pop.Bar.LineWidth = 2;
    pop.Bar.ErrorNegative = false;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBoxStyle'>Population Box Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBoxStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The box symbol in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationBoxStyle.png?241029205813)](/cookbook/5.0/images/PopulationBoxStyle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);
    pop.Bar.IsVisible = false;
    pop.Box.IsVisible = true;
    pop.Box.LineWidth = 2;
    pop.Box.FillColor = pop.Marker.MarkerLineColor.WithAlpha(.5);
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationMarkerStyle'>Population Marker Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationMarkerStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The data markers in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationMarkerStyle.png?241029205813)](/cookbook/5.0/images/PopulationMarkerStyle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.Marker.LineWidth = 2;
    pop.Marker.Color = Colors.Black.WithAlpha(.5);
    pop.Marker.Shape = MarkerShape.OpenTriangleUp;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationArrangement'>Population Arrangement</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationArrangement">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The user may customize where data is drawn relative to the bar or box. Centering everything can be used to achieve an effect where data points are drawn over the bar or box.

[![](/cookbook/5.0/images/PopulationArrangement.png?241029205813)](/cookbook/5.0/images/PopulationArrangement.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.MarkerAlignment = HorizontalAlignment.Center;
    pop.BarAlignment = HorizontalAlignment.Center;
    pop.Marker.Shape = MarkerShape.OpenDiamond;
    pop.Marker.Color = Colors.Black.WithAlpha(.5);
    pop.Bar.FillColor = Colors.Gray;
    pop.Bar.LineWidth = 2;
    pop.Width = 0.5;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationGroups'>Population Groups</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationGroups">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

Groups of populations can be achieved by customizing position, color, axis labels, and legend items.

[![](/cookbook/5.0/images/PopulationGroups.png?241029205813)](/cookbook/5.0/images/PopulationGroups.png?241029205813)

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

<hr class='my-5 invisible'>


