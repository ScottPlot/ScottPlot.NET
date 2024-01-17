---
Title: Text - ScottPlot 5.0 Cookbook
Description: Text lables placed on the plot in coordinate space
URL: /cookbook/5.0/Text/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text"]
Date: 2024-01-17
Version: ScottPlot 5.0.17
Version: ScottPlot 5.0.17
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Text


<h2><a href='/cookbook/5.0/Text/TextQuickstart'>Text Quickstart</a></h2>

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png)](/cookbook/5.0/images/TextQuickstart.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(ScottPlot.Generate.Sin());
myPlot.Add.Signal(ScottPlot.Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/Formatting'>Text Formatting</a></h2>

Text formatting can be extensively customized.

[![](/cookbook/5.0/images/Formatting.png)](/cookbook/5.0/images/Formatting.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var text = myPlot.Add.Text("Hello, World", 42, 69);
text.Label.FontSize = 26;
text.Label.Bold = true;
text.Label.Rotation = -45;
text.Label.ForeColor = Colors.Yellow;
text.Label.BackColor = Colors.Navy.WithAlpha(.5);
text.Label.BorderColor = Colors.Magenta;
text.Label.BorderWidth = 3;
text.Label.Padding = 10;
text.Label.Alignment = Alignment.MiddleCenter;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

