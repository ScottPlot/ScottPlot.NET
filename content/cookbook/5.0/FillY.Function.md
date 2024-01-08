---
Title: FillY with Custom Type - ScottPlot 5.0 Cookbook
Description: FillY plots can be created from data of any type if a conversion function is supplied.
URL: /cookbook/5.0/FillY/Function/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "FillY with Custom Type"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/Function"]
Date: 2024-01-08
Version: ScottPlot 5.0.11-beta
Version: ScottPlot 5.0.11-beta
SearchUrl: "/cookbook/5.0/search/"
---

# FillY with Custom Type



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.11-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>



FillY plots can be created from data of any type if a conversion function is supplied.

[![](/cookbook/5.0/images/Function.png)](/cookbook/5.0/images/Function.png)

```cs
ScottPlot.Version.ShouldBe(5, 0, 11);
ScottPlot.Plot myPlot = new();

// create source data in a nonstandard data type
List<(int, int, int)> data = new();
Random rand = new(0);
for (int i = 0; i < 10; i++)
{
    int x = i;
    int y1 = rand.Next(0, 10);
    int y2 = rand.Next(20, 30);
    data.Add((x, y1, y2));
}

// create a custom converter for the source data type
static (double, double, double) MyConverter((int, int, int) s) => (s.Item1, s.Item2, s.Item3);

// create a filled plot from source data using the custom converter
myPlot.Add.FillY(data, MyConverter);

myPlot.SavePng("demo.png");

```

