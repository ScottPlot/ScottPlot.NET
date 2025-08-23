---
Title: Multiplot - ScottPlot 5.0 Cookbook
Description: Use Multiplot to create figures with multiple subplots
URL: /cookbook/5.0/MultiplotRecipes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Multiplot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/MultiplotRecipes"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Multiplot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Quickstart</h1>
<a href='/cookbook/5.0/MultiplotRecipes/MultiplotQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use the Multiplot class to create figures with multiple subplots.

[![](/cookbook/5.0/images/MultiplotQuickstart.png?250822231048)](/cookbook/5.0/images/MultiplotQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotQuickstart.png?250822231048" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to use 2 subplots
multiplot.AddPlots(2);
Plot plot1 = multiplot.Subplots.GetPlot(0);
Plot plot2 = multiplot.Subplots.GetPlot(1);

// add sample data to each subplot
plot1.Add.Signal(Generate.Sin());
plot2.Add.Signal(Generate.Cos());

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Columns</h1>
<a href='/cookbook/5.0/MultiplotRecipes/MultiplotColumns' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The Multiplot's Layout property may be customized to achieve a column layout.

[![](/cookbook/5.0/images/MultiplotColumns.png?250822231048)](/cookbook/5.0/images/MultiplotColumns.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotColumns.png?250822231048" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to use 2 subplots
multiplot.AddPlots(2);
Plot plot1 = multiplot.Subplots.GetPlot(0);
Plot plot2 = multiplot.Subplots.GetPlot(1);

// add sample data to each subplot
plot1.Add.Signal(Generate.Sin());
plot2.Add.Signal(Generate.Cos());

// apply a custom layout
multiplot.Layout = new ScottPlot.MultiplotLayouts.Columns();

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Grid</h1>
<a href='/cookbook/5.0/MultiplotRecipes/MultiplotGrid' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The Multiplot's Layout property may be customized to achieve a grid layout.

[![](/cookbook/5.0/images/MultiplotGrid.png?250822231048)](/cookbook/5.0/images/MultiplotGrid.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotGrid.png?250822231048" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to have 6 subplots
multiplot.AddPlots(6);

// add sample data to each subplot
for (int i = 0; i &lt; multiplot.Subplots.Count; i++)
{
    Plot plot = multiplot.GetPlot(i);
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
}

// configure the multiplot to use a grid layout
multiplot.Layout = new ScottPlot.MultiplotLayouts.Grid(rows: 2, columns: 3);

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiplot Custom Layout</h1>
<a href='/cookbook/5.0/MultiplotRecipes/MultiplotCustom' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The Multiplot's Layout property may be configured to achieve a fully custom layout.

[![](/cookbook/5.0/images/MultiplotCustom.png?250822231048)](/cookbook/5.0/images/MultiplotCustom.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/MultiplotRecipes.cs" imageUrl="/cookbook/5.0/images/MultiplotCustom.png?250822231048" >}}ScottPlot.Multiplot multiplot = new();

// configure the multiplot to have 3 subplots
multiplot.AddPlots(3);

// add sample data to each subplot
for (int i = 0; i &lt; multiplot.Subplots.Count; i++)
{
    Plot plot = multiplot.GetPlot(i);
    double[] ys = Generate.Sin(oscillations: i + 1);
    plot.Add.Signal(ys);
}

// create a custom grid layout and define the position of each subplot
ScottPlot.MultiplotLayouts.CustomGrid gridLayout = new();
gridLayout.Set(multiplot.GetPlot(0), new GridCell(0, 0, 2, 1)); // double wide
gridLayout.Set(multiplot.GetPlot(1), new GridCell(1, 0, 2, 2)); // bottom left
gridLayout.Set(multiplot.GetPlot(2), new GridCell(1, 1, 2, 2)); // bottom right

// user the custom layout in our multiplot
multiplot.Layout = gridLayout;

multiplot.SavePng("demo.png", 400, 400);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


