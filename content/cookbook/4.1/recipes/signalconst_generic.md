---
Title: "Generic Data Type - ScottPlot 4.1 Cookbook"
Description: "SignalConst supports other data types beyond just double arrays. You can use this plot type to display data in any numerical format that can be cast to a double."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/signalconst_generic/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "SignalConst", "Generic Data Type"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signalconst", "/cookbook/4.1/recipes/signalconst_generic/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signalconst_generic.png"
---

<h2><a id='generic-data-type' href='/cookbook/4.1/recipes/signalconst_generic/'>Generic Data Type</a></h2>

SignalConst supports other data types beyond just double arrays. You can use this plot type to display data in any numerical format that can be cast to a double.

```cs
var plt = new ScottPlot.Plot(600, 400);

int[] data = { 2, 6, 3, 8, 5, 6, 1, 9, 7 };
plt.AddSignalConst(data);
plt.Title("SignalConst Displaying int[] Data");

plt.SaveFig("signalconst_generic.png");
```

<img src='../../images/signalconst_generic.png' class='d-block mx-auto my-5' />


