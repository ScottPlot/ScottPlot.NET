---
Title: ScottPlot 4.1 Cookbook
Description: Example plots shown next to the code used to create them
url: /cookbook/4.1
---

<!--
## Table of Contents
{{< toc >}}
-->

### <div><a href='/cookbook/4.1/category/quickstart'>Quickstart</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#scatter-plot'>Scatter Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Scatter plots have paired X/Y points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#scatter-plot'>
                <img src='/cookbook/4.1/images/quickstart_scatter_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#signal-plot'>Signal Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots have evenly spaced Y points. Signal plots are very fast and can interactively display millions of data points. There are many different types of plottable objects, each serving a different purpose.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#signal-plot'>
                <img src='/cookbook/4.1/images/quickstart_signal_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#axis-labels-and-limits'>Axis Labels and Limits</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis labels and limits can be customized</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#axis-labels-and-limits'>
                <img src='/cookbook/4.1/images/quickstart_axis_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#manually-add-a-plottable'>Manually add a Plottable</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can create a plot manually, then add it to the plot with Add(). This allows you to create custom plot types and add them to the plot.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#manually-add-a-plottable'>
                <img src='/cookbook/4.1/images/quickstart_add_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#remove-a-plottable'>Remove a Plottable</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Call Remove() to remove a specific plottable.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#remove-a-plottable'>
                <img src='/cookbook/4.1/images/quickstart_remove_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/quickstart/#clear-plottables'>Clear Plottables</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Call Clear() to remove all plottables from the plot. Overloads of Clear() allow you to remote one type of plottable, or a specific plottable.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/quickstart/#clear-plottables'>
                <img src='/cookbook/4.1/images/quickstart_clear_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/advanced-axis-features'>Advanced Axis Features</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#advanced-grid-customization'>Advanced Grid Customization</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Grid lines can be extensively customized using various configuration methods.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#advanced-grid-customization'>
                <img src='/cookbook/4.1/images/asis_gridadvanced_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#numeric-format-string'>Numeric Format String</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tick labels can be converted to text using a custom format string.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#numeric-format-string'>
                <img src='/cookbook/4.1/images/ticks_numericformatstring_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#manual-tick-labels'>Manual Tick Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tick positions and labels can be defined manually.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#manual-tick-labels'>
                <img src='/cookbook/4.1/images/ticks_defined_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#nonlinear-tick-spacing'>NonLinear Tick Spacing</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Plot data on regular cartesian space then manually control axis labels to give the appearance of non-linear spacing between points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#nonlinear-tick-spacing'>
                <img src='/cookbook/4.1/images/ticks_nonlinearx_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#descending-ticks'>Descending Ticks</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>ScottPlot will always display data where X values ascend from left to right. To simulate an inverted axis (where numbers decrease from left to right) plot data in the negative space, then invert the sign of tick labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#descending-ticks'>
                <img src='/cookbook/4.1/images/ticks_descending_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#defined-tick-spacing'>Defined Tick Spacing</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The space between tick marks can be manually defined by setting the grid spacing.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#defined-tick-spacing'>
                <img src='/cookbook/4.1/images/ticks_definedspacing_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#tick-label-culture'>Tick Label Culture</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Large numbers and dates are formatted differently for different cultures. Hungarian uses spaces to separate large numbers and periods to separate fields in dates.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#tick-label-culture'>
                <img src='/cookbook/4.1/images/ticks_culture_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#custom-tick-label-culture'>Custom Tick Label Culture</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SetCulture() as arguments to let the user manually define formatting strings which will be used globally to change how numbers and dates are formatted.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#custom-tick-label-culture'>
                <img src='/cookbook/4.1/images/ticks_culturecustom_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#multiplier-notation'>Multiplier Notation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Multiplier notation keeps tick labels small when plotting large data values. This style is also called engineering notation or scientific notation.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#multiplier-notation'>
                <img src='/cookbook/4.1/images/ticks_multiplier_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#offset-notation'>Offset Notation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Offset notation keeps tick labels small when plotting large data values that are close together.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#offset-notation'>
                <img src='/cookbook/4.1/images/ticks_offset_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#defined-datetime-spacing'>Defined DateTime Spacing</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example shows how to use a fixed inter-tick distance for a DateTime axis</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#defined-datetime-spacing'>
                <img src='/cookbook/4.1/images/ticks_defineddatetimespace_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#log-scale'>Log Scale</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>ScottPlot is designed to display 2D data on linear X and Y axes, but you can log-transform data before plotting it and customize the ticks and grid to give the appearance of logarithmic scales.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#log-scale'>
                <img src='/cookbook/4.1/images/asis_log_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#log-scale-tick-density'>Log Scale Tick Density</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Numer of minor ticks between major ticks can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#log-scale-tick-density'>
                <img src='/cookbook/4.1/images/asis_logtickdensity_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#ruler-mode'>Ruler mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Ruler mode is an alternative way to display axis ticks. It draws long ticks and offsets the tick labels to give the appearance of a ruler.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#ruler-mode'>
                <img src='/cookbook/4.1/images/asis_ruler_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#polar-coordinates'>Polar Coordinates</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A helper function converts radius and theta arrays into Cartesian coordinates suitable for plotting with traditioanl plot types.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#polar-coordinates'>
                <img src='/cookbook/4.1/images/asis_polar_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#images-as-axis-labels'>Images as Axis Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Images can be used as axis labels to allow for things like LaTeX axis labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#images-as-axis-labels'>
                <img src='/cookbook/4.1/images/asis_image_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#transparent-images-axis-labels'>Transparent Images Axis Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Transparency in PNGs is respected, but JPEG files do not support transparency.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#transparent-images-axis-labels'>
                <img src='/cookbook/4.1/images/asis_imagetransparent_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#tick-density'>Tick Density</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis tick density can be adjusted by the user. The largest the density is, the more ticks are displayed. Setting this value too high will result in overlapping tick labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#tick-density'>
                <img src='/cookbook/4.1/images/asis_tickdensity_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#minimum-tick-spacing'>Minimum Tick Spacing</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Minimum tick spacing can be defined such that zooming in does not produce more grid lines, ticks, and tick labels beyond the defined limit.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#minimum-tick-spacing'>
                <img src='/cookbook/4.1/images/asis_minimumtickspacing_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#custom-tick-formatter'>Custom Tick Formatter</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>For ultimate control over tick label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format tick labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#custom-tick-formatter'>
                <img src='/cookbook/4.1/images/asis_custom_tick_formatter_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/advanced-axis-features/#invert-tick-mark-direction'>Invert tick mark direction</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tick marks can be outward (default) or inverted to appear as inward lines relative to the edge of the plot area.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/advanced-axis-features/#invert-tick-mark-direction'>
                <img src='/cookbook/4.1/images/ticks_invert_tick_mark_direction_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/axis-and-ticks'>Axis and Ticks</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#axis-customizations'>Axis Customizations</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axes can be customized different ways. Axis labels and colors are the most common types of customizations.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#axis-customizations'>
                <img src='/cookbook/4.1/images/axis_label_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#disable-grid'>Disable Grid</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Visibility of primary X and Y grids can be set using a single method.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#disable-grid'>
                <img src='/cookbook/4.1/images/axis_griddisableall_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#disable-vertical-grid'>Disable Vertical Grid</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Grid line visibility can be controlled for each axis individually. Use this to selectively enable grid lines only for the axes of interest. Keep in mind that vertical grid lines are controlled by horizontal axes.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#disable-vertical-grid'>
                <img src='/cookbook/4.1/images/axis_griddisableone_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#grid-style'>Grid Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Common grid line configurations are available.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#grid-style'>
                <img src='/cookbook/4.1/images/asis_gridconfigure_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#frameless-plots'>Frameless Plots</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Frameless plots can display data that appraoches the edge of the figure.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#frameless-plots'>
                <img src='/cookbook/4.1/images/asis_frameless_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#one-axis-only'>One Axis Only</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis ticks and lines can be disabled. Note that hiding them in this way preserves their whitespace. Setting XAxis.IsVisible to false would collapse the axis entirely. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#one-axis-only'>
                <img src='/cookbook/4.1/images/one_axisonly_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#rotated-x-ticks'>Rotated X Ticks</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Horizontal tick labels can be rotated as desired.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#rotated-x-ticks'>
                <img src='/cookbook/4.1/images/ticks_rotated_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#rotated-y-ticks'>Rotated Y Ticks</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Vertical tick labels can be rotated as desired.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#rotated-y-ticks'>
                <img src='/cookbook/4.1/images/ticks_rotatedy_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/axis-and-ticks/#plotting-datetime-data'>Plotting DateTime Data</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example shows how to display DateTime data on the horizontal axis. Use DateTime.ToOADate() to convert DateTime[] to double[], plot the data,  then tell the axis to format tick labels as dates.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/axis-and-ticks/#plotting-datetime-data'>
                <img src='/cookbook/4.1/images/ticks_datetime_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/misc'>Misc</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/misc/#spline-interpolation'>Spline Interpolation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Interpolated splines create curves with many X/Y points to smoothly connect a limited number of input points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/misc/#spline-interpolation'>
                <img src='/cookbook/4.1/images/misc_interpolation_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/misc/#spline-interpolation-types'>Spline Interpolation Types</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Different methods are available for smoothing data using interpolation, curve fitting, or corner cutting. Notice that some methods produce curves which pass through the original data points and others do not.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/misc/#spline-interpolation-types'>
                <img src='/cookbook/4.1/images/misc_interpolation_types_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/misc/#action-potential'>Action Potential</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The raw trace (voltage) and first derivative (voltage change / time) of a mammalian action potential.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/misc/#action-potential'>
                <img src='/cookbook/4.1/images/misc_ap_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/misc/#display-scaling'>Display Scaling</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>When display scaling is enabled the dots per inch (DPI) is changed so images appear larger. When scaling is increased bitmap images are stretched to appear larger, but may appear blurry as a result. Alternatively images could be increased in size when DPI scaling is enabled, but fonts and lines may appear small. This example shows how to increase the size of common plot components so they look good on high resolution scaled displays (e.g., 4K monitors). DPI stretching can be set in the user control's Configuration module.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/misc/#display-scaling'>
                <img src='/cookbook/4.1/images/misc_dpiscale_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/multi-axis'>Multi-Axis</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/multi-axis/#primary-axes'>Primary Axes</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Plots always have 4 fundamental axes available to work with. Primary axes (XAxis and YAxis) are axis index 0. Secondary axes (XAxis2 and YAxis2) are axis index 1.By default primary axes are totally visible, and secondary axes have ticks hidden and no label. Sometimes the top axis (XAxis2) is given a label to simulate a plot title.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/multi-axis/#primary-axes'>
                <img src='/cookbook/4.1/images/multiaxis_primary_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/multi-axis/#additional-y-axis'>Additional Y Axis</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Additional axes can be added on any edge. Additional axes stack away from the plot area.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/multi-axis/#additional-y-axis'>
                <img src='/cookbook/4.1/images/multiaxis_additional_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/multi-axis/#right-y-axis'>Right Y Axis</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to display a Y axis on the right side of the figure. The vertical axis to the right of the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/multi-axis/#right-y-axis'>
                <img src='/cookbook/4.1/images/multiaxis_right_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/multi-axis/#top-y-axis'>Top Y Axis</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to display an X axis above the figure. The horizontal axis above the figure is index 1, so plots must be updated to indicate they are to use a nonstandard axis index.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/multi-axis/#top-y-axis'>
                <img src='/cookbook/4.1/images/multiaxis_top_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/multi-axis/#axis-visibility'>Axis Visibility</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Visibility of axes can be toggled. In this example an additional Y axis is added but the primary Y axis is hidden. The result is a plot that appears to only have one Y axis.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/multi-axis/#axis-visibility'>
                <img src='/cookbook/4.1/images/multiaxis_invisible_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/palette'>Palette</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#category10'>Category10</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This 10-color palette is the default colorset used by ScottPlot. It is the same default colorset used by modern versions of Matplotlib (https://matplotlib.org/2.0.2/users/dflt_style_changes.html)</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#category10'>
                <img src='/cookbook/4.1/images/palette_category10_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#category20'>Category20</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This 20-color palette is similar to the default, but optimized for situations where more than 10 plottables are required. Every second color is a lighter version of the color before it. This palette was sourced from Matplotlib.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#category20'>
                <img src='/cookbook/4.1/images/palette_category20_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#aurora'>Aurora</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Aurora is a 5-color palette sourced from Nord.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#aurora'>
                <img src='/cookbook/4.1/images/palette_aurora_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#frost'>Frost</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Frost is a 4-color palette sourced from Nord.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#frost'>
                <img src='/cookbook/4.1/images/palette_frost_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#nord'>Nord</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Nord is a 7-color palette derived from Aurora source from NordConEmu.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#nord'>
                <img src='/cookbook/4.1/images/palette_nord_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#polarnight'>PolarNight</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>PolarNight is a 4-color palette sourced from Nord. This palette is optimized for a dark background.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#polarnight'>
                <img src='/cookbook/4.1/images/palette_polarnight_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#snowstorm'>SnowStorm</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SnowStorm is a 3-color palette sourced from Nord.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#snowstorm'>
                <img src='/cookbook/4.1/images/palette_snowstorm_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#onehalf'>OneHalf</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>OneHalf is a 7-color palette sourced from Sublime</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#onehalf'>
                <img src='/cookbook/4.1/images/palette_onehalf_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#onehalfdark'>OneHalfDark</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>OneHalfDark is a 7-color palette of colors complimentary to the OneHalf palette desaturated and optimized for a dark background. #2e3440 is a recommended background color with this palette.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#onehalfdark'>
                <img src='/cookbook/4.1/images/palette_onehalfdark_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#custom'>Custom</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A custom palette can be created from an array of HTML color values. These colors will be used as the default colors for new plottables added to the plot.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#custom'>
                <img src='/cookbook/4.1/images/palette_custom_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#microcharts'>Microcharts</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This is the default 12-color palette used by Microcharts.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#microcharts'>
                <img src='/cookbook/4.1/images/palette_microcharts_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/palette/#colorblind-friendly'>Colorblind Friendly</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>8-color palette that has good overall variability and can be differentiated by individuals with red-green color blindness. Colors originated from Wong 2011, https://www.nature.com/articles/nmeth.1618.pdf</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/palette/#colorblind-friendly'>
                <img src='/cookbook/4.1/images/palette_colorblindfriendly_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/statistics'>Statistics</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#histogram'>Histogram</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>ScottPlot.Statistics.Common contains methods for creating histograms.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#histogram'>
                <img src='/cookbook/4.1/images/stats_histogram_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#histogram-probability'>Histogram Probability</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Histograms can be displayed as binned probability instead of binned counts. The ideal probability distribution can also be plotted.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#histogram-probability'>
                <img src='/cookbook/4.1/images/stats_histogramprobability_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#histogram-multi-axis'>Histogram Multi-Axis</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to display a histogram counts on the primary Y axis and the probability curve on the secondary Y axis.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#histogram-multi-axis'>
                <img src='/cookbook/4.1/images/stats_histogrammultiaxis_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#histogram-stdev'>Histogram Stdev</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to display a histogram with labeled mean and standard deviations.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#histogram-stdev'>
                <img src='/cookbook/4.1/images/stats_histogramstdev_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#multiple-histograms'>Multiple Histograms</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates two histograms on the same plot. Note the use of fractional units on the vertical axis, allowing easy comparison of datasets with different numbers of points. Unlike the previous example, this one does not use multiple axes.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#multiple-histograms'>
                <img src='/cookbook/4.1/images/stats_histogram2_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#cph'>CPH</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to plot a cumulative probability histogram (CPH) to compare the distribution of two datasets.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#cph'>
                <img src='/cookbook/4.1/images/stats_cph_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#linear-regression'>Linear Regression</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A regression module is available to simplify the act of creating a linear regression line fitted to the data.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#linear-regression'>
                <img src='/cookbook/4.1/images/stats_linearregression_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#nth-order-statistics'>Nth Order Statistics</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The Nth order statistic of a set is the Nth smallest value of the set (indexed from 1).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#nth-order-statistics'>
                <img src='/cookbook/4.1/images/stats_orderstatistics_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#percentiles'>Percentiles</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Percentiles are a good tool to analyze the distribution of your data and filter out extreme values.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#percentiles'>
                <img src='/cookbook/4.1/images/stats_percentiles_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/statistics/#quantiles'>Quantiles</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A q-Quantile is a generalization of quartiles and percentiles to any number of buckets.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/statistics/#quantiles'>
                <img src='/cookbook/4.1/images/stats_quantiles_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/style'>Style</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#default-style'>Default Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#default-style'>
                <img src='/cookbook/4.1/images/style_default_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#monospace-style'>Monospace Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#monospace-style'>
                <img src='/cookbook/4.1/images/style_monospace_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#blue1-style'>Blue1 Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#blue1-style'>
                <img src='/cookbook/4.1/images/style_blue1_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#blue2-style'>Blue2 Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#blue2-style'>
                <img src='/cookbook/4.1/images/style_blue2_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#light1-style'>Light1 Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#light1-style'>
                <img src='/cookbook/4.1/images/style_light1_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#gray1-style'>Gray1 Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#gray1-style'>
                <img src='/cookbook/4.1/images/style_gray1_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#black-style'>Black Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#black-style'>
                <img src='/cookbook/4.1/images/style_black_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/style/#seaborn-style'>Seaborn Style</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Customize many plot features using style presets</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/style/#seaborn-style'>
                <img src='/cookbook/4.1/images/style_seaborn_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-annotation'>Plottable: Annotation</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-annotation/#figure-annotations'>Figure Annotations</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Annotations are labels placed at a X/Y location on the figure (not coordinates of the data area). Unlike the Text plottable, annotations do not move as the axes are adjusted.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-annotation/#figure-annotations'>
                <img src='/cookbook/4.1/images/annotation_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-arrow'>Plottable: Arrow</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-arrow/#arrows'>Arrows</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Arrows point to specific locations on the plot. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-arrow/#arrows'>
                <img src='/cookbook/4.1/images/plottable_arrow_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-axis-line-and-span'>Plottable: Axis Line and Span</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-line'>Axis Line</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An axis line marks a position on an axis. Axis lines extend to positive and negative infinity on the other axis.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-line'>
                <img src='/cookbook/4.1/images/axisline_basics_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#finite-axis-line'>Finite Axis Line</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis lines can have lower and/or upper bounds. This can be useful for labeling points of interest.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#finite-axis-line'>
                <img src='/cookbook/4.1/images/axisline_finite_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#draggable-axis-lines'>Draggable Axis Lines</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>In GUI environments, axis lines can be draggable and moved with the mouse. Drag limits define the boundaries the lines can be dragged.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#draggable-axis-lines'>
                <img src='/cookbook/4.1/images/axisline_draggable_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#position-labels'>Position Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis line positions can be labeled on the axis on top of axis ticks and tick labels. Custom position formatters allow for full customization of the text displayed in these labels. If using a DateTime axis, implement a custom formatter that uses DateTime.FromOADate().</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#position-labels'>
                <img src='/cookbook/4.1/images/axisline_positionlabels_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-span'>Axis Span</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis spans shade a portion of one axis. Axis spans extend to negative and positive infinity on the other axis.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-span'>
                <img src='/cookbook/4.1/images/axisspan_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#draggable-axis-span'>Draggable Axis Span</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis spans can be dragged using the mouse. Drag limits are boundaries over which the edges of spans cannot cross.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#draggable-axis-span'>
                <img src='/cookbook/4.1/images/axisspan_draggable_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#ignore-axis-limits'>Ignore Axis Limits</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Calling Plot.AxisAuto (or middle-clicking the plot) will set the axis limits automatically to fit the data on the plot. By default the position of axis lines and spans are included in automatic axis limit calculations, but setting the '' flag can disable this behavior.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#ignore-axis-limits'>
                <img src='/cookbook/4.1/images/axisspan_ignore_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#repeating-axis-line'>Repeating Axis Line</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Repeating axis lines allows to plot several axis lines, either horizontal or vertical, draggable or not, whose positions are linked</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#repeating-axis-line'>
                <img src='/cookbook/4.1/images/repeatingaxisline_basics_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-line-vector'>Axis Line Vector</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An AxisLineVector allows to setup a series of VLines or HLines, without hassle.These lines can optionally be dragged as their counterparts</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-axis-line-and-span/#axis-line-vector'>
                <img src='/cookbook/4.1/images/axisline_vector_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-bar-graph'>Plottable: Bar Graph</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph'>Bar Graph</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A simple bar graph can be created from a series of values. By default values are palced at X positions 0, 1, 2, etc.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph'>
                <img src='/cookbook/4.1/images/bar_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph-with-defined-positions'>Bar Graph with Defined Positions</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Horizontal positions for each bar can be defined manually. If you define bar positions, you will probably want to define the bar width as well.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph-with-defined-positions'>
                <img src='/cookbook/4.1/images/bar_positions_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bar-labels'>Bar Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bars placed at specific positions can be labeled by setting tick labels for those positions.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bar-labels'>
                <img src='/cookbook/4.1/images/bar_labels_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph-with-error-bars'>Bar Graph with Error Bars</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Errorbars can be added to any bar graph.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bar-graph-with-error-bars'>
                <img src='/cookbook/4.1/images/bar_error_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#stacked-bar-graphs'>Stacked Bar Graphs</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bars can be overlapped to give the appearance of stacking.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#stacked-bar-graphs'>
                <img src='/cookbook/4.1/images/bar_stacked_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#values-above-bars'>Values Above Bars</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The value of each bar can be displayed above it.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#values-above-bars'>
                <img src='/cookbook/4.1/images/bar_values_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#custom-value-formatter'>Custom Value Formatter</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A custom formatter can be used to generate labels above each bar using the numeric value of the bar itself.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#custom-value-formatter'>
                <img src='/cookbook/4.1/images/bar_values_custom_formatter_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bar-fill-pattern'>Bar Fill Pattern</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bar graph fill pattern can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bar-fill-pattern'>
                <img src='/cookbook/4.1/images/bar_pattern_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#horizontal-bar-graph'>Horizontal Bar Graph</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bar graphs are typically displayed as columns, but it's possible to show bars as rows.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#horizontal-bar-graph'>
                <img src='/cookbook/4.1/images/bar_horizontal_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#grouped-bar-graphs'>Grouped Bar Graphs</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By customizing positions of multiple bar plots you can achieve the appearance of grouped bar graphs. The AddBarGroups() method is designed to simplify this process. More advanced grouping and bar plot styling is possible using the Population plot type.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#grouped-bar-graphs'>
                <img src='/cookbook/4.1/images/bar_group_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#bars-with-y-offsets'>Bars with Y Offsets</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default bar graphs start at 0, but this does not have to be the case. Y offsets can be defined for each bar. When Y offsets are used, values represent the height of the bars (relative to their offsets).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#bars-with-y-offsets'>
                <img src='/cookbook/4.1/images/bar_yoffset_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#negative-bar-colors'>Negative Bar Colors</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bars with negative values can be colored differently than positive ones.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#negative-bar-colors'>
                <img src='/cookbook/4.1/images/bar_ynegcolor_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#waterfall-bar-graph'>Waterfall Bar Graph</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Waterfall bar graphs use bars to represent changes in value from the previous level. This style graph can be created by offseting each bar by the sum of all bars preceeding it. This effect is similar to financial plots (OHLC and Candlestick) which are described in another section.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#waterfall-bar-graph'>
                <img src='/cookbook/4.1/images/bar_waterfall_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#lollipop-plot-quickstart'>Lollipop Plot Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Lollipop plots convey the same information as Bar plots but have a different appearance.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#lollipop-plot-quickstart'>
                <img src='/cookbook/4.1/images/bar_lollipop_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#lollipop-plot-customizations'>Lollipop Plot Customizations</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Lollipop plots can be extensively customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#lollipop-plot-customizations'>
                <img src='/cookbook/4.1/images/bar_lollipop_custom_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#cleveland-dot-plot'>Cleveland Dot Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Cleveland Dot Plots allow comparing two categories in situations where a Bar Plot may be crowded.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#cleveland-dot-plot'>
                <img src='/cookbook/4.1/images/bar_cleveland_dot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bar-graph/#datetime-bar-plot'>DateTime Bar Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bars have a default width of 1.0, but when using DateTime axis this means bars are one day wide. To plot DateTime data you may need to manually set the width of a bar to a desired size (in fractions of a day).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bar-graph/#datetime-bar-plot'>
                <img src='/cookbook/4.1/images/bar_datetime_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-bubble'>Plottable: Bubble</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bubble/#bubble-plot'>Bubble Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bubble plots display circles at specific X/Y locations. Each circle can be individually customized. Save the object that is returned when the bubble plot is created and call its Add() method to add bubbles.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bubble/#bubble-plot'>
                <img src='/cookbook/4.1/images/bubble_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-bubble/#bubbles-with-labels'>Bubbles with Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bubble plots can be combined with other plot types to create more advanced charts. In this example each bubble is accompanied by a text object. Bubbles are also colored according to their size such that smaller bubbles are bluer.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-bubble/#bubbles-with-labels'>
                <img src='/cookbook/4.1/images/bubble_withtext_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-colorbar'>Plottable: Colorbar</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#colorbar'>Colorbar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A colorbar displays a colormap beside the data area. Colorbars are typically added to plots containing heatmaps.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#colorbar'>
                <img src='/cookbook/4.1/images/colorbar_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-for-colormap'>Colorbar for Colormap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default colorbars use the Viridis colormap, but this behavior can be customized and many colormaps are available.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-for-colormap'>
                <img src='/cookbook/4.1/images/colorbar_colormap_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-ticks'>Colorbar Ticks</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tick marks can be added to colorbars. Each tick is described by a position (a fraction of the distance from the bottom to the top) and a string (the tick label).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-ticks'>
                <img src='/cookbook/4.1/images/colorbar_ticks_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#color-range'>Color Range</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can restrict a colorbar to only show a small range of a colormap. In this example we only use the middle of a rainbow colormap.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#color-range'>
                <img src='/cookbook/4.1/images/colorbar_range_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#clipped-value-range'>Clipped value range</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>If data values extend beyond the min/max range displayed by a colorbar you can indicate the colormap is clipping the data values and inequality symbols will be displayed in the tick labeles at the edge of the colorbar.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#clipped-value-range'>
                <img src='/cookbook/4.1/images/colorbar_clip_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#scatter-plot-with-colorbar'>Scatter Plot with Colorbar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example shows how to add differently colored markers to the plot to simulate a scatter plot with points colored according to a colorbar. Note that the colormap generates the colors, and that a colorbar just displays a colormap</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#scatter-plot-with-colorbar'>
                <img src='/cookbook/4.1/images/colorbar_scatter_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-on-left'>Colorbar on Left</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A colorbar may be added to the left side of the chart</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-colorbar/#colorbar-on-left'>
                <img src='/cookbook/4.1/images/colorbar_left_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-coxcomb'>Plottable: Coxcomb</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-coxcomb/#coxcomb-chart'>Coxcomb Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A Pie chart where the angle of slices is constant but the radii are not.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-coxcomb/#coxcomb-chart'>
                <img src='/cookbook/4.1/images/coxcomb_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-coxcomb/#coxcomb-chart-with-icons'>Coxcomb Chart with icons</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A Pie chart where the angle of slices is constant but the radii are not, icons are used for quick reference.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-coxcomb/#coxcomb-chart-with-icons'>
                <img src='/cookbook/4.1/images/coxcomb_iconvalue_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-crosshair'>Plottable: Crosshair</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-crosshair/#crosshair'>Crosshair</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The Crosshair plot type draws vertical and horizontal lines that intersect at a point on the plot and the coordinates of those lines are displayed on top of the axis ticks. This plot type is typically updated after MouseMove events to track the mouse</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-crosshair/#crosshair'>
                <img src='/cookbook/4.1/images/crosshair_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-crosshair/#crosshair-customization'>Crosshair Customization</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Crosshair styling and label formatting can be customized by accessing public fields.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-crosshair/#crosshair-customization'>
                <img src='/cookbook/4.1/images/crosshair_customize_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-crosshair/#datetime-axis-label'>DateTime Axis Label</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Crosshair labels display numeric labels by default, but a public field makes it possible to convert positions to DateTime (FromOATime) when generating their axis labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-crosshair/#datetime-axis-label'>
                <img src='/cookbook/4.1/images/crosshair_formatting_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-crosshair/#custom-label-format'>Custom Label Format</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>For ultimate control over crosshair label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format crosshair labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-crosshair/#custom-label-format'>
                <img src='/cookbook/4.1/images/crosshair_customlabelformatting_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-crosshair/#crosshairs-on-multiple-axes'>Crosshairs on Multiple Axes</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Crosshairs label coordinates on the primary axes by default, but the axis index can be changed allowing multiple crosshairs to label multiple axes.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-crosshair/#crosshairs-on-multiple-axes'>
                <img src='/cookbook/4.1/images/crosshair_multiple_different_axes_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-error-bar'>Plottable: Error Bar</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-error-bar/#error-bar-quickstart'>Error Bar Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Error Bars allow more fine-grained control over how your error bars are shown.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-error-bar/#error-bar-quickstart'>
                <img src='/cookbook/4.1/images/errorbar_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-error-bar/#symmetric-error-bars'>Symmetric Error Bars</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>There's a shorthand method for error bars where the positive and negative error is the same.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-error-bar/#symmetric-error-bars'>
                <img src='/cookbook/4.1/images/errorbar_symmetric_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-error-bar/#error-bars-in-one-dimension'>Error Bars in One Dimension</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>If you only have error data for one dimension you can simply pass in null for the other dimension.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-error-bar/#error-bars-in-one-dimension'>
                <img src='/cookbook/4.1/images/errorbar_onedimension_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-error-bar/#customization'>Customization</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can customize the colour, cap size, and line width of the error bars.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-error-bar/#customization'>
                <img src='/cookbook/4.1/images/errorbar_customization_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-error-bar/#error-bar-marker'>Error Bar Marker</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An optional marker can be drawn at the center X/Y position for each error bar.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-error-bar/#error-bar-marker'>
                <img src='/cookbook/4.1/images/errorbar_marker_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-fill'>Plottable: Fill</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-fill/#fill-under-curve'>Fill Under Curve</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Fill methods help to create semitransparent polygons to fill the area under a curve. This can be used to give the appearance of shading under a scatter plot, even though the plottable created here is a polygon with optional edge color and fill color.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-fill/#fill-under-curve'>
                <img src='/cookbook/4.1/images/fill_curve_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-fill/#fill-above-and-below'>Fill Above and Below</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Sometimes you want to share the area under a curve, but change its color depending on which side of the baseline value it is. There's a helper method to make this easier.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-fill/#fill-above-and-below'>
                <img src='/cookbook/4.1/images/fill_abovebelow_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-fill/#fill-between-curves'>Fill Between Curves</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Given two curves, a polygon can be created to give the appearance of shading between them. Here we will display two scatter plots, then create a polygon to fill the region between them.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-fill/#fill-between-curves'>
                <img src='/cookbook/4.1/images/fill_between_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-fill/#hatched-fill'>Hatched Fill</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Hatched Fills are useful for when there are overlapping fills, such as this diagram depicting the ranges of possible producer surpluses under a price floor.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-fill/#hatched-fill'>
                <img src='/cookbook/4.1/images/fill_hatched_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-finance'>Plottable: Finance</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#candlestick-chart'>Candlestick Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>ScottPlot can draw some financial indicators on plots in X/Y space, but users looking to develop robust financial charts should probably look at other libraries designed specifically for financial charting. The biggest limitations are (1) lack of mouse interaction and (2) the horizontal axis is strictly numeric Cartesian space and is not ideal for plotting dates. That said, some financial charting is possible with ScottPlot, and this cookbook demonstrates common use cases.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#candlestick-chart'>
                <img src='/cookbook/4.1/images/finance_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#ohlc-chart'>OHLC Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>OHLC charts are an alternative to candlestick charts. They show high and low prices as a vertical line, and indicate open and close prices with little ticks to the left and to the right.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#ohlc-chart'>
                <img src='/cookbook/4.1/images/finance_ohlc_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#using-a-datetime-axis'>Using a DateTime Axis</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You probably never want to do this... but OHLCs have an X value you can customize to be a DateTime (converted to a double using DateTime.ToOATime()). The advantage is that you can use the native DateTime axis support on the horizontal axis. The disadvantage is that gaps in time appear as gaps in the candlesticks. Weekends without trading will appear as gaps. The alternative to this method is to plot a series of OHLCs using sequential numbers, then manually define the axis tick labels.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#using-a-datetime-axis'>
                <img src='/cookbook/4.1/images/finance_datetimeaxis_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#candlesticks-with-custom-tick-labels'>Candlesticks with Custom Tick Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A better way to represent time on the horizontal axis is to use traditional Cartesian coordinates so each candlestick is placed at X positions (0, 1, 2, etc.), then manually define the locations and label text of important positions on the plot. This is clunky, but possible. This inelegance is why financial charting is probably best done with real financial charting libraries, not a scientific charting library like ScottPlot...</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#candlesticks-with-custom-tick-labels'>
                <img src='/cookbook/4.1/images/finance_ticklabels_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#simple-moving-average-sma'>Simple Moving Average (SMA)</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A simple moving average (SMA) technical indicator can be calculated and drawn as a scatter plot.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#simple-moving-average-sma'>
                <img src='/cookbook/4.1/images/finance_sma_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#bollinger-bands'>Bollinger Bands</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Bollinger bands are a common technical indicator that show the average +/- two times the standard deviation of a given time range preceeding it.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#bollinger-bands'>
                <img src='/cookbook/4.1/images/finance_bollinger_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#price-on-right'>Price on Right</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Newer data appears on the ride side of the chart so financial charts are often displayed with the vertical axis label on the right side as well. This is possible by disabling the left vertical axis (YAxis) and enabling the right one (YAxis2). The left and right Y axes are index 0 and 1 (respectively), and the plottable has to be update to indicate which axis index it should render on.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#price-on-right'>
                <img src='/cookbook/4.1/images/finance_right_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#custom-wick-color'>Custom Wick Color</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default candle wicks are the same color as their bodies, but this can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#custom-wick-color'>
                <img src='/cookbook/4.1/images/finance_wick_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#custom-colors'>Custom Colors</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Candles that close below their open price are colored differently from candles which close at or above it. These colors can be customized. Combine this styling with a custom wick color (which also controls the candle border) to create a different visual style.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#custom-colors'>
                <img src='/cookbook/4.1/images/finance_color_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-finance/#dark-mode'>Dark Mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A dark mode finance plot can be realized by customizing color options of the candles and figure. Colors in this example were chosen to mimic TC2000.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-finance/#dark-mode'>
                <img src='/cookbook/4.1/images/finance_dark_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-function'>Plottable: Function</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-function/#function'>Function</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Function plots are defined by a function (not X/Y data points) so the curve is continuous and can be zoomed in and out infinitely</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-function/#function'>
                <img src='/cookbook/4.1/images/function_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-heatmap'>Plottable: Heatmap</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-quickstart'>Heatmap Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Heatmaps display a 2D array using a colormap.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-quickstart'>
                <img src='/cookbook/4.1/images/heatmap_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-tight-margins'>Heatmap with Tight Margins</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The heatmap can fit the plot area exactly if margins are set to zero and the square axis lock is disabled.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-tight-margins'>
                <img src='/cookbook/4.1/images/heatmap_margins_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-colorbar'>Heatmap with Colorbar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Colorbars are often added when heatmaps are used.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-colorbar'>
                <img src='/cookbook/4.1/images/heatmap_colorbar_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#smooth-heatmap'>Smooth Heatmap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Heatmaps display values as rectangles with sharp borders by default. Enabling the Smooth feature uses bicubic interpolation to display the heatmap as a smooth gradient between values.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#smooth-heatmap'>
                <img src='/cookbook/4.1/images/heatmap_smooth_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-image'>Heatmap Image</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Image data can be plotted using the heatmap plot type.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-image'>
                <img src='/cookbook/4.1/images/heatmap_image_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#2d-waveform'>2D Waveform</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates a heatmap with 1000 tiles</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#2d-waveform'>
                <img src='/cookbook/4.1/images/heatmap_2dwaveform_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#colormap'>Colormap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Viridis is the default colormap, but several alternatives are available.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#colormap'>
                <img src='/cookbook/4.1/images/heatmap_colormap_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#styled-colormap'>Styled Colormap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Viridis is the default colormap, but several alternatives are available.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#styled-colormap'>
                <img src='/cookbook/4.1/images/styled_heatmap_colormap_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#scale-limits'>Scale Limits</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Heatmap colormap scale can use a defined min/max value.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#scale-limits'>
                <img src='/cookbook/4.1/images/heatmap_limitscale_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#color-clipping'>Color Clipping</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The value range displayed by the colormap can restricted to a narrow subset of the full data range. Tick labels at the edges of the colorbar can be made to show inequality symbols to indicate the range of data is being clipped when translating values to colors.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#color-clipping'>
                <img src='/cookbook/4.1/images/heatmap_clip_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#interpolation-by-density'>Interpolation by Density</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Heatmaps can be created from random 2D data points using the count within a square of fixed size.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#interpolation-by-density'>
                <img src='/cookbook/4.1/images/heatmap_density_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#gaussian-interpolation'>Gaussian Interpolation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Heatmaps can be created from 2D data points using bilinear interpolation with Gaussian weighting. This option results in a heatmap with a standard deviation of 4.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#gaussian-interpolation'>
                <img src='/cookbook/4.1/images/heatmap_gaussian_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#custom-dimensions'>Custom Dimensions</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default heatmaps start at the origin and each rectangle (cell) is 1 unit in size, but heatmap offset and cell size can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#custom-dimensions'>
                <img src='/cookbook/4.1/images/heatmap_dimensions_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-empty-squares'>Heatmap with Empty Squares</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can use a 2D array of nullable doubles to indicate some squares do not contain data. This allows the user to display heatmaps with transparency and implement non-rectangular heatmaps.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#heatmap-with-empty-squares'>
                <img src='/cookbook/4.1/images/heatmap_transparent_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-heatmap/#size-and-placement'>Size and Placement</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Edges of the heatmap can be defined as an alternative to defining offset and cell size,</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-heatmap/#size-and-placement'>
                <img src='/cookbook/4.1/images/heatmap_placement_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-image'>Plottable: Image</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-image/#image-quickstart'>Image Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The Image plottable places a Bitmap at a location in X/Y space.The image's position will move in space as the axes move, but the size of the bitmap will always be the same (matched to the display resolution). </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-image/#image-quickstart'>
                <img src='/cookbook/4.1/images/image_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-image/#image-alignment'>Image Alignment</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default the X/Y coordinates define the upper left position of the image, but alignment can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-image/#image-alignment'>
                <img src='/cookbook/4.1/images/image_alignment_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-image/#image-rotation'>Image Rotation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Images can be rotated, but rotation is always relative to the upper left corner.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-image/#image-rotation'>
                <img src='/cookbook/4.1/images/image_rotation_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-image/#image-border'>Image Border</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The borders of images can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-image/#image-border'>
                <img src='/cookbook/4.1/images/image_border_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-marker'>Plottable: Marker</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-marker/#marker'>Marker</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can place individual markers anywhere on the plot. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-marker/#marker'>
                <img src='/cookbook/4.1/images/marker_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-marker/#draggable-marker'>Draggable Marker</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A special type of marker exists which allows dragging with the mouse.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-marker/#draggable-marker'>
                <img src='/cookbook/4.1/images/marker_draggable_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-marker/#draggable-marker-snap'>Draggable Marker Snap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This is a type of marker which can be dragged with the mouse, but is restricted to to X/Y positions defined by two arrays.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-marker/#draggable-marker-snap'>
                <img src='/cookbook/4.1/images/marker_draggableinvector_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-marker/#labeled-marker'>Labeled Marker</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Markers have an optional text label.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-marker/#labeled-marker'>
                <img src='/cookbook/4.1/images/marker_labeled_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-marker/#marker-line-width'>Marker Line Width</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Markers have options that can be customized, such as line width.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-marker/#marker-line-width'>
                <img src='/cookbook/4.1/images/marker_linewidth_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-pie'>Plottable: Pie</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#pie-chart'>Pie Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A pie chart illustrates numerical proportions as slices of a circle.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#pie-chart'>
                <img src='/cookbook/4.1/images/pie_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#exploded-pie-chart'>Exploded Pie Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Exploded pie charts have a bit of space between their slices.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#exploded-pie-chart'>
                <img src='/cookbook/4.1/images/pie_exploded_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#donut-chart'>Donut Chart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Donut plots are pie charts with a hollow center.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#donut-chart'>
                <img src='/cookbook/4.1/images/pie_donut_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#donut-with-text'>Donut with Text</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Custom text can be displayed in the center of a donut chart. Notice too how the colors of each slice are customized in this example.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#donut-with-text'>
                <img src='/cookbook/4.1/images/pie_donuttext_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#slice-values'>Slice Values</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The value of each slice can be displayed at its center.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#slice-values'>
                <img src='/cookbook/4.1/images/pie_showvalues_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#slice-percentages'>Slice Percentages</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The percentage of each slice can be displayed at its center.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#slice-percentages'>
                <img src='/cookbook/4.1/images/pie_showpercentage_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#customize-pie-colors'>Customize Pie Colors</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Colors for pie slices and labels can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#customize-pie-colors'>
                <img src='/cookbook/4.1/images/pie_customcolors_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#slices-in-legend'>Slices in Legend</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Slices can be labeled in the legend.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#slices-in-legend'>
                <img src='/cookbook/4.1/images/pie_legend_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#label-everything'>Label Everything</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Slices can labeled with values, percentages, and lables, with a legend.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#label-everything'>
                <img src='/cookbook/4.1/images/pie_showeverything_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-pie/#custom-slice-labels'>Custom Slice Labels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Custom slice labels can be used to display values using custom formats</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-pie/#custom-slice-labels'>
                <img src='/cookbook/4.1/images/pie_customlabels_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-polygon'>Plottable: Polygon</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-polygon/#polygon-quickstart'>Polygon Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Polygons are 2D shapes made from pairs of X/Y points. The last point connects back to the first point, forming a closed shape. Polygons can be optionally outlined and optionally filled. Colors with semitransparency are especially useful for polygons.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-polygon/#polygon-quickstart'>
                <img src='/cookbook/4.1/images/polygon_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-polygon/#filled-line-plot'>Filled Line Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Polygons can be used to create 2D shapes resembling filled line plots. When mixed with semitransprent fills, these can be useful for displaying data.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-polygon/#filled-line-plot'>
                <img src='/cookbook/4.1/images/polygon_filledlineplot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-polygon/#fill-between-curves'>Fill Between Curves</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A shaded area between two curves can be created by enclosing the area as a polygon. For this to work the two curves must share the same X points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-polygon/#fill-between-curves'>
                <img src='/cookbook/4.1/images/polygon_fillbetween_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-polygon/#stacked-filled-line-plot'>Stacked Filled Line Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A stacked filled line plot effect can be achieved by overlapping polygons.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-polygon/#stacked-filled-line-plot'>
                <img src='/cookbook/4.1/images/polygon_stackedfilledlineplot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-polygon/#many-polygons'>Many Polygons</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Special rendering optimizations are available to display a large number of polygons.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-polygon/#many-polygons'>
                <img src='/cookbook/4.1/images/polygon_polygons_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-population'>Plottable: Population</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-population/#population-plot'>Population Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The population plot makes it easy to display populations as bar graphs, box-and-whisker plots, scattered values, or box plots and data points side-by-side. The population plot is different than using a box plot with an error bar in that you pass your original data into the population plot and it determines the standard deviation, standard error, quartiles, mean, median, outliers, etc., and you get to determine how to display these values.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-population/#population-plot'>
                <img src='/cookbook/4.1/images/population_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-population/#multiple-populations'>Multiple Populations</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Multiple populations can be assembled into an array and plotted as a single group.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-population/#multiple-populations'>
                <img src='/cookbook/4.1/images/population_multiple_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-population/#data-points-over-bar'>Data points over bar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Alternate styling options allow data points to be displayed over the box and whisker plots.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-population/#data-points-over-bar'>
                <img src='/cookbook/4.1/images/population_data_over_bar_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-population/#multiple-series'>Multiple Series</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Multiple series of population groups can be plotted Here each group is clustered on the horizontal axis, and each series is given a different color and appears in the legend.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-population/#multiple-series'>
                <img src='/cookbook/4.1/images/population_multiseries_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-population/#advanced-population-styling'>Advanced Population Styling</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Populations can be displayed many different ways. Scatter values can be displayed on either side of the bar or bar. Populations can be shown as bar graphs instead of box plots. Public fields allow many additional customizations.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-population/#advanced-population-styling'>
                <img src='/cookbook/4.1/images/population_advanced_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-radar'>Plottable: Radar</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#radar'>Radar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A radar chart concisely displays multiple values. Radar plots are also called a spider charts or star charts.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#radar'>
                <img src='/cookbook/4.1/images/radar_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#straight-axis-lines'>Straight Axis Lines</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Change the axis type to polygon to display radar charts with straight lines.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#straight-axis-lines'>
                <img src='/cookbook/4.1/images/radar_straightlines_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#no-axis-lines'>No Axis Lines</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A radar chart can have no drawn axis as well.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#no-axis-lines'>
                <img src='/cookbook/4.1/images/radar_nolines_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#labeled-categories'>Labeled Categories</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Category labels can be displayed on the radar chart.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#labeled-categories'>
                <img src='/cookbook/4.1/images/radar_labelcategory_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#labeled-values'>Labeled Values</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Labels can be displayed on the arms of the radar chart.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#labeled-values'>
                <img src='/cookbook/4.1/images/radar_labelvalue_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#customizable-polygon-outline'>Customizable polygon outline</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The thickness of each radar plot's outline can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#customizable-polygon-outline'>
                <img src='/cookbook/4.1/images/radar_customizepolygonoutline_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#categories-with-images'>Categories with images</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Images can be displayed on the arms of the radar chart. When using images, labels will be ignored so setting them will have no effect.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#categories-with-images'>
                <img src='/cookbook/4.1/images/radar_iconvalue_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#independent-axis-scaling'>Independent Axis Scaling</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Axis scaling can be independent, allowing values for each category to be displayed using a different scale. When independent axis mode is enabled, axis limits are automatically adjusted to fit the range of the data.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#independent-axis-scaling'>
                <img src='/cookbook/4.1/images/radar_axisscaling_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#defined-axis-limits'>Defined Axis Limits</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Radar charts with independent axis limits use scales fitted to the data by default, but scaling can be controlled by defining the maximum value for each axis.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#defined-axis-limits'>
                <img src='/cookbook/4.1/images/radar_axislimits_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radar/#customization'>Customization</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Radar charts support customization of the line color and width.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radar/#customization'>
                <img src='/cookbook/4.1/images/radar_customization_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-radialgauge'>Plottable: RadialGauge</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#radial-gauge'>Radial Gauge</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A radial gauge chart displays scalar data as circular gauges. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#radial-gauge'>
                <img src='/cookbook/4.1/images/radialgauge_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-colors'>Gauge Colors</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Gauge colors can be customized by changing the default palette. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-colors'>
                <img src='/cookbook/4.1/images/radialgauge_colors_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#negative-values'>Negative Values</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Radial gauge plots support positive and negative values.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#negative-values'>
                <img src='/cookbook/4.1/images/radialgauge_negative_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#sequential-gauge-mode'>Sequential Gauge Mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Sequential gauge mode indicates that the base of each gauge starts at the tip of the previous gauge.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#sequential-gauge-mode'>
                <img src='/cookbook/4.1/images/radialgauge_mode_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#reverse-order'>Reverse Order</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Gauges are displayed from the center outward by default but the order can be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#reverse-order'>
                <img src='/cookbook/4.1/images/radialgauge_reverse_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#single-gauge-mode'>Single Gauge Mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The SingleGauge mode draws all gauges stacked together as a single gauge. This is useful for showing a progress gauges composed of many individual smaller gauges.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#single-gauge-mode'>
                <img src='/cookbook/4.1/images/radialgauge_single_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-direction'>Gauge Direction</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The direction of gauges can be customized. Clockwise is used by default.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-direction'>
                <img src='/cookbook/4.1/images/radialgauge_direction_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-size'>Gauge Size</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The empty space between gauges can be adjusted as a fraction of their width. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-size'>
                <img src='/cookbook/4.1/images/radialgauge_size_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-caps'>Gauge Caps</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Caps can be customized for the starting and end of the gauges. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-caps'>
                <img src='/cookbook/4.1/images/radialgauge_caps_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-starting-angle'>Gauge Starting Angle</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The starting angle for gauges can be customized. 270 for North (default value), 0 for East, 90 for South, 180 for West, etc.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-starting-angle'>
                <img src='/cookbook/4.1/images/radialgauge_start_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-angular-range'>Gauge Angular Range</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default gauges are full circles (360 degrees) but smaller gauges can be created by customizing the gauge size.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-angular-range'>
                <img src='/cookbook/4.1/images/radialgauge_range_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#show-levels'>Show Levels</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The value of each gauge is displayed as text by default but this behavior can be overridden. Note that this is different than the labels fiels which is what appears in the legened.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#show-levels'>
                <img src='/cookbook/4.1/images/radialgauge_levels_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-position'>Gauge Label Position</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Gauge level text is positioned at the tip of each gauge by default, but this position can be adjusted by the user.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-position'>
                <img src='/cookbook/4.1/images/radialgauge_labelpos_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-font-percentage'>Gauge Label Font Percentage</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Size of the gauge level text as a fraction of the gauge width.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-font-percentage'>
                <img src='/cookbook/4.1/images/radialgauge_labelfontsize_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-color'>Gauge Label Color</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Level text fonts may be customized.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-label-color'>
                <img src='/cookbook/4.1/images/radialgauge_labelcolor_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-labels-in-legend'>Gauge Labels in Legend</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Radial gauge labels will appear in the legend if they are assigned. </p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#gauge-labels-in-legend'>
                <img src='/cookbook/4.1/images/radialgauge_legend_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#background-gauges-dim'>Background Gauges Dim</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>By default the full range of each gauge is drawn as a semitransparent ring. The amount of transparency can be adjusted as desired.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#background-gauges-dim'>
                <img src='/cookbook/4.1/images/radialgauge_backdim_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-radialgauge/#background-gauges-normalization'>Background Gauges Normalization</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Gauge backgrounds are drawn as full circles by default. This behavior can be disabled to draw partial backgrounds for non-circular gauges.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-radialgauge/#background-gauges-normalization'>
                <img src='/cookbook/4.1/images/radialgauge_backnorm_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-scale-bar'>Plottable: Scale Bar</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scale-bar/#scale-bar'>Scale Bar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scale-bar/#scale-bar'>
                <img src='/cookbook/4.1/images/scalebar_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scale-bar/#horizontal-scale-bar'>Horizontal Scale Bar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scale-bar/#horizontal-scale-bar'>
                <img src='/cookbook/4.1/images/scalebar_horizontal_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scale-bar/#styled-scale-bar'>Styled Scale Bar</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scale-bar/#styled-scale-bar'>
                <img src='/cookbook/4.1/images/scalebar_styled_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-scatter-plot'>Plottable: Scatter Plot</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#scatter-plot-quickstart'>Scatter Plot Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Scatter plots are best for small numbers of paired X/Y data points. For evenly-spaced data points Signal is much faster.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#scatter-plot-quickstart'>
                <img src='/cookbook/4.1/images/scatter_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#custom-markers'>Custom markers</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Markers can be customized using optional arguments and public fields.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#custom-markers'>
                <img src='/cookbook/4.1/images/scatter_markers_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#all-marker-shapes'>All marker shapes</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Legend indicates names of all available marker shapes</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#all-marker-shapes'>
                <img src='/cookbook/4.1/images/scatter_markershape_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#custom-lines'>Custom lines</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Line color, size, and style can be customized. Setting markerSize to 0 prevents markers from being rendered.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#custom-lines'>
                <img src='/cookbook/4.1/images/scatter_linestyle_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#random-xy-points'>Random X/Y Points</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>X data for scatter plots does not have to be evenly spaced, making scatter plots are ideal for displaying random data like this.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#random-xy-points'>
                <img src='/cookbook/4.1/images/scatter_random_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#scatter-plot-with-errorbars'>Scatter Plot with Errorbars</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>An array of values can be supplied for error bars and redering options can be customized as desired</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#scatter-plot-with-errorbars'>
                <img src='/cookbook/4.1/images/scatter_errorbar_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#lines-only'>Lines Only</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A shortcut method makes it easy to create a scatter plot with just lines (no markers)</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#lines-only'>
                <img src='/cookbook/4.1/images/scatter_lineplot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#markers-only'>Markers Only</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A shortcut method makes it easy to create a scatter plot where markers are displayed at every point (without any connecting lines)</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#markers-only'>
                <img src='/cookbook/4.1/images/scatter_pointsplot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#step-plot'>Step Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A step plot is a special type of scatter plot where points are connected by right angles instead of straight lines.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#step-plot'>
                <img src='/cookbook/4.1/images/scatter_stepplot_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#add-markers'>Add markers</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Want to place a marker at a position in X/Y space? AddMarker() will create a scatter plot with a single point.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#add-markers'>
                <img src='/cookbook/4.1/images/scatter_addmarker_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#draggable-scatter-plot'>Draggable Scatter Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Want to modify the scatter points interactively? A ScatterPlotDraggable lets you move the points around with the mouse. As you move the points around, the values in the original arrays change to reflect their new positions.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#draggable-scatter-plot'>
                <img src='/cookbook/4.1/images/scatter_draggable_vertical_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#draggable-scatter-plot-vertical'>Draggable Scatter Plot Vertical</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can restrict dragging to just X or Y directions.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#draggable-scatter-plot-vertical'>
                <img src='/cookbook/4.1/images/scatter_draggable_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot/#forest-plot'>Forest Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Scatter plots can be used to create forest plots, which are useful for showing the agreement between multiple estimates.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot/#forest-plot'>
                <img src='/cookbook/4.1/images/scatter_forest_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-scatter-plot-list'>Plottable: Scatter Plot List</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-quickstart'>Scatter List Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This experimental plot type has add/remove/clear methods like typical lists.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-quickstart'>
                <img src='/cookbook/4.1/images/scatterlist_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-generic'>Scatter List Generic</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This plot type supports generics.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-generic'>
                <img src='/cookbook/4.1/images/scatterlist_generic_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-draggable'>Scatter List Draggable</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>There exists an experimental Scatter Plot List with draggable points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-draggable'>
                <img src='/cookbook/4.1/images/scatterlist_draggable_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-draggable-limits'>Scatter List Draggable Limits</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A custom function can be used to limit the range of draggable points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-scatter-plot-list/#scatter-list-draggable-limits'>
                <img src='/cookbook/4.1/images/scatterlist_draggablelimits_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-signal-plot'>Plottable: Signal Plot</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#signal-plot-quickstart'>Signal Plot Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots are ideal for evenly-spaced data with thousands or millions of points.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#signal-plot-quickstart'>
                <img src='/cookbook/4.1/images/signal_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#signal-offset'>Signal Offset</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can have X and Y offsets that shift all data by a defined amount.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#signal-offset'>
                <img src='/cookbook/4.1/images/signal_offset_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#speed-test'>Speed Test</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Compare the speed to the same data plotted as a scatter plot.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#speed-test'>
                <img src='/cookbook/4.1/images/signal_advantage_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#styled-signal-plot'>Styled Signal Plot</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be styled using public fields. Signal plots can also be offset by a defined X or Y amount.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#styled-signal-plot'>
                <img src='/cookbook/4.1/images/signal_styled_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#step-display'>Step Display</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be styled as step plots where points are connected by right angles instead of straight lines.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#step-display'>
                <img src='/cookbook/4.1/images/signal_step_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#5-million-points'>5 Million Points</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots with millions of points can be interacted with in real time.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#5-million-points'>
                <img src='/cookbook/4.1/images/signal_5millionpoints_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#display-data-density'>Display data density</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>When plotting extremely high density data, you can't always see the trends underneath all those overlapping data points. If you send an array of colors to PlotSignal(), it will use those colors to display density.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#display-data-density'>
                <img src='/cookbook/4.1/images/signal_density_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#display-first-n-points'>Display first N points</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>When plotting live data it is useful to allocate a large array in memory then fill it with values as they come in. By setting the maxRenderIndex property of a scatter plot to can prevent rendering the end of the array (which is probably filled with zeros).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#display-first-n-points'>
                <img src='/cookbook/4.1/images/signal_firstnpoints_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#plot-a-range-of-points'>Plot a Range of Points</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>It is sometimes useful to only display values within a range of the source data array.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#plot-a-range-of-points'>
                <img src='/cookbook/4.1/images/signal_range_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#fill-below'>Fill Below</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be filled below with a solid color.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#fill-below'>
                <img src='/cookbook/4.1/images/signal_fillbelow_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-below'>Gradient Fill Below</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be filled below using a color gradient.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-below'>
                <img src='/cookbook/4.1/images/signal_fillbelowgradient_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-above'>Gradient Fill Above</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be filled above using a color gradient.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-above'>
                <img src='/cookbook/4.1/images/signal_fillabove_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#fill-above-and-below'>Fill Above and Below</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal plots can be filled above and below</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#fill-above-and-below'>
                <img src='/cookbook/4.1/images/signal_fillaboveandbelow_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-above-and-below'>Gradient Fill Above and Below</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Gradients can be used to fill above and below.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signal-plot/#gradient-fill-above-and-below'>
                <img src='/cookbook/4.1/images/signal_gradientaboveandbelowgradient_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-signalconst'>Plottable: SignalConst</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalconst/#signalconst-quickstart'>SignalConst Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalConst plots pre-processes data to render much faster than Signal plots. Pre-processing takes a little time up-front and requires 4x the memory of Signal.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalconst/#signalconst-quickstart'>
                <img src='/cookbook/4.1/images/signalconst_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalconst/#generic-data-type'>Generic Data Type</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalConst supports other data types beyond just double arrays. You can use this plot type to display data in any numerical format that can be cast to a double.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalconst/#generic-data-type'>
                <img src='/cookbook/4.1/images/signalconst_generic_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-signalxy'>Plottable: SignalXY</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-quickstart'>SignalXY Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalXY is a speed-optimized plot for displaying vaues (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-quickstart'>
                <img src='/cookbook/4.1/images/signalxy_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-offset'>SignalXY Offset</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalXY plots can have X and Y offsets that shift all data by a defined amount.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-offset'>
                <img src='/cookbook/4.1/images/signalxy_offset_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#signal-data-with-gaps'>Signal Data with Gaps</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal with defined Xs that contain gaps</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#signal-data-with-gaps'>
                <img src='/cookbook/4.1/images/signalxy_gaps_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#different-densities'>Different Densities</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Signal with mised low and high density data</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#different-densities'>
                <img src='/cookbook/4.1/images/signalxy_density_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-step-mode'>SignalXY Step Mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Data points can be connected with steps (instead of straight lines).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-step-mode'>
                <img src='/cookbook/4.1/images/signalxy_step_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-with-fill'>SignalXY with Fill</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Various options allow shading above/below the signal data.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxy/#signalxy-with-fill'>
                <img src='/cookbook/4.1/images/signalxy_fillbelow_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-signalxyconst'>Plottable: SignalXYConst</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxyconst/#signalconst-with-x-and-y-data'>SignalConst with X and Y data</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalXYConst is a speed-optimized plot for displaying vaues (Ys) with unevenly-spaced positions (Xs) that are in ascending order. If your data is evenly-spaced, Signal and SignalConst is faster.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxyconst/#signalconst-with-x-and-y-data'>
                <img src='/cookbook/4.1/images/signalxyconst_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxyconst/#different-data-types-for-xs-and-ys'>Different data types for xs and ys</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>SignalXYConst with (int)Xs and (float)Ys arrays</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxyconst/#different-data-types-for-xs-and-ys'>
                <img src='/cookbook/4.1/images/signalxyconst_types_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-signalxyconst/#signalconst-step-mode'>SignalConst Step Mode</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Data points can be connected with steps (instead of straight lines).</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-signalxyconst/#signalconst-step-mode'>
                <img src='/cookbook/4.1/images/signalxyconst_step_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-text'>Plottable: Text</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-text/#text'>Text</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>The Text plottable displays a string at an X/Y coordinate in unit space. Unlike the Annotation plottable, text moves when the axes are adjusted.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-text/#text'>
                <img src='/cookbook/4.1/images/text_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-text/#text-alignment-and-rotation'>Text Alignment and Rotation</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Alignment indicates which corner is placed at the X/Y coordinate.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-text/#text-alignment-and-rotation'>
                <img src='/cookbook/4.1/images/text_alignment_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-text/#custom-fonts'>Custom Fonts</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>You can pass in a Font to further customize font options</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-text/#custom-fonts'>
                <img src='/cookbook/4.1/images/text_fonts_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-tooltip'>Plottable: Tooltip</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-quickstart'>Tooltip Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tooltips are annotations that point to an X/Y coordinate on the plot</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-quickstart'>
                <img src='/cookbook/4.1/images/tooltip_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-font'>Tooltip Font</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tooltips fonts can be customized</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-font'>
                <img src='/cookbook/4.1/images/tooltip_font_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-colors'>Tooltip Colors</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Tooltips border and fill styles can be customized</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-tooltip/#tooltip-colors'>
                <img src='/cookbook/4.1/images/tooltip_colors_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

### <div><a href='/cookbook/4.1/category/plottable-vector-field'>Plottable: Vector Field</a></div>
<div class='row'>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-vector-field/#quickstart'>Quickstart</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A vector field can be useful to show data explained by differential equations</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-vector-field/#quickstart'>
                <img src='/cookbook/4.1/images/vectorfield_quickstart_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-vector-field/#angle-and-magnitude'>Angle and Magnitude</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>This example demonstrates how to define vectors according to a given angle and magnitude.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-vector-field/#angle-and-magnitude'>
                <img src='/cookbook/4.1/images/vectorfield_anglemag_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-vector-field/#custom-colormap'>Custom Colormap</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A colormap can be supplied to color arrows according to their magnitude</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-vector-field/#custom-colormap'>
                <img src='/cookbook/4.1/images/vectorfield_colormap_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-vector-field/#custom-scale-factor'>Custom Scale Factor</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>A custom scale factor can adjust the length of the arrows.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-vector-field/#custom-scale-factor'>
                <img src='/cookbook/4.1/images/vectorfield_scalefactor_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>

<div class='col-md-4 mb-3'>
    <div class='card'>
        <div class='card-header'>
        <strong><a href='/cookbook/4.1/category/plottable-vector-field/#scaled-arrowheads'>Scaled Arrowheads</a></strong>
        </div>
        <div class='card-body'>
            <p class='card-text'>Use a slower drawing method that draws tips that are proportional to the length of the arrows.</p>
        <div class='text-center'>
            <a href='/cookbook/4.1/category/plottable-vector-field/#scaled-arrowheads'>
                <img src='/cookbook/4.1/images/vectorfield_fancytips_thumb.jpg' class='mw-100' />
            </a>
        </div>
        </div>
    </div>
</div>
</div>

