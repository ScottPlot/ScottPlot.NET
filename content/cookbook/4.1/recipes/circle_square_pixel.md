---
Title: "Circle with Locked Scale - ScottPlot 4.1 Cookbook"
Description: "For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/circle_square_pixel/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Ellipse", "Circle with Locked Scale"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-ellipse", "/cookbook/4.1/recipes/circle_square_pixel/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/circle_square_pixel.png"
---

<h2><a href='/cookbook/4.1/recipes/circle_square_pixel/'>Circle with Locked Scale</a></h2>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

```cs
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

plt.AxisScaleLock(true); // this forces pixels to have 1:1 scale ratio

plt.SaveFig("circle_square_pixel.png");
```

<img src='../../images/circle_square_pixel.png' class='d-block mx-auto my-5' />


