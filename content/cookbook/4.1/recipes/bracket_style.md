---
Title: "Styling Brackets - ScottPlot 4.1 Cookbook"
Description: "Brackets have additional options for customizations."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bracket_style/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bracket", "Styling Brackets"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bracket", "/cookbook/4.1/recipes/bracket_style/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bracket_style.png"
---

<h2><a id='styling-brackets' href='/cookbook/4.1/recipes/bracket_style/'>Styling Brackets</a></h2>

Brackets have additional options for customizations.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddBracket(-1, 0, 0, 1, "Default Style");

var bracketA = plt.AddBracket(0, 0, 1, 1, "Large Font");
bracketA.Font.Size = 24;

var bracketB = plt.AddBracket(1, 0, 2, 1, "Custom Color");
bracketB.Color = Color.Magenta;

var bracketC = plt.AddBracket(2, 0, 3, 1, "Longer Stem & Edges");
bracketC.EdgeLength = 20;

var bracketD = plt.AddBracket(3, 0, 4, 1, "Thicker Bracket");
bracketD.LineWidth = 3;
bracketD.Font.Bold = true;

plt.AddBracket(4, 0, 5, 1, label: null);

plt.Margins(.2, .2); // zoom out slightly to make room for labels

plt.SaveFig("bracket_style.png");
```

<img src='../../images/bracket_style.png' class='d-block mx-auto my-5' />


