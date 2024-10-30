---
Title: Custom Tick Formatters - ScottPlot 5.0 Cookbook
Description: Users can customize the logic used to create tick labels from tick positions. Old versions of ScottPlot achieved this using a ManualTickPositions method.
URL: /cookbook/5.0/CustomizingTicks/CustomTickFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Custom Tick Formatters"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/CustomTickFormatter"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'>Custom Tick Formatters</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/CustomTickFormatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Users can customize the logic used to create tick labels from tick positions. Old versions of ScottPlot achieved this using a ManualTickPositions method.

[![](/cookbook/5.0/images/CustomTickFormatter.png?241029205813)](/cookbook/5.0/images/CustomTickFormatter.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(100, 1, -50);
myPlot.Add.Scatter(xs, Generate.Sin(100));
myPlot.Add.Scatter(xs, Generate.Cos(100));

// create a static function containing the string formatting logic
static string CustomFormatter(double position)
{
    if (position == 0)
        return "0";
    else if (position > 0)
        return $"+{position}";
    else
        return $"({-position})";
}

// create a custom tick generator using your custom label formatter
ScottPlot.TickGenerators.NumericAutomatic myTickGenerator = new()
{
    LabelFormatter = CustomFormatter
};

// tell an axis to use the custom tick generator
myPlot.Axes.Bottom.TickGenerator = myTickGenerator;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


