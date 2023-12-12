---
Title: "Waterfall Bar Graph - ScottPlot 4.1 Cookbook"
Description: "Waterfall bar graphs use bars to represent changes in value from the previous level. This style graph can be created by offseting each bar by the sum of all bars preceeding it. This effect is similar to financial plots (OHLC and Candlestick) which are described in another section."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_waterfall/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Waterfall Bar Graph"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_waterfall/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_waterfall.png"
---

<h2><a id='waterfall-bar-graph' href='/cookbook/4.1/recipes/bar_waterfall/'>Waterfall Bar Graph</a></h2>

Waterfall bar graphs use bars to represent changes in value from the previous level. This style graph can be created by offseting each bar by the sum of all bars preceeding it. This effect is similar to financial plots (OHLC and Candlestick) which are described in another section.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomNormal(1, 12, 5, 10);
double[] offsets = Enumerable.Range(0, values.Length).Select(x => values.Take(x).Sum()).ToArray();

var bar = plt.AddBar(values);
bar.ValueOffsets = offsets;
bar.FillColorNegative = Color.Red;
bar.FillColor = Color.Green;

plt.SaveFig("bar_waterfall.png");
```

<img src='../../images/bar_waterfall.png' class='d-block mx-auto my-5' />


