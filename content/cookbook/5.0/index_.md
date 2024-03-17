---
Title: ScottPlot 5.0 Cookbook
Description: Example plots shown next to the code used to create them
URL: /cookbook/5.0/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook"]
BreadcrumbUrls: ["/cookbook/5.0/"]
Date: 2024-03-17
Version: ScottPlot 5.0.22
Version: ScottPlot 5.0.22
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# ScottPlot 5.0 Cookbook

<div class='mt-3 fs-4'><strong>Introduction</strong></div>
<ul>
<li><a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> - A survey of basic functionality in ScottPlot 5</li>
<li><a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> - Examples of common customizations for axis labels and ticks</li>
<li><a href='/cookbook/5.0/Legend'>Configuring Legends</a> - A legend is a key typically displayed in the corner of a plot</li>
<li><a href='/cookbook/5.0/Styling'>Styling Plots</a> - How to customize appearance of plots</li>
</ul>
<div class='mt-3 fs-4'><strong>Axis</strong></div>
<ul>
<li><a href='/cookbook/5.0/AdvancedAxis'>Advanced Axis Features</a> - How to further customize axes</li>
<li><a href='/cookbook/5.0/CustomizingGrids'>Customizing Grids</a> - Advanced customization of grid lines</li>
<li><a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> - Advanced customization of tick marks and tick labels</li>
<li><a href='/cookbook/5.0/DateTimeAxes'>DateTime Axes</a> - Plot data values on a DataTime axes</li>
<li><a href='/cookbook/5.0/MultiAxis'>Multiple Axes</a> - Tick mark customization and creation of multi-Axis plots</li>
</ul>
<div class='mt-3 fs-4'><strong>Plot Types</strong></div>
<ul>
<li><a href='/cookbook/5.0/ArrowCoordinated'>Arrow</a> - Arrows point to a location in coordinate space.</li>
<li><a href='/cookbook/5.0/AxisLines'>Axis Lines</a> - Axis lines indicate a position on an axis.</li>
<li><a href='/cookbook/5.0/AxisSpans'>Axis Spans</a> - Axis spans indicate a range of an axis.</li>
<li><a href='/cookbook/5.0/Bar'>Bar Plot</a> - Bar plots represent values as horizontal or vertical rectangles</li>
<li><a href='/cookbook/5.0/Box'>Box Plot</a> - Box plots show a distribution at a glance</li>
<li><a href='/cookbook/5.0/Ellipse'>Ellipse</a> - Ellipses are curves with a defined center and distinct X and Y radii. A circle is an ellipse with an X radius equal to its Y radius.</li>
<li><a href='/cookbook/5.0/ErrorBar'>Error Bars</a> - Error Bars communicate the range of possible values for a measurement</li>
<li><a href='/cookbook/5.0/FillY'>FillY plot</a> - FillY plots display the vertical range between two Y values at defined X positions</li>
<li><a href='/cookbook/5.0/Finance'>Financial Plot</a> - Finance plots display price data binned into time ranges</li>
<li><a href='/cookbook/5.0/Function'>Function</a> - Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.</li>
<li><a href='/cookbook/5.0/Heatmap'>Heatmap</a> - Heatmaps display values from 2D data as an image with cells of different intensities</li>
<li><a href='/cookbook/5.0/LinePlot'>Line Plot</a> - Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.</li>
<li><a href='/cookbook/5.0/Marker'>Marker</a> - Markers can be placed on the plot in coordinate space.</li>
<li><a href='/cookbook/5.0/Pie'>Pie</a> - Pie charts illustrate numerical proportions as slices of a circle.</li>
<li><a href='/cookbook/5.0/RadialGauge'>Radial gauge</a> - A radial gauge chart displays scalar data as circular gauges.</li>
<li><a href='/cookbook/5.0/Scatter'>Scatter Plot</a> - Scatter plots display points at X/Y locations in coordinate space.</li>
<li><a href='/cookbook/5.0/Shapes'>Shapes</a> - Basic shapes that can be added to plots</li>
<li><a href='/cookbook/5.0/Signal'>Signal Plot</a> - Signal plots display evenly-spaced data</li>
<li><a href='/cookbook/5.0/SignalConst'>SignalConst</a> - SignalConst is a type of signal plot which contains immutable data points and occupies more memory but offers greater performance for extremely large datasets. It is rarely needed, but best use for plotting data containing millions of points.</li>
<li><a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> - SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).</li>
<li><a href='/cookbook/5.0/Text'>Text</a> - Text labels can be placed on the plot in coordinate space</li>
</ul>
<div class='mt-3 fs-4'><strong>Statistics</strong></div>
<ul>
<li><a href='/cookbook/5.0/Regression'>Regression</a> - Statistical operations to fit lines to data</li>
</ul>
<div class='mt-3 fs-4'><strong>Miscellaneous</strong></div>
<ul>
<li><a href='/cookbook/5.0/AdvancedStyling'>Advanced Styling</a> - Features for users seeking extensive customization options.</li>
<li><a href='/cookbook/5.0/Internationalization'>Internationalization</a> - Using ScottPlot across cultures with different text and numeric requirements.</li>
</ul>
<h1>Introduction</h1>
<h2 class=''><a href='/cookbook/5.0/ScottPlotQuickstart' class='text-dark'>Quickstart</a></h2>
<div>A survey of basic functionality in ScottPlot 5</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartScatter.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter'><b>Scatter Plot</b></a></div>
<div>Display paired X/Y data as a scatter plot.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables'><img class='img-fluid' src='/cookbook/5.0/images/CustomizingPlottables.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables'><b>Customizing Plottables</b></a></div>
<div>Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartSignal.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartSignal'><b>Signal Plot</b></a></div>
<div>Signal plots are optimized for displaying evenly spaced data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance'><img class='img-fluid' src='/cookbook/5.0/images/SignalPerformance.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/SignalPerformance'><b>Signal Plot Performance</b></a></div>
<div>Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels'><img class='img-fluid' src='/cookbook/5.0/images/QuickstartAxisLabels.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartAxisLabels'><b>Axis Labels</b></a></div>
<div>Axis labels can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/Legend'><img class='img-fluid' src='/cookbook/5.0/images/Legend.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/Legend'><b>Legend</b></a></div>
<div>A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ScottPlotQuickstart/AddPlottablesManually'><img class='img-fluid' src='/cookbook/5.0/images/AddPlottablesManually.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ScottPlotQuickstart/AddPlottablesManually'><b>Add Plottables Manually</b></a></div>
<div>Although the Plot.Add class has many helpful methods for creating plottable objects and adding them to the plot, users can instantiate plottable objects themselves and use Add.Plottable() to place it on the plot. This stategy allows users to create their own plottables (implementing IPlottable) with custom appearance or behavior.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/AxisAndTicks' class='text-dark'>Axis and Ticks</a></h2>
<div>Examples of common customizations for axis labels and ticks</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'><img class='img-fluid' src='/cookbook/5.0/images/SetAxisLimits.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits'><b>Set Axis Limits</b></a></div>
<div>Axis Limits can be set by the user.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits'><img class='img-fluid' src='/cookbook/5.0/images/GetAxisLimits.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits'><b>Read Axis Limits</b></a></div>
<div>Use GetLimits() to obtain the current axis limits.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/AutoScale'><img class='img-fluid' src='/cookbook/5.0/images/AutoScale.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisAndTicks/AutoScale'><b>AutoScale Axis Limits to Fit Data</b></a></div>
<div>The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.In older versions of ScottPlot this functionality was achieved by a method named AxisAuto().</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisAndTicks/Frameless'><img class='img-fluid' src='/cookbook/5.0/images/Frameless.png?240316204900' /></a>
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
<a href='/cookbook/5.0/Legend/LegendQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/LegendQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/LegendQuickstart'><b>Legend Quickstart</b></a></div>
<div>Many plottables have a Label property that can be set so they appear in the legend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/ManualLegend'><img class='img-fluid' src='/cookbook/5.0/images/ManualLegend.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/ManualLegend'><b>Manual Legend Items</b></a></div>
<div>Legends may be constructed manually.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/LegendStyle'><img class='img-fluid' src='/cookbook/5.0/images/LegendStyle.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/LegendStyle'><b>Legend Customization</b></a></div>
<div>Access the Legend object directly for advanced customization options.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/LegendOrientation'><img class='img-fluid' src='/cookbook/5.0/images/LegendOrientation.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/LegendOrientation'><b>Legend Orientation</b></a></div>
<div>Legend items may be arranged horizontally instead of vertically</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Legend/LegendWrapping'><img class='img-fluid' src='/cookbook/5.0/images/LegendWrapping.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Legend/LegendWrapping'><b>Legend Wrapping</b></a></div>
<div>Legend items may wrap to improve display for a large number of items</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Styling' class='text-dark'>Styling Plots</a></h2>
<div>How to customize appearance of plots</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/StyleClass'><img class='img-fluid' src='/cookbook/5.0/images/StyleClass.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/StyleClass'><b>Style Helper Functions</b></a></div>
<div>Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/AxisCustom'><img class='img-fluid' src='/cookbook/5.0/images/AxisCustom.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/AxisCustom'><b>Axis Customization</b></a></div>
<div>Axis labels, tick marks, and frame can all be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Palette'><img class='img-fluid' src='/cookbook/5.0/images/Palette.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Palette'><b>Palettes</b></a></div>
<div>A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Markers'><img class='img-fluid' src='/cookbook/5.0/images/Markers.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Markers'><b>Markers</b></a></div>
<div>Many plot types have a MarkerStyle which can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/MarkerNames'><img class='img-fluid' src='/cookbook/5.0/images/MarkerNames.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/MarkerNames'><b>Marker Names</b></a></div>
<div>Markers can be referred to by their name.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/LineStyles'><img class='img-fluid' src='/cookbook/5.0/images/LineStyles.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/LineStyles'><b>Line Styles</b></a></div>
<div>Many plot types have a LineStyle which can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/Scaling'><img class='img-fluid' src='/cookbook/5.0/images/Scaling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/Scaling'><b>Scaling</b></a></div>
<div>All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Styling/DarkMode'><img class='img-fluid' src='/cookbook/5.0/images/DarkMode.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Styling/DarkMode'><b>Dark Mode</b></a></div>
<div>Plots can be created using dark mode by setting the colors of major plot components to ones consistent with a dark theme.</div>
</div>
</div>
<h1>Axis</h1>
<h2 class=''><a href='/cookbook/5.0/AdvancedAxis' class='text-dark'>Advanced Axis Features</a></h2>
<div>How to further customize axes</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'><img class='img-fluid' src='/cookbook/5.0/images/InvertedAxis.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedAxis/InvertedAxis'><b>Inverted Axis</b></a></div>
<div>Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedAxis/InvertedAutoAxis'><img class='img-fluid' src='/cookbook/5.0/images/InvertedAutoAxis.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedAxis/InvertedAutoAxis'><b>Inverted Auto-Axis</b></a></div>
<div>Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedAxis/SquareAxisUnits'><img class='img-fluid' src='/cookbook/5.0/images/SquareAxisUnits.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedAxis/SquareAxisUnits'><b>SquareAxisUnits</b></a></div>
<div>Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/CustomizingGrids' class='text-dark'>Customizing Grids</a></h2>
<div>Advanced customization of grid lines</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/HideGrid'><img class='img-fluid' src='/cookbook/5.0/images/HideGrid.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingGrids/HideGrid'><b>Hide Grid</b></a></div>
<div>Grid lines can be hidden.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/GridCustom'><img class='img-fluid' src='/cookbook/5.0/images/GridCustom.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingGrids/GridCustom'><b>Grid Customization</b></a></div>
<div>Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingGrids/GridAbove'><img class='img-fluid' src='/cookbook/5.0/images/GridAbove.png?240316204900' /></a>
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
<a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'><img class='img-fluid' src='/cookbook/5.0/images/CustomTickFormatter.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'><b>Custom Tick Formatters</b></a></div>
<div>Users can customize the logic used to create tick labels from tick positions. Old versions of ScottPlot achieved this using a ManualTickPositions method.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/AltTickGen'><img class='img-fluid' src='/cookbook/5.0/images/AltTickGen.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/AltTickGen'><b>Custom Tick Generators</b></a></div>
<div>Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/CustomTicks'><img class='img-fluid' src='/cookbook/5.0/images/CustomTicks.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/CustomTicks'><b>Custom Tick Positions</b></a></div>
<div>Users can define ticks to be placed at specific locations.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/RotatedTicks'><img class='img-fluid' src='/cookbook/5.0/images/RotatedTicks.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/RotatedTicks'><b>Rotated Tick Labels</b></a></div>
<div>Users can customize tick label rotation.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels'><img class='img-fluid' src='/cookbook/5.0/images/RotatedTicksLongLabels.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels'><b>Rotated Tick with Long Labels</b></a></div>
<div>The axis size can be increased to accommodate rotated or long tick labels.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/DisableGridLines'><img class='img-fluid' src='/cookbook/5.0/images/DisableGridLines.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/DisableGridLines'><b>Disable Grid Lines</b></a></div>
<div>Users can disable grid lines for specific axes.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution'><img class='img-fluid' src='/cookbook/5.0/images/StandardMinorTickDistribution.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution'><b>Minor Tick Density</b></a></div>
<div>Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/CustomizingTicks/LogScaleTicks'><img class='img-fluid' src='/cookbook/5.0/images/LogScaleTicks.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/CustomizingTicks/LogScaleTicks'><b>Log Scale Tick Marks</b></a></div>
<div>The apperance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/DateTimeAxes' class='text-dark'>DateTime Axes</a></h2>
<div>Plot data values on a DataTime axes</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/DateTimeAxisQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisQuickstart'><b>DateTime Axis Quickstart</b></a></div>
<div>Axis tick labels can be displayed using a time format.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisMixed'><img class='img-fluid' src='/cookbook/5.0/images/DateTimeAxisMixed.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisMixed'><b>DateTime Axis Values</b></a></div>
<div>DateTime axes are achieved using Microsoft's DateTime.ToOADate() and DateTime.FromOADate() methods to convert between dates and numeric values. Advanced users who wish to display data on DateTime axes may prefer to work with collections of doubles rather than collections of DateTimes.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisCustomFormatter'><img class='img-fluid' src='/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/DateTimeAxes/DateTimeAxisCustomFormatter'><b>Custom DateTime Label Format</b></a></div>
<div>Users can provide their own logic for customizing DateTime tick labels</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/MultiAxis' class='text-dark'>Multiple Axes</a></h2>
<div>Tick mark customization and creation of multi-Axis plots</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/MultiAxis/RightAxis'><img class='img-fluid' src='/cookbook/5.0/images/RightAxis.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/MultiAxis/RightAxis'><b>Right Axis</b></a></div>
<div>New plots have one axis on every side. Axes on the right and top are invisible by default. To use the right axis, make it visible, then tell a plottable to use it. </div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/MultiAxisQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/MultiAxis/MultiAxisQuickstart'><b>Multi-Axis</b></a></div>
<div>Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.</div>
</div>
</div>
<h1>Plot Types</h1>
<h2 class=''><a href='/cookbook/5.0/ArrowCoordinated' class='text-dark'>Arrow</a></h2>
<div>Arrows point to a location in coordinate space.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ArrowCoordinated/ArrowQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/ArrowQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ArrowCoordinated/ArrowQuickstart'><b>Arrow Quickstart</b></a></div>
<div>Arrows can be placed on plots to point to a location in coordinate space and extensively customized.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/AxisLines' class='text-dark'>Axis Lines</a></h2>
<div>Axis lines indicate a position on an axis.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisLines/AxisLineQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/AxisLineQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisLines/AxisLineQuickstart'><b>Axis Lines</b></a></div>
<div>Axis lines are vertical or horizontal lines that span an entire axis.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisLines/AxisLineLabel'><img class='img-fluid' src='/cookbook/5.0/images/AxisLineLabel.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisLines/AxisLineLabel'><b>Axis Line Label</b></a></div>
<div>Axis lines have labels that can be used to display arbitrary on the axes they are attached to.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisLines/AxisLineStyle'><img class='img-fluid' src='/cookbook/5.0/images/AxisLineStyle.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisLines/AxisLineStyle'><b>Axis Line Style</b></a></div>
<div>Axis lines have extensive customization options.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/AxisSpans' class='text-dark'>Axis Spans</a></h2>
<div>Axis spans indicate a range of an axis.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisSpans/AxisSpanQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/AxisSpanQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisSpans/AxisSpanQuickstart'><b>Axis Span Quickstart</b></a></div>
<div>Axis spans label a range of an axis. Vertical spans shade the full width of a vertical range, and horizontal spans shade the full height of a horizontal range.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AxisSpans/AxisSpanStyling'><img class='img-fluid' src='/cookbook/5.0/images/AxisSpanStyling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AxisSpans/AxisSpanStyling'><b>Axis Span Styling</b></a></div>
<div>Axis spans can be extensively customized.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Bar' class='text-dark'>Bar Plot</a></h2>
<div>Bar plots represent values as horizontal or vertical rectangles</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/Quickstart'><img class='img-fluid' src='/cookbook/5.0/images/Quickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/Quickstart'><b>Bar Plot Quickstart</b></a></div>
<div>Bar plots can be added from a series of values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarLegend'><img class='img-fluid' src='/cookbook/5.0/images/BarLegend.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarLegend'><b>Bar Plot Legend</b></a></div>
<div>A collection of bars can appear in the legend as a single item.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarValues'><img class='img-fluid' src='/cookbook/5.0/images/BarValues.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarValues'><b>Bar with Value Labels</b></a></div>
<div>Set the `Label` property of bars to have text displayed above each bar.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarPosition'><img class='img-fluid' src='/cookbook/5.0/images/BarPosition.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarPosition'><b>Bar Positioning</b></a></div>
<div>The exact position and size of each bar may be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarWithError'><img class='img-fluid' src='/cookbook/5.0/images/BarWithError.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarWithError'><b>Bars with Error</b></a></div>
<div>Bars can have errorbars.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarTickLabels'><img class='img-fluid' src='/cookbook/5.0/images/BarTickLabels.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarTickLabels'><b>Bars with Labeled Ticks</b></a></div>
<div>Bars can be labeled by manually specifying axis tick mark positions and labels.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/BarStackVertically'><img class='img-fluid' src='/cookbook/5.0/images/BarStackVertically.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/BarStackVertically'><b>Stacked Bar Plot</b></a></div>
<div>Bars can be positioned on top of each other.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/GroupedBarPlot'><img class='img-fluid' src='/cookbook/5.0/images/GroupedBarPlot.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/GroupedBarPlot'><b>Grouped Bar Plot</b></a></div>
<div>Bars can be grouped by position and color.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Bar/HorizontalBar'><img class='img-fluid' src='/cookbook/5.0/images/HorizontalBar.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Bar/HorizontalBar'><b>Horizontal Bar Plot</b></a></div>
<div>Bar plots can be displayed horizontally.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Box' class='text-dark'>Box Plot</a></h2>
<div>Box plots show a distribution at a glance</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/BoxPlotQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/BoxPlotQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/BoxPlotQuickstart'><b>Box Plot Quickstart</b></a></div>
<div>Box plots can be created individually and added to the plot.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Box/BoxPlotGroups'><img class='img-fluid' src='/cookbook/5.0/images/BoxPlotGroups.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Box/BoxPlotGroups'><b>Box Plot Groups</b></a></div>
<div>Each collection of boxes added to the plot gets styled the same and appears as a single item in the legend. Add multiple bar series plots with defined X positions to give the appearance of grouped data.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Ellipse' class='text-dark'>Ellipse</a></h2>
<div>Ellipses are curves with a defined center and distinct X and Y radii. A circle is an ellipse with an X radius equal to its Y radius.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Ellipse/PlotEllipseQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/PlotEllipseQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Ellipse/PlotEllipseQuickstart'><b>Ellipse Quickstart</b></a></div>
<div>Ellipses can be added to plots</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Ellipse/PlotCircleQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/PlotCircleQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Ellipse/PlotCircleQuickstart'><b>Circle Quickstart</b></a></div>
<div>Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Ellipse/CircleWithLockedScale'><img class='img-fluid' src='/cookbook/5.0/images/CircleWithLockedScale.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Ellipse/CircleWithLockedScale'><b>Circle with Locked Scale</b></a></div>
<div>For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Ellipse/EllipseStyling'><img class='img-fluid' src='/cookbook/5.0/images/EllipseStyling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Ellipse/EllipseStyling'><b>Ellipse Styling</b></a></div>
<div>Ellipses styles can be extensively customized</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Ellipse/EllipseRotation'><img class='img-fluid' src='/cookbook/5.0/images/EllipseRotation.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Ellipse/EllipseRotation'><b>Ellipse Rotation</b></a></div>
<div>Ellipses can also be rotated</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/ErrorBar' class='text-dark'>Error Bars</a></h2>
<div>Error Bars communicate the range of possible values for a measurement</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/ErrorBarQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/ErrorBar/ErrorBarQuickstart'><b>Error Bar Quickstart</b></a></div>
<div>Error Bars go well with scatter plots.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/ErrorBar/CustomErrors'><img class='img-fluid' src='/cookbook/5.0/images/CustomErrors.png?240316204900' /></a>
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
<a href='/cookbook/5.0/FillY/FillYFromArrays'><img class='img-fluid' src='/cookbook/5.0/images/FillYFromArrays.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/FillYFromArrays'><b>FillY From Array Data</b></a></div>
<div>FillY plots can be created from X, Y1, and Y2 arrays.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/FillYFromScatters'><img class='img-fluid' src='/cookbook/5.0/images/FillYFromScatters.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/FillYFromScatters'><b>FillY From Scatter Plots</b></a></div>
<div>FillY plots can be created from two scatter plots that share the same X values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/Function'><img class='img-fluid' src='/cookbook/5.0/images/Function.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/FillY/Function'><b>FillY with Custom Type</b></a></div>
<div>FillY plots can be created from data of any type if a conversion function is supplied.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/FillY/Styling'><img class='img-fluid' src='/cookbook/5.0/images/Styling.png?240316204900' /></a>
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
<a href='/cookbook/5.0/Finance/Candlestick'><img class='img-fluid' src='/cookbook/5.0/images/Candlestick.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/Candlestick'><b>Candlestick Chart</b></a></div>
<div>Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/OhlcChart'><img class='img-fluid' src='/cookbook/5.0/images/OhlcChart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/OhlcChart'><b>OHLC Chart</b></a></div>
<div>OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceRightAxis'><img class='img-fluid' src='/cookbook/5.0/images/FinanceRightAxis.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceRightAxis'><b>Price on Right</b></a></div>
<div>Finance charts can be created which display price information on the right axis.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceSma'><img class='img-fluid' src='/cookbook/5.0/images/FinanceSma.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceSma'><b>Simple Moving Average</b></a></div>
<div>Tools exist for creating simple moving average (SMA) curves and displaying them next to finanial data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinanceBollinger'><img class='img-fluid' src='/cookbook/5.0/images/FinanceBollinger.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinanceBollinger'><b>Bollinger Bands</b></a></div>
<div>Tools exist for creating Bollinger Bands which display weighted moving mean and variance for time series financial data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Finance/FinancialPlotWithoutGaps'><img class='img-fluid' src='/cookbook/5.0/images/FinancialPlotWithoutGaps.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Finance/FinancialPlotWithoutGaps'><b>Financial Plot Without Gaps</b></a></div>
<div>When the DateTimes stored in OHLC objects are used to determine the horizontal position of candlesticks, periods without data like weekends and holidays appear as gaps in the plot. Enabling sequential mode causes the plot to ignore the OHLC DateTimes and display candles at integer positions starting from zero. Since this is not a true DateTime axis, users enabling this mode must customize the tick labels themselves.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Function' class='text-dark'>Function</a></h2>
<div>Function plots are a type of line plot where Y positions are defined by a function that depends on X rather than a collection of discrete data points.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Function/FunctionQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/FunctionQuickstart.png?240316204900' /></a>
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
<a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapQuickstart'><b>Heatmap Quickstart</b></a></div>
<div>Heatmaps can be created from 2D arrays</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapInverted'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapInverted.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapInverted'><b>Inverted Heatmap</b></a></div>
<div>Heatmaps can be inverted by reversing the order of colors in the colormap</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapColormap'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapColormap.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapColormap'><b>Heatmap with custom Colormap</b></a></div>
<div>A heatmap's Colormap is the logic used to convert from cell value to cell color and they can set by the user. ScottPlot comes with many common colormaps, but users may implement IColormap and apply their own. A colorbar can be added to indicate which colors map to which values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapFlip'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapFlip.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapFlip'><b>Flipped Heatmap</b></a></div>
<div>Heatmaps can be flipped horizontally and/or vertically</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Heatmap/HeatmapSmooth'><img class='img-fluid' src='/cookbook/5.0/images/HeatmapSmooth.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Heatmap/HeatmapSmooth'><b>Smooth Heatmap</b></a></div>
<div>Enable the `Smooth` property for anti-aliased rendering</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/LinePlot' class='text-dark'>Line Plot</a></h2>
<div>Line plots can be placed on the plot in coordinate space using a Start, End, and an optional LineStyle.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LineQuickStart'><img class='img-fluid' src='/cookbook/5.0/images/LineQuickStart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/LinePlot/LineQuickStart'><b>Line Plot Quickstart</b></a></div>
<div>Line plots are placed with a start and end location in coordinate space. Their styles can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LinePlotStyles'><img class='img-fluid' src='/cookbook/5.0/images/LinePlotStyles.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/LinePlot/LinePlotStyles'><b>Line Plot Shapes</b></a></div>
<div>Line plots can be styled using a LineStyle.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/LinePlot/LinePlotLegendQWER'><img class='img-fluid' src='/cookbook/5.0/images/LinePlotLegendQWER.png?240316204900' /></a>
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
<a href='/cookbook/5.0/Marker/MarkerQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/MarkerQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerQuickstart'><b>Marker Quickstart</b></a></div>
<div>Markers are symbols placed at a location in coordinate space. Their shape, size, and color can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkerShapes'><img class='img-fluid' src='/cookbook/5.0/images/MarkerShapes.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerShapes'><b>Marker Shapes</b></a></div>
<div>Many marker shapes are available.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkerLegend'><img class='img-fluid' src='/cookbook/5.0/images/MarkerLegend.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkerLegend'><b>Marker Legend</b></a></div>
<div>Markers with labels appear in the legend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Marker/MarkersPlot'><img class='img-fluid' src='/cookbook/5.0/images/MarkersPlot.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Marker/MarkersPlot'><b>Many Markers</b></a></div>
<div>Collections of markers that are all styled the same may be added to the plot</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Pie' class='text-dark'>Pie</a></h2>
<div>Pie charts illustrate numerical proportions as slices of a circle.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Pie/PieQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/PieQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Pie/PieQuickstart'><b>Pie Chart from Values</b></a></div>
<div>A pie chart can be created from a few values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Pie/PieSlices'><img class='img-fluid' src='/cookbook/5.0/images/PieSlices.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Pie/PieSlices'><b>Pie Chart from Slices</b></a></div>
<div>A pie chart can be created from a collection of slices.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Pie/PieDonut'><img class='img-fluid' src='/cookbook/5.0/images/PieDonut.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Pie/PieDonut'><b>Donut from Slices</b></a></div>
<div>A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Pie/PieSliceLabels'><img class='img-fluid' src='/cookbook/5.0/images/PieSliceLabels.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Pie/PieSliceLabels'><b>Pie Slice Labels</b></a></div>
<div>Slice labels can be displayed centered with the slice at a customizable distance from the center of the pie.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/RadialGauge' class='text-dark'>Radial gauge</a></h2>
<div>A radial gauge chart displays scalar data as circular gauges.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeQuickstart'><b>Radial gauge from values</b></a></div>
<div>A radial gauge chart can be created from a few values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeColormap'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeColormap.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeColormap'><b>Gauge Colors</b></a></div>
<div>Gauge colors can be customized by changing the default palette.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeNegative'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeNegative.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeNegative'><b>Negative Values</b></a></div>
<div>Radial gauge plots support positive and negative values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeSequential'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeSequential.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeSequential'><b>Sequential Gauge Mode</b></a></div>
<div>Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeReverse'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeReverse.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeReverse'><b>Reverse Order</b></a></div>
<div>Gauges are displayed from the center outward by default but the order can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeModeSingle'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeModeSingle.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeModeSingle'><b>Single Gauge Mode</b></a></div>
<div>The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeDirection'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeDirection.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeDirection'><b>Gauge Direction</b></a></div>
<div>The direction of gauges can be customized. Clockwise is used by default.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeSize'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeSize.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeSize'><b>Gauge Size</b></a></div>
<div>The empty space between gauges can be adjusted as a fraction of their width. </div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeStart'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeStart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeStart'><b>Gauge Starting Angle</b></a></div>
<div>The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeRange'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeRange.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeRange'><b>Gauge Angular Range</b></a></div>
<div>By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabels'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeLabels.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabels'><b>Show Levels</b></a></div>
<div>The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelPos'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeLabelPos.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelPos'><b>Gauge Label Position</b></a></div>
<div>Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeLabelFontPct.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelFontPct'><b>Gauge Label Font Percentage</b></a></div>
<div>Size of the gauge level text as a fraction of the gauge width.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelColor'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeLabelColor.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeLabelColor'><b>Gauge Label Color</b></a></div>
<div>Level text fonts may be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeLegend'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeLegend.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeLegend'><b>Gauge Labels in Legend</b></a></div>
<div>Radial gauge labels will appear in the legend if they are assigned. </div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeBackDim'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeBackDim.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeBackDim'><b>Background Gauges Dim</b></a></div>
<div>By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/RadialGauge/RadialGaugeBackNorm'><img class='img-fluid' src='/cookbook/5.0/images/RadialGaugeBackNorm.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/RadialGauge/RadialGaugeBackNorm'><b>Background Gauges Normalization</b></a></div>
<div>Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Scatter' class='text-dark'>Scatter Plot</a></h2>
<div>Scatter plots display points at X/Y locations in coordinate space.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/ScatterQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterQuickstart'><b>Scatter Plot Quickstart</b></a></div>
<div>Scatter plots can be created from two arrays containing X and Y values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterCoordinates'><img class='img-fluid' src='/cookbook/5.0/images/ScatterCoordinates.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterCoordinates'><b>Scatter Plot Coordinates</b></a></div>
<div>Scatter plots can be created from a collection of Coordinates.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterDataType'><img class='img-fluid' src='/cookbook/5.0/images/ScatterDataType.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterDataType'><b>Scatter Plot Data Type</b></a></div>
<div>Scatter plots can be created from any numeric data type, not just double.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterList'><img class='img-fluid' src='/cookbook/5.0/images/ScatterList.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterList'><b>Scatter Plot of List Data</b></a></div>
<div>Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterLine'><img class='img-fluid' src='/cookbook/5.0/images/ScatterLine.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterLine'><b>Scatter Plot with Lines Only</b></a></div>
<div>The `ScatterLine()` method can be used to create a scatter plot with a line only (marker size is set to 0).</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterPoints'><img class='img-fluid' src='/cookbook/5.0/images/ScatterPoints.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterPoints'><b>Scatter Plot with Points Only</b></a></div>
<div>The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterStyling'><img class='img-fluid' src='/cookbook/5.0/images/ScatterStyling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterStyling'><b>Scatter Plot Styling</b></a></div>
<div>Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterLinePatterns'><img class='img-fluid' src='/cookbook/5.0/images/ScatterLinePatterns.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterLinePatterns'><b>Scatter Line Patterns</b></a></div>
<div>Several line patterns are available</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterGeneric'><img class='img-fluid' src='/cookbook/5.0/images/ScatterGeneric.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterGeneric'><b>Scatter Generic</b></a></div>
<div>Scatter plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterDateTime'><img class='img-fluid' src='/cookbook/5.0/images/ScatterDateTime.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterDateTime'><b>Scatter DateTime</b></a></div>
<div>A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Scatter/ScatterStep'><img class='img-fluid' src='/cookbook/5.0/images/ScatterStep.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Scatter/ScatterStep'><b>Step Plot</b></a></div>
<div>Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Shapes' class='text-dark'>Shapes</a></h2>
<div>Basic shapes that can be added to plots</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Shapes/RectangleQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/RectangleQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Shapes/RectangleQuickstart'><b>Rectangle</b></a></div>
<div>A rectangle can be added to the plot and styled as desired.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Shapes/CircleQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/CircleQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Shapes/CircleQuickstart'><b>Circle</b></a></div>
<div>A circle can be placed on the plot and styled as desired.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Shapes/EllipseQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/EllipseQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Shapes/EllipseQuickstart'><b>Ellipse</b></a></div>
<div>An ellipse can be placed on the plot and styled as desired.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Shapes/PolygonQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/PolygonQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Shapes/PolygonQuickstart'><b>Polygon Plot Quickstart</b></a></div>
<div>Polygon plots can be added from a series of vertices, and must be in clockwise order.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Shapes/PolygonStyling'><img class='img-fluid' src='/cookbook/5.0/images/PolygonStyling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Shapes/PolygonStyling'><b>Polygon Plot Styling</b></a></div>
<div>Polygon plots can be fully customized.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Signal' class='text-dark'>Signal Plot</a></h2>
<div>Signal plots display evenly-spaced data</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/SignalQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalQuickstart'><b>Signal Plot Quickstart</b></a></div>
<div>Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalStyling'><img class='img-fluid' src='/cookbook/5.0/images/SignalStyling.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalStyling'><b>Signal Plot Styling</b></a></div>
<div>Signal plots can be styled in a variety of ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalOffset'><img class='img-fluid' src='/cookbook/5.0/images/SignalOffset.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalOffset'><b>Signal Offset</b></a></div>
<div>Signal plots can be offset by a given X and Y value.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalMarkerSize'><img class='img-fluid' src='/cookbook/5.0/images/SignalMarkerSize.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalMarkerSize'><b>Signal Marker Size</b></a></div>
<div>Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalRenderIndexes'><img class='img-fluid' src='/cookbook/5.0/images/SignalRenderIndexes.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalRenderIndexes'><b>Partial Signal Rendering</b></a></div>
<div>Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalGeneric'><img class='img-fluid' src='/cookbook/5.0/images/SignalGeneric.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalGeneric'><b>Signal Generic</b></a></div>
<div>Signal plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Signal/SignalDateTime'><img class='img-fluid' src='/cookbook/5.0/images/SignalDateTime.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Signal/SignalDateTime'><b>Signal DateTime</b></a></div>
<div>A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/SignalConst' class='text-dark'>SignalConst</a></h2>
<div>SignalConst is a type of signal plot which contains immutable data points and occupies more memory but offers greater performance for extremely large datasets. It is rarely needed, but best use for plotting data containing millions of points.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalConst/SignalConstQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/SignalConstQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalConst/SignalConstQuickstart'><b>SignalConst Quickstart</b></a></div>
<div>SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/SignalXY' class='text-dark'>SignalXY Plot</a></h2>
<div>SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'><b>SignalXY Quickstart</b></a></div>
<div>SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYGeneric'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYGeneric.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYGeneric'><b>SignalXY Generic</b></a></div>
<div>SignalXY plots support generic data types, although double is typically the most performant.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYRenderIndexes'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYRenderIndexes.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYRenderIndexes'><b>Partial SignalXY Rendering</b></a></div>
<div>Even if a SignalXY plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYOffset'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYOffset.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYOffset'><b>SignalXY Offset</b></a></div>
<div>A fixed offset can be applied to SignalXY plots.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/VerticalSignalXY'><img class='img-fluid' src='/cookbook/5.0/images/VerticalSignalXY.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/VerticalSignalXY'><b>Vertical SignalXY</b></a></div>
<div>Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYVerticalInvertedX.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX'><b>Vertical SignalXY with Inverted X Axis</b></a></div>
<div>Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedY'><img class='img-fluid' src='/cookbook/5.0/images/SignalXYVerticalInvertedY.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedY'><b>Vertical SignalXY with Inverted Y Axis</b></a></div>
<div>Demonstrates how to display a rotated SignalXY plot on an inverted vertical axis so data goes from top to bottom.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Text' class='text-dark'>Text</a></h2>
<div>Text labels can be placed on the plot in coordinate space</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Text/TextQuickstart'><img class='img-fluid' src='/cookbook/5.0/images/TextQuickstart.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Text/TextQuickstart'><b>Text Quickstart</b></a></div>
<div>Text can be placed anywhere in coordinate space.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Text/Formatting'><img class='img-fluid' src='/cookbook/5.0/images/Formatting.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Text/Formatting'><b>Text Formatting</b></a></div>
<div>Text formatting can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Text/LabelLineHeight'><img class='img-fluid' src='/cookbook/5.0/images/LabelLineHeight.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Text/LabelLineHeight'><b>Line Height</b></a></div>
<div>Multiline labels have a default line height estimated from the typeface and font size, however line height may be manually defined by the user.</div>
</div>
</div>
<h1>Statistics</h1>
<h2 class=''><a href='/cookbook/5.0/Regression' class='text-dark'>Regression</a></h2>
<div>Statistical operations to fit lines to data</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Regression/Linear'><img class='img-fluid' src='/cookbook/5.0/images/Linear.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Regression/Linear'><b>LinearRegression</b></a></div>
<div>Fit a line to a collection of X/Y data points.</div>
</div>
</div>
<h1>Miscellaneous</h1>
<h2 class=''><a href='/cookbook/5.0/AdvancedStyling' class='text-dark'>Advanced Styling</a></h2>
<div>Features for users seeking extensive customization options.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingDataBackground'><img class='img-fluid' src='/cookbook/5.0/images/AdvancedStylingDataBackground.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingDataBackground'><b>Data Area Background Image</b></a></div>
<div>An image can be used for the background of the data area.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingFigureBackground'><img class='img-fluid' src='/cookbook/5.0/images/AdvancedStylingFigureBackground.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedStyling/AdvancedStylingFigureBackground'><b>Figure Background Image</b></a></div>
<div>An image can be used for the background of a figure.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/AdvancedStyling/ColorInterpolation'><img class='img-fluid' src='/cookbook/5.0/images/ColorInterpolation.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/AdvancedStyling/ColorInterpolation'><b>Color Interpolation</b></a></div>
<div>Colors can be mixed to createa range of colors. This strategy uses linear RGB interpolation.</div>
</div>
</div>
<h2 class=''><a href='/cookbook/5.0/Internationalization' class='text-dark'>Internationalization</a></h2>
<div>Using ScottPlot across cultures with different text and numeric requirements.</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Internationalization/FontDetection'><img class='img-fluid' src='/cookbook/5.0/images/FontDetection.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Internationalization/FontDetection'><b>Supported Font Detection</b></a></div>
<div>ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='/cookbook/5.0/Internationalization/AutomaticFontDetection'><img class='img-fluid' src='/cookbook/5.0/images/AutomaticFontDetection.png?240316204900' /></a>
</div>
<div class='col'>
<div><a href='/cookbook/5.0/Internationalization/AutomaticFontDetection'><b>Automatic Font Detection</b></a></div>
<div>The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.</div>
</div>
</div>
