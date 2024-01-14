---
Title: "Custom Tick Label Culture - ScottPlot 4.1 Cookbook"
Description: "SetCulture() as arguments to let the user manually define formatting strings which will be used globally to change how numbers and dates are formatted."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_culturecustom/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Custom Tick Label Culture"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_culturecustom/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_culturecustom.png"
---

<h2><a id='custom-tick-label-culture' href='/cookbook/4.1/recipes/ticks_culturecustom/'>Custom Tick Label Culture</a></h2>

SetCulture() as arguments to let the user manually define formatting strings which will be used globally to change how numbers and dates are formatted.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// generate 10 days of data
int pointCount = 10;
double[] values = DataGen.RandomWalk(null, pointCount);
double[] days = new double[pointCount];
DateTime day1 = new DateTime(1985, 09, 24);
for (int i = 0; i < days.Length; i++)
    days[i] = day1.AddDays(1).AddDays(i).ToOADate();

// plot the data with custom tick format (https://tinyurl.com/ycwh45af)
plt.AddScatter(days, values);
plt.XAxis.TickLabelFormat("M\\/dd", dateTimeFormat: true);

plt.SaveFig("ticks_cultureCustom.png");
```

{{< /code-sp4 >}}

<img src='../../images/ticks_culturecustom.png' class='d-block mx-auto my-5' />


