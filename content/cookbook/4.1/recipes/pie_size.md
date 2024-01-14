---
Title: "Custom Size - ScottPlot 4.1 Cookbook"
Description: "You can define the size of the pie to make room for large labels."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_size/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Custom Size"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_size/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_size.png"
---

<h2><a id='custom-size' href='/cookbook/4.1/recipes/pie_size/'>Custom Size</a></h2>

You can define the size of the pie to make room for large labels.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.Title("Really\nLarge\nTitle");

double[] values = { 778, 283, 184, 76, 43 };
var pie = plt.AddPie(values);

pie.Size = .6; // size of the pie (default is .9)

plt.SaveFig("pie_size.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_size.png' class='d-block mx-auto my-5' />


