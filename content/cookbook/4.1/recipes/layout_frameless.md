---
Title: "Frameless Plot - ScottPlot 4.1 Cookbook"
Description: "The Frameless() method disables and collapses all axes so the data area is all that appears. Although the figure background is blue in this example, none of it will show, because the data area occupies all of the available space."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/layout_frameless/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Frameless Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_frameless/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_frameless.png"
---

<h2><a id='frameless-plot' href='/cookbook/4.1/recipes/layout_frameless/'>Frameless Plot</a></h2>

The Frameless() method disables and collapses all axes so the data area is all that appears. Although the figure background is blue in this example, none of it will show, because the data area occupies all of the available space.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.Style(figureBackground: Color.SkyBlue);

plt.Frameless();

plt.SaveFig("layout_frameless.png");
```

{{< /code-sp4 >}}

<img src='../../images/layout_frameless.png' class='d-block mx-auto my-5' />


