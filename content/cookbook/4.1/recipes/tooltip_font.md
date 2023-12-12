---
Title: "Tooltip Font - ScottPlot 4.1 Cookbook"
Description: "Tooltips fonts can be customized"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/tooltip_font/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Tooltip", "Tooltip Font"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-tooltip", "/cookbook/4.1/recipes/tooltip_font/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/tooltip_font.png"
---

<h2><a id='tooltip-font' href='/cookbook/4.1/recipes/tooltip_font/'>Tooltip Font</a></h2>

Tooltips fonts can be customized

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

var tt1 = plt.AddTooltip("Top", 12, ys[12]);
tt1.Font.Color = System.Drawing.Color.Magenta;
tt1.Font.Size = 24;

var tt2 = plt.AddTooltip("Negative Slope", 25, ys[25]);
tt2.Font.Name = "Comic Sans MS";
tt2.Font.Bold = true;

plt.SaveFig("tooltip_font.png");
```

<img src='../../images/tooltip_font.png' class='d-block mx-auto my-5' />


