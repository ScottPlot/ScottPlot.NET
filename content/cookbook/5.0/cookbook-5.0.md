---
title: ScottPlot 5.0 Cookbook
description: Example plots shown next to the code used to create them
url: /cookbook/5.0/
date: 2/28/2023 1:42:27 AM
---



<div class='alert alert-warning' role='alert'><h4 class='alert-heading py-0 my-0'>⚠️ ScottPlot 5.0.2-beta is a preview package</h4><hr /><p class='mb-0'><span class='fw-semibold'>This page describes a beta release of ScottPlot.</span> It is available on NuGet as a preview package, but its API is not stable and it is not recommended for production use. See the <a href='https://scottplot.net/versions/'>ScottPlot Versions</a> page for more information. </p></div>


## Introduction
<div class='fs-4 mt-4'>ScottPlot 5 Quickstart</div>
<div>A survey of basic functionality in ScottPlot 5</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#scatter-plot'><img class='img-fluid' src='scottplot-5-quickstart/scatter-plot.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#scatter-plot'><b>Scatter Plot</b></a></div>
<div>Display paired X/Y data as a scatter plot.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#customizing-plottables'><img class='img-fluid' src='scottplot-5-quickstart/customizing-plottables.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#customizing-plottables'><b>Customizing Plottables</b></a></div>
<div>Functions that add things to plots return the plottables they create. Interact with the properties of plottables to customize their styling and behavior.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#signal-plot'><img class='img-fluid' src='scottplot-5-quickstart/signal-plot.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#signal-plot'><b>Signal Plot</b></a></div>
<div>Signal plots are optimized for displaying evenly spaced data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#signal-plot-performance'><img class='img-fluid' src='scottplot-5-quickstart/signal-plot-performance.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#signal-plot-performance'><b>Signal Plot Performance</b></a></div>
<div>Signal plots can interactively display millions of data points in real time. Double-click the plot to display performance benchmarks.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#axis-labels'><img class='img-fluid' src='scottplot-5-quickstart/axis-labels.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#axis-labels'><b>Axis Labels</b></a></div>
<div>Axis labels can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='scottplot-5-quickstart/#legend'><img class='img-fluid' src='scottplot-5-quickstart/legend.png' /></a>
</div>
<div class='col'>
<div><a href='scottplot-5-quickstart/#legend'><b>Legend</b></a></div>
<div>A legend displays plottables in a key along the edge of a plot. Most plottables have a Label property which configures what text appears in the legend.</div>
</div>
</div>
<div class='fs-4 mt-4'>Styling Plots</div>
<div>How to customize plots</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#style-helper-functions'><img class='img-fluid' src='styling-plots/style-helper-functions.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#style-helper-functions'><b>Style Helper Functions</b></a></div>
<div>Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#axis-customization'><img class='img-fluid' src='styling-plots/axis-customization.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#axis-customization'><b>Axis Customization</b></a></div>
<div>Axis labels, tick marks, and frame can all be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#grid-customization'><img class='img-fluid' src='styling-plots/grid-customization.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#grid-customization'><b>Grid Customization</b></a></div>
<div>Grid lines can be customized. Custom grid systems can be created to give developers full control of grid rendering, but the default grid can be interacted with to customize its appearance.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#grid-above-data'><img class='img-fluid' src='styling-plots/grid-above-data.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#grid-above-data'><b>Grid Above Data</b></a></div>
<div>Grid lines are typically drawn beneath data, but grids can be configured to render on top of plottables too.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#palettes'><img class='img-fluid' src='styling-plots/palettes.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#palettes'><b>Palettes</b></a></div>
<div>A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#markers'><img class='img-fluid' src='styling-plots/markers.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#markers'><b>Markers</b></a></div>
<div>Many plot types have a MarkerStyle which can be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='styling-plots/#line-styles'><img class='img-fluid' src='styling-plots/line-styles.png' /></a>
</div>
<div class='col'>
<div><a href='styling-plots/#line-styles'><b>Line Styles</b></a></div>
<div>Many plot types have a LineStyle which can be customized.</div>
</div>
</div>
<hr class='my-5' />
## Customization
<div class='fs-4 mt-4'>Axis and Ticks</div>
<div>Examples of common customizations for axis labels and ticks</div>
<div class='row my-4'>
<div class='col'>
<a href='axis-and-ticks/#axis-labels'><img class='img-fluid' src='axis-and-ticks/axis-labels.png' /></a>
</div>
<div class='col'>
<div><a href='axis-and-ticks/#axis-labels'><b>Axis Labels</b></a></div>
<div>Axis labels are the text labels centered on each axis. The text inside these labels can be changed, and the style of the text can be extensively customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='axis-and-ticks/#manually-set-axis-limits'><img class='img-fluid' src='axis-and-ticks/manually-set-axis-limits.png' /></a>
</div>
<div class='col'>
<div><a href='axis-and-ticks/#manually-set-axis-limits'><b>Manually Set Axis Limits</b></a></div>
<div>Axis Limits can be set manually in different ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='axis-and-ticks/#read-axis-limits'><img class='img-fluid' src='axis-and-ticks/read-axis-limits.png' /></a>
</div>
<div class='col'>
<div><a href='axis-and-ticks/#read-axis-limits'><b>Read Axis Limits</b></a></div>
<div>The current axis limits can be read in multiple ways.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='axis-and-ticks/#zoom-to-fit-data'><img class='img-fluid' src='axis-and-ticks/zoom-to-fit-data.png' /></a>
</div>
<div class='col'>
<div><a href='axis-and-ticks/#zoom-to-fit-data'><b>Zoom to Fit Data</b></a></div>
<div>The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='axis-and-ticks/#frameless-plot'><img class='img-fluid' src='axis-and-ticks/frameless-plot.png' /></a>
</div>
<div class='col'>
<div><a href='axis-and-ticks/#frameless-plot'><b>Frameless Plot</b></a></div>
<div>How to create a plot containig only the data area and no axes.</div>
</div>
</div>
<div class='fs-4 mt-4'>Configuring Legends</div>
<div>A legend is a key typically displayed in the corner of a plot</div>
<div class='row my-4'>
<div class='col'>
<a href='configuring-legends/#legend-customization'><img class='img-fluid' src='configuring-legends/legend-customization.png' /></a>
</div>
<div class='col'>
<div><a href='configuring-legends/#legend-customization'><b>Legend Customization</b></a></div>
<div>The default legend can be easily accessed and customized. It is possible to add multiple legends, including custom ones implementing ILegend.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='configuring-legends/#manual-legend'><img class='img-fluid' src='configuring-legends/manual-legend.png' /></a>
</div>
<div class='col'>
<div><a href='configuring-legends/#manual-legend'><b>Manual Legend</b></a></div>
<div>Legends may be constructed manually.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='configuring-legends/#limit-plottables-in-legend'><img class='img-fluid' src='configuring-legends/limit-plottables-in-legend.png' /></a>
</div>
<div class='col'>
<div><a href='configuring-legends/#limit-plottables-in-legend'><b>Limit Plottables in Legend</b></a></div>
<div>Legends typically show all plot items with populated Label fields. However, users can use the manual legend property to only show legend items from specific plottables.</div>
</div>
</div>
<div class='fs-4 mt-4'>Customizing Ticks</div>
<div>Advanced customization of tick marks and tick labels</div>
<div class='row my-4'>
<div class='col'>
<a href='customizing-ticks/#custom-tick-generators'><img class='img-fluid' src='customizing-ticks/custom-tick-generators.png' /></a>
</div>
<div class='col'>
<div><a href='customizing-ticks/#custom-tick-generators'><b>Custom Tick Generators</b></a></div>
<div>Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.</div>
</div>
</div>
<div class='fs-4 mt-4'>DateTime Axes</div>
<div>Plot data values on a DataTime axes</div>
<div class='row my-4'>
<div class='col'>
<a href='datetime-axes/#datetime-axis-quickstart'><img class='img-fluid' src='datetime-axes/datetime-axis-quickstart.png' /></a>
</div>
<div class='col'>
<div><a href='datetime-axes/#datetime-axis-quickstart'><b>DateTime Axis Quickstart</b></a></div>
<div>.</div>
</div>
</div>
<div class='fs-4 mt-4'>Advanced Axis Features</div>
<div>Tick mark customization and creation of multi-Axis plots</div>
<div class='row my-4'>
<div class='col'>
<a href='advanced-axis-features/#multi-axis'><img class='img-fluid' src='advanced-axis-features/multi-axis.png' /></a>
</div>
<div class='col'>
<div><a href='advanced-axis-features/#multi-axis'><b>Multi-Axis</b></a></div>
<div>Additional axes may be added to plots. Plottables are displayed using the coordinate system of the primary axes by default, but any plottable can be displayed using any X and Y axis.</div>
</div>
</div>
<hr class='my-5' />
## PlotTypes
<div class='fs-4 mt-4'>Bar Plot</div>
<div>Bar plots represent values as horizontal or vertical rectangles</div>
<div class='row my-4'>
<div class='col'>
<a href='bar-plot/#bar-plot-quickstart'><img class='img-fluid' src='bar-plot/bar-plot-quickstart.png' /></a>
</div>
<div class='col'>
<div><a href='bar-plot/#bar-plot-quickstart'><b>Bar Plot Quickstart</b></a></div>
<div>Bar plots can be added from a series of values.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='bar-plot/#bar-positioning'><img class='img-fluid' src='bar-plot/bar-positioning.png' /></a>
</div>
<div class='col'>
<div><a href='bar-plot/#bar-positioning'><b>Bar Positioning</b></a></div>
<div>The exact position and size of each bar may be customized.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='bar-plot/#bar-series'><img class='img-fluid' src='bar-plot/bar-series.png' /></a>
</div>
<div class='col'>
<div><a href='bar-plot/#bar-series'><b>Bar Series</b></a></div>
<div>Bar plots can be grouped into bar series and plotted together.</div>
</div>
</div>
<div class='fs-4 mt-4'>Error Bars</div>
<div>Error Bars communicate the range of possible values for a measurement</div>
<div class='row my-4'>
<div class='col'>
<a href='error-bars/#error-bar-quickstart'><img class='img-fluid' src='error-bars/error-bar-quickstart.png' /></a>
</div>
<div class='col'>
<div><a href='error-bars/#error-bar-quickstart'><b>Error Bar Quickstart</b></a></div>
<div>Error Bars go well with scatter plots.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='error-bars/#multidimensional-errorbars'><img class='img-fluid' src='error-bars/multidimensional-errorbars.png' /></a>
</div>
<div class='col'>
<div><a href='error-bars/#multidimensional-errorbars'><b>MultiDimensional ErrorBars</b></a></div>
<div>You can mix and match x and y error bars.</div>
</div>
</div>
<div class='fs-4 mt-4'>Financial Plot</div>
<div>Finance plots display price data binned into time ranges</div>
<div class='row my-4'>
<div class='col'>
<a href='financial-plot/#ohlc-chart'><img class='img-fluid' src='financial-plot/ohlc-chart.png' /></a>
</div>
<div class='col'>
<div><a href='financial-plot/#ohlc-chart'><b>OHLC Chart</b></a></div>
<div>OHLC charts use symbols to display price data (open, high, low, and close) for specific time ranges.</div>
</div>
</div>
<div class='row my-4'>
<div class='col'>
<a href='financial-plot/#candlestick-chart'><img class='img-fluid' src='financial-plot/candlestick-chart.png' /></a>
</div>
<div class='col'>
<div><a href='financial-plot/#candlestick-chart'><b>Candlestick Chart</b></a></div>
<div>Candlestick charts use symbols to display price data. The rectangle indicates open and close prices, and the center line indicates minimum and maximum price for the given time period. Color indicates whether the price increased or decreased between open and close.</div>
</div>
</div>
<div class='fs-4 mt-4'>Signal Plot</div>
<div>Signal plots display evenly-spaced data</div>
<div class='row my-4'>
<div class='col'>
<a href='signal-plot/#offset'><img class='img-fluid' src='signal-plot/offset.png' /></a>
</div>
<div class='col'>
<div><a href='signal-plot/#offset'><b>Offset</b></a></div>
<div>Signal plots can be offset by a given X and Y value.</div>
</div>
</div>
<hr class='my-5' />
