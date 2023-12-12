---
Title: "Inverted Brackets - ScottPlot 4.1 Cookbook"
Description: "By default bracket labels appear clockwise relative to the line formed by their two points. Users can invert the direction of brackets as needed."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bracket_invert/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bracket", "Inverted Brackets"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bracket", "/cookbook/4.1/recipes/bracket_invert/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bracket_invert.png"
---

<h2><a id='inverted-brackets' href='/cookbook/4.1/recipes/bracket_invert/'>Inverted Brackets</a></h2>

By default bracket labels appear clockwise relative to the line formed by their two points. Users can invert the direction of brackets as needed.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

var bracketA = plt.AddBracket(50, 1, 50, 0, "Bracket A");
bracketA.LabelCounterClockwise = true;

var backetB = plt.AddBracket(13, 1, 50, 1, "Bracket B");
backetB.LabelCounterClockwise = true;

var backetC = plt.AddBracket(20, .65, 27, -.20, "Bracket C");
backetC.LabelCounterClockwise = true;

plt.Margins(.2, .2); // zoom out slightly to make room for labels

plt.SaveFig("bracket_invert.png");
```

<img src='../../images/bracket_invert.png' class='d-block mx-auto my-5' />


