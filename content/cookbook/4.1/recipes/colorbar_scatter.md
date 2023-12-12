---
Title: "Scatter Plot with Colorbar - ScottPlot 4.1 Cookbook"
Description: "This example shows how to add differently colored markers to the plot to simulate a scatter plot with points colored according to a colorbar. Note that the colormap generates the colors, and that a colorbar just displays a colormap"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/colorbar_scatter/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Colorbar", "Scatter Plot with Colorbar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-colorbar", "/cookbook/4.1/recipes/colorbar_scatter/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/colorbar_scatter.png"
---

<h2><a id='scatter-plot-with-colorbar' href='/cookbook/4.1/recipes/colorbar_scatter/'>Scatter Plot with Colorbar</a></h2>

This example shows how to add differently colored markers to the plot to simulate a scatter plot with points colored according to a colorbar. Note that the colormap generates the colors, and that a colorbar just displays a colormap

```cs
var plt = new ScottPlot.Plot(600, 400);

var cmap = ScottPlot.Drawing.Colormap.Viridis;
plt.AddColorbar(cmap);

Random rand = new(0);
for (int i = 0; i < 1000; i++)
{
    double x = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0, stdDev: .5);
    double y = ScottPlot.DataGen.RandomNormalValue(rand, mean: 0, stdDev: .5);
    double colorFraction = Math.Sqrt(x * x + y * y);
    System.Drawing.Color c = ScottPlot.Drawing.Colormap.Viridis.GetColor(colorFraction);
    plt.AddPoint(x, y, c);
}

plt.SaveFig("colorbar_scatter.png");
```

<img src='../../images/colorbar_scatter.png' class='d-block mx-auto my-5' />


