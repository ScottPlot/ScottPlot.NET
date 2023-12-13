---
Title: Custom Tick Formatters - ScottPlot 5.0 Cookbook
Description: Users can customize the logic used to create tick labels from tick positions.
URL: /cookbook/5.0/CustomizingTicks/CustomTickFormatter
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Custom Tick Formatters"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/CustomTickFormatter"]
Date: 2023-12-13
Version: ScottPlot 5.0.10-beta
---

# Custom Tick Formatters



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



Users can customize the logic used to create tick labels from tick positions.

[![](/cookbook/5.0/images/CustomTickFormatter.png)](/cookbook/5.0/images/CustomTickFormatter.png)

```cs
ScottPlot.Plot myPlot = new();

double[] xs = ScottPlot.Generate.Consecutive(100, 1, -50);
myPlot.Add.Scatter(xs, ScottPlot.Generate.Sin(100));
myPlot.Add.Scatter(xs, ScottPlot.Generate.Cos(100));

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
myPlot.XAxis.TickGenerator = myTickGenerator;

myPlot.SavePng("demo.png");

```

