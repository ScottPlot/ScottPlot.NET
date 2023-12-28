---
Title: "Bracket Annotations - ScottPlot 4.1 Cookbook"
Description: "Brackets are useful for annotating a range of data."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bracket_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bracket", "Bracket Annotations"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bracket", "/cookbook/4.1/recipes/bracket_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bracket_quickstart.png"
---

<h2><a id='bracket-annotations' href='/cookbook/4.1/recipes/bracket_quickstart/'>Bracket Annotations</a></h2>

Brackets are useful for annotating a range of data.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.AddBracket(0, 1, 0, 0, "Bracket A");
plt.AddBracket(25, -1, 38, -1, "Bracket B");
plt.AddBracket(20, .55, 27, -.3, "Bracket C");

plt.Margins(.2, .2); // zoom out slightly to make room for labels

plt.SaveFig("bracket_quickstart.png");
```

<img src='../../images/bracket_quickstart.png' class='d-block mx-auto my-5' />


