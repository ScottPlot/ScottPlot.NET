---
Title: Scale Bar - ScottPlot 5.0 Cookbook
Description: Scalebars display a horizontal and/or vertical range using a line segment and may be used to convey axis scale as a minimal alternative to using axis frames, ticks, and tick labels.
URL: /cookbook/5.0/ScaleBar/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scale Bar"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScaleBar"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Scale Bar</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Quickstart</h1>
<a href='/cookbook/5.0/ScaleBar/ScaleBarQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A ScaleBar can be added to a plot to convey scale information allowing axis frames, ticks, and labels to be hidden.

[![](/cookbook/5.0/images/ScaleBarQuickstart.png?241117162641)](/cookbook/5.0/images/ScaleBarQuickstart.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarQuickstart.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
myPlot.Add.ScaleBar(5, 0.25);

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Labels</h1>
<a href='/cookbook/5.0/ScaleBar/ScaleBarLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Text may be added to each dimension of an L shaped scalebar

[![](/cookbook/5.0/images/ScaleBarLabels.png?241117162641)](/cookbook/5.0/images/ScaleBarLabels.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarLabels.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(5, 0.25);
scalebar.XLabel = "5 mV";
scalebar.YLabel = "1 µF";

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Styling</h1>
<a href='/cookbook/5.0/ScaleBar/ScaleBarStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The ScaleBar has many properties which may be customized 

[![](/cookbook/5.0/images/ScaleBarStyling.png?241117162641)](/cookbook/5.0/images/ScaleBarStyling.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarStyling.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(5, 0.25);
scalebar.LineWidth = 5;
scalebar.LineColor = Colors.Magenta;

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>ScaleBar Single Dimension</h1>
<a href='/cookbook/5.0/ScaleBar/ScaleBarSingleDimension' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Set Width or Height to 0 to cause the ScaleBar to use a single axis only

[![](/cookbook/5.0/images/ScaleBarSingleDimension.png?241117162641)](/cookbook/5.0/images/ScaleBarSingleDimension.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/ScaleBar.cs" imageUrl="/cookbook/5.0/images/ScaleBarSingleDimension.png?241117162641" >}}ScottPlot.Plot myPlot = new();

// plot sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// add a scale bar
var scalebar = myPlot.Add.ScaleBar(7, 0);
scalebar.LineWidth = 2;
scalebar.XLabel = "70 ms";
scalebar.XLabelStyle.Bold = true;
scalebar.LabelPadding = new(0);

// disable the grid and axis labels
myPlot.HideGrid();
myPlot.Axes.Frameless();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


