---
Title: Arrow Shapes - ScottPlot 5 Cookbook
Description: Many standard arrow shapes are available
URL: /cookbook/5/Styling/ArrowShapeNames/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Arrow Shapes"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/ArrowShapeNames"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Arrow Shapes</h1>
</div>

Many standard arrow shapes are available

[![](/cookbook/5/images/ArrowShapeNames.png?251011113742)](/cookbook/5/images/ArrowShapeNames.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/ArrowShapeNames.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


