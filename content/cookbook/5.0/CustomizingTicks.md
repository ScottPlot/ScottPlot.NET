---
Title: Customizing Ticks - ScottPlot 5.0 Cookbook
Description: Advanced customization of tick marks and tick labels
URL: /cookbook/5.0/CustomizingTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks"]
Date: 2023-12-24
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# Customizing Ticks



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



## Custom Tick Formatters

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


## Custom Tick Generators

Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.

[![](/cookbook/5.0/images/AltTickGen.png)](/cookbook/5.0/images/AltTickGen.png)

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin(51));
myPlot.Add.Signal(ScottPlot.Generate.Cos(51));

myPlot.XAxis.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(11);

myPlot.SavePng("demo.png");

```


## Custom Tick Positions

Users can define ticks to be placed at specific locations.

[![](/cookbook/5.0/images/CustomTicks.png)](/cookbook/5.0/images/CustomTicks.png)

```cs
ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// create a manual tick generator and add ticks
ScottPlot.TickGenerators.NumericManual ticks = new();

// add major ticks with their labels
ticks.AddMajor(0, "zero");
ticks.AddMajor(20, "twenty");
ticks.AddMajor(50, "fifty");

// add minor ticks
ticks.AddMinor(22);
ticks.AddMinor(25);
ticks.AddMinor(32);
ticks.AddMinor(35);
ticks.AddMinor(42);
ticks.AddMinor(45);

// tell the horizontal axis to use the custom tick genrator
myPlot.BottomAxis.TickGenerator = ticks;

myPlot.SavePng("demo.png");

```

