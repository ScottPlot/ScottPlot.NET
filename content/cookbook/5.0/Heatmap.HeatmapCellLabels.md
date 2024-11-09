---
Title: Heatmap Cell Labels - ScottPlot 5.0 Cookbook
Description: Text may be placed over cells to provide cell labels. In interactive applications MouseMove events may be used to remove old labels and only display a label over the cell beneath the mouse. See the ScottPlot Demo page for more information and code samples.
URL: /cookbook/5.0/Heatmap/HeatmapCellLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Heatmap", "Heatmap Cell Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Heatmap", "/cookbook/5.0/Heatmap/HeatmapCellLabels"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Heatmap Cell Labels</h1>
</div>

Text may be placed over cells to provide cell labels. In interactive applications MouseMove events may be used to remove old labels and only display a label over the cell beneath the mouse. See the ScottPlot Demo page for more information and code samples.

[![](/cookbook/5.0/images/HeatmapCellLabels.png?241109132219)](/cookbook/5.0/images/HeatmapCellLabels.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Heatmap.cs" imageUrl="/cookbook/5.0/images/HeatmapCellLabels.png?241109132219" >}}ScottPlot.Plot myPlot = new();

double[,] data = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
};

var hm = myPlot.Add.Heatmap(data);

for (int y = 0; y &lt; data.GetLength(0); y++)
{
    for (int x = 0; x &lt; data.GetLength(1); x++)
    {
        Coordinates coordinates = new(x, y);
        string cellLabel = data[y, x].ToString("0.0");
        var text = myPlot.Add.Text(cellLabel, coordinates);
        text.Alignment = Alignment.MiddleCenter;
        text.LabelFontSize = 30;
        text.LabelFontColor = Colors.White;
    }
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Heatmap'>Heatmap</a> category</div>


