---
Title: Configuring Legends - ScottPlot 5.0 Cookbook
Description: A legend is a key typically displayed in the corner of a plot
URL: /cookbook/5.0/Legend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Configuring Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend"]
Date: 2024-03-17
Version: ScottPlot 5.0.22
Version: ScottPlot 5.0.22
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Configuring Legends


<h2><a href='/cookbook/5.0/Legend/LegendQuickstart'>Legend Quickstart</a></h2>

Many plottables have a Label property that can be set so they appear in the legend.

[![](/cookbook/5.0/images/LegendQuickstart.png?240316204900)](/cookbook/5.0/images/LegendQuickstart.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Legend/ManualLegend'>Manual Legend Items</a></h2>

Legends may be constructed manually.

[![](/cookbook/5.0/images/ManualLegend.png?240316204900)](/cookbook/5.0/images/ManualLegend.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));
myPlot.Legend.IsVisible = true;

LegendItem item1 = new()
{
    LineColor = Colors.Magenta,
    MarkerColor = Colors.Magenta,
    LineWidth = 2,
    Label = "Alpha"
};

LegendItem item2 = new()
{
    LineColor = Colors.Green,
    MarkerColor = Colors.Green,
    LineWidth = 4,
    Label = "Beta"
};

LegendItem[] items = { item1, item2 };
myPlot.ShowLegend(items);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Legend/LegendStyle'>Legend Customization</a></h2>

Access the Legend object directly for advanced customization options.

[![](/cookbook/5.0/images/LegendStyle.png?240316204900)](/cookbook/5.0/images/LegendStyle.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.Label = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.Label = "Cos";

myPlot.Legend.IsVisible = true;
myPlot.Legend.OutlineStyle.Color = Colors.Navy;
myPlot.Legend.OutlineStyle.Width = 2;
myPlot.Legend.BackgroundFill.Color = Colors.LightBlue;
myPlot.Legend.ShadowFill.Color = Colors.Blue.WithOpacity(.5);
myPlot.Legend.Font.Size = 16;
myPlot.Legend.Font.Name = Fonts.Serif;
myPlot.Legend.Location = Alignment.UpperCenter;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Legend/LegendOrientation'>Legend Orientation</a></h2>

Legend items may be arranged horizontally instead of vertically

[![](/cookbook/5.0/images/LegendOrientation.png?240316204900)](/cookbook/5.0/images/LegendOrientation.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51, phase: .2));
var sig2 = myPlot.Add.Signal(Generate.Sin(51, phase: .4));
var sig3 = myPlot.Add.Signal(Generate.Sin(51, phase: .6));

sig1.Label = "Signal 1";
sig2.Label = "Signal 2";
sig3.Label = "Signal 3";

myPlot.Legend.IsVisible = true;
myPlot.Legend.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Legend/LegendWrapping'>Legend Wrapping</a></h2>

Legend items may wrap to improve display for a large number of items

[![](/cookbook/5.0/images/LegendWrapping.png?240316204900)](/cookbook/5.0/images/LegendWrapping.png?240316204900)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

for (int i = 1; i <= 10; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin(51, phase: .02 * i));
    sig.Label = $"Signal #{i}";
}

myPlot.Legend.IsVisible = true;
myPlot.Legend.Orientation = Orientation.Horizontal;
myPlot.Legend.AllowMultiline = true;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

