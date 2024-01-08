---
Title: "Custom Slice Labels - ScottPlot 4.1 Cookbook"
Description: "Custom slice labels can be used to display values using custom formats"
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_customlabels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Custom Slice Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_customlabels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_customlabels.png"
---

<h2><a id='custom-slice-labels' href='/cookbook/4.1/recipes/pie_customlabels/'>Custom Slice Labels</a></h2>

Custom slice labels can be used to display values using custom formats

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };

// modify labels to include a custom formatted value
labels = Enumerable.Range(0, values.Length)
       .Select(i => $"{labels[i]}\n({values[i]})")
       .ToArray();

var pie = plt.AddPie(values);
pie.SliceLabels = labels;
pie.ShowLabels = true;

plt.SaveFig("pie_customLabels.png");
```

<img src='../../images/pie_customlabels.png' class='d-block mx-auto my-5' />


