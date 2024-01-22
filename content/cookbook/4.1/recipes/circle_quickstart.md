---
Title: "Circle Quickstart - ScottPlot 4.1 Cookbook"
Description: "Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/circle_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Circle Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/circle_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/circle_quickstart.png"
---

<h2><a id='circle-quickstart' href='/cookbook/4.1/recipes/circle_quickstart/'>Circle Quickstart</a></h2>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
for (int i = 0; i < 5; i++)
{
    plt.AddCircle(
        x: rand.Next(-10, 10),
        y: rand.Next(-10, 10),
        radius: rand.Next(1, 7),
        lineWidth: rand.Next(1, 10));
}

plt.SaveFig("circle_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/circle_quickstart.png' class='d-block mx-auto my-5' />


