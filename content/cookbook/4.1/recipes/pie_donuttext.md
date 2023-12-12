---
Title: "Donut with Text - ScottPlot 4.1 Cookbook"
Description: "Custom text can be displayed in the center of a donut chart. Notice too how the colors of each slice are customized in this example."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/pie_donuttext/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Donut with Text"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_donuttext/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_donuttext.png"
---

<h2><a id='donut-with-text' href='/cookbook/4.1/recipes/pie_donuttext/'>Donut with Text</a></h2>

Custom text can be displayed in the center of a donut chart. Notice too how the colors of each slice are customized in this example.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 779, 586 };
string centerText = $"{values[0] / values.Sum() * 100:00.0}%";
Color color1 = Color.FromArgb(255, 0, 150, 200);
Color color2 = Color.FromArgb(100, 0, 150, 200);

var pie = plt.AddPie(values);
pie.DonutSize = .6;
pie.DonutLabel = centerText;
pie.CenterFont.Color = color1;
pie.OutlineSize = 2;
pie.SliceFillColors = new Color[] { color1, color2 };

plt.SaveFig("pie_donutText.png");
```

<img src='../../images/pie_donuttext.png' class='d-block mx-auto my-5' />


