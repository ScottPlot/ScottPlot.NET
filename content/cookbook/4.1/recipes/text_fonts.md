---
Title: "Custom Fonts - ScottPlot 4.1 Cookbook"
Description: "You can pass in a Font to further customize font options"
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/text_fonts/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Text", "Custom Fonts"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-text", "/cookbook/4.1/recipes/text_fonts/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/text_fonts.png"
---

<h2><a href='/cookbook/4.1/recipes/text_fonts/'>Custom Fonts</a></h2>

You can pass in a Font to further customize font options

```cs
var plt = new ScottPlot.Plot(600, 400);

// display some interesting data in the background
plt.AddSignal(DataGen.Sin(51), label: "sin");
plt.AddSignal(DataGen.Cos(51), label: "cos");

// add text with custom fonts
plt.AddText("very graph", 25, .8, new Drawing.Font() { Name = "comic sans ms", Size = 24, Color = Color.Blue, Bold = true });
plt.AddText("so data", 0, 0, new Drawing.Font() { Name = "comic sans ms", Size = 42, Color = Color.Magenta, Bold = true });
plt.AddText("many documentation", 3, -.6, new Drawing.Font() { Name = "comic sans ms", Size = 18, Color = Color.DarkBlue, Bold = true });
plt.AddText("wow.", 10, .6, new Drawing.Font() { Name = "comic sans ms", Size = 36, Color = Color.Green, Bold = true });
plt.AddText("NuGet", 32, 0, new Drawing.Font() { Name = "comic sans ms", Size = 24, Color = Color.Gold, Bold = true });

// configure axis labels
plt.YAxis.Label(label: "vertical units", fontName: "impact", size: 24, color: Color.Red, bold: true);
plt.XAxis.Label(label: "horizontal units", fontName: "georgia", size: 24, color: Color.Blue, bold: true);
plt.XAxis2.Label(label: "Impressive Graph", size: 24, color: Color.Purple, bold: true);

// configure tick labels
plt.XAxis.TickLabelStyle(color: Color.DarkBlue, fontName: "comic sans ms", fontSize: 16);
plt.YAxis.TickLabelStyle(color: Color.DarkGreen, fontName: "comic sans ms", fontSize: 16);

// add a legend to the corner
var legend = plt.Legend();
legend.FontName = "comic sans ms";
legend.FontSize = 18;
legend.FontBold = true;
legend.FontColor = Color.DarkBlue;

plt.SaveFig("text_fonts.png");
```

<img src='../../images/text_fonts.png' class='d-block mx-auto my-5' />


