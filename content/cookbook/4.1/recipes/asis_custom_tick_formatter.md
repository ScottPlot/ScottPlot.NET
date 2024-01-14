---
Title: "Custom Tick Formatter - ScottPlot 4.1 Cookbook"
Description: "For ultimate control over tick label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format tick labels."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/asis_custom_tick_formatter/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Custom Tick Formatter"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_custom_tick_formatter/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_custom_tick_formatter.png"
---

<h2><a id='custom-tick-formatter' href='/cookbook/4.1/recipes/asis_custom_tick_formatter/'>Custom Tick Formatter</a></h2>

For ultimate control over tick label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format tick labels.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));

// create a custom formatter as a static class
static string customTickFormatter(double position)
{
    if (position == 0)
        return "zero";
    else if (position > 0)
        return $"+{position:F2}";
    else
        return $"({Math.Abs(position):F2})";
}

// use the custom formatter for horizontal and vertical tick labels
plt.XAxis.TickLabelFormat(customTickFormatter);
plt.YAxis.TickLabelFormat(customTickFormatter);

plt.SaveFig("asis_custom_tick_formatter.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_custom_tick_formatter.png' class='d-block mx-auto my-5' />


