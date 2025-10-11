---
Title: Interactive - ScottPlot 5 Cookbook
Description: Interactive plottables interact with the mouse without requiring the user to manually wire mouse tracking.
URL: /cookbook/5/InteractivePlottables/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---

<h1>Interactive</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Line Segment</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveLineSegment' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Two draggable points with a straight line between them.

[![](/cookbook/5/images/InteractiveLineSegment.png?251011113742)](/cookbook/5/images/InteractiveLineSegment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveLineSegment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    CoordinateLine line = Generate.RandomLine();
    myPlot.Add.InteractiveLineSegment(line);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Horizontal Line Segment</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveHorizontalLineSegment' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Horizontal line segments can be expanded horizontally by dragging the left and right edges, or slid vertically by dragging the center line.

[![](/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742)](/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double y = i;
    double x1 = i;
    double x2 = i * 2;
    myPlot.Add.InteractiveHorizontalLineSegment(x1, x2, y);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Vertical Line Segment</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveVerticalLineSegment' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Vertical line segments can be expanded vertically by dragging the top and bottom edges, or slid horizontally by dragging the center line.

[![](/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742)](/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double x = i;
    double y1 = i;
    double y2 = i * 2;
    myPlot.Add.InteractiveVerticalLineSegment(x, y1, y2);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Vertical Line</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveVerticalLine' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An interactive vertical line has an X position and extends to infinity along the Y axis.

[![](/cookbook/5/images/InteractiveVerticalLine.png?251011113742)](/cookbook/5/images/InteractiveVerticalLine.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveVerticalLine.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double x = Generate.RandomNumber();
    myPlot.Add.InteractiveVerticalLine(x);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Horizontal Line</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveHorizontalLine' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

An interactive horizontal line has a Y position and extends to infinity along the X axis.

[![](/cookbook/5/images/InteractiveHorizontalLine.png?251011113742)](/cookbook/5/images/InteractiveHorizontalLine.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveHorizontalLine.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double x = Generate.RandomNumber();
    myPlot.Add.InteractiveHorizontalLine(x);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Spans</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveSpans' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Interactive vertical and horizontal spans let the user select ranges along the vertical and horizontal axes, respectively.

[![](/cookbook/5/images/InteractiveSpans.png?251011113742)](/cookbook/5/images/InteractiveSpans.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveSpans.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.InteractiveVerticalSpan(3, 5);
myPlot.Add.InteractiveHorizontalSpan(3, 5);
myPlot.Axes.SetLimits(0, 10, 0, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Marker</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveMarker' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Interactive markers respond to hover events and can be dragged.

[![](/cookbook/5/images/InteractiveMarker.png?251011113742)](/cookbook/5/images/InteractiveMarker.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveMarker.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 10; i++)
{
    Coordinates point = Generate.RandomCoordinates();
    var marker = myPlot.Add.InteractiveMarker(point);
    marker.MarkerStyle.Shape = Generate.RandomMarkerShape();
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Rectangles</h1>
<a href='/cookbook/5/InteractivePlottables/InteractiveRectangle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Interactive rectangles can be resized by dragging their edges or repositioned by dragging their bodies

[![](/cookbook/5/images/InteractiveRectangle.png?251011113742)](/cookbook/5/images/InteractiveRectangle.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveRectangle.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    CoordinateRect rect = Generate.RandomCoordinateRect();
    myPlot.Add.InteractiveRectangle(rect);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


