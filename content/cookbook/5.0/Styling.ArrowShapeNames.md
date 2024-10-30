---
Title: Arrow Shapes - ScottPlot 5.0 Cookbook
Description: Many standard arrow shapes are available
URL: /cookbook/5.0/Styling/ArrowShapeNames/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Arrow Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/ArrowShapeNames"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/ArrowShapeNames'>Arrow Shapes</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/ArrowShapeNames">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Many standard arrow shapes are available

[![](/cookbook/5.0/images/ArrowShapeNames.png?241029205813)](/cookbook/5.0/images/ArrowShapeNames.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ArrowShape[] arrowShapes = Enum.GetValues<ArrowShape>().ToArray();

for (int i = 0; i < arrowShapes.Length; i++)
{
    Coordinates arrowTip = new(0, -i);
    Coordinates arrowBase = arrowTip.WithDelta(1, 0);

    var arrow = myPlot.Add.Arrow(arrowBase, arrowTip);
    arrow.ArrowShape = arrowShapes[i].GetShape();

    var txt = myPlot.Add.Text(arrowShapes[i].ToString(), arrowBase.WithDelta(.1, 0));
    txt.LabelFontColor = arrow.ArrowLineColor;
    txt.LabelAlignment = Alignment.MiddleLeft;
    txt.LabelFontSize = 18;
}

myPlot.Axes.SetLimits(-1, 3, -arrowShapes.Length, 1);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


