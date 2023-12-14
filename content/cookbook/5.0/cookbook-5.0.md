---
Title: ScottPlot 5.0 Cookbook
Description: Example plots shown next to the code used to create them
URL: /cookbook/5.0//index.html
BreadcrumbNames: ["ScottPlot 5.0 Cookbook"]
BreadcrumbUrls: ["/cookbook/5.0/"]
Date: 2023-12-14
Version: ScottPlot 5.0.10-beta
---

# ScottPlot 5.0 Cookbook



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.10-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>


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
<div><a href='/cookbook/5.0/AxisAndTicks/AutoScale'><b>Zoom to Fit Data</b></a></div>
<div>The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.</div>
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
<a href='/cookbook/5.0/Styling/GridCustom'><img class='img-fluid' src='/cookbook/5.0/images/GridCustom.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/GridCustom'><b>Grid Customization</b></a></div>
<div>Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/GridAbove'><img class='img-fluid' src='/cookbook/5.0/images/GridAbove.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/GridAbove'><b>Grid Above Data</b></a></div>
<div>Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.</div>
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
<div>Box plots can be added from a series of values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/IndividualBox'><img class='img-fluid' src='/cookbook/5.0/images/IndividualBox.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/IndividualBox'><b>Individual Box Plots</b></a></div>
<div>One can easily create a box plot with only a single box.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/HorizontalBox'><img class='img-fluid' src='/cookbook/5.0/images/HorizontalBox.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/HorizontalBox'><b>Horizontal Box Plots</b></a></div>
<div>Box plots can be oriented horizontally, similarly to bar plots.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/BoxSeries'><img class='img-fluid' src='/cookbook/5.0/images/BoxSeries.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/BoxSeries'><b>Box Plot Series</b></a></div>
<div>Similarly to bar charts, box plots can be compared across multiple categories.</div>
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
<a href='/cookbook/5.0/Finance/OHLC'><img class='img-fluid' src='/cookbook/5.0/images/OHLC.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/OHLC'><b>OHLC Chart</b></a></div>
<div>OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/Candlestick'><img class='img-fluid' src='/cookbook/5.0/images/Candlestick.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/Candlestick'><b>Candlestick Chart</b></a></div>
<div>Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.</div>
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
<h2 class=''><a href='/cookbook/5.0/Signal' class='text-dark'>Signal Plot</a></h2>
<div>Signal plots display evenly-spaced data</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/Offset'><img class='img-fluid' src='/cookbook/5.0/images/Offset.png' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/Offset'><b>Offset</b></a></div>
<div>Signal plots can be offset by a given X and Y value.</div>
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
