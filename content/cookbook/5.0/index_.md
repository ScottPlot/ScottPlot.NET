---
Title: ScottPlot 5.0 Cookbook
Description: Example plots shown next to the code used to create them
URL: /cookbook/5.0/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook"]
BreadcrumbUrls: ["/cookbook/5.0/"]
Date: 2024-01-11
Version: ScottPlot 5.0.14-beta
Version: ScottPlot 5.0.14-beta
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# ScottPlot 5.0 Cookbook



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.14-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>


<div class='mt-3 fs-4'><strong>Quickstart</strong></div>
<ul>
<li><a href='/cookbook/5.0/Quickstart'>ScottPlot 5 Quickstart</a> - A survey of basic functionality in ScottPlot 5</li>
</ul>
<div class='mt-3 fs-4'><strong>Introduction</strong></div>
<ul>
<li><a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> - Examples of common customizations for axis labels and ticks</li>
<li><a href='/cookbook/5.0/Legend'>Configuring Legends</a> - A legend is a key typically displayed in the corner of a plot</li>
<li><a href='/cookbook/5.0/Styling'>Styling Plots</a> - How to customize plots</li>
</ul>
<div class='mt-3 fs-4'><strong>Axis</strong></div>
<ul>
<li><a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> - Advanced customization of grid lines</li>
<li><a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> - Advanced customization of tick marks and tick labels</li>
<li><a href='/cookbook/5.0/DateTimeAxes'>DateTime Axes</a> - Plot data values on a DataTime axes</li>
<li><a href='/cookbook/5.0/MultiAxis'>Advanced Axis Features</a> - Tick mark customization and creation of multi-Axis plots</li>
</ul>
<div class='mt-3 fs-4'><strong>Plot Types</strong></div>
<ul>
<li><a href='/cookbook/5.0/Bar'>Bar Plot</a> - Bar plots represent values as horizontal or vertical rectangles</li>
<li><a href='/cookbook/5.0/Box'>Box Plot</a> - Box plots show a distribution at a glance</li>
<li><a href='/cookbook/5.0/ErrorBar'>Error Bars</a> - Error Bars communicate the range of possible values for a measurement</li>
<li><a href='/cookbook/5.0/FillY'>FillY plot</a> - FillY plots display the vertical range between two Y values at defined X positions</li>
<li><a href='/cookbook/5.0/Finance'>Financial Plot</a> - Finance plots display price data binned into time ranges</li>
<li><a href='/cookbook/5.0/Function'>Function</a> - Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.</li>
<li><a href='/cookbook/5.0/Heatmap'>Heatmap</a> - Heatmaps display values from 2D data as an image with cells of different intensities</li>
<li><a href='/cookbook/5.0/LinePlot'>Line Plot</a> - Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.</li>
<li><a href='/cookbook/5.0/Marker'>Marker</a> - Markers can be placed on the plot in coordinate space.</li>
<li><a href='/cookbook/5.0/Polygon'>Polygon Plot</a> - Polygon plots draws a polygon</li>
<li><a href='/cookbook/5.0/Scatter'>Scatter Plot</a> - Scatter plots display points at X/Y locations in coordinate space.</li>
<li><a href='/cookbook/5.0/Signal'>Signal Plot</a> - Signal plots display evenly-spaced data</li>
<li><a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> - SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).</li>
<li><a href='/cookbook/5.0/Text'>Text</a> - Text lables placed on the plot in coordinate space</li>
</ul>
<div class='mt-3 fs-4'><strong>Statistics</strong></div>
<ul>
<li><a href='/cookbook/5.0/Regression'>Regression</a> - Statistical operations to fit lines to data</li>
</ul>
<h1>Quickstart</h1>
<h2 class=''><a href='/cookbook/5.0/Quickstart' class='text-dark'>ScottPlot 5 Quickstart</a></h2>
<div>A survey of basic functionality in ScottPlot 5</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/QuickstartScatter'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartScatter.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/QuickstartScatter'><b>Scatter Plot</b></a></div>
<div>Display paired X/Y data as a scatter plot.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/CustomizingPlottables'><img class='img-fluid' src='/cookbook/5.0/images/CustomizingPlottables.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/CustomizingPlottables'><b>Customizing Plottables</b></a></div>
<div>Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/QuickstartSignal'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartSignal.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/QuickstartSignal'><b>Signal Plot</b></a></div>
<div>Signal plots are optimized for displaying evenly spaced data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/SignalPerformance'><img class='img-fluid' src='/cookbook/5.0/images/SignalPerformance.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/SignalPerformance'><b>Signal Plot Performance</b></a></div>
<div>Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/QuickstartAxisLabels'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartAxisLabels.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/QuickstartAxisLabels'><b>Axis Labels</b></a></div>
<div>Axis labels can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Quickstart/Legend'><img class='img-fluid' src='/cookbook/5.0/images/Legend.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Quickstart/Legend'><b>Legend</b></a></div>
<div>A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.</div>
</div>
</div>
<h1>Introduction</h1>
<h2 class=''><a href='/cookbook/5.0/AxisAndTicks' class='text-dark'>Axis and Ticks</a></h2>
<div>Examples of common customizations for axis labels and ticks</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/AxisLabels'><img class='img-fluid' src='/cookbook/5.0/images/AxisLabels.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/AxisLabels'><b>Adding Axis Labels</b></a></div>
<div>Axis labels are the text labels centered on each axis. The text inside these labels can be changed, and the style of the text can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'><img class='img-fluid' src='/cookbook/5.0/images/SetAxisLimits.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'><b>Manually Set Axis Limits</b></a></div>
<div>Axis Limits can be set manually in different ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits'><img class='img-fluid' src='/cookbook/5.0/images/GetAxisLimits.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits'><b>Read Axis Limits</b></a></div>
<div>The current axis limits can be read in multiple ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/AutoScale'><img class='img-fluid' src='/cookbook/5.0/images/AutoScale.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/AutoScale'><b>AutoScale Axis Limits to Fit Data</b></a></div>
<div>The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.In older versions of ScottPlot this functionality was achieved by a method named AxisAuto().</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/Frameless'><img class='img-fluid' src='/cookbook/5.0/images/Frameless.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/Frameless'><b>Frameless Plot</b></a></div>
<div>How to create a plot containig only the data area and no axes.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Legend' class='text-dark'>Configuring Legends</a></h2>
<div>A legend is a key typically displayed in the corner of a plot</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/LegendStyle'><img class='img-fluid' src='/cookbook/5.0/images/LegendStyle.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/LegendStyle'><b>Legend Customization</b></a></div>
<div>The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/ManualLegend'><img class='img-fluid' src='/cookbook/5.0/images/ManualLegend.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/ManualLegend'><b>Manual Legend</b></a></div>
<div>Legends may be constructed manually.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Styling' class='text-dark'>Styling Plots</a></h2>
<div>How to customize plots</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/StyleClass'><img class='img-fluid' src='/cookbook/5.0/images/StyleClass.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/StyleClass'><b>Style Helper Functions</b></a></div>
<div>Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/AxisCustom'><img class='img-fluid' src='/cookbook/5.0/images/AxisCustom.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/AxisCustom'><b>Axis Customization</b></a></div>
<div>Axis labels, tick marks, and frame can all be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Palette'><img class='img-fluid' src='/cookbook/5.0/images/Palette.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Palette'><b>Palettes</b></a></div>
<div>A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Markers'><img class='img-fluid' src='/cookbook/5.0/images/Markers.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Markers'><b>Markers</b></a></div>
<div>Many plot types have a MarkerStyle which can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/MarkerNames'><img class='img-fluid' src='/cookbook/5.0/images/MarkerNames.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/MarkerNames'><b>Marker Names</b></a></div>
<div>Markers can be referred to by their name.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/LineStyles'><img class='img-fluid' src='/cookbook/5.0/images/LineStyles.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/LineStyles'><b>Line Styles</b></a></div>
<div>Many plot types have a LineStyle which can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Scaling'><img class='img-fluid' src='/cookbook/5.0/images/Scaling.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Scaling'><b>Scaling</b></a></div>
<div>All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.</div>
</div>
</div>
<h1>Axis</h1>
<h2 class=''><a href='/cookbook/5.0/CustomizingGrids' class='text-dark'>Customizing Grids</a></h2>
<div>Advanced customization of grid lines</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/HideGrid'><img class='img-fluid' src='/cookbook/5.0/images/HideGrid.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingGrids/HideGrid'><b>Hide Grid</b></a></div>
<div>Grid lines can be hidden.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/GridCustom'><img class='img-fluid' src='/cookbook/5.0/images/GridCustom.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingGrids/GridCustom'><b>Grid Customization</b></a></div>
<div>Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/GridAbove'><img class='img-fluid' src='/cookbook/5.0/images/GridAbove.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingGrids/GridAbove'><b>Grid Above Data</b></a></div>
<div>Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/CustomizingTicks' class='text-dark'>Customizing Ticks</a></h2>
<div>Advanced customization of tick marks and tick labels</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'><img class='img-fluid' src='/cookbook/5.0/images/CustomTickFormatter.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'><b>Custom Tick Formatters</b></a></div>
<div>Users can customize the logic used to create tick labels from tick positions.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/AltTickGen'><img class='img-fluid' src='/cookbook/5.0/images/AltTickGen.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/AltTickGen'><b>Custom Tick Generators</b></a></div>
<div>Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/CustomTicks'><img class='img-fluid' src='/cookbook/5.0/images/CustomTicks.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/CustomTicks'><b>Custom Tick Positions</b></a></div>
<div>Users can define ticks to be placed at specific locations.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/DateTimeAxes' class='text-dark'>DateTime Axes</a></h2>
<div>Plot data values on a DataTime axes</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/DateTimeAxisQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'><b>DateTime Axis Quickstart</b></a></div>
<div>Axis tick labels can be displayed using a time format.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/MultiAxis' class='text-dark'>Advanced Axis Features</a></h2>
<div>Tick mark customization and creation of multi-Axis plots</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/MultiAxis/RightAxis'><img class='img-fluid' src='/cookbook/5.0/images/RightAxis.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/MultiAxis/RightAxis'><b>Right Axis</b></a></div>
<div>New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. </div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/MultiAxisQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart'><b>Multi-Axis</b></a></div>
<div>Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.</div>
</div>
</div>
<h1>Plot Types</h1>
<h2 class=''><a href='/cookbook/5.0/Bar' class='text-dark'>Bar Plot</a></h2>
<div>Bar plots represent values as horizontal or vertical rectangles</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/Quickstart'><img class='img-fluid' src='/cookbook/5.0/images/Quickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/Quickstart'><b>Bar Plot Quickstart</b></a></div>
<div>Bar plots can be added from a series of values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarPosition'><img class='img-fluid' src='/cookbook/5.0/images/BarPosition.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarPosition'><b>Bar Positioning</b></a></div>
<div>The exact position and size of each bar may be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarWithError'><img class='img-fluid' src='/cookbook/5.0/images/BarWithError.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarWithError'><b>Bars with Error</b></a></div>
<div>Bars can have errorbars.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarTickLabels'><img class='img-fluid' src='/cookbook/5.0/images/BarTickLabels.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarTickLabels'><b>Bars with Labeled Ticks</b></a></div>
<div>Bars can be labeled by manually specifying axis tick mark positions and labels.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarStackVertically'><img class='img-fluid' src='/cookbook/5.0/images/BarStackVertically.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarStackVertically'><b>Stacked Bar Plot</b></a></div>
<div>Bars can be positioned on top of each other.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/GroupedBarPlot'><img class='img-fluid' src='/cookbook/5.0/images/GroupedBarPlot.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/GroupedBarPlot'><b>Grouped Bar Plot</b></a></div>
<div>Bars can be grouped by position and color.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Box' class='text-dark'>Box Plot</a></h2>
<div>Box plots show a distribution at a glance</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/BoxPlotQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/BoxPlotQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/BoxPlotQuickstart'><b>Box Plot Quickstart</b></a></div>
<div>Box plots can be created individually and added to the plot.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/BoxPlotGroups'><img class='img-fluid' src='/cookbook/5.0/images/BoxPlotGroups.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/BoxPlotGroups'><b>Box Plot Groups</b></a></div>
<div>Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/ErrorBar' class='text-dark'>Error Bars</a></h2>
<div>Error Bars communicate the range of possible values for a measurement</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/ErrorBarQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'><b>Error Bar Quickstart</b></a></div>
<div>Error Bars go well with scatter plots.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ErrorBar/CustomErrors'><img class='img-fluid' src='/cookbook/5.0/images/CustomErrors.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ErrorBar/CustomErrors'><b>ErrorBar Values</b></a></div>
<div>Error size can be set for all dimensions.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/FillY' class='text-dark'>FillY plot</a></h2>
<div>FillY plots display the vertical range between two Y values at defined X positions</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/FillYFromArrays'><img class='img-fluid' src='/cookbook/5.0/images/FillYFromArrays.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/FillYFromArrays'><b>FillY From Array Data</b></a></div>
<div>FillY plots can be created from X, Y1, and Y2 arrays.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/FillYFromScatters'><img class='img-fluid' src='/cookbook/5.0/images/FillYFromScatters.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/FillYFromScatters'><b>FillY From Scatter Plots</b></a></div>
<div>FillY plots can be created from two scatter plots that share the same X values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/Function'><img class='img-fluid' src='/cookbook/5.0/images/Function.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/Function'><b>FillY with Custom Type</b></a></div>
<div>FillY plots can be created from data of any type if a conversion function is supplied.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/Styling'><img class='img-fluid' src='/cookbook/5.0/images/Styling.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/Styling'><b>FillY Plot Styling</b></a></div>
<div>FillY plots can be customized using public properties.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Finance' class='text-dark'>Financial Plot</a></h2>
<div>Finance plots display price data binned into time ranges</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/Candlestick'><img class='img-fluid' src='/cookbook/5.0/images/Candlestick.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/Candlestick'><b>Candlestick Chart</b></a></div>
<div>Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/OhlcChart'><img class='img-fluid' src='/cookbook/5.0/images/OhlcChart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/OhlcChart'><b>OHLC Chart</b></a></div>
<div>OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceRightAxis'><img class='img-fluid' src='/cookbook/5.0/images/FinanceRightAxis.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceRightAxis'><b>Price on Right</b></a></div>
<div>Finance charts can be created which display price information on the right axis.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceSma'><img class='img-fluid' src='/cookbook/5.0/images/FinanceSma.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceSma'><b>Simple Moving Average</b></a></div>
<div>Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceBollinger'><img class='img-fluid' src='/cookbook/5.0/images/FinanceBollinger.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceBollinger'><b>Bollinger Bands</b></a></div>
<div>Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Function' class='text-dark'>Function</a></h2>
<div>Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Function/FunctionQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/FunctionQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Function/FunctionQuickstart'><b>Function Quickstart</b></a></div>
<div>Create a function plot from a formula.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Heatmap' class='text-dark'>Heatmap</a></h2>
<div>Heatmaps display values from 2D data as an image with cells of different intensities</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'><b>Heatmap Quickstart</b></a></div>
<div>Heatmaps can be created from 2D arrays</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapInverted'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapInverted.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapInverted'><b>Inverted Heatmap</b></a></div>
<div>Heatmaps can be inverted by reversing the order of colors in the colormap</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/LinePlot' class='text-dark'>Line Plot</a></h2>
<div>Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LineQuickStart'><img class='img-fluid' src='/cookbook/5.0/images/LineQuickStart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/LinePlot/LineQuickStart'><b>Line Plot Quickstart</b></a></div>
<div>Line plots are placed with a start and end location in coordinate space. Their styles can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LinePlotStyles'><img class='img-fluid' src='/cookbook/5.0/images/LinePlotStyles.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/LinePlot/LinePlotStyles'><b>Line Plot Shapes</b></a></div>
<div>Line plots can be styled using a LineStyle.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER'><img class='img-fluid' src='/cookbook/5.0/images/LinePlotLegendQWER.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER'><b>Line Plot Legend</b></a></div>
<div>Line plots with labels appear in the legend.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Marker' class='text-dark'>Marker</a></h2>
<div>Markers can be placed on the plot in coordinate space.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkerQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/MarkerQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerQuickstart'><b>Marker Quickstart</b></a></div>
<div>Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkerShapes'><img class='img-fluid' src='/cookbook/5.0/images/MarkerShapes.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerShapes'><b>Marker Shapes</b></a></div>
<div>Many marker shapes are available.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkerLegend'><img class='img-fluid' src='/cookbook/5.0/images/MarkerLegend.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerLegend'><b>Marker Legend</b></a></div>
<div>Markers with labels appear in the legend.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Polygon' class='text-dark'>Polygon Plot</a></h2>
<div>Polygon plots draws a polygon</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Polygon/PolygonQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/PolygonQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Polygon/PolygonQuickstart'><b>Polygon Plot Quickstart</b></a></div>
<div>Polygon plots can be added from a series of vertices, and must be in clockwise order.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Polygon/PolygonStyling'><img class='img-fluid' src='/cookbook/5.0/images/PolygonStyling.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Polygon/PolygonStyling'><b>Polygon Plot Styling</b></a></div>
<div>Polygon plots can be fully customized.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Scatter' class='text-dark'>Scatter Plot</a></h2>
<div>Scatter plots display points at X/Y locations in coordinate space.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/ScatterQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterQuickstart'><b>Scatter Plot Quickstart</b></a></div>
<div>Scatter plots can be created from two arrays containing X and Y values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterCoordinates'><img class='img-fluid' src='/cookbook/5.0/images/ScatterCoordinates.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterCoordinates'><b>Scatter Plot Coordinates</b></a></div>
<div>Scatter plots can be created from a collection of Coordinates.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterDataType'><img class='img-fluid' src='/cookbook/5.0/images/ScatterDataType.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterDataType'><b>Scatter Plot Data Type</b></a></div>
<div>Scatter plots can be created from any numeric data type, not just double.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterList'><img class='img-fluid' src='/cookbook/5.0/images/ScatterList.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterList'><b>Scatter Plot of List Data</b></a></div>
<div>Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterStyling'><img class='img-fluid' src='/cookbook/5.0/images/ScatterStyling.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterStyling'><b>Scatter Plot Styling</b></a></div>
<div>Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterLinePatterns'><img class='img-fluid' src='/cookbook/5.0/images/ScatterLinePatterns.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterLinePatterns'><b>Scatter Line Patterns</b></a></div>
<div>Several line patterns are available</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterGeneric'><img class='img-fluid' src='/cookbook/5.0/images/ScatterGeneric.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterGeneric'><b>Scatter Generic</b></a></div>
<div>Scatter plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterDateTime'><img class='img-fluid' src='/cookbook/5.0/images/ScatterDateTime.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterDateTime'><b>Scatter DateTime</b></a></div>
<div>A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Signal' class='text-dark'>Signal Plot</a></h2>
<div>Signal plots display evenly-spaced data</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/SignalQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalQuickstart'><b>Signal Plot Quickstart</b></a></div>
<div>Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalStyling'><img class='img-fluid' src='/cookbook/5.0/images/SignalStyling.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalStyling'><b>Signal Plot Styling</b></a></div>
<div>Signal plots can be styled in a variety of ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalOffset'><img class='img-fluid' src='/cookbook/5.0/images/SignalOffset.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalOffset'><b>Signal Offset</b></a></div>
<div>Signal plots can be offset by a given X and Y value.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalMarkerSize'><img class='img-fluid' src='/cookbook/5.0/images/SignalMarkerSize.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalMarkerSize'><b>Signal Marker Size</b></a></div>
<div>Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalRenderIndexes'><img class='img-fluid' src='/cookbook/5.0/images/SignalRenderIndexes.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalRenderIndexes'><b>Partial Signal Rendering</b></a></div>
<div>Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalGeneric'><img class='img-fluid' src='/cookbook/5.0/images/SignalGeneric.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalGeneric'><b>Signal Generic</b></a></div>
<div>Signal plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalDateTime'><img class='img-fluid' src='/cookbook/5.0/images/SignalDateTime.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalDateTime'><b>Signal DateTime</b></a></div>
<div>A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/SignalXY' class='text-dark'>SignalXY Plot</a></h2>
<div>SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'><b>SignalXY Quickstart</b></a></div>
<div>SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYGeneric'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYGeneric.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYGeneric'><b>SignalXY Generic</b></a></div>
<div>SignalXY plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Text' class='text-dark'>Text</a></h2>
<div>Text lables placed on the plot in coordinate space</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Text/TextQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/TextQuickstart.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Text/TextQuickstart'><b>Text Quickstart</b></a></div>
<div>Text can be placed anywhere in coordinate space.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Text/Formatting'><img class='img-fluid' src='/cookbook/5.0/images/Formatting.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Text/Formatting'><b>Text Formatting</b></a></div>
<div>Text formatting can be extensively customized.</div>
</div>
</div>
<h1>Statistics</h1>
<h2 class=''><a href='/cookbook/5.0/Regression' class='text-dark'>Regression</a></h2>
<div>Statistical operations to fit lines to data</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Regression/Linear'><img class='img-fluid' src='/cookbook/5.0/images/Linear.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Regression/Linear'><b>LinearRegression</b></a></div>
<div>Fit a line to a collection of X/Y data points.</div>
</div>
</div>
