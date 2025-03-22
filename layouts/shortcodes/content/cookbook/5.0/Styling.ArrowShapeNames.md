---
Title: Arrow Shapes - ScottPlot 5.0 Cookbook
Description: Many standard arrow shapes are available
URL: /cookbook/5.0/Styling/ArrowShapeNames/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Arrow Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/ArrowShapeNames"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Arrow Shapes</h1>
</div>

Many standard arrow shapes are available

[![](/cookbook/5.0/images/ArrowShapeNames.png?250322130304)](/cookbook/5.0/images/ArrowShapeNames.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/ArrowShapeNames.png?250322130304" >}}ScottPlot.Plot myPlot = new();

ArrowShape[] arrowShapes = Enum.GetValues&lt;ArrowShape&gt;().ToArray();

for (int i = 0; i &lt; arrowShapes.Length; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


