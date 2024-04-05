---
Title: ScottPlot Changelog
Description: Release notes for every version of ScottPlot
---

# ScottPlot Changelog

Release notes for every version of ScottPlot

<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.24</h1>
<div><i>NuGet packages published </i></div>
<div class='mt-1'>
<ul>
<li>Ticks: Modified <code>NumericFixedInterval</code> to add support for inverted axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3567">#3567</a>) <a href="https://github.com/Alexander-png"><strong>@Alexander-png</strong></a>
</li>
<li>Bar plot: Improved support for labels on horizontally oriented bar plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3546">#3546</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3520">#3520</a>) <a href="https://github.com/aespitia"><strong>@aespitia</strong></a> <a href="https://github.com/yui1227"><strong>@yui1227</strong></a>
</li>
<li>Axis: Added new axis rules for edge locking, center locking, and tick snapping (<a href="https://github.com/ScottPlot/ScottPlot/issues/3547">#3547</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>SignalXY: Added <code>GetNearest()</code> for locating the data point nearest the cursor (<a href="https://github.com/ScottPlot/ScottPlot/issues/3550">#3550</a>) <a href="https://github.com/endreew"><strong>@endreew</strong></a>
</li>
<li>Demo: Added demonstration for draggable <code>SignalXY</code> plots which respond to the cursor (<a href="https://github.com/ScottPlot/ScottPlot/issues/3550">#3550</a>) <a href="https://github.com/endreew"><strong>@endreew</strong></a>
</li>
<li>Legend: Do not display plottables where <code>IsVisible</code> is <code>false</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3552">#3552</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3545">#3545</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3541">#3541</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>, <a href="https://github.com/blahetal"><strong>@blahetal</strong></a>, <a href="https://github.com/pkstrsk"><strong>@pkstrsk</strong></a>
</li>
<li>Annotation: Improve positioning so it is unaffected by typeface or font (<a href="https://github.com/ScottPlot/ScottPlot/issues/3558">#3558</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Controls: Improve render artifacts on platforms that allow concurrent rendering and UI manipulation (<a href="https://github.com/ScottPlot/ScottPlot/issues/3559">#3559</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3557">#3557</a>) <a href="https://github.com/chjrom"><strong>@chjrom</strong></a> <a href="https://github.com/Limula-PMA"><strong>@Limula-PMA</strong></a>
</li>
<li>Controls: Improve behavior of interactions started outside the plot area (<a href="https://github.com/ScottPlot/ScottPlot/issues/3571">#3571</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3543">#3543</a>) <a href="https://github.com/bwedding"><strong>@bwedding</strong></a> <a href="https://github.com/pkstrsk"><strong>@pkstrsk</strong></a>
</li>
<li>Label: Prevent rendering borders when line width is zero (<a href="https://github.com/ScottPlot/ScottPlot/issues/3572">#3572</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3538">#3538</a>) <a href="https://github.com/bwedding"><strong>@bwedding</strong></a>
</li>
<li>Scatter: Added support for <code>NaN</code> values to display gaps in the line (<a href="https://github.com/ScottPlot/ScottPlot/issues/3577">#3577</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3276">#3276</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a> <a href="https://github.com/Hub3r"><strong>@Hub3r</strong></a>
</li>
<li>DataLogger: Added support for <code>NaN</code> values to display gaps in the line (<a href="https://github.com/ScottPlot/ScottPlot/issues/3577">#3577</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Finance: OHLC plots now have a <code>Sequential</code> mode (like candlestick plots) for displaying data without gaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/3590">#3590</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Plot: Added optional arguments to <code>GetCoordinateRect()</code> to support non-standard axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3591">#3591</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Axes: Added optional arguments to <code>Plot.Axes.AutoScale()</code> to add support for nonstandard axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3592">#3592</a>)
</li>
<li>Axis Rules: Improved <code>Plot.Axes.SquareUnits()</code> to support inverted axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3592">#3592</a>) <a href="https://github.com/VisMotrix"><strong>@VisMotrix</strong></a>
</li>
<li>WinForms: Improve <code>FormsPlot</code> disposal so the control displays properly when re-launched (<a href="https://github.com/ScottPlot/ScottPlot/issues/3593">#3593</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3589">#3589</a>) <a href="https://github.com/bwedding"><strong>@bwedding</strong></a> <a href="https://github.com/Kruno313"><strong>@Kruno313</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Alexander-png'>@Alexander-png</a>, <a href='https://github.com/aespitia'>@aespitia</a>, <a href='https://github.com/yui1227'>@yui1227</a>, <a href='https://github.com/BrianAtZetica'>@BrianAtZetica</a>, <a href='https://github.com/endreew'>@endreew</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/blahetal'>@blahetal</a>, <a href='https://github.com/pkstrsk'>@pkstrsk</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/chjrom'>@chjrom</a>, <a href='https://github.com/Limula-PMA'>@Limula-PMA</a>, <a href='https://github.com/bwedding'>@bwedding</a>, <a href='https://github.com/drolevar'>@drolevar</a>, <a href='https://github.com/Hub3r'>@Hub3r</a>, <a href='https://github.com/oktrue'>@oktrue</a>, <a href='https://github.com/VisMotrix'>@VisMotrix</a>, <a href='https://github.com/Kruno313'>@Kruno313</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Alexander-png'><img src='https://scottplot.net/images/contributors/alexander-png.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/aespitia'><img src='https://scottplot.net/images/contributors/aespitia.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/yui1227'><img src='https://scottplot.net/images/contributors/yui1227.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BrianAtZetica'><img src='https://scottplot.net/images/contributors/brianatzetica.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/endreew'><img src='https://scottplot.net/images/contributors/endreew.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/blahetal'><img src='https://scottplot.net/images/contributors/blahetal.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/pkstrsk'><img src='https://scottplot.net/images/contributors/pkstrsk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chjrom'><img src='https://scottplot.net/images/contributors/chjrom.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Limula-PMA'><img src='https://scottplot.net/images/contributors/limula-pma.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bwedding'><img src='https://scottplot.net/images/contributors/bwedding.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/drolevar'><img src='https://scottplot.net/images/contributors/drolevar.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Hub3r'><img src='https://scottplot.net/images/contributors/hub3r.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oktrue'><img src='https://scottplot.net/images/contributors/oktrue.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/VisMotrix'><img src='https://scottplot.net/images/brand/favicon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Kruno313'><img src='https://scottplot.net/images/brand/favicon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.23</h1>
<div><i>NuGet packages published 2024-03-24</i></div>
<div class='mt-1'>
<ul>
<li>Plot: Added <code>ShowLegend()</code> overload that does not override the current <code>Orientation</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3450">#3450</a>) <a href="https://github.com/aespitia"><strong>@aespitia</strong></a>
</li>
<li>Grid: The standard grid can be accessed via <code>Plot.Grid</code> instead of <code>GetDefaultGrid()</code>
</li>
<li>Style: <code>Plot.Style.ColorLegend()</code> is deprecated. Access <code>Plot.Legend</code> properties directly as seen in the cookbook.
</li>
<li>Style: <code>Plot.Style.ColorAxes()</code> has moved to <code>Plot.Axes.Color()</code>
</li>
<li>Style: <code>Plot.Style.AxisFrame()</code> has moved to <code>Plot.Axes.Frame()</code>
</li>
<li>Style: <code>Plot.Style.SetBestFonts()</code> has moved to <code>Plot.Font.Automatic()</code>
</li>
<li>Grid: Added <code>Plot.Grid</code> with axis-specific styling options as seen in the cookbook (<a href="https://github.com/ScottPlot/ScottPlot/issues/3291">#3291</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3293">#3293</a>) <a href="https://github.com/bjschwarz"><strong>@bjschwarz</strong></a> <a href="https://github.com/PaxITIS"><strong>@PaxITIS</strong></a>
</li>
<li>SignalXY: Fixed a bug where the final line segment was not drawn (<a href="https://github.com/ScottPlot/ScottPlot/issues/3495">#3495</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3423">#3423</a>) <a href="https://github.com/MareMare"><strong>@MareMare</strong></a> <a href="https://github.com/mjazd"><strong>@mjazd</strong></a>
</li>
<li>SignalXY: Improved support for inverted vertical axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3495">#3495</a>) <a href="https://github.com/MareMare"><strong>@MareMare</strong></a>
</li>
<li>Controls: Ignore mouse wheel zooming if a zoom rectangle is being drawn (<a href="https://github.com/ScottPlot/ScottPlot/issues/3498">#3498</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Controls: Improve axis lock behavior when dragging the mouse on a control (<a href="https://github.com/ScottPlot/ScottPlot/issues/3498">#3498</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Heatmap: Added <code>Opacity</code> and <code>AlphaMap</code> properties to enhance transparency customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/3499">#3499</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3349">#3349</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Heatmap: Intensity values that are <code>double.NaN</code> are now displayed as transparent cells (<a href="https://github.com/ScottPlot/ScottPlot/issues/3499">#3499</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3349">#3349</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Text: Added an <code>OffsetX</code> and <code>OffsetY</code> properties for adjusting text position in pixel units (<a href="https://github.com/ScottPlot/ScottPlot/issues/3506">#3506</a>) <a href="https://github.com/jamaa"><strong>@jamaa</strong></a>
</li>
<li>Demo: Added a demonstration window for highlight the point nearest the cursor across multiple scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3507">#3507</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3503">#3503</a>) <a href="https://github.com/jamaa"><strong>@jamaa</strong></a> <a href="https://github.com/RubensMigliore"><strong>@RubensMigliore</strong></a>
</li>
<li>Polygon: Improved automatic axis limit detection of polygons (<a href="https://github.com/ScottPlot/ScottPlot/issues/3501">#3501</a>) <a href="https://github.com/drphobos"><strong>@drphobos</strong></a>
</li>
<li>Annotation: New plot type for adding text labels aligned to the data area which are always visible (<a href="https://github.com/ScottPlot/ScottPlot/issues/3510">#3510</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3356">#3356</a>) <a href="https://github.com/dlampa"><strong>@dlampa</strong></a>
</li>
<li>Ticks: Added <code>MinimumTickSpacing</code>, <code>TickDensity</code>, and <code>TargetTickCount</code> properties to the automatic tick generator (see Cookbook)
</li>
<li>Avalonia: Fixed transparent background issue introduced in the previous version (<a href="https://github.com/ScottPlot/ScottPlot/issues/3502">#3502</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3516">#3516</a>) <a href="https://github.com/chjrom"><strong>@chjrom</strong></a> <a href="https://github.com/MrOldOwl"><strong>@MrOldOwl</strong></a> <a href="https://github.com/kebox7"><strong>@kebox7</strong></a>
</li>
<li>Rendering: Improved canvas state management to prevent duplicate restoration calls (<a href="https://github.com/ScottPlot/ScottPlot/issues/3527">#3527</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3523">#3523</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3528">#3528</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a> <a href="https://github.com/chjrom"><strong>@chjrom</strong></a>
</li>
<li>Signal: Improved performance of large signal plots when zoomed in (<a href="https://github.com/ScottPlot/ScottPlot/issues/3530">#3530</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3229">#3229</a>) <a href="https://github.com/minjjKang"><strong>@minjjKang</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/aespitia'>@aespitia</a>, <a href='https://github.com/bjschwarz'>@bjschwarz</a>, <a href='https://github.com/PaxITIS'>@PaxITIS</a>, <a href='https://github.com/MareMare'>@MareMare</a>, <a href='https://github.com/mjazd'>@mjazd</a>, <a href='https://github.com/BrianAtZetica'>@BrianAtZetica</a>, <a href='https://github.com/jamaa'>@jamaa</a>, <a href='https://github.com/RubensMigliore'>@RubensMigliore</a>, <a href='https://github.com/drphobos'>@drphobos</a>, <a href='https://github.com/dlampa'>@dlampa</a>, <a href='https://github.com/chjrom'>@chjrom</a>, <a href='https://github.com/MrOldOwl'>@MrOldOwl</a>, <a href='https://github.com/kebox7'>@kebox7</a>, <a href='https://github.com/minjjKang'>@minjjKang</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/aespitia'><img src='https://scottplot.net/images/contributors/aespitia.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bjschwarz'><img src='https://scottplot.net/images/contributors/bjschwarz.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PaxITIS'><img src='https://scottplot.net/images/contributors/paxitis.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MareMare'><img src='https://scottplot.net/images/contributors/maremare.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mjazd'><img src='https://scottplot.net/images/contributors/mjazd.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BrianAtZetica'><img src='https://scottplot.net/images/contributors/brianatzetica.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jamaa'><img src='https://scottplot.net/images/contributors/jamaa.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RubensMigliore'><img src='https://scottplot.net/images/contributors/rubensmigliore.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/drphobos'><img src='https://scottplot.net/images/contributors/drphobos.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dlampa'><img src='https://scottplot.net/images/contributors/dlampa.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chjrom'><img src='https://scottplot.net/images/contributors/chjrom.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MrOldOwl'><img src='https://scottplot.net/images/contributors/mroldowl.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kebox7'><img src='https://scottplot.net/images/contributors/kebox7.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/minjjKang'><img src='https://scottplot.net/images/contributors/minjjkang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.73</h1>
<div><i>NuGet packages published 2024-03-24</i></div>
<div class='mt-1'>
<ul>
<li>Image: Improve automatic axis limit detection for images with manually defined positions (<a href="https://github.com/ScottPlot/ScottPlot/issues/3529">#3529</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3515">#3515</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.22</h1>
<div><i>NuGet packages published 2024-03-16</i></div>
<div class='mt-1'>
<ul>
<li>Rendering: Added additional options for gradient fills (<a href="https://github.com/ScottPlot/ScottPlot/issues/3324">#3324</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Plot: Improve <code>GetPixel()</code> behavior when a custom <code>ScaleFactor</code> is in use (<a href="https://github.com/ScottPlot/ScottPlot/issues/3327">#3327</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Fonts: Improve behavior of cached typefaces (<a href="https://github.com/ScottPlot/ScottPlot/issues/3334">#3334</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3335">#3335</a>) <a href="https://github.com/Milkitic"><strong>@Milkitic</strong></a>
</li>
<li>Legend: Added support for horizontal orientation (<a href="https://github.com/ScottPlot/ScottPlot/issues/3341">#3341</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3302">#3302</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3280">#3280</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Controls: Created <code>AddSeparator()</code> to facilitate creation of custom context menus (<a href="https://github.com/ScottPlot/ScottPlot/issues/3342">#3342</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Live Data: Improved indexing of the <code>Wipe</code> view to prevent race conditions when displaying live data (<a href="https://github.com/ScottPlot/ScottPlot/issues/3352">#3352</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Radial Gauge Plot: Added a new plot type for displaying categorical data as circular gauges (<a href="https://github.com/ScottPlot/ScottPlot/issues/3358">#3358</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Generate: Improved <code>RandomNormalSample()</code> behavior by fixing an off-by-one indexing error <a href="https://github.com/DominicBeer"><strong>@DominicBeer</strong></a>
</li>
<li>Avalonia: Redraw plots using a non-blocking background thread to improve multi-axis behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/3373">#3373</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3359">#3359</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>, <a href="https://github.com/BendRocks"><strong>@BendRocks</strong></a>, and <a href="https://github.com/ykarpeev"><strong>@ykarpeev</strong></a>
</li>
<li>Bar plot: Added a <code>Label</code> property to allow a collection of bars to be displayed as a single item in the legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/3375">#3375</a>) <a href="https://github.com/fhannan-ti"><strong>@fhannan-ti</strong></a>
</li>
<li>WPF: Redraw plots using a non-blocking background background thread to improve multi-axis behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/3373">#3373</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3359">#3359</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3381">#3381</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Ellipse: Added <code>LineWidth</code>, <code>LineColor</code>, and <code>FillColor</code> shortcut properties
</li>
<li>Color: Added <code>Lighten()</code> and <code>Darken()</code> properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/3387">#3387</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3390">#3390</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Color: Modified <code>ToHSL()</code> to return improved Hue, Saturation and Luminosity values (<a href="https://github.com/ScottPlot/ScottPlot/issues/3390">#3390</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>SignalXY: Improve support for displaying data on inverted axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3396">#3396</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3400">#3400</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Axes: Improved support for ticks and labels on inverted axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3401">#3401</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3397">#3397</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Plot: Added <code>Remove()</code> overloads for Axes, Panels, and Grids (<a href="https://github.com/ScottPlot/ScottPlot/issues/3402">#3402</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3360">#3360</a>) <a href="https://github.com/Excustic"><strong>@Excustic</strong></a>, <a href="https://github.com/redrabbit007"><strong>@redrabbit007</strong></a>, <a href="https://github.com/csbebetter"><strong>@csbebetter</strong></a>, <a href="https://github.com/xichaoqiang"><strong>@xichaoqiang</strong></a>
</li>
<li>Plot: <code>Plot.FigureBackground</code> is now <code>Plot.FigureBackground.Color</code> (and same with <code>DataBackground</code>)
</li>
<li>Plot: <code>Plot.FigureBackground.Image</code> and <code>Plot.DataBackground.Image</code> can be used to add a background image to plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3406">#3406</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3405">#3405</a>) <a href="https://github.com/unsigned-ru"><strong>@unsigned-ru</strong></a>
</li>
<li>Axes: Updated the auto-scaler to ignore plottables with visibility disabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/3407">#3407</a>) <a href="https://github.com/levipara"><strong>@levipara</strong></a>
</li>
<li>Axes: Restrict pan, zoom, and autoscale to a single dimension if the cursor is over an axis panel (<a href="https://github.com/ScottPlot/ScottPlot/issues/3410">#3410</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Controls: Improved behavior of middle-click-drag zoom rectangle actions when CTRL or SHIFT is pressed
</li>
<li>DataLogger and DataStreamer: Improve support for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3411">#3411</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Controls: Prevent unnecessary zoom rectangle clearing (<a href="https://github.com/ScottPlot/ScottPlot/issues/3412">#3412</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Axes: Improve placement of decisecond and centisecond ticks on DateTime axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3413">#3413</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Label: Improved appearance of multiline labels with outlined borders or filled backgrounds (<a href="https://github.com/ScottPlot/ScottPlot/issues/3415">#3415</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3371">#3371</a>) <a href="https://github.com/NicolasLairNET"><strong>@NicolasLairNET</strong></a>
</li>
<li>Label: Added a <code>LineSpacing</code> property to allow manually defining line height in multi-line labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/3415">#3415</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3371">#3371</a>) <a href="https://github.com/NicolasLairNET"><strong>@NicolasLairNET</strong></a>
</li>
<li>Heatmap: Improve vertical placement of scaled heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/3416">#3416</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3417">#3417</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Heatmap: Added <code>FlipHorizontally</code> and <code>FlipVertically</code> properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/3418">#3418</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3419">#3419</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Heatmap: Fixed off-by-one render error when <code>Extent</code> is provided by the user (<a href="https://github.com/ScottPlot/ScottPlot/issues/3434">#3434</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3419">#3419</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Heatmap: Added support for the <code>Smooth</code> property do render anti-aliased images (<a href="https://github.com/ScottPlot/ScottPlot/issues/3419">#3419</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
<li>Ticks: Fix issue where manual ticks could be displayed outside the data area (<a href="https://github.com/ScottPlot/ScottPlot/issues/3425">#3425</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3427">#3427</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3395">#3395</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a> <a href="https://github.com/wsomegapoint"><strong>@wsomegapoint</strong></a>
</li>
<li>DataLogger and DataStreamer: prevent possible out-of-range exception when using the <code>Scroll</code> view mode (<a href="https://github.com/ScottPlot/ScottPlot/issues/3430">#3430</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3429">#3429</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Color: Added <code>MixWith()</code> and related methods to facilitate color mixing and creation of color gradients (<a href="https://github.com/ScottPlot/ScottPlot/issues/3443">#3443</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3441">#3441</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Pie: Added <code>DonutFraction</code> property to enable donut charts (<a href="https://github.com/ScottPlot/ScottPlot/issues/3447">#3447</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3438">#3438</a>) <a href="https://github.com/aespitia"><strong>@aespitia</strong></a>, <a href="https://github.com/Prototipo-Erick-Santander"><strong>@Prototipo-Erick-Santander</strong></a>
</li>
<li>Plot: <code>ScaleFactor</code> is now a <code>double</code> for simplified assignment (<a href="https://github.com/ScottPlot/ScottPlot/issues/3454">#3454</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3455">#3455</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Marker: Improved default settings for outline-only markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/3456">#3456</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3453">#3453</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Scatter: New <code>Add.ScatterLine()</code> method creates a scatter plot with a line only and no markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/3462">#3462</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3452">#3452</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Scatter: New <code>Add.ScatterPoints()</code> method creates a scatter plot with markers only and no line (<a href="https://github.com/ScottPlot/ScottPlot/issues/3462">#3462</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3452">#3452</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Ticks: Improve performance by reducing the number of string measurements (<a href="https://github.com/ScottPlot/ScottPlot/issues/3468">#3468</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
<li>Plot: <code>GetCoordinateRect()</code> now returns dimensions that respect <code>ScaleFactor</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3471">#3471</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Label: Added <code>Measure()</code> overloads to facilitate measuring arbitrary strings without modifying the label text (<a href="https://github.com/ScottPlot/ScottPlot/issues/3474">#3474</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3473">#3473</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3458">#3458</a>) <a href="https://github.com/aespitia"><strong>@aespitia</strong></a> <a href="https://github.com/David-A-Blankenship"><strong>@David-A-Blankenship</strong></a>
</li>
<li>Layout: Improved positioning of text for bottom tick labels with large font (<a href="https://github.com/ScottPlot/ScottPlot/issues/3436">#3436</a>) <a href="https://github.com/edwwsw"><strong>@edwwsw</strong></a>
</li>
<li>Legend: Improve international font support when <code>Plot.Style.SetBestFonts()</code> is used (<a href="https://github.com/ScottPlot/ScottPlot/issues/3440">#3440</a>) <a href="https://github.com/edwwsw"><strong>@edwwsw</strong></a> <a href="https://github.com/yui1227"><strong>@yui1227</strong></a>
</li>
<li>Drawing: Do not draw rectangles if they have a line width of zero (<a href="https://github.com/ScottPlot/ScottPlot/issues/3384">#3384</a>)
</li>
<li>Ticks: Do not render ticks on <code>Axes</code> where <code>TickLabelStyle.IsVisible</code> is <code>false</code>
</li>
<li>NuGet: Package now includes native Linux assets regardless of original build target (<a href="https://github.com/ScottPlot/ScottPlot/issues/3481">#3481</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3357">#3357</a>)
</li>
<li>Bar: Added <code>Label</code> property to allow values to be displayed above bars (<a href="https://github.com/ScottPlot/ScottPlot/issues/3477">#3477</a>) <a href="https://github.com/DouglasWatt"><strong>@DouglasWatt</strong></a>
</li>
<li>Axes: Added <code>Plot.Axes.SquareUnits()</code> helper method for adding an axis rule that enforces equal axis scales (<a href="https://github.com/ScottPlot/ScottPlot/issues/3451">#3451</a>)
</li>
<li>Pie: Fixed issue were pie charts may have duplicate legends (<a href="https://github.com/ScottPlot/ScottPlot/issues/3445">#3445</a>)
</li>
<li>Axes: Improved render event behavior and support for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3525">#3525</a>) <a href="https://github.com/BrianAtZetica"><strong>@BrianAtZetica</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/Milkitic'>@Milkitic</a>, <a href='https://github.com/drolevar'>@drolevar</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/DominicBeer'>@DominicBeer</a>, <a href='https://github.com/oktrue'>@oktrue</a>, <a href='https://github.com/BendRocks'>@BendRocks</a>, <a href='https://github.com/ykarpeev'>@ykarpeev</a>, <a href='https://github.com/fhannan-ti'>@fhannan-ti</a>, <a href='https://github.com/BrianAtZetica'>@BrianAtZetica</a>, <a href='https://github.com/Excustic'>@Excustic</a>, <a href='https://github.com/redrabbit007'>@redrabbit007</a>, <a href='https://github.com/csbebetter'>@csbebetter</a>, <a href='https://github.com/xichaoqiang'>@xichaoqiang</a>, <a href='https://github.com/unsigned-ru'>@unsigned-ru</a>, <a href='https://github.com/levipara'>@levipara</a>, <a href='https://github.com/NicolasLairNET'>@NicolasLairNET</a>, <a href='https://github.com/wsomegapoint'>@wsomegapoint</a>, <a href='https://github.com/aespitia'>@aespitia</a>, <a href='https://github.com/Prototipo-Erick-Santander'>@Prototipo-Erick-Santander</a>, <a href='https://github.com/David-A-Blankenship'>@David-A-Blankenship</a>, <a href='https://github.com/edwwsw'>@edwwsw</a>, <a href='https://github.com/yui1227'>@yui1227</a>, <a href='https://github.com/DouglasWatt'>@DouglasWatt</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Milkitic'><img src='https://scottplot.net/images/contributors/milkitic.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/drolevar'><img src='https://scottplot.net/images/contributors/drolevar.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DominicBeer'><img src='https://scottplot.net/images/contributors/dominicbeer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oktrue'><img src='https://scottplot.net/images/contributors/oktrue.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BendRocks'><img src='https://scottplot.net/images/contributors/bendrocks.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ykarpeev'><img src='https://scottplot.net/images/contributors/ykarpeev.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/fhannan-ti'><img src='https://scottplot.net/images/contributors/fhannan-ti.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BrianAtZetica'><img src='https://scottplot.net/images/contributors/brianatzetica.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Excustic'><img src='https://scottplot.net/images/contributors/excustic.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/redrabbit007'><img src='https://scottplot.net/images/contributors/redrabbit007.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/csbebetter'><img src='https://scottplot.net/images/contributors/csbebetter.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xichaoqiang'><img src='https://scottplot.net/images/contributors/xichaoqiang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/unsigned-ru'><img src='https://scottplot.net/images/contributors/unsigned-ru.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/levipara'><img src='https://scottplot.net/images/contributors/levipara.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/NicolasLairNET'><img src='https://scottplot.net/images/contributors/nicolaslairnet.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/wsomegapoint'><img src='https://scottplot.net/images/contributors/wsomegapoint.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/aespitia'><img src='https://scottplot.net/images/contributors/aespitia.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Prototipo-Erick-Santander'><img src='https://scottplot.net/images/contributors/prototipo-erick-santander.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/David-A-Blankenship'><img src='https://scottplot.net/images/contributors/david-a-blankenship.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/edwwsw'><img src='https://scottplot.net/images/contributors/edwwsw.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/yui1227'><img src='https://scottplot.net/images/contributors/yui1227.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DouglasWatt'><img src='https://scottplot.net/images/contributors/douglaswatt.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.72</h1>
<div><i>NuGet packages published 2024-03-16</i></div>
<div class='mt-1'>
<ul>
<li>DataLogger: Improve support for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3411">#3411</a>) <a href="https://github.com/drolevar"><strong>@drolevar</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/drolevar'>@drolevar</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/drolevar'><img src='https://scottplot.net/images/contributors/drolevar.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.21</h1>
<div><i>NuGet packages published 2024-01-28</i></div>
<div class='mt-1'>
<ul>
<li>RenderManager: Exposed <code>EnableRendering</code> to facilitate render locking in async environments (<a href="https://github.com/ScottPlot/ScottPlot/issues/3264">#3264</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3213">#3213</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3095">#3095</a>) <a href="https://github.com/kagerouttepaso"><strong>@kagerouttepaso</strong></a>
</li>
<li>Arrow: Added a new arrow plot type that can be used to mark a position in coordinate space (<a href="https://github.com/ScottPlot/ScottPlot/issues/3265">#3265</a>) <a href="https://github.com/hockerschwan"><strong>@hockerschwan</strong></a>
</li>
<li>Label: Improved measurement of text containing leading or tailing whitespace (<a href="https://github.com/ScottPlot/ScottPlot/issues/3223">#3223</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3268">#3268</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a> and <a href="https://github.com/lindpatr"><strong>@lindpatr</strong></a>
</li>
<li>Axis Line: Added <code>LabelOppositeAxis</code> property and created dedicated cookbook page (<a href="https://github.com/ScottPlot/ScottPlot/issues/3275">#3275</a>)Lyakabynka
</li>
<li>Plot: <code>AddRectangle()</code> now accepts more input types (<a href="https://github.com/ScottPlot/ScottPlot/issues/3263">#3263</a>) <a href="https://github.com/enumer"><strong>@enumer</strong></a>
</li>
<li>Ticks: Created <code>IMinorTickGenerator</code> to allow users to inject their own logic for placing minor ticks
</li>
<li>Axes: Added support for log-scale tick labels and grid lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/3143">#3143</a>)
</li>
<li>Plot: Users can now <code>Add.Ellipse()</code> and <code>Add.Circle()</code> to place closed curves on plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3277">#3277</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3287">#3287</a>) <a href="https://github.com/hockerschwan"><strong>@hockerschwan</strong></a>
</li>
<li>Plot: Added <code>Plot.Remove()</code> overloads for removing all plottables of the given type (<a href="https://github.com/ScottPlot/ScottPlot/issues/3296">#3296</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3296">#3296</a>) <a href="https://github.com/DerekGooding"><strong>@DerekGooding</strong></a>
</li>
<li>Plot: Added <code>Plot.Remove()</code> overloads for removing plottables matching specific criteria (<a href="https://github.com/ScottPlot/ScottPlot/issues/3296">#3296</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3297">#3297</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Plot: Added <code>Plot.GetPlottables()</code> overloads to facilitate iterating over plottables of a specific type
</li>
<li>Rendering: Added support for gradient fills (<a href="https://github.com/ScottPlot/ScottPlot/issues/3298">#3298</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3157">#3157</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3310">#3310</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>, <a href="https://github.com/hockerschwan"><strong>@hockerschwan</strong></a>, and <a href="https://github.com/faguetan"><strong>@faguetan</strong></a>
</li>
<li>Controls: Disabling interactions then re-enabling them restores original interactions (<a href="https://github.com/ScottPlot/ScottPlot/issues/3305">#3305</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3304">#3304</a>) <a href="https://github.com/Nils-Berghs"><strong>@Nils-Berghs</strong></a>
</li>
<li>Plot: Added <code>Plot.GetPixel()</code> overload for improved support on multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3306">#3306</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Axis Lines: Label background color may be distinct from line color (<a href="https://github.com/ScottPlot/ScottPlot/issues/3309">#3309</a>) <a href="https://github.com/PhoenixChenLu"><strong>@PhoenixChenLu</strong></a>
</li>
<li>Axis Spans: New <code>Plot.Add.HorizontalSpan()</code> and <code>Plot.Add.VerticalSpan()</code> methods for shading axis ranges (<a href="https://github.com/ScottPlot/ScottPlot/issues/3307">#3307</a>) <a href="https://github.com/erikjl"><strong>@erikjl</strong></a>
</li>
<li>Interactivity: Added methods to simplify dragging axis lines and spans. See the demo application for details. (<a href="https://github.com/ScottPlot/ScottPlot/issues/3307">#3307</a>) <a href="https://github.com/erikjl"><strong>@erikjl</strong></a>
</li>
<li>Ticks: Improved tick density calculation to prevent overlapping tick labels for very large numbers (<a href="https://github.com/ScottPlot/ScottPlot/issues/3203">#3203</a>)
</li>
<li>Axes: Deprecate <code>DateTimeTicks(Edge.Bottom)</code> in favor of <code>DateTimeTicksBottom()</code> which now returns the created axis.
</li>
<li>Cookbook: Demonstrate DateTime tick labels with custom string formatting (<a href="https://github.com/ScottPlot/ScottPlot/issues/3272">#3272</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3273">#3273</a>) <a href="https://github.com/sterenas"><strong>@sterenas</strong></a> and <a href="https://github.com/stratdev3"><strong>@stratdev3</strong></a>
</li>
<li>Demo: Added icon to main application and all windows launched within (<a href="https://github.com/ScottPlot/ScottPlot/issues/3281">#3281</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3273">#3273</a>) <a href="https://github.com/sterenas"><strong>@sterenas</strong></a>
</li>
<li>Controls: Do not list OpenGL controls in the toolbox. They can still be added programmatically, but they invite many problems and offer little performance improvements for most applications so their use is discouraged (<a href="https://github.com/ScottPlot/ScottPlot/issues/3282">#3282</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3262">#3262</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3271">#3271</a>)
</li>
<li>WinForms: Disable design time visibility in .NET Framework projects to prevent Visual Studio error messages (<a href="https://github.com/ScottPlot/ScottPlot/issues/3300">#3300</a>) <a href="https://github.com/MaxFun"><strong>@MaxFun</strong></a>
</li>
<li>Markers: Added <code>Plot.Add.Markers()</code> to display a collection of marker positions all using the same style (<a href="https://github.com/ScottPlot/ScottPlot/issues/3283">#3283</a>)
</li>
<li>Axes: Added <code>Plot.Axes.Remove()</code> to allow users to remove additional axes they may have added (<a href="https://github.com/ScottPlot/ScottPlot/issues/3288">#3288</a>)Felix
</li>
<li>Data Streamer and Data Logger: Renamed <code>IAxisManager</code> to <code>IAxisLimitManager</code> to disambiguate it from the <code>AxisManager</code> class (<a href="https://github.com/ScottPlot/ScottPlot/issues/3289">#3289</a>)
</li>
<li>Pie: Added support for displaying slice label text above each slice (<a href="https://github.com/ScottPlot/ScottPlot/issues/3295">#3295</a>) <a href="https://github.com/sterenas"><strong>@sterenas</strong></a>
</li>
<li>Plot: <code>Save()</code> methods used to return the saved file path as a <code>string</code> but now they return a <code>SavedImageInfo</code> with a <code>Path</code> property and additional information (<a href="https://github.com/ScottPlot/ScottPlot/issues/3314">#3314</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/kagerouttepaso'>@kagerouttepaso</a>, <a href='https://github.com/hockerschwan'>@hockerschwan</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/lindpatr'>@lindpatr</a>, <a href='https://github.com/enumer'>@enumer</a>, <a href='https://github.com/DerekGooding'>@DerekGooding</a>, <a href='https://github.com/faguetan'>@faguetan</a>, <a href='https://github.com/Nils-Berghs'>@Nils-Berghs</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/PhoenixChenLu'>@PhoenixChenLu</a>, <a href='https://github.com/erikjl'>@erikjl</a>, <a href='https://github.com/sterenas'>@sterenas</a>, <a href='https://github.com/stratdev3'>@stratdev3</a>, <a href='https://github.com/MaxFun'>@MaxFun</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/kagerouttepaso'><img src='https://scottplot.net/images/contributors/kagerouttepaso.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/hockerschwan'><img src='https://scottplot.net/images/contributors/hockerschwan.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/lindpatr'><img src='https://scottplot.net/images/contributors/lindpatr.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/enumer'><img src='https://scottplot.net/images/contributors/enumer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DerekGooding'><img src='https://scottplot.net/images/contributors/derekgooding.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/faguetan'><img src='https://scottplot.net/images/contributors/faguetan.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Nils-Berghs'><img src='https://scottplot.net/images/contributors/nils-berghs.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PhoenixChenLu'><img src='https://scottplot.net/images/contributors/phoenixchenlu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/erikjl'><img src='https://scottplot.net/images/contributors/erikjl.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sterenas'><img src='https://scottplot.net/images/contributors/sterenas.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/stratdev3'><img src='https://scottplot.net/images/contributors/stratdev3.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MaxFun'><img src='https://scottplot.net/images/contributors/maxfun.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.20</h1>
<div><i>NuGet packages published 2024-01-21</i></div>
<div class='mt-1'>
<ul>
<li>Assembly: ScottPlot packages are now strongly named (<a href="https://github.com/ScottPlot/ScottPlot/issues/3235">#3235</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3241">#3241</a>) <a href="https://github.com/mlessmann"><strong>@mlessmann</strong></a>
</li>
<li>Scatter Plot: Added a <code>ConnectStyle</code> to enable step display mode (<a href="https://github.com/ScottPlot/ScottPlot/issues/3242">#3242</a>) <a href="https://github.com/NoahSigl"><strong>@NoahSigl</strong></a>
</li>
<li>Polygon: <code>Plot.Add.Polygon()</code> now accepts generic type lists and arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/3244">#3244</a>)howhowone_23
</li>
<li>Demo: Added a draggable points window to show how to drag points of a scatter plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/3248">#3248</a>)bologna
</li>
<li>Generate: Added <code>RandomNumber()</code> and <code>RandomNumbers()</code> overloads
</li>
<li>OHLC: Improved autoscaling behavior for empty datasets
</li>
<li>Generate: Added <code>RandomOHLCs()</code> overload that accepts a starting <code>DateTime</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3254">#3254</a>) <a href="https://github.com/CBrauer"><strong>@CBrauer</strong></a>
</li>
<li>Axes: Improved support for inverted axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3252">#3252</a>) <a href="https://github.com/fujiangang"><strong>@fujiangang</strong></a>
</li>
<li>Finance: Improved performance of financial charts by not rendering symbols outside the data area (<a href="https://github.com/ScottPlot/ScottPlot/issues/3258">#3258</a>)Lyakabynka
</li>
<li>SignalXY: Support vertical orientation (<a href="https://github.com/ScottPlot/ScottPlot/issues/3253">#3253</a>) <a href="https://github.com/manaruto"><strong>@manaruto</strong></a>
</li>
<li>Data logger and streamer: The property <code>Data</code> has been renamed to <code>DataSource</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3260">#3260</a>)
</li>
<li>SignalConst: The property <code>Data</code> has been renamed to <code>DataSource</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3260">#3260</a>)
</li>
<li>Axes: Added <code>AutoScaleExpand()</code> to zoom out to fit data only if necessary (<a href="https://github.com/ScottPlot/ScottPlot/issues/3259">#3259</a>)
</li>
<li>Style: Added <code>Plot.Style.ColorLegend()</code> for quick customization of legend colors (<a href="https://github.com/ScottPlot/ScottPlot/issues/3247">#3247</a>)
</li>
<li>Plot: Replacing palettes is now achieved by setting <code>Plot.Add.Palette</code> instead of <code>Plot.Palette</code>.
</li>
<li>Plot: Added <code>ShowLegend()</code> overload that accepts manually created legend items
</li>
<li>Scatter Plot: Added <code>LinePattern</code> property for customizing line style
</li>
<li>Pie: Improved default colors of pie charts created from discrete values
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/mlessmann'>@mlessmann</a>, <a href='https://github.com/NoahSigl'>@NoahSigl</a>, <a href='https://github.com/CBrauer'>@CBrauer</a>, <a href='https://github.com/fujiangang'>@fujiangang</a>, <a href='https://github.com/manaruto'>@manaruto</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/mlessmann'><img src='https://scottplot.net/images/contributors/mlessmann.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/NoahSigl'><img src='https://scottplot.net/images/contributors/noahsigl.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/CBrauer'><img src='https://scottplot.net/images/contributors/cbrauer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/fujiangang'><img src='https://scottplot.net/images/contributors/fujiangang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/manaruto'><img src='https://scottplot.net/images/contributors/manaruto.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.71</h1>
<div><i>NuGet packages published 2024-01-21</i></div>
<div class='mt-1'>
<ul>
<li>Assembly: All ScottPlot packages use the same strong name signing key (<a href="https://github.com/ScottPlot/ScottPlot/issues/3235">#3235</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3241">#3241</a>) <a href="https://github.com/mlessmann"><strong>@mlessmann</strong></a>
</li>
<li>WPF Control: Routed events now pass the original source (<a href="https://github.com/ScottPlot/ScottPlot/issues/3243">#3243</a>) <a href="https://github.com/MarekJur"><strong>@MarekJur</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/mlessmann'>@mlessmann</a>, <a href='https://github.com/MarekJur'>@MarekJur</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/mlessmann'><img src='https://scottplot.net/images/contributors/mlessmann.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MarekJur'><img src='https://scottplot.net/images/contributors/marekjur.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.19</h1>
<div><i>NuGet packages published 2024-01-18</i></div>
<div class='mt-1'>
<ul>
<li>Plot: Improved render manager initialization (<a href="https://github.com/ScottPlot/ScottPlot/issues/3233">#3233</a>) <a href="https://github.com/VoteForPedro"><strong>@VoteForPedro</strong></a>
</li>
<li>Projects: Sign all assemblies using strong names (<a href="https://github.com/ScottPlot/ScottPlot/issues/3235">#3235</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/283">#283</a>) <a href="https://github.com/mlessmann"><strong>@mlessmann</strong></a>
</li>
<li>Axes: Improved automatic axis determination for plots containing non-real or infinite data limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/3232">#3232</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3237">#3237</a>)
</li>
<li>Bar Plots: Do not overwrite existing colors when adding <code>Bar</code> collections to the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/3231">#3231</a>)
</li>
<li>Label: Clear cached typefaces when styles change (<a href="https://github.com/ScottPlot/ScottPlot/issues/3236">#3236</a>) <a href="https://github.com/kl7107"><strong>@kl7107</strong></a> and <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/VoteForPedro'>@VoteForPedro</a>, <a href='https://github.com/mlessmann'>@mlessmann</a>, <a href='https://github.com/kl7107'>@kl7107</a>, <a href='https://github.com/prime167'>@prime167</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/VoteForPedro'><img src='https://scottplot.net/images/contributors/voteforpedro.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mlessmann'><img src='https://scottplot.net/images/contributors/mlessmann.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kl7107'><img src='https://scottplot.net/images/contributors/kl7107.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/prime167'><img src='https://scottplot.net/images/contributors/prime167.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.18</h1>
<div><i>NuGet packages published 2024-01-17</i></div>
<div class='mt-1'>
<ul>
<li>Axes: Improved default label rotation for DateTime axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3211">#3211</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3216">#3216</a>) <a href="https://github.com/CBrauer"><strong>@CBrauer</strong></a>
</li>
<li>Fonts: Improved font detection for strings containing mixed-language characters (<a href="https://github.com/ScottPlot/ScottPlot/issues/3220">#3220</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3184">#3184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/kl7107"><strong>@kl7107</strong></a> and <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
<li>Controls: Add a Reset function for context menus (<a href="https://github.com/ScottPlot/ScottPlot/issues/3224">#3224</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Axes: Prevent exceptions when generating ticks for a DateTime axis with zero size (<a href="https://github.com/ScottPlot/ScottPlot/issues/3221">#3221</a>) <a href="https://github.com/devbotas"><strong>@devbotas</strong></a>
</li>
<li>SignalXY: Added <code>MinimumIndex</code> and <code>MaximumIndex</code> for partial array rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/3227">#3227</a>)
</li>
<li>SignalXY: Added <code>OffsetX</code> and <code>OffsetY</code> for for applying a fixed offset in coordinate space (<a href="https://github.com/ScottPlot/ScottPlot/issues/3227">#3227</a>)
</li>
<li>SignalConst: Improved display when signals are zoomed in enough to see individual points (<a href="https://github.com/ScottPlot/ScottPlot/issues/3228">#3228</a>) <a href="https://github.com/Marvenix"><strong>@Marvenix</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/CBrauer'>@CBrauer</a>, <a href='https://github.com/kl7107'>@kl7107</a>, <a href='https://github.com/prime167'>@prime167</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/devbotas'>@devbotas</a>, <a href='https://github.com/Marvenix'>@Marvenix</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/CBrauer'><img src='https://scottplot.net/images/contributors/cbrauer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kl7107'><img src='https://scottplot.net/images/contributors/kl7107.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/prime167'><img src='https://scottplot.net/images/contributors/prime167.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/devbotas'><img src='https://scottplot.net/images/contributors/devbotas.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Marvenix'><img src='https://scottplot.net/images/contributors/marvenix.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.17</h1>
<div><i>NuGet packages published 2024-01-16</i></div>
<div class='mt-1'>
<ul>
<li>Rendering: Added a <code>RenderManager.EnableRendering</code> flag to skip render requests while performing dangerous actions in multi-threaded environments. Skipping renders compliments the <code>PreRenderLock</code> event which hangs renders. See the <a href="https://scottplot.net/faq/async/">async FAQ page</a> for usage details. (<a href="https://github.com/ScottPlot/ScottPlot/issues/3213">#3213</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3095">#3095</a>) <a href="https://github.com/LumAsWell"><strong>@LumAsWell</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>WPF: Improved &quot;Copy to Clipboard&quot; functionality (<a href="https://github.com/ScottPlot/ScottPlot/issues/3214">#3214</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Controls: Created <code>FormsPlotViewer</code> and <code>WpfPlotViewer</code> for launching interactive plots from console applications. See the <a href="https://scottplot.net/faq/launch-console/">Interactive Plots in Console Applications</a> page for details. (<a href="https://github.com/ScottPlot/ScottPlot/issues/3212">#3212</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/308">#308</a>) <a href="https://github.com/chaojian-zhang"><strong>@chaojian-zhang</strong></a>
</li>
<li>DataLogger: Added <code>Add()</code> overloads which support X/Y pairs (<a href="https://github.com/ScottPlot/ScottPlot/issues/3210">#3210</a>) <a href="https://github.com/devbotas"><strong>@devbotas</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/LumAsWell'>@LumAsWell</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/chaojian-zhang'>@chaojian-zhang</a>, <a href='https://github.com/devbotas'>@devbotas</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/LumAsWell'><img src='https://scottplot.net/images/contributors/lumaswell.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chaojian-zhang'><img src='https://scottplot.net/images/contributors/chaojian-zhang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/devbotas'><img src='https://scottplot.net/images/contributors/devbotas.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.16</h1>
<div><i>NuGet packages published 2024-01-15</i></div>
<div class='mt-1'>
<ul>
<li>Data Streamer: A new plot type for displaying live data as a fixed-width line trace (<a href="https://github.com/ScottPlot/ScottPlot/issues/3202">#3202</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3205">#3205</a>)
</li>
<li>Data Logger: A new plot type for displaying live data as a growing scatter plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/3202">#3202</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3205">#3205</a>)
</li>
<li>Generate: Created a <code>Generate.RandomWalker</code> class for producing an infinite amount of streaming random data
</li>
<li>Ticks: Improved support for multi-line tick labels on vertical axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3208">#3208</a>) <a href="https://github.com/raburton"><strong>@raburton</strong></a>
</li>
<li>Text: Exposed <code>FontName</code> and <code>LabelText</code> properties
</li>
<li>Internationalization: <code>Fonts.Detect()</code> now inspects all characters instead of just the first (<a href="https://github.com/ScottPlot/ScottPlot/issues/3184">#3184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
<li>Label: Added <code>SetBestFont()</code> to apply the installed font most likely able to display characters in the label (<a href="https://github.com/ScottPlot/ScottPlot/issues/3184">#3184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
<li>Style: Added <code>Plot.Style.SetBestFonts()</code> to apply the best font to all plot components (<a href="https://github.com/ScottPlot/ScottPlot/issues/3184">#3184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
<li>Controls: Removed <code>GetCoordinates()</code> from <code>IPlotControl</code>. Users can call Plot.GetCoordinates()` directly. (<a href="https://github.com/ScottPlot/ScottPlot/issues/3199">#3199</a>)
</li>
<li>Ticks: Do not display manually defined grid lines, tick marks, or tick labels to appear outside the data area (<a href="https://github.com/ScottPlot/ScottPlot/issues/3207">#3207</a>)
</li>
<li>Rendering: Created <code>IManagesAxisLimits</code> for <code>IPlottable</code> objects that manipulate axis limits at render time (<a href="https://github.com/ScottPlot/ScottPlot/issues/3207">#3207</a>)
</li>
<li>NuGet: Improved package descriptions to better reflect that ScottPlot 5 is no longer in preview (<a href="https://github.com/ScottPlot/ScottPlot/issues/3207">#3207</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/raburton'>@raburton</a>, <a href='https://github.com/prime167'>@prime167</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/raburton'><img src='https://scottplot.net/images/contributors/raburton.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/prime167'><img src='https://scottplot.net/images/contributors/prime167.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.15</h1>
<div><i>NuGet packages published 2024-01-14</i></div>
<div class='mt-1'>
<ul>
<li>Ticks: Added additional styling options for axis tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/3185">#3185</a>) <a href="https://github.com/barnettben"><strong>@barnettben</strong></a>
</li>
<li>Finance: Added <code>Sequential</code> property to display OHLC data without gaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/2611">#2611</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3187">#3187</a>) <a href="https://github.com/robbyls"><strong>@robbyls</strong></a>, <a href="https://github.com/mjpz"><strong>@mjpz</strong></a>, and <a href="https://github.com/segeyros"><strong>@segeyros</strong></a>
</li>
<li>SignalConst: A high performance plot type for evenly-spaced unchanging data (<a href="https://github.com/ScottPlot/ScottPlot/issues/70">#70</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3188">#3188</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Plot: Created <code>Plot.Add.Rectangle()</code> for placing a rectangular polygon on the plot
</li>
<li>Axis Rules: Improved <code>MaximumBoundary</code> and <code>MinimumBoundary</code> correction behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/3191">#3191</a>) <a href="https://github.com/Milyczekpolsl"><strong>@Milyczekpolsl</strong></a>
</li>
<li>Bar Plot: Added support for horizontal bar graphs (<a href="https://github.com/ScottPlot/ScottPlot/issues/3192">#3192</a>) <a href="https://github.com/sghctoma"><strong>@sghctoma</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/barnettben'>@barnettben</a>, <a href='https://github.com/robbyls'>@robbyls</a>, <a href='https://github.com/mjpz'>@mjpz</a>, <a href='https://github.com/segeyros'>@segeyros</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/Milyczekpolsl'>@Milyczekpolsl</a>, <a href='https://github.com/sghctoma'>@sghctoma</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/barnettben'><img src='https://scottplot.net/images/contributors/barnettben.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/robbyls'><img src='https://scottplot.net/images/contributors/robbyls.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mjpz'><img src='https://scottplot.net/images/contributors/mjpz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/segeyros'><img src='https://scottplot.net/images/contributors/segeyros.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Milyczekpolsl'><img src='https://scottplot.net/images/contributors/milyczekpolsl.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sghctoma'><img src='https://scottplot.net/images/contributors/sghctoma.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.14-beta</h1>
<div><i>NuGet packages published 2024-01-10</i></div>
<div class='mt-1'>
<ul>
<li>Rendering: Improved performance by limiting how often <code>AutoScale()</code> is called by the renderer (<a href="https://github.com/ScottPlot/ScottPlot/issues/3183">#3183</a>) <a href="https://github.com/Smonze"><strong>@Smonze</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Smonze'>@Smonze</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Smonze'><img src='https://scottplot.net/images/contributors/smonze.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.13-beta</h1>
<div><i>NuGet packages published 2024-01-09</i></div>
<div class='mt-1'>
<ul>
<li>SignalXY: New high performance plot type for signal data with defined ascending X positions (<a href="https://github.com/ScottPlot/ScottPlot/issues/3163">#3163</a>) <a href="https://github.com/ChristianWeigand"><strong>@ChristianWeigand</strong></a>
</li>
<li>Scatter, Signal, and SignalXY: Improved support for generic data types
</li>
<li>Axis: Improve behavior of axis rules which reference axes from previous renders (<a href="https://github.com/ScottPlot/ScottPlot/issues/3179">#3179</a>) <a href="https://github.com/raburton"><strong>@raburton</strong></a>
</li>
<li>Primitives: Separated <code>CoordinateRange</code> struct for passing ranges and <code>CoordinateRangeMutable</code> for mutating them (<a href="https://github.com/ScottPlot/ScottPlot/issues/3170">#3170</a>)
</li>
<li>Function: Improved autoscaling behavior
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ChristianWeigand'>@ChristianWeigand</a>, <a href='https://github.com/raburton'>@raburton</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ChristianWeigand'><img src='https://scottplot.net/images/contributors/christianweigand.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/raburton'><img src='https://scottplot.net/images/contributors/raburton.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.12-beta</h1>
<div><i>NuGet packages published 2024-01-07</i></div>
<div class='mt-1'>
<ul>
<li>Axes: Improved automatic axis scaling for plots containing 1D plottables (<a href="https://github.com/ScottPlot/ScottPlot/issues/3132">#3132</a>)
</li>
<li>Coordinates: Added <code>AreReal</code> property to confirm <code>X</code> and <code>Y</code> are finite
</li>
<li>Crosshair: Added <code>X</code> and <code>Y</code> properties to compliment <code>Position</code>
</li>
<li>Axes: Removed <code>Plot.Axes</code> list to encourage interaction with <code>Plot.YAxes</code> and <code>Plot.XAxes</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3133">#3133</a>)
</li>
<li>Plot: Added <code>AddLeftAxis()</code>, <code>AddRightAxis()</code>, etc. to simplify multi-axis creation and management (<a href="https://github.com/ScottPlot/ScottPlot/issues/3133">#3133</a>)
</li>
<li>Layout: Created <code>Plot.Layout.Frameless()</code> to hide axes and allow the data area to fill the figure
</li>
<li>Axes: Improve rotation for right axis labels
</li>
<li>Bar: Improve autoscaling for bar plots displaying error ranges
</li>
<li>Signal: Improved rendering of makers when plots are zoomed in (<a href="https://github.com/ScottPlot/ScottPlot/issues/3136">#3136</a>)
</li>
<li>Signal: Exposed <code>Color</code>, <code>LineWidth</code>, and <code>MaximumMarkerSize</code> so users do not interact with <code>LineStyle</code> and <code>MarkerStyle</code> directly (<a href="https://github.com/ScottPlot/ScottPlot/issues/3136">#3136</a>)
</li>
<li>Statistics: Created <code>Series</code> class for calculating statistics for time series data
</li>
<li>Scatter Plot: Added <code>LineWidth</code> and <code>MarkerSize</code> properties
</li>
<li>Finance: Created <code>SimpleMovingAverage</code> and <code>BollingerBands</code> in the <code>ScottPlot.Finance</code> namespace to facilitate calculation and display of technical indicators (<a href="https://github.com/ScottPlot/ScottPlot/issues/3137">#3137</a>)
</li>
<li>Axes: Moved axis management logic from <code>Plot</code> into the <code>Plot.Axes</code> class. Notable changed method names include <code>Plot.Axes.SetLimits()</code>, <code>Plot.Axes.GetLimits()</code>, <code>Plot.Axes.AutoScale()</code>, and <code>Plot.Axes.Margins()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3140">#3140</a>)
</li>
<li>Rendering: Improved anti-aliased drawing of solid shapes
</li>
<li>Axis: Added rules for zoom in/out boundaries, axis span limits, and square ratio locking (<a href="https://github.com/ScottPlot/ScottPlot/issues/3139">#3139</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3142">#3142</a>)
</li>
<li>ErrorBar: Improved axis limit detection for data that does not start at zero (<a href="https://github.com/ScottPlot/ScottPlot/issues/3155">#3155</a>) <a href="https://github.com/wolfcomp"><strong>@wolfcomp</strong></a>
</li>
<li>DataSources: Created <code>SignalSourceUInt16</code> to demonstrate how to plot data with custom types (<a href="https://github.com/ScottPlot/ScottPlot/issues/3154">#3154</a>) <a href="https://github.com/angulion"><strong>@angulion</strong></a>
</li>
<li>Signal Plot: Added support for generic type arrays and lists (<a href="https://github.com/ScottPlot/ScottPlot/issues/3154">#3154</a>)
</li>
<li>Scatter Plot: Added support for generic types including Xs and Ys of different types (<a href="https://github.com/ScottPlot/ScottPlot/issues/3154">#3154</a>)
</li>
<li>Scatter Plot: Added support for DateTime types (<a href="https://github.com/ScottPlot/ScottPlot/issues/3154">#3154</a>)
</li>
<li>Style: Added support for more line patterns (<a href="https://github.com/ScottPlot/ScottPlot/issues/3161">#3161</a>) <a href="https://github.com/MCF"><strong>@MCF</strong></a>
</li>
<li>Controls: Assigning <code>Interaction</code> can be used instead of <code>Replace()</code> for customizing mouse actions (<a href="https://github.com/ScottPlot/ScottPlot/issues/3150">#3150</a>)
</li>
<li>Controls: Added <code>Menu</code> with <code>Add()</code> and <code>Clear()</code> methods to simplify context menu customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/3150">#3150</a>)
</li>
<li>Axes: Added rules for locking horizontal and/or vertical axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3160">#3160</a>) <a href="https://github.com/raburton"><strong>@raburton</strong></a>
</li>
<li>Signal: Added <code>Data.MinimumIndex</code> and <code>Data.MaximumIndex</code> to allow for partial array rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/3158">#3158</a>) <a href="https://github.com/raburton"><strong>@raburton</strong></a>
</li>
<li>Heatmap: Added <code>GetIndexes()</code> and <code>GetValue()</code> to get data from a coordinate (<a href="https://github.com/ScottPlot/ScottPlot/issues/3165">#3165</a>) <a href="https://github.com/skn41"><strong>@skn41</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/wolfcomp'>@wolfcomp</a>, <a href='https://github.com/angulion'>@angulion</a>, <a href='https://github.com/MCF'>@MCF</a>, <a href='https://github.com/raburton'>@raburton</a>, <a href='https://github.com/skn41'>@skn41</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/wolfcomp'><img src='https://scottplot.net/images/contributors/wolfcomp.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/angulion'><img src='https://scottplot.net/images/contributors/angulion.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MCF'><img src='https://scottplot.net/images/contributors/mcf.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/raburton'><img src='https://scottplot.net/images/contributors/raburton.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/skn41'><img src='https://scottplot.net/images/contributors/skn41.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.11-beta</h1>
<div><i>NuGet packages published 2023-12-29</i></div>
<div class='mt-1'>
<ul>
<li>Plot: <code>AutoScaler</code> can now be assigned a <code>FractionalAutoScaler</code> with custom properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/3069">#3069</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3067">#3067</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Controls: add SVG to recommended save formats in the right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/3068">#3068</a>)
</li>
<li>Bar: Refactored bar plots to simplify individual bar customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/3070">#3070</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3066">#3066</a>)
</li>
<li>Legend: Added <code>ManualItems</code> to allow building custom legend content
</li>
<li>Render: Prevent the pre-render auto-scaler from resetting manually defined axis limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/3058">#3058</a>)
</li>
<li>Cookbook: Rewrote reflection and source file parsing for simplified querying (<a href="https://github.com/ScottPlot/ScottPlot/issues/3081">#3081</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3080">#3080</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3079">#3079</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2962">#2962</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2755">#2755</a>)
</li>
<li>Function: Added a new line plot type where Y position is a user defined function (<a href="https://github.com/ScottPlot/ScottPlot/issues/3094">#3094</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axes: Improved axis label alignment for secondary axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/3030">#3030</a>) <a href="https://github.com/albyoo"><strong>@albyoo</strong></a>
</li>
<li>Statistics: Added generic overloads to <code>Statistics.Descriptive</code> class, renamed <code>StDev()</code> to <code>StandardDeviation()</code>, and added methods for calculating both sample and population statistics (<a href="https://github.com/ScottPlot/ScottPlot/issues/3071">#3071</a> and <a href="https://github.com/ScottPlot/ScottPlot/issues/3055">#3055</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Markers: Added a <code>None</code> marker (<a href="https://github.com/ScottPlot/ScottPlot/issues/3075">#3075</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3057">#3057</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Generate: Added methods for generating random marker shapes and colors
</li>
<li>Generate: <code>Random()</code> is deprecated in favor of <code>RandomSample()</code>
</li>
<li>Plot: Added <code>ShowLegend()</code> and <code>HideLegend()</code> helper methods which set <code>Plot.Legend.IsVisible</code>
</li>
<li>Marker Plot: <code>Plot.AddMarker()</code> can now be used to place a single marker on the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/3076">#3076</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2806">#2806</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Rendering: Fixed issue where disabling a plottable's visibility prevented rendering of subsequent plottables (<a href="https://github.com/ScottPlot/ScottPlot/issues/3097">#3097</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3089">#3089</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>SVG: Improved rendering of shadows by adding slight color to semitransparent black (<a href="https://github.com/ScottPlot/ScottPlot/issues/3098">#3098</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3063">#3063</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Colormap: Added a <code>Reversed()</code> method for creating colormaps with reversed color order (<a href="https://github.com/ScottPlot/ScottPlot/issues/3100">#3100</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Version: Added <code>ShouldBe()</code> method to assert the version of ScottPlot matches the expected one (<a href="https://github.com/ScottPlot/ScottPlot/issues/3093">#3093</a>)
</li>
<li>Ticks: <code>TickGenerators.NumericManual</code> now has <code>AddMajor()</code> and <code>AddMinor()</code> to simplify manual tick placement (<a href="https://github.com/ScottPlot/ScottPlot/issues/3105">#3105</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2957">#2957</a>)Lake
</li>
<li>Legend: Added <code>Plot.GetLegendImage()</code> and <code>Plot.GetLegendSvg()</code> for displaying legends outside plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3062">#3062</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2934">#2934</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>, <a href="https://github.com/lichen95"><strong>@lichen95</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot: Added new <code>Line</code> plot type for creating straight lines between two points (<a href="https://github.com/ScottPlot/ScottPlot/issues/2915">#2915</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3109">#3109</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Controls: Added <code>IPlotInteraction</code> so users can inject their own <code>Interaction</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3111">#3111</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3110">#3110</a>) <a href="https://github.com/albyoo"><strong>@albyoo</strong></a>
</li>
<li>Signal: Improved appearance of signal plots where <code>YOffset</code> is used (<a href="https://github.com/ScottPlot/ScottPlot/issues/2949">#2949</a>) <a href="https://github.com/minjjKang"><strong>@minjjKang</strong></a>
</li>
<li>AxisLine: Improve rendering and simplify API by exposing common properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/3060">#3060</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3056">#3056</a>)
</li>
<li>Legend: <code>Alignment</code> has been renamed to <code>Location</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3059">#3059</a>)
</li>
<li>Box: Refactored box plot API to favor simplicity and user customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/3072">#3072</a>)
</li>
<li>Rendering: Added <code>RenderManager.RenderStarting</code> event to allow modification of plottable properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/3077">#3077</a>)GooBad
</li>
<li>Rendering: Added <code>RenderManager.PreRenderLock</code> event so developers of multi-threaded applications can ensure plottables are stable at render time (<a href="https://github.com/ScottPlot/ScottPlot/issues/3095">#3095</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Statistics: Added descriptive statistics methods and improved support for 2D arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/3113">#3113</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3121">#3121</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Rendering: Improved appearance of shapes with custom hatches and outlines (<a href="https://github.com/ScottPlot/ScottPlot/issues/3099">#3099</a>) <a href="https://github.com/faguetan"><strong>@faguetan</strong></a>
</li>
<li>Text: Improved support for multiline labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/3087">#3087</a>) <a href="https://github.com/raburton"><strong>@raburton</strong></a>
</li>
<li>Layout: Improved tick and axis label alignment in fixed layout plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/3104">#3104</a>) <a href="https://github.com/albyoo"><strong>@albyoo</strong></a>
</li>
<li>Layout: Created <code>Plot.Layout</code> class for holding <code>Frameless()</code> and related methods (<a href="https://github.com/ScottPlot/ScottPlot/issues/3106">#3106</a>) <a href="https://github.com/angulion"><strong>@angulion</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/albyoo'>@albyoo</a>, <a href='https://github.com/Gray-lab'>@Gray-lab</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/lichen95'>@lichen95</a>, <a href='https://github.com/minjjKang'>@minjjKang</a>, <a href='https://github.com/faguetan'>@faguetan</a>, <a href='https://github.com/raburton'>@raburton</a>, <a href='https://github.com/angulion'>@angulion</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/albyoo'><img src='https://scottplot.net/images/contributors/albyoo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Gray-lab'><img src='https://scottplot.net/images/contributors/gray-lab.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/lichen95'><img src='https://scottplot.net/images/contributors/lichen95.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/minjjKang'><img src='https://scottplot.net/images/contributors/minjjkang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/faguetan'><img src='https://scottplot.net/images/contributors/faguetan.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/raburton'><img src='https://scottplot.net/images/contributors/raburton.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/angulion'><img src='https://scottplot.net/images/contributors/angulion.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.70</h1>
<div><i>NuGet packages published 2023-12-29</i></div>
<div class='mt-1'>
<ul>
<li>Population Plot: Improved performance for populations with curves that run off the screen (<a href="https://github.com/ScottPlot/ScottPlot/issues/3054">#3054</a>) <a href="https://github.com/Em3a-c"><strong>@Em3a-c</strong></a> and <a href="https://github.com/cornford"><strong>@cornford</strong></a>
</li>
<li>Performance: Improved performance of Bar and Finance plots by not drawing shapes outside the data area (<a href="https://github.com/ScottPlot/ScottPlot/issues/3053">#3053</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3078">#3078</a>) <a href="https://github.com/AndreyPalyutin"><strong>@AndreyPalyutin</strong></a>
</li>
<li>Colormap: Added a <code>Reversed()</code> method for creating colormaps with reversed color order (<a href="https://github.com/ScottPlot/ScottPlot/issues/3100">#3100</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Version: Added <code>ShouldBe()</code> method to assert the version of ScottPlot matches the expected one (<a href="https://github.com/ScottPlot/ScottPlot/issues/3093">#3093</a>)
</li>
<li>Marker: Added support for <code>Marker.horizontalBar</code> to compliment <code>verticalBar</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3101">#3101</a>) <a href="https://github.com/SerhiiMahera"><strong>@SerhiiMahera</strong></a>
</li>
<li>Axis: Span limits are respected when zooming with a window or scroll wheel (<a href="https://github.com/ScottPlot/ScottPlot/issues/3082">#3082</a>) <a href="https://github.com/ashe27"><strong>@ashe27</strong></a>
</li>
<li>Statistics: Added <code>Descriptive.StdErr()</code> for calculating standard error of the mean (<a href="https://github.com/ScottPlot/ScottPlot/issues/3112">#3112</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Em3a-c'>@Em3a-c</a>, <a href='https://github.com/cornford'>@cornford</a>, <a href='https://github.com/AndreyPalyutin'>@AndreyPalyutin</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/SerhiiMahera'>@SerhiiMahera</a>, <a href='https://github.com/ashe27'>@ashe27</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Em3a-c'><img src='https://scottplot.net/images/contributors/em3a-c.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cornford'><img src='https://scottplot.net/images/contributors/cornford.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AndreyPalyutin'><img src='https://scottplot.net/images/contributors/andreypalyutin.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SerhiiMahera'><img src='https://scottplot.net/images/contributors/serhiimahera.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ashe27'><img src='https://scottplot.net/images/contributors/ashe27.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.10-beta</h1>
<div><i>NuGet packages published 2023-12-03</i></div>
<div class='mt-1'>
<ul>
<li>Signal: Improved support for datasets with repeating values (<a href="https://github.com/ScottPlot/ScottPlot/issues/2933">#2933</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2935">#2935</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Blazor: Added a Blazor control (<a href="https://github.com/ScottPlot/ScottPlot/issues/2959">#2959</a>) <a href="https://github.com/sulivanganter"><strong>@sulivanganter</strong></a>
</li>
<li>Layout: Expose <code>Matched</code> layout engine (<a href="https://github.com/ScottPlot/ScottPlot/issues/2881">#2881</a>) <a href="https://github.com/proplunger"><strong>@proplunger</strong></a>
</li>
<li>Plot: Added <code>DisableGrid()</code> and <code>EnableGrid()</code> helper methods (<a href="https://github.com/ScottPlot/ScottPlot/issues/2947">#2947</a>)
</li>
<li>Render: Created <code>IRenderLast</code> plottables can implement to draw above axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/2998">#2998</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2993">#2993</a>)
</li>
<li>Controls: Added <code>Interaction.Disable()</code> and <code>Interaction.Enable()</code> methods for easy control of mouse interactivity
</li>
<li>Render: Improve axis frame and tick mark rendering for SVG export (<a href="https://github.com/ScottPlot/ScottPlot/issues/2944">#2944</a>) <a href="https://github.com/Crown0815"><strong>@Crown0815</strong></a>
</li>
<li>Controls: Created OpenGL controls <code>FormsPlotGL</code> and <code>WpfPlotGL</code> distinct from <code>FormsPlot</code> and <code>WpfPlot</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/3008">#3008</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3007">#3007</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2950">#2950</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2395">#2395</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2565">#2565</a>)
</li>
<li>Markers: Added numerous additional marker types (<a href="https://github.com/ScottPlot/ScottPlot/issues/2999">#2999</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3019">#3019</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Plot: Improved support for multiple axes and automatic scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/3027">#3027</a>)
</li>
<li>RandomDataGenerator: Use a global Random number generator for improved randomness and thread safety (<a href="https://github.com/ScottPlot/ScottPlot/issues/2893">#2893</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3022">#3022</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Scatter: Added <code>Data.GetNearest()</code> to simplify locating the point nearest the cursor (<a href="https://github.com/ScottPlot/ScottPlot/issues/3026">#3026</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3048">#3048</a>) <a href="https://github.com/JurasskPark"><strong>@JurasskPark</strong></a> and <a href="https://github.com/CBrauer"><strong>@CBrauer</strong></a>
</li>
<li>Plottable: Added a new <code>Text</code> plot type for displaying a label at a location in coordinate space (<a href="https://github.com/ScottPlot/ScottPlot/issues/2939">#2939</a>)
</li>
<li>Plot: Benchmark is now a user-customizable plottable and <code>Plot.ShowBenchmark</code> is now <code>Plot.Benchmark.IsVisible</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2961">#2961</a>)
</li>
<li>Grid: Improve support for custom line styles (<a href="https://github.com/ScottPlot/ScottPlot/issues/2904">#2904</a>) <a href="https://github.com/minjjKang"><strong>@minjjKang</strong></a>
</li>
<li>Pie: Improve appearance of slice labels in the legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/2894">#2894</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2852">#2852</a>) <a href="https://github.com/zy1075984"><strong>@zy1075984</strong></a>
</li>
<li>Legend: Replaced <code>List&lt;ILegend&gt;</code> with a simple <code>Legend</code> object with an <code>IsVisible</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2792">#2792</a>)
</li>
<li>Avalonia: Improved sizing of plot controls inside containers (<a href="https://github.com/ScottPlot/ScottPlot/issues/2923">#2923</a>) <a href="https://github.com/JohnSmith20211124"><strong>@JohnSmith20211124</strong></a> and <a href="https://github.com/Developer-Alexander"><strong>@Developer-Alexander</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/sulivanganter'>@sulivanganter</a>, <a href='https://github.com/proplunger'>@proplunger</a>, <a href='https://github.com/Crown0815'>@Crown0815</a>, <a href='https://github.com/Gray-lab'>@Gray-lab</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/JurasskPark'>@JurasskPark</a>, <a href='https://github.com/CBrauer'>@CBrauer</a>, <a href='https://github.com/minjjKang'>@minjjKang</a>, <a href='https://github.com/zy1075984'>@zy1075984</a>, <a href='https://github.com/JohnSmith20211124'>@JohnSmith20211124</a>, <a href='https://github.com/Developer-Alexander'>@Developer-Alexander</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sulivanganter'><img src='https://scottplot.net/images/contributors/sulivanganter.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/proplunger'><img src='https://scottplot.net/images/contributors/proplunger.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Crown0815'><img src='https://scottplot.net/images/contributors/crown0815.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Gray-lab'><img src='https://scottplot.net/images/contributors/gray-lab.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JurasskPark'><img src='https://scottplot.net/images/contributors/jurasskpark.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/CBrauer'><img src='https://scottplot.net/images/contributors/cbrauer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/minjjKang'><img src='https://scottplot.net/images/contributors/minjjkang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/zy1075984'><img src='https://scottplot.net/images/contributors/zy1075984.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JohnSmith20211124'><img src='https://scottplot.net/images/contributors/johnsmith20211124.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Developer-Alexander'><img src='https://scottplot.net/images/contributors/developer-alexander.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.69</h1>
<div><i>NuGet packages published 2023-12-03</i></div>
<div class='mt-1'>
<ul>
<li>Axis: Added <code>IsReverse</code> property to let users invert the orientation of an axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/2958">#2958</a>) <a href="https://github.com/HandsomeGoldenKnight"><strong>@HandsomeGoldenKnight</strong></a>
</li>
<li>Text: Exposed <code>LastRenderRectangleCoordinates</code> to improve mouse interactivity (<a href="https://github.com/ScottPlot/ScottPlot/issues/2994">#2994</a>) <a href="https://github.com/DaveMartel"><strong>@DaveMartel</strong></a>
</li>
<li>Arrow: Fixed bug in constructor overload (<a href="https://github.com/ScottPlot/ScottPlot/issues/2976">#2976</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3001">#3001</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Controls: Resizing will now invoke <code>OnAxesChanged</code> event (<a href="https://github.com/ScottPlot/ScottPlot/issues/3000">#3000</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3002">#3002</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>Plot: Added <code>LastRenderDimensions</code> for easy access to the latest figure dimensions (<a href="https://github.com/ScottPlot/ScottPlot/issues/3000">#3000</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3002">#3002</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>DataLogger and DataStreamer: Added support for custom line styles (<a href="https://github.com/ScottPlot/ScottPlot/issues/2972">#2972</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2972">#2972</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a>
</li>
<li>Population: Defining <code>BoxAlphaOverride</code> and <code>MarkerAlpha</code> allows for exact color representation (<a href="https://github.com/ScottPlot/ScottPlot/issues/2967">#2967</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3013">#3013</a>) <a href="https://github.com/Gray-lab"><strong>@Gray-lab</strong></a> and <a href="https://github.com/Em3a-c"><strong>@Em3a-c</strong></a>
</li>
<li>RandomDataGenerator: Use a global Random number generator for improved randomness and thread safety (<a href="https://github.com/ScottPlot/ScottPlot/issues/2893">#2893</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3022">#3022</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Controls: Improve <code>Bitmap</code> disposal as controls are unloaded (<a href="https://github.com/ScottPlot/ScottPlot/issues/3023">#3023</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2902">#2902</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a> and <a href="https://github.com/mocakturk"><strong>@mocakturk</strong></a>
</li>
<li>ScatterPlotDraggable: Fixed bug affecting <code>IsUnderMouse()</code> after <code>Update()</code> is called (<a href="https://github.com/ScottPlot/ScottPlot/issues/2870">#2870</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2969">#2969</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3025">#3025</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>, <a href="https://github.com/SasKayDE"><strong>@SasKayDE</strong></a>, and <a href="https://github.com/onur-akaydin"><strong>@onur-akaydin</strong></a>
</li>
<li>Bar: New <code>AddBar()</code> overload for creating a single highly customized bar graph bar (<a href="https://github.com/ScottPlot/ScottPlot/issues/3024">#3024</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/3033">#3033</a>) <a href="https://github.com/melhashash"><strong>@melhashash</strong></a>
</li>
<li>FormsPlot: Fix bug affecting mouse interaction on plots with all items hidden (<a href="https://github.com/ScottPlot/ScottPlot/issues/2895">#2895</a>) <a href="https://github.com/LapinFou"><strong>@LapinFou</strong></a>
</li>
<li>RadarPlot: Added customization options for axis label string formatting, manual tick positions, and transparency (<a href="https://github.com/ScottPlot/ScottPlot/issues/3041">#3041</a>) <a href="https://github.com/JbmOnGitHub"><strong>@JbmOnGitHub</strong></a>
</li>
<li>Axis: Added <code>Axis.SetTicks()</code> to allow full customization of major and minor ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/2957">#2957</a>) <a href="https://github.com/FannyAtGitHub"><strong>@FannyAtGitHub</strong></a>
</li>
<li>Plot: <code>GetImageHTML()</code> has been renamed to <code>GetImageHtml()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2974">#2974</a>) <a href="https://github.com/b4shful"><strong>@b4shful</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/HandsomeGoldenKnight'>@HandsomeGoldenKnight</a>, <a href='https://github.com/DaveMartel'>@DaveMartel</a>, <a href='https://github.com/Gray-lab'>@Gray-lab</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/Em3a-c'>@Em3a-c</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/mocakturk'>@mocakturk</a>, <a href='https://github.com/SasKayDE'>@SasKayDE</a>, <a href='https://github.com/onur-akaydin'>@onur-akaydin</a>, <a href='https://github.com/melhashash'>@melhashash</a>, <a href='https://github.com/LapinFou'>@LapinFou</a>, <a href='https://github.com/JbmOnGitHub'>@JbmOnGitHub</a>, <a href='https://github.com/FannyAtGitHub'>@FannyAtGitHub</a>, <a href='https://github.com/b4shful'>@b4shful</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/HandsomeGoldenKnight'><img src='https://scottplot.net/images/contributors/handsomegoldenknight.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DaveMartel'><img src='https://scottplot.net/images/contributors/davemartel.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Gray-lab'><img src='https://scottplot.net/images/contributors/gray-lab.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Em3a-c'><img src='https://scottplot.net/images/contributors/em3a-c.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mocakturk'><img src='https://scottplot.net/images/contributors/mocakturk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SasKayDE'><img src='https://scottplot.net/images/contributors/saskayde.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/onur-akaydin'><img src='https://scottplot.net/images/contributors/onur-akaydin.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/melhashash'><img src='https://scottplot.net/images/contributors/melhashash.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LapinFou'><img src='https://scottplot.net/images/contributors/lapinfou.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JbmOnGitHub'><img src='https://scottplot.net/images/contributors/jbmongithub.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/FannyAtGitHub'><img src='https://scottplot.net/images/contributors/fannyatgithub.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/b4shful'><img src='https://scottplot.net/images/contributors/b4shful.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.9-beta</h1>
<div><i>NuGet packages published 2023-10-03</i></div>
<div class='mt-1'>
<ul>
<li>PixelPadding: <code>TotalHorizontal</code> and <code>TotalVertical</code> renamed to <code>Horizontal</code> and <code>Vertical</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2874">#2874</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2878">#2878</a>) <a href="https://github.com/viktoriussuwandi"><strong>@viktoriussuwandi</strong></a>
</li>
<li>CoordinateRect: Added <code>Expanded()</code> method for creating a copy of the rectangle expanded to include a given point (<a href="https://github.com/ScottPlot/ScottPlot/issues/2871">#2871</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2890">#2890</a>) <a href="https://github.com/aespitia"><strong>@aespitia</strong></a>
</li>
<li>FillY: Added legend support (<a href="https://github.com/ScottPlot/ScottPlot/issues/2886">#2886</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2896">#2896</a>) <a href="https://github.com/msroest"><strong>@msroest</strong></a>
</li>
<li>Plot: Created <code>Add.Line(x1, x2, y1, y2)</code> and related overloads for adding straight lines to plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2901">#2901</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2915">#2915</a>)
</li>
<li>LinearRegression: Added <code>Statistics.Regression</code> (see cookbook) for fitting lines to collections of X/Y data points (<a href="https://github.com/ScottPlot/ScottPlot/issues/2901">#2901</a>) <a href="https://github.com/anewton"><strong>@anewton</strong></a>
</li>
<li>Avalonia: Improve rendering in multi-control windows (<a href="https://github.com/ScottPlot/ScottPlot/issues/2920">#2920</a>) <a href="https://github.com/nightfog-git"><strong>@nightfog-git</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/viktoriussuwandi'>@viktoriussuwandi</a>, <a href='https://github.com/aespitia'>@aespitia</a>, <a href='https://github.com/msroest'>@msroest</a>, <a href='https://github.com/anewton'>@anewton</a>, <a href='https://github.com/nightfog-git'>@nightfog-git</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/viktoriussuwandi'><img src='https://scottplot.net/images/contributors/viktoriussuwandi.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/aespitia'><img src='https://scottplot.net/images/contributors/aespitia.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/msroest'><img src='https://scottplot.net/images/contributors/msroest.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/anewton'><img src='https://scottplot.net/images/contributors/anewton.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/nightfog-git'><img src='https://scottplot.net/images/contributors/nightfog-git.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.68</h1>
<div><i>NuGet packages published 2023-10-03</i></div>
<div class='mt-1'>
<ul>
<li>Heatmap: Added a <code>UseParallel</code> option which can improve <code>Update()</code> performance for large datasets (<a href="https://github.com/ScottPlot/ScottPlot/issues/2897">#2897</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.8-beta</h1>
<div><i>NuGet packages published 2023-08-13</i></div>
<div class='mt-1'>
<ul>
<li>Rendering: Improved performance by caching typefaces (<a href="https://github.com/ScottPlot/ScottPlot/issues/2833">#2833</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2848">#2848</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a> and <a href="https://github.com/taya92413"><strong>@taya92413</strong></a>
</li>
<li>Avalonia: Improved performance, DPI awareness, and color rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/2818">#2818</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2859">#2859</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Rename: <code>XMin</code>, <code>XMax</code>, <code>YMin</code>, and <code>YMax</code> properties are now <code>Left</code>, <code>Right</code>, <code>Bottom</code>, <code>Top</code> for all coordinate primitives (<a href="https://github.com/ScottPlot/ScottPlot/issues/2840">#2840</a>)
</li>
<li>Plot: Improve <code>AutoScale()</code> customization using <code>Margins()</code> to define whitespace area (<a href="https://github.com/ScottPlot/ScottPlot/issues/2857">#2857</a>)
</li>
<li>Primitives: Improved equality checks (<a href="https://github.com/ScottPlot/ScottPlot/issues/2855">#2855</a>)
</li>
<li>Controls: Added a <code>RenderQueue</code> to allow cross-control render requests that would otherwise cause render artifacts or infinite loops
</li>
<li>Controls: Created <code>SharedAxisManager</code> and <code>SharedLayoutManager</code> to facilitate pairing controls together
</li>
<li>Multiplot: Added methods for creating creating static multi-plot figures (<a href="https://github.com/ScottPlot/ScottPlot/issues/2868">#2868</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2869">#2869</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/taya92413'>@taya92413</a>, <a href='https://github.com/oktrue'>@oktrue</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/taya92413'><img src='https://scottplot.net/images/contributors/taya92413.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oktrue'><img src='https://scottplot.net/images/contributors/oktrue.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.67</h1>
<div><i>NuGet packages published 2023-08-13</i></div>
<div class='mt-1'>
<ul>
<li>DataLogger: Improved appearance of legend items (<a href="https://github.com/ScottPlot/ScottPlot/issues/2829">#2829</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2850">#2850</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a> and <a href="https://github.com/p4pravin"><strong>@p4pravin</strong></a>
</li>
<li>Radial Gauge Plot: Improved layout for plots with a large number of gauges (<a href="https://github.com/ScottPlot/ScottPlot/issues/2722">#2722</a>) <a href="https://github.com/tinuskotze"><strong>@tinuskotze</strong></a>
</li>
<li>DataLogger: Added support for markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/2862">#2862</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>AxisLimits: Added <code>WithPan()</code> overloads to facilitate panning in interactive applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/2863">#2863</a>) <a href="https://github.com/LapinFou"><strong>@LapinFou</strong></a>
</li>
<li>Rectangle: Plots now have an <code>AddRectangle()</code> for placing rectangular shapes on plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2866">#2866</a>) <a href="https://github.com/dpieve"><strong>@dpieve</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/p4pravin'>@p4pravin</a>, <a href='https://github.com/tinuskotze'>@tinuskotze</a>, <a href='https://github.com/LapinFou'>@LapinFou</a>, <a href='https://github.com/dpieve'>@dpieve</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/p4pravin'><img src='https://scottplot.net/images/contributors/p4pravin.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tinuskotze'><img src='https://scottplot.net/images/contributors/tinuskotze.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LapinFou'><img src='https://scottplot.net/images/contributors/lapinfou.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dpieve'><img src='https://scottplot.net/images/contributors/dpieve.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.7-beta</h1>
<div><i>NuGet packages published 2023-08-06</i></div>
<div class='mt-1'>
<ul>
<li>Axis: Fixed issue where axes with zero span would cause renders to fail (<a href="https://github.com/ScottPlot/ScottPlot/issues/2714">#2714</a>) <a href="https://github.com/ahmad-qamar"><strong>@ahmad-qamar</strong></a>
</li>
<li>Avalonia: Improve support for cross-platform and non-desktop applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/2748">#2748</a>) <a href="https://github.com/PremekTill"><strong>@PremekTill</strong></a>
</li>
<li>Scatter Plot: Improve support for empty datasets (<a href="https://github.com/ScottPlot/ScottPlot/issues/2740">#2740</a>)
</li>
<li>Scatter Plot: Improve support for user-defined line widths (<a href="https://github.com/ScottPlot/ScottPlot/issues/2739">#2739</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2750">#2750</a>) <a href="https://github.com/dayo05"><strong>@dayo05</strong></a>
</li>
<li>Fonts: New static class to facilitate selecting fonts that support international characters (<a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>Axis: Exposed <code>TickFont</code> to allow tick label size and style customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/2747">#2747</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>Plot: Added <code>Title()</code>, <code>XLabel()</code>, and <code>YLabel()</code> helper methods
</li>
<li>Fonts: Favor the system default font to achieve better support international characters (<a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>Plot: Added <code>ScaleFactor</code> property to manage scaling of all plot components (<a href="https://github.com/ScottPlot/ScottPlot/issues/2747">#2747</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>WinForms: Automatically adjust plot scaling to match display scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/2747">#2747</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>Plot: Added a <code>RenderManager</code> which has a <code>List&lt;RenderAction&gt;</code> the user can modify to customize the render sequence (<a href="https://github.com/ScottPlot/ScottPlot/issues/2767">#2767</a>)
</li>
<li>Plot: Refactored rendering system for all plottables, axes, etc. so canvases (not surfaces) are passed (<a href="https://github.com/ScottPlot/ScottPlot/issues/2767">#2767</a>)
</li>
<li>WPF: Improved support for display scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/2760">#2760</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2766">#2766</a>) <a href="https://github.com/DmitryKotenev"><strong>@DmitryKotenev</strong></a>
</li>
<li>Plot: Added support for SVG export (<a href="https://github.com/ScottPlot/ScottPlot/issues/2704">#2704</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/717">#717</a>)
</li>
<li>Legend: Respect <code>IsVisible</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2805">#2805</a>)
</li>
<li>Ticks: Added <code>NumericManual</code> tick generator for manually-defined tick positions and labels
</li>
<li>Plot: <code>Title()</code>, <code>XLabel()</code>, and <code>YLabel()</code> have optional arguments for <code>size</code>
</li>
<li>Plot: Added <code>Plot.Style.SetFont()</code> to apply the given font to all titles, axis labels, and tick labels
</li>
<li>Plot: Added <code>Plot.Style.SetFontFromText()</code> to apply system font that best supports the language of the provided text (<a href="https://github.com/ScottPlot/ScottPlot/issues/2746">#2746</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>RandomDataGenerator: Improved XML docs and added methods for returning single numbers (<a href="https://github.com/ScottPlot/ScottPlot/issues/2774">#2774</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2787">#2787</a>) <a href="https://github.com/Silent0Wings"><strong>@Silent0Wings</strong></a>
</li>
<li>Pixel: Added constructor overload that accepts <code>double</code> values (<a href="https://github.com/ScottPlot/ScottPlot/issues/2780">#2780</a>) <a href="https://github.com/Silent0Wings"><strong>@Silent0Wings</strong></a>
</li>
<li>Primitives: Refactored and added XML docs to <code>Pixel</code>, <code>PixelSize</code>, and <code>PixelRect</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2784">#2784</a>)
</li>
<li>Color: Added <code>WithAlpha()</code> method that accepts a fraction (<a href="https://github.com/ScottPlot/ScottPlot/issues/2794">#2794</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2776">#2776</a>) <a href="https://github.com/mjpz"><strong>@mjpz</strong></a>
</li>
<li>Coordinates: Added <code>Distance()</code> method for calculating distance between two points in axis space (<a href="https://github.com/ScottPlot/ScottPlot/issues/2791">#2791</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2798">#2798</a>) <a href="https://github.com/able-j"><strong>@able-j</strong></a>
</li>
<li>CoordinateRect: Added a <code>Center</code> property that returns a <code>Coordinates</code> value in axis space (<a href="https://github.com/ScottPlot/ScottPlot/issues/2789">#2789</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2812">#2812</a>) <a href="https://github.com/tijin-abe-thomas"><strong>@tijin-abe-thomas</strong></a>
</li>
<li>CoordinateRect: Added a <code>Contains()</code> method to evaluate whether given <code>Coordinates</code> are inside the rectangle (<a href="https://github.com/ScottPlot/ScottPlot/issues/2790">#2790</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2813">#2813</a>) <a href="https://github.com/tijin-abe-thomas"><strong>@tijin-abe-thomas</strong></a>
</li>
<li>Crosshair: New plot type that draws a cross centered at a given position in X/Y space
</li>
<li>Avalonia: Support Avalonia version 11.0.1 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2822">#2822</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Controls: Now have <code>GetCoordinates()</code> with built-in logic for display scaling compensation (<a href="https://github.com/ScottPlot/ScottPlot/issues/2760">#2760</a>)
</li>
<li>Rendering: Improve multi-platform color support (<a href="https://github.com/ScottPlot/ScottPlot/issues/2818">#2818</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a> and <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Random Data Generation: Added an optional <code>slope</code> argument to <code>RandomWalk()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2763">#2763</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2826">#2826</a>) <a href="https://github.com/JasonC0x0D"><strong>@JasonC0x0D</strong></a>
</li>
<li>Browser: Improved support and documentation for running ScottPlot in the browser with Avalonia and WinUI (<a href="https://github.com/ScottPlot/ScottPlot/issues/2830">#2830</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Android: Improved support and documentation for running ScottPlot in Avalonia Android projects (<a href="https://github.com/ScottPlot/ScottPlot/issues/2830">#2830</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Legend: Now hidden by default with opt-in visibility by calling <code>Plot.Legend()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2764">#2764</a>)
</li>
<li>Style: <code>Plot.Axes</code> has been renamed to <code>Plot.AxisStyler</code> to better communicate its purpose (<a href="https://github.com/ScottPlot/ScottPlot/issues/2778">#2778</a>)
</li>
<li>Primitives: Created <code>ExpandingAxisLimits</code> helper class for creating <code>AxisLimits</code> inside plottables (<a href="https://github.com/ScottPlot/ScottPlot/issues/2799">#2799</a>)
</li>
<li>Plot: Added <code>Pan()</code> and <code>Zoom()</code> methods that do not require passing state like <code>MousePan()</code> and <code>MouseZoom()</code> do (<a href="https://github.com/ScottPlot/ScottPlot/issues/2800">#2800</a>)
</li>
<li>Plot: Added <code>Plot.RenderManager.RenderFinished</code> event that provides a <code>RenderDetails</code> indicating whether axes or layout changed (<a href="https://github.com/ScottPlot/ScottPlot/issues/2801">#2801</a>)
</li>
<li>FormsPlot: Added <code>RefreshQueue()</code> to allow facilitate event-driven refreshing of multiple controls in single-thread applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/2801">#2801</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2802">#2802</a>)
</li>
<li>Plot: Added <code>MatchAxisLimits()</code> to simplify applying limits from one plot to another in multi-control applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/2802">#2802</a>)
</li>
<li>Layout: Added <code>MatchLayout()</code> and <code>FixedLayout()</code> as an alternative to the default <code>AutomaticLayout()</code> engine (<a href="https://github.com/ScottPlot/ScottPlot/issues/2802">#2802</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ahmad-qamar'>@ahmad-qamar</a>, <a href='https://github.com/PremekTill'>@PremekTill</a>, <a href='https://github.com/dayo05'>@dayo05</a>, <a href='https://github.com/heartacker'>@heartacker</a>, <a href='https://github.com/DmitryKotenev'>@DmitryKotenev</a>, <a href='https://github.com/Silent0Wings'>@Silent0Wings</a>, <a href='https://github.com/mjpz'>@mjpz</a>, <a href='https://github.com/able-j'>@able-j</a>, <a href='https://github.com/tijin-abe-thomas'>@tijin-abe-thomas</a>, <a href='https://github.com/oktrue'>@oktrue</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/JasonC0x0D'>@JasonC0x0D</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ahmad-qamar'><img src='https://scottplot.net/images/contributors/ahmad-qamar.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PremekTill'><img src='https://scottplot.net/images/contributors/premektill.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dayo05'><img src='https://scottplot.net/images/contributors/dayo05.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/heartacker'><img src='https://scottplot.net/images/contributors/heartacker.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DmitryKotenev'><img src='https://scottplot.net/images/contributors/dmitrykotenev.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Silent0Wings'><img src='https://scottplot.net/images/contributors/silent0wings.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mjpz'><img src='https://scottplot.net/images/contributors/mjpz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/able-j'><img src='https://scottplot.net/images/contributors/able-j.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tijin-abe-thomas'><img src='https://scottplot.net/images/contributors/tijin-abe-thomas.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oktrue'><img src='https://scottplot.net/images/contributors/oktrue.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JasonC0x0D'><img src='https://scottplot.net/images/contributors/jasonc0x0d.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.66</h1>
<div><i>NuGet packages published 2023-08-06</i></div>
<div class='mt-1'>
<ul>
<li>DataLogger: Improved support for single-point datasets (<a href="https://github.com/ScottPlot/ScottPlot/issues/2733">#2733</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Plot: Added optional arguments to <code>AddDataLogger()</code> and <code>AddDataStreamer()</code> for customizing style (<a href="https://github.com/ScottPlot/ScottPlot/issues/2733">#2733</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Version: Build information can now be accessed from the static <code>ScottPlot.Version</code> class
</li>
<li>Avalonia: Removed dependency on <code>Avalonia.Desktop</code> package (<a href="https://github.com/ScottPlot/ScottPlot/issues/2752">#2752</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2748">#2748</a>) <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>
</li>
<li>Cookbook: Remove &quot;experimental&quot; designator from ScatterPlotList (<a href="https://github.com/ScottPlot/ScottPlot/issues/2782">#2782</a>) <a href="https://github.com/prime167"><strong>@prime167</strong></a>
</li>
<li>Heatmap: Added <code>Rotation</code> and <code>CenterOfRotation</code> properties (<a href="https://github.com/ScottPlot/ScottPlot/issues/2814">#2814</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2815">#2815</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>WPF: Improved the <code>PlottableDragged</code> event (<a href="https://github.com/ScottPlot/ScottPlot/issues/2820">#2820</a>) <a href="https://github.com/tadmccorkle"><strong>@tadmccorkle</strong></a>
</li>
<li>Avalonia: Support Avalonia version 11.0.1 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2822">#2822</a>) <a href="https://github.com/oktrue"><strong>@oktrue</strong></a>
</li>
<li>Heatmap: Improved XML docs (<a href="https://github.com/ScottPlot/ScottPlot/issues/2738">#2738</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2827">#2827</a>) <a href="https://github.com/JasonC0x0D"><strong>@JasonC0x0D</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/Fruchtzwerg94'>@Fruchtzwerg94</a>, <a href='https://github.com/prime167'>@prime167</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/tadmccorkle'>@tadmccorkle</a>, <a href='https://github.com/oktrue'>@oktrue</a>, <a href='https://github.com/JasonC0x0D'>@JasonC0x0D</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Fruchtzwerg94'><img src='https://scottplot.net/images/contributors/fruchtzwerg94.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/prime167'><img src='https://scottplot.net/images/contributors/prime167.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tadmccorkle'><img src='https://scottplot.net/images/contributors/tadmccorkle.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oktrue'><img src='https://scottplot.net/images/contributors/oktrue.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JasonC0x0D'><img src='https://scottplot.net/images/contributors/jasonc0x0d.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.6-beta</h1>
<div><i>NuGet packages published 2023-07-09</i></div>
<div class='mt-1'>
<ul>
<li>Legend: Improve support for custom positioning (<a href="https://github.com/ScottPlot/ScottPlot/issues/2584">#2584</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2638">#2638</a>) <a href="https://github.com/heartacker"><strong>@heartacker</strong></a>
</li>
<li>OpenGL: Use CPU to render on devices without hardware acceleration (<a href="https://github.com/ScottPlot/ScottPlot/issues/2651">#2651</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Polygon: New plot type for displaying closed shapes with arbitrary X/Y corners (<a href="https://github.com/ScottPlot/ScottPlot/issues/2696">#2696</a>) <a href="https://github.com/Tilation"><strong>@Tilation</strong></a>
</li>
<li>FillY: New plot type for displaying a shaded area between two sets of Y points that share the same X points (<a href="https://github.com/ScottPlot/ScottPlot/issues/2696">#2696</a>) <a href="https://github.com/Tilation"><strong>@Tilation</strong></a>
</li>
<li>Avalonia: Added support for Avalonia 11 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2720">#2720</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2184">#2184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2664">#2664</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2507">#2507</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2321">#2321</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2184">#2184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2183">#2183</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2725">#2725</a>) <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>, <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/heartacker'>@heartacker</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/Tilation'>@Tilation</a>, <a href='https://github.com/Fruchtzwerg94'>@Fruchtzwerg94</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/heartacker'><img src='https://scottplot.net/images/contributors/heartacker.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Tilation'><img src='https://scottplot.net/images/contributors/tilation.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Fruchtzwerg94'><img src='https://scottplot.net/images/contributors/fruchtzwerg94.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.65</h1>
<div><i>NuGet packages published 2023-07-09</i></div>
<div class='mt-1'>
<ul>
<li>Axis: Improved log-scaled axis minor tick density default value and customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/2646">#2646</a>) <a href="https://github.com/hellfo"><strong>@hellfo</strong></a>
</li>
<li>Image: Added option to disable anti-aliasing for scaled images (<a href="https://github.com/ScottPlot/ScottPlot/issues/2649">#2649</a>) <a href="https://github.com/mYcheng-95"><strong>@mYcheng-95</strong></a>
</li>
<li>Binned Histogram: New plot type that represents binned 2D histogram data as a heatmap (<a href="https://github.com/ScottPlot/ScottPlot/issues/2453">#2453</a>)
</li>
<li>DataLogger: New type of scatter plot designed for infinitely growing X/Y datasets (<a href="https://github.com/ScottPlot/ScottPlot/issues/2377">#2377</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2641">#2641</a>)
</li>
<li>DataStreamer: New type of signal plot for displaying live data as it is shifted in (<a href="https://github.com/ScottPlot/ScottPlot/issues/2377">#2377</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2641">#2641</a>)
</li>
<li>WPF: Multi-target Framework 4.6.1 changed to 4.6.2 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2685">#2685</a>)
</li>
<li>Axis: Added option to customize tick line width (<a href="https://github.com/ScottPlot/ScottPlot/issues/2643">#2643</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2654">#2654</a>) <a href="https://github.com/Guillaume-Deville"><strong>@Guillaume-Deville</strong></a>
</li>
<li>Horizontal Span: Fixed <code>ToString()</code> message <a href="https://github.com/RachamimYaakobov"><strong>@RachamimYaakobov</strong></a>
</li>
<li>Signal Plot: Added <code>ScaleY</code> property to compliment <code>OffsetY</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2642">#2642</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2656">#2656</a>) <a href="https://github.com/Guillaume-Deville"><strong>@Guillaume-Deville</strong></a>
</li>
<li>Colorbar: Automatically adjust label position to prevent overlap with tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2684">#2684</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Launcher: Made <code>Plot.Launch</code> methods available without requiring using statements (<a href="https://github.com/ScottPlot/ScottPlot/issues/2627">#2627</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2657">#2657</a>) <a href="https://github.com/Guillaume-Deville"><strong>@Guillaume-Deville</strong></a>
</li>
<li>Population plot: Added <code>BoxBorderColor</code> and <code>ErrorStDevBarColor</code> properties to customize appearance (<a href="https://github.com/ScottPlot/ScottPlot/issues/2708">#2708</a>) <a href="https://github.com/johndoh"><strong>@johndoh</strong></a>
</li>
<li>Arrow: Made tip and base positions mutable (<a href="https://github.com/ScottPlot/ScottPlot/issues/2673">#2673</a>) <a href="https://github.com/MyZQL"><strong>@MyZQL</strong></a>
</li>
<li>ScatterPlotList: Add <code>GetXs()</code> and <code>GetYs()</code> to let users retrieve copies of data points (<a href="https://github.com/ScottPlot/ScottPlot/issues/2694">#2694</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2711">#2711</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/Marc-Frank"><strong>@Marc-Frank</strong></a>
</li>
<li>FormsPlotViewer: New constructor for synchronized plots with bidirectional updates (<a href="https://github.com/ScottPlot/ScottPlot/issues/2653">#2653</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2710">#2710</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2722">#2722</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>LineStyle: Default patterns (and a new custom pattern) can be customized by assigning <code>ScottPlot.LineStylePatterns</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2690">#2690</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2692">#2692</a>) <a href="https://github.com/mocakturk"><strong>@mocakturk</strong></a>, <a href="https://github.com/Marc-Frank"><strong>@Marc-Frank</strong></a>, and <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Radar Plots: Improve vertical spacing for all aspect ratios (<a href="https://github.com/ScottPlot/ScottPlot/issues/2702">#2702</a>) <a href="https://github.com/pjt33"><strong>@pjt33</strong></a>
</li>
<li>Avalonia: Added support for Avalonia 11 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2720">#2720</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2184">#2184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2664">#2664</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2507">#2507</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2321">#2321</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2184">#2184</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2183">#2183</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2725">#2725</a>) <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>, <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Colorbar: Added a <code>ResizeLayout()</code> helper method for adjusting plot layouts to accommodate large tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2703">#2703</a>)
</li>
<li>Scatter List: Improved support for data containing NaN values (<a href="https://github.com/ScottPlot/ScottPlot/issues/2707">#2707</a>) <a href="https://github.com/oldteacup"><strong>@oldteacup</strong></a>
</li>
<li>Population Plot: Improved support for populations with no data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2727">#2727</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2726">#2726</a>) <a href="https://github.com/marklam"><strong>@marklam</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/hellfo'>@hellfo</a>, <a href='https://github.com/mYcheng-95'>@mYcheng-95</a>, <a href='https://github.com/Guillaume-Deville'>@Guillaume-Deville</a>, <a href='https://github.com/RachamimYaakobov'>@RachamimYaakobov</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/johndoh'>@johndoh</a>, <a href='https://github.com/MyZQL'>@MyZQL</a>, <a href='https://github.com/Marc-Frank'>@Marc-Frank</a>, <a href='https://github.com/mocakturk'>@mocakturk</a>, <a href='https://github.com/pjt33'>@pjt33</a>, <a href='https://github.com/Fruchtzwerg94'>@Fruchtzwerg94</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/oldteacup'>@oldteacup</a>, <a href='https://github.com/marklam'>@marklam</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/hellfo'><img src='https://scottplot.net/images/contributors/hellfo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mYcheng-95'><img src='https://scottplot.net/images/contributors/mycheng-95.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Guillaume-Deville'><img src='https://scottplot.net/images/contributors/guillaume-deville.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RachamimYaakobov'><img src='https://scottplot.net/images/contributors/rachamimyaakobov.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/johndoh'><img src='https://scottplot.net/images/contributors/johndoh.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MyZQL'><img src='https://scottplot.net/images/contributors/myzql.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Marc-Frank'><img src='https://scottplot.net/images/contributors/marc-frank.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mocakturk'><img src='https://scottplot.net/images/contributors/mocakturk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/pjt33'><img src='https://scottplot.net/images/contributors/pjt33.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Fruchtzwerg94'><img src='https://scottplot.net/images/contributors/fruchtzwerg94.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/oldteacup'><img src='https://scottplot.net/images/contributors/oldteacup.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/marklam'><img src='https://scottplot.net/images/contributors/marklam.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.5-beta</h1>
<div><i>NuGet packages published 2023-05-17</i></div>
<div class='mt-1'>
<ul>
<li>Box Plot: New plot type for displaying multiple collections of population data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2589">#2589</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>OpenGL Control: Prevent exceptions on keyboard input (<a href="https://github.com/ScottPlot/ScottPlot/issues/2609">#2609</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2616">#2616</a>) <a href="https://github.com/stendprog"><strong>@stendprog</strong></a>
</li>
<li>Platforms: Improved linux support by using SkiaSharp native assets without dependencies (<a href="https://github.com/ScottPlot/ScottPlot/issues/2607">#2607</a>) <a href="https://github.com/chrisxfire"><strong>@chrisxfire</strong></a>
</li>
<li>Color: Improved support for alpha values in constructor (<a href="https://github.com/ScottPlot/ScottPlot/issues/2625">#2625</a>)Clay
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/stendprog'>@stendprog</a>, <a href='https://github.com/chrisxfire'>@chrisxfire</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/stendprog'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chrisxfire'><img src='https://scottplot.net/images/contributors/chrisxfire.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.64</h1>
<div><i>NuGet packages published 2023-05-17</i></div>
<div class='mt-1'>
<ul>
<li>Ellipse: Added <code>Rotation</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2588">#2588</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2595">#2595</a>) <a href="https://github.com/JohniMIEP"><strong>@JohniMIEP</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Controls: Prevent horizontal scroll wheel events from throwing exceptions (<a href="https://github.com/ScottPlot/ScottPlot/issues/2600">#2600</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2626">#2626</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2630">#2630</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>, <a href="https://github.com/szescxz"><strong>@szescxz</strong></a>, and <a href="https://github.com/Jordant190"><strong>@Jordant190</strong></a>
</li>
<li>ScatterDataLogger: Experimental plot type for live incoming data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2377">#2377</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2599">#2599</a>)
</li>
<li>Ticks: Improved automatic layout sizing when manual ticks are used (<a href="https://github.com/ScottPlot/ScottPlot/issues/2603">#2603</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2605">#2605</a>) <a href="https://github.com/StefanBertels"><strong>@StefanBertels</strong></a> and <a href="https://github.com/szescxz"><strong>@szescxz</strong></a>
</li>
<li>Ticks: Improved automatic layout sizing for short and empty tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2606">#2606</a>) <a href="https://github.com/szescxz"><strong>@szescxz</strong></a>
</li>
<li>Plot: Improved <code>AddVerticalLine()</code> XML docs (<a href="https://github.com/ScottPlot/ScottPlot/issues/2610">#2610</a>) <a href="https://github.com/wfs1900"><strong>@wfs1900</strong></a>
</li>
<li>FinancePlot: <code>GetBollingerBands()</code> now accepts an optional standard deviation coefficient (<a href="https://github.com/ScottPlot/ScottPlot/issues/2594">#2594</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>SignalPlot: Fixed bug where <code>Update()</code> did not change the final point (<a href="https://github.com/ScottPlot/ScottPlot/issues/2592">#2592</a>) <a href="https://github.com/Angeld10"><strong>@Angeld10</strong></a>
</li>
<li>ScatterPlotDraggable: Expose IndexUnderMouse for access after drag events (<a href="https://github.com/ScottPlot/ScottPlot/issues/2682">#2682</a>) <a href="https://github.com/mocakturk"><strong>@mocakturk</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/JohniMIEP'>@JohniMIEP</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/szescxz'>@szescxz</a>, <a href='https://github.com/Jordant190'>@Jordant190</a>, <a href='https://github.com/StefanBertels'>@StefanBertels</a>, <a href='https://github.com/wfs1900'>@wfs1900</a>, <a href='https://github.com/Minu476'>@Minu476</a>, <a href='https://github.com/Angeld10'>@Angeld10</a>, <a href='https://github.com/mocakturk'>@mocakturk</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/JohniMIEP'><img src='https://scottplot.net/images/contributors/johnimiep.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/szescxz'><img src='https://scottplot.net/images/contributors/szescxz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Jordant190'><img src='https://scottplot.net/images/contributors/jordant190.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StefanBertels'><img src='https://scottplot.net/images/contributors/stefanbertels.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/wfs1900'><img src='https://scottplot.net/images/contributors/wfs1900.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Minu476'><img src='https://scottplot.net/images/contributors/minu476.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Angeld10'><img src='https://scottplot.net/images/contributors/angeld10.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mocakturk'><img src='https://scottplot.net/images/contributors/mocakturk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.4-beta</h1>
<div><i>NuGet packages published 2023-04-09</i></div>
<div class='mt-1'>
<ul>
<li>WpfPlot: Converted the <code>UserControl</code> to a <code>CustomControl</code> to facilitate inheritance and theming (<a href="https://github.com/ScottPlot/ScottPlot/issues/2565">#2565</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Controls: Improved ALT + left-click-drag zoom rectangle behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/2566">#2566</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.63</h1>
<div><i>NuGet packages published 2023-04-09</i></div>
<div class='mt-1'>
<ul>
<li>WpfPlot: Converted the <code>UserControl</code> to a <code>CustomControl</code> to facilitate inheritance and theming (<a href="https://github.com/ScottPlot/ScottPlot/issues/2509">#2509</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2526">#2526</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Lollipop and Cleveland plots: Added <code>LineWidth</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2556">#2556</a>) <a href="https://github.com/benton-anderson"><strong>@benton-anderson</strong></a>
</li>
<li>Pie: Added <code>SliceLabelPosition</code> property to allow slice labels to be placed outside the pie (<a href="https://github.com/ScottPlot/ScottPlot/issues/2515">#2515</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2510">#2510</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2275">#2275</a>) <a href="https://github.com/nuelle16"><strong>@nuelle16</strong></a> and <a href="https://github.com/cpa-level-it"><strong>@cpa-level-it</strong></a>
</li>
<li>Axis: Made <code>Edge</code> and <code>AxisIndex</code> immutable to prevent accidental modification after construction (<a href="https://github.com/ScottPlot/ScottPlot/issues/2539">#2539</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2538">#2538</a>) <a href="https://github.com/cxjcqu"><strong>@cxjcqu</strong></a>
</li>
<li>Plot: Created <code>LeftAxis</code>, <code>RightAxis</code>, <code>BottomAxis</code>, and <code>TopAxis</code> which alias <code>YAxis</code>, <code>YAxis2</code>, <code>XAxis</code>, and <code>XAxis2</code> but are more expressive (<a href="https://github.com/ScottPlot/ScottPlot/issues/2568">#2568</a>)
</li>
<li>Plot: <code>Launch</code> property has methods for launching the plot as a static image, refreshing web page, or interactive window (<a href="https://github.com/ScottPlot/ScottPlot/issues/2543">#2543</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2570">#2570</a>)
</li>
<li>Heatmap: Improved support for semitransparent cells (<a href="https://github.com/ScottPlot/ScottPlot/issues/2313">#2313</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2277">#2277</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2285">#2285</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2461">#2461</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2484">#2484</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Axis: Added <code>SetZoomInLimit()</code>, <code>SetZoomOutLimit()</code>, and <code>SetBoundary()</code> to control zoom and pan (<a href="https://github.com/ScottPlot/ScottPlot/issues/2250">#2250</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2291">#2291</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1997">#1997</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1873">#1873</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/662">#662</a>) <a href="https://github.com/dusko23"><strong>@dusko23</strong></a>, <a href="https://github.com/Gholamalih"><strong>@Gholamalih</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Controls: Added <code>Configuration.RightClickDragZoomFromMouseDown</code> flag to enable right-click-drag zoom to scale relative to the cursor (<a href="https://github.com/ScottPlot/ScottPlot/issues/2296">#2296</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2573">#2573</a>) <a href="https://github.com/pavlexander"><strong>@pavlexander</strong></a>
</li>
<li>Finance: Improved DateTime position of random stock price sample data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2574">#2574</a>)
</li>
<li>Axis: Improve tick spacing for extremely small plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2289">#2289</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Signal: Fixed bug causing <code>Update()</code> to throw an indexing error (<a href="https://github.com/ScottPlot/ScottPlot/issues/2578">#2578</a>) <a href="https://github.com/Angeld10"><strong>@Angeld10</strong></a>
</li>
<li>Annotation: Position is no longer defined as <code>X</code> and <code>Y</code> but instead <code>Alignment</code>, <code>MarginX</code>, and <code>MarginY</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2302">#2302</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Colorbar: Add <code>Label</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2341">#2341</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/benton-anderson'>@benton-anderson</a>, <a href='https://github.com/nuelle16'>@nuelle16</a>, <a href='https://github.com/cpa-level-it'>@cpa-level-it</a>, <a href='https://github.com/cxjcqu'>@cxjcqu</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/dusko23'>@dusko23</a>, <a href='https://github.com/Gholamalih'>@Gholamalih</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/pavlexander'>@pavlexander</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/Angeld10'>@Angeld10</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/benton-anderson'><img src='https://scottplot.net/images/contributors/benton-anderson.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/nuelle16'><img src='https://scottplot.net/images/contributors/nuelle16.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cpa-level-it'><img src='https://scottplot.net/images/contributors/cpa-level-it.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cxjcqu'><img src='https://scottplot.net/images/contributors/cxjcqu.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dusko23'><img src='https://scottplot.net/images/contributors/dusko23.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Gholamalih'><img src='https://scottplot.net/images/contributors/gholamalih.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/pavlexander'><img src='https://scottplot.net/images/contributors/pavlexander.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Angeld10'><img src='https://scottplot.net/images/contributors/angeld10.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.4-beta</h1>
<div><i>NuGet packages published 2023-04-02</i></div>
<div class='mt-1'>
<ul>
<li>OpenGL: Enhanced customization options for OpenGL-accelerated scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2446">#2446</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Data: Added axis limit caching functionality for improved performance of large scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2460">#2460</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>DataOperations: New static class with helper methods for working with 1D and 2D data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2497">#2497</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Financial: Created <code>IOHLC</code> to allow users to inject their own pricing logic (<a href="https://github.com/ScottPlot/ScottPlot/issues/2404">#2404</a>) <a href="https://github.com/mjpz"><strong>@mjpz</strong></a>
</li>
<li>Solution: Fixed configuration error caused by invalid GUIDs (<a href="https://github.com/ScottPlot/ScottPlot/issues/2525">#2525</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Controls: Disabled context menu in non-interactive mode (<a href="https://github.com/ScottPlot/ScottPlot/issues/2475">#2475</a>) <a href="https://github.com/KroMignon"><strong>@KroMignon</strong></a>
</li>
<li>Histogram: Improved constructor argument validation and support for small bins(<a href="https://github.com/ScottPlot/ScottPlot/issues/2490">#2490</a>) <a href="https://github.com/Margulieuxd"><strong>@Margulieuxd</strong></a> and <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>WpfPlot: Control now appears in the Visual Studio Toolbox (<a href="https://github.com/ScottPlot/ScottPlot/issues/2535">#2535</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1966">#1966</a>)Valkyre
</li>
<li>Axis: Improved tick label format customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/2500">#2500</a>) <a href="https://github.com/chhh"><strong>@chhh</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/mjpz'>@mjpz</a>, <a href='https://github.com/KroMignon'>@KroMignon</a>, <a href='https://github.com/Margulieuxd'>@Margulieuxd</a>, <a href='https://github.com/chhh'>@chhh</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mjpz'><img src='https://scottplot.net/images/contributors/mjpz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KroMignon'><img src='https://scottplot.net/images/contributors/kromignon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Margulieuxd'><img src='https://scottplot.net/images/contributors/margulieuxd.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chhh'><img src='https://scottplot.net/images/contributors/chhh.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.62</h1>
<div><i>NuGet packages published 2023-04-02</i></div>
<div class='mt-1'>
<ul>
<li>WinForms Control: <code>Reset()</code> makes new plots transparent (<a href="https://github.com/ScottPlot/ScottPlot/issues/2445">#2445</a>) <a href="https://github.com/Neopentane1"><strong>@Neopentane1</strong></a>
</li>
<li>Ellipse and Circle: New plot types demonstrated in the cookbook. (<a href="https://github.com/ScottPlot/ScottPlot/issues/2413">#2413</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2437">#2437</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Heatmap: Added <code>FlipVertically</code> to invert vertical axis of heatmap data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2444">#2444</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2450">#2450</a>) <a href="https://github.com/Neopentane1"><strong>@Neopentane1</strong></a>
</li>
<li>Histogram: Improved support for datasets with low variance (<a href="https://github.com/ScottPlot/ScottPlot/issues/2464">#2464</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2463">#2463</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Heatmap: Added <code>Opacity</code> property (<a href="https://github.com/ScottPlot/ScottPlot/issues/2461">#2461</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2484">#2484</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>DataOperations: New static class with helper methods for working with 1D and 2D data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2497">#2497</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Population: Added option for customizing horizontal errorbar alignment (<a href="https://github.com/ScottPlot/ScottPlot/issues/2502">#2502</a>) <a href="https://github.com/benton-anderson"><strong>@benton-anderson</strong></a>
</li>
<li>Financial: Created <code>IOHLC</code> to allow users to inject their own pricing logic (<a href="https://github.com/ScottPlot/ScottPlot/issues/2404">#2404</a>) <a href="https://github.com/mjpz"><strong>@mjpz</strong></a>
</li>
<li>OHLC: The <code>Volume</code> property and constructor overload initializing it have been deprecated (<a href="https://github.com/ScottPlot/ScottPlot/issues/2404">#2404</a>)
</li>
<li>Axis: Expose tick, spine, and label configuration objects (<a href="https://github.com/ScottPlot/ScottPlot/issues/2512">#2512</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2513">#2513</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2353">#2353</a>) <a href="https://github.com/cxjcqu"><strong>@cxjcqu</strong></a> and <a href="https://github.com/SaltyTears"><strong>@SaltyTears</strong></a>
</li>
<li>Signal: Improved <code>FillDisable()</code> behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/2436">#2436</a>) <a href="https://github.com/szescxz"><strong>@szescxz</strong></a>
</li>
<li>RadialGaugePlot: Improve alignment for plots with 1-3 gauges (<a href="https://github.com/ScottPlot/ScottPlot/issues/2448">#2448</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2128">#2128</a>) <a href="https://github.com/DavidWhataGIT"><strong>@DavidWhataGIT</strong></a>, <a href="https://github.com/johndoh"><strong>@johndoh</strong></a>, and daddydavid
</li>
<li>Pie: Added <code>LegendLabels</code> property so slices and legend items can have different labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2459">#2459</a>) <a href="https://github.com/vietanhbui"><strong>@vietanhbui</strong></a>
</li>
<li>Controls: Improved <code>GetCoordinate()</code> behavior for empty plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2468">#2468</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2540">#2540</a>) <a href="https://github.com/dusko23"><strong>@dusko23</strong></a>
</li>
<li>Histogram: Improved constructor argument validation and support for small bins(<a href="https://github.com/ScottPlot/ScottPlot/issues/2490">#2490</a>) <a href="https://github.com/Margulieuxd"><strong>@Margulieuxd</strong></a> and <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Axis: Improved <code>Plot.AxisPanCenter()</code> support for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2483">#2483</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2544">#2544</a>) <a href="https://github.com/dusko23"><strong>@dusko23</strong></a>
</li>
<li>Bubble Plot: Added <code>RadiusIsPixels</code> flag which when <code>falst</code> sizes bubbles using radius units instead of pixels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2492">#2492</a>) <a href="https://github.com/marcelpel"><strong>@marcelpel</strong></a>
</li>
<li>Axis: Improved <code>Plot.MatchAxisLimits()</code> support for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2495">#2495</a>) <a href="https://github.com/Margulieuxd"><strong>@Margulieuxd</strong></a>
</li>
<li>Plot: Improved <code>Plot.XLabel()</code> XML documentation (<a href="https://github.com/ScottPlot/ScottPlot/issues/2552">#2552</a>) <a href="https://github.com/JulianusIV"><strong>@JulianusIV</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Neopentane1'>@Neopentane1</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/benton-anderson'>@benton-anderson</a>, <a href='https://github.com/mjpz'>@mjpz</a>, <a href='https://github.com/cxjcqu'>@cxjcqu</a>, <a href='https://github.com/SaltyTears'>@SaltyTears</a>, <a href='https://github.com/szescxz'>@szescxz</a>, <a href='https://github.com/DavidWhataGIT'>@DavidWhataGIT</a>, <a href='https://github.com/johndoh'>@johndoh</a>, <a href='https://github.com/vietanhbui'>@vietanhbui</a>, <a href='https://github.com/dusko23'>@dusko23</a>, <a href='https://github.com/Margulieuxd'>@Margulieuxd</a>, <a href='https://github.com/marcelpel'>@marcelpel</a>, <a href='https://github.com/JulianusIV'>@JulianusIV</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Neopentane1'><img src='https://scottplot.net/images/contributors/neopentane1.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/benton-anderson'><img src='https://scottplot.net/images/contributors/benton-anderson.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mjpz'><img src='https://scottplot.net/images/contributors/mjpz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cxjcqu'><img src='https://scottplot.net/images/contributors/cxjcqu.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SaltyTears'><img src='https://scottplot.net/images/contributors/saltytears.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/szescxz'><img src='https://scottplot.net/images/contributors/szescxz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DavidWhataGIT'><img src='https://scottplot.net/images/contributors/davidwhatagit.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/johndoh'><img src='https://scottplot.net/images/contributors/johndoh.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/vietanhbui'><img src='https://scottplot.net/images/contributors/vietanhbui.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dusko23'><img src='https://scottplot.net/images/contributors/dusko23.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Margulieuxd'><img src='https://scottplot.net/images/contributors/margulieuxd.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/marcelpel'><img src='https://scottplot.net/images/contributors/marcelpel.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JulianusIV'><img src='https://scottplot.net/images/contributors/julianusiv.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.2-beta</h1>
<div><i>NuGet packages published 2023-02-27</i></div>
<div class='mt-1'>
<ul>
<li>Signal Plot: Support X and Y offset (<a href="https://github.com/ScottPlot/ScottPlot/issues/2378">#2378</a>) <a href="https://github.com/minjjKang"><strong>@minjjKang</strong></a>
</li>
<li>WebAssembly: New sandbox demonstrates interactive ScottPlot in a browser (<a href="https://github.com/ScottPlot/ScottPlot/issues/2380">#2380</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2374">#2374</a>)rafntor
</li>
<li>OpenGL: Added experimental support for direct GPU rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/2383">#2383</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2397">#2397</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Finance Plots: Added OHLC and Candlestick plot types (<a href="https://github.com/ScottPlot/ScottPlot/issues/2386">#2386</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Style: Improved <code>Plot.Style.Background()</code> color configuration (<a href="https://github.com/ScottPlot/ScottPlot/issues/2398">#2398</a>) <a href="https://github.com/Jonathanio123"><strong>@Jonathanio123</strong></a>
</li>
<li>WPF: Added OpenGL support to the WPF control (<a href="https://github.com/ScottPlot/ScottPlot/issues/2395">#2395</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Palette: Refactored the palette system to allow ScottPlot 4 and 5 to share palette code (<a href="https://github.com/ScottPlot/ScottPlot/issues/2409">#2409</a>)
</li>
<li>Plot: Added <code>GetImageHTML()</code> for improved rendering in interactive notebooks (<a href="https://github.com/ScottPlot/ScottPlot/issues/2385">#2385</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1772">#1772</a>) <a href="https://github.com/neilyoung2008"><strong>@neilyoung2008</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/minjjKang'>@minjjKang</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Jonathanio123'>@Jonathanio123</a>, <a href='https://github.com/neilyoung2008'>@neilyoung2008</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/minjjKang'><img src='https://scottplot.net/images/contributors/minjjkang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Jonathanio123'><img src='https://scottplot.net/images/contributors/jonathanio123.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/neilyoung2008'><img src='https://scottplot.net/images/contributors/neilyoung2008.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.61</h1>
<div><i>NuGet packages published 2023-02-27</i></div>
<div class='mt-1'>
<ul>
<li>Axis: Throw exception immediately upon setting invalid axis limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/2327">#2327</a>) <a href="https://github.com/mjpz"><strong>@mjpz</strong></a>
</li>
<li>Heatmap: Added support for transparent single-color heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/2336">#2336</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Statistics: Improved median calculation method in population plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2363">#2363</a>) <a href="https://github.com/Syntaxrabbit"><strong>@Syntaxrabbit</strong></a>
</li>
<li>AxisLineVector: Improved automatic axis limits when using limited axis lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/2371">#2371</a>) <a href="https://github.com/ChrisAtVault"><strong>@ChrisAtVault</strong></a>
</li>
<li>Controls: <code>Configuration.AddLinkedControl()</code> simplifies axis sharing across multiple controls (<a href="https://github.com/ScottPlot/ScottPlot/issues/2402">#2402</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2372">#2372</a>)
</li>
<li>Statistics: New <code>ScottPlot.Statistics.Histogram</code> class optimized for simplicity and live data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2403">#2403</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2389">#2389</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Statistics: Improved bin edge calculations for histograms with fixed bin size bins (<a href="https://github.com/ScottPlot/ScottPlot/issues/2299">#2299</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Palette: Refactored the palette system to allow ScottPlot 4 and 5 to share palette code (<a href="https://github.com/ScottPlot/ScottPlot/issues/2409">#2409</a>)
</li>
<li>Heatmap: Added <code>GetBitmap()</code> to provide access to raw heatmap image data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2396">#2396</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2410">#2410</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Pie: Prevent invalid argument exceptions when drawing zero-size pie charts (<a href="https://github.com/ScottPlot/ScottPlot/issues/2415">#2415</a>) <a href="https://github.com/KC7465128305"><strong>@KC7465128305</strong></a>
</li>
<li>Colormap: Colormaps can be created from a set of colors (<a href="https://github.com/ScottPlot/ScottPlot/issues/2375">#2375</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2191">#2191</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2187">#2187</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>Function Plot: New optional <code>AxisLimits</code> allows users to define default axis limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/2428">#2428</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2412">#2412</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Population: Fixed bug causing argument exceptions for 1px high plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2429">#2429</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2384">#2384</a>) <a href="https://github.com/Sprenk"><strong>@Sprenk</strong></a>
</li>
<li>Controls: Added <code>Configuration.AltLeftClickDragZoom</code> option to customize zooming behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/2391">#2391</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2392">#2392</a>) <a href="https://github.com/DevJins"><strong>@DevJins</strong></a>
</li>
<li>Error Bar: Added <code>Label</code> property which allows error bars to appear independently in the legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/2432">#2432</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2388">#2388</a>) <a href="https://github.com/dongyi-cai-windsab"><strong>@dongyi-cai-windsab</strong></a>
</li>
<li>Demo: Fixed bug preventing the cookbook from launching (<a href="https://github.com/ScottPlot/ScottPlot/issues/2443">#2443</a>) <a href="https://github.com/FannyAtGitHub"><strong>@FannyAtGitHub</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/mjpz'>@mjpz</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/Syntaxrabbit'>@Syntaxrabbit</a>, <a href='https://github.com/ChrisAtVault'>@ChrisAtVault</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/KC7465128305'>@KC7465128305</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/Sprenk'>@Sprenk</a>, <a href='https://github.com/DevJins'>@DevJins</a>, <a href='https://github.com/dongyi-cai-windsab'>@dongyi-cai-windsab</a>, <a href='https://github.com/FannyAtGitHub'>@FannyAtGitHub</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/mjpz'><img src='https://scottplot.net/images/contributors/mjpz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Syntaxrabbit'><img src='https://scottplot.net/images/contributors/syntaxrabbit.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisAtVault'><img src='https://scottplot.net/images/contributors/chrisatvault.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KC7465128305'><img src='https://scottplot.net/images/contributors/kc7465128305.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Sprenk'><img src='https://scottplot.net/images/contributors/sprenk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DevJins'><img src='https://scottplot.net/images/contributors/devjins.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dongyi-cai-windsab'><img src='https://scottplot.net/images/contributors/dongyi-cai-windsab.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/FannyAtGitHub'><img src='https://scottplot.net/images/contributors/fannyatgithub.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.1-beta</h1>
<div><i>NuGet packages published 2023-02-09</i></div>
<div class='mt-1'>
<ul>
<li>Namespace: DataSource → DataSources
</li>
<li>Error Bar: New plot type (<a href="https://github.com/ScottPlot/ScottPlot/issues/2346">#2346</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot: Added <code>Style</code> object to group functions that perform complex styling tasks
</li>
<li>Controls: Added right-click context menus (<a href="https://github.com/ScottPlot/ScottPlot/issues/2350">#2350</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Rendering: Added support for saving bitmap files (<a href="https://github.com/ScottPlot/ScottPlot/issues/2350">#2350</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axes: Added support for DateTime Axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/2369">#2369</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Rendering: Added support for line styles (<a href="https://github.com/ScottPlot/ScottPlot/issues/2373">#2373</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>WinUI3: Created a Uno WinUI3 control (<a href="https://github.com/ScottPlot/ScottPlot/issues/2374">#2374</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2039">#2039</a>) <a href="https://github.com/rafntor"><strong>@rafntor</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/rafntor'>@rafntor</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/rafntor'><img src='https://scottplot.net/images/contributors/rafntor.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 5.0.0-beta</h1>
<div><i>NuGet packages published 2023-01-01</i></div>
<div class='mt-1'>
<ul>
<li>ScottPlot 5: First version 5 release published to NuGet <a href="https://github.com/ScottPlot/ScottPlot/issues/2304">#2304</a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.60</h1>
<div><i>NuGet packages published 2022-12-23</i></div>
<div class='mt-1'>
<ul>
<li>Pie Chart: Improved display when a single slice covers the entire pie (<a href="https://github.com/ScottPlot/ScottPlot/issues/2248">#2248</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2251">#2251</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot: Added <code>AddFill()</code> arguments for <code>LineWidth</code> and <code>LineColor</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2258">#2258</a>) <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>
</li>
<li>Plot: Improved support for filled polygons with fewer than 3 points (<a href="https://github.com/ScottPlot/ScottPlot/issues/2258">#2258</a>) <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>
</li>
<li>A new <code>IDraggableSpan</code> interface was added to trigger events when the edges of spans are dragged (<a href="https://github.com/ScottPlot/ScottPlot/issues/2268">#2268</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Palettes: Added new light-color palettes PastelWheel, LightSpectrum, and LightOcean (<a href="https://github.com/ScottPlot/ScottPlot/issues/2271">#2271</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2272">#2272</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2273">#2273</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Ticks: Improved tick calculations for very small plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2280">#2280</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2278">#2278</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Crosshair: HLine and VLine are no longer readonly (<a href="https://github.com/ScottPlot/ScottPlot/issues/2208">#2208</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Function Plot: Added support for filling above and below lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/2239">#2239</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2238">#2238</a>) <a href="https://github.com/SGanard"><strong>@SGanard</strong></a>
</li>
<li>Signal Plot: Improved error messages for when <code>Update()</code> fails to replace data (<a href="https://github.com/ScottPlot/ScottPlot/issues/2263">#2263</a>)
</li>
<li>Plot: <code>Clear()</code> now resets inner and outer view limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/2264">#2264</a>) <a href="https://github.com/vietanhbui"><strong>@vietanhbui</strong></a>
</li>
<li>FormsPlot: Right-click help menu is now <code>TopMost</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2282">#2282</a>) <a href="https://github.com/dusko23"><strong>@dusko23</strong></a>
</li>
<li>Signal Plot: Allow users to apply different colors to lines and markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/2288">#2288</a>) <a href="https://github.com/Nuliax7"><strong>@Nuliax7</strong></a>
</li>
<li>Pie: Added <code>Size</code> option to allow customizing how large the pie chart is (<a href="https://github.com/ScottPlot/ScottPlot/issues/2317">#2317</a>) <a href="https://github.com/Rudde"><strong>@Rudde</strong></a>
</li>
<li>FormsPlot: Improved support for horizontal legends in the pop-out legend viewer (<a href="https://github.com/ScottPlot/ScottPlot/issues/2300">#2300</a>) <a href="https://github.com/rotger"><strong>@rotger</strong></a>
</li>
<li>Axis: Added arguments to <code>AxisPan()</code> to improve multi-axis support (<a href="https://github.com/ScottPlot/ScottPlot/issues/2293">#2293</a>)
</li>
<li>Axis: Added <code>AxisPanCenter()</code> to center the view on a coordinate (<a href="https://github.com/ScottPlot/ScottPlot/issues/2293">#2293</a>) <a href="https://github.com/dusko23"><strong>@dusko23</strong></a>
</li>
<li>Project: Use System.Drawing.Common version 4.7.2 to avoid CVE-2021-26701 (<a href="https://github.com/ScottPlot/ScottPlot/issues/2303">#2303</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1004">#1004</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1413">#1413</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Fruchtzwerg94'>@Fruchtzwerg94</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/SGanard'>@SGanard</a>, <a href='https://github.com/vietanhbui'>@vietanhbui</a>, <a href='https://github.com/dusko23'>@dusko23</a>, <a href='https://github.com/Nuliax7'>@Nuliax7</a>, <a href='https://github.com/Rudde'>@Rudde</a>, <a href='https://github.com/rotger'>@rotger</a>, <a href='https://github.com/gobikulandaisamy'>@gobikulandaisamy</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Fruchtzwerg94'><img src='https://scottplot.net/images/contributors/fruchtzwerg94.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SGanard'><img src='https://scottplot.net/images/contributors/sganard.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/vietanhbui'><img src='https://scottplot.net/images/contributors/vietanhbui.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dusko23'><img src='https://scottplot.net/images/contributors/dusko23.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Nuliax7'><img src='https://scottplot.net/images/contributors/nuliax7.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Rudde'><img src='https://scottplot.net/images/contributors/rudde.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/rotger'><img src='https://scottplot.net/images/contributors/rotger.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gobikulandaisamy'><img src='https://scottplot.net/images/contributors/gobikulandaisamy.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.59</h1>
<div><i>NuGet packages published 2022-11-06</i></div>
<div class='mt-1'>
<ul>
<li>Ticks: Improve datetime tick labels for systems with a 24-hour display format (<a href="https://github.com/ScottPlot/ScottPlot/issues/2132">#2132</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2135">#2135</a>) <a href="https://github.com/MareMare"><strong>@MareMare</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axis: <code>Plot.AddAxis()</code> now uses auto-incremented axis index unless one is explicitly defined (<a href="https://github.com/ScottPlot/ScottPlot/issues/2133">#2133</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and Discord/Nick
</li>
<li>Axis: <code>Plot.GetAxesMatching()</code> was created to obtain a given vertical or horizontal axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/2133">#2133</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and Discord/Nick
</li>
<li>Axis: Corner label format can be customized for any axis by calling <code>CornerLabelFormat()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2134">#2134</a>) <a href="https://github.com/ShannonZ"><strong>@ShannonZ</strong></a>
</li>
<li>BarSeries: Improved rendering of negative values (<a href="https://github.com/ScottPlot/ScottPlot/issues/2147">#2147</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2152">#2152</a>) <a href="https://github.com/fe-c"><strong>@fe-c</strong></a>
</li>
<li>Function Plot: Added optional <code>XMin</code> and <code>XMax</code> fields which limit function rendering to a defined horizontal span (<a href="https://github.com/ScottPlot/ScottPlot/issues/2158">#2158</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2156">#2156</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2138">#2138</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/phil100vol"><strong>@phil100vol</strong></a>
</li>
<li>FormsPlot: Plot viewer now has <code>RefreshLegendImage()</code> allowing the pop-out legend to be redrawn programmatically (<a href="https://github.com/ScottPlot/ScottPlot/issues/2157">#2157</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2153">#2153</a>) <a href="https://github.com/rosdyana"><strong>@rosdyana</strong></a>
</li>
<li>Function Plot: Improved performance for functions which return null (<a href="https://github.com/ScottPlot/ScottPlot/issues/2158">#2158</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2156">#2156</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2138">#2138</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>BarSeries: improve support for negative and horizontal bar labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/2148">#2148</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2159">#2159</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2152">#2152</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Palette: Added <code>Normal</code> Palette based on <a href="http://tsitsul.in/blog/coloropt/">Anton Tsitsulin's Normal 6-color palette</a> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2161">#2161</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2010">#2010</a>) <a href="https://github.com/martinkleppe"><strong>@martinkleppe</strong></a>
</li>
<li>BarSeries: Added helper function to create a bar series from an array of values (<a href="https://github.com/ScottPlot/ScottPlot/issues/2161">#2161</a>) <a href="https://github.com/KonH"><strong>@KonH</strong></a>
</li>
<li>SignalPlot: Add <code>Smooth</code> option (<a href="https://github.com/ScottPlot/ScottPlot/issues/2174">#2174</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2137">#2137</a>) <a href="https://github.com/rosdyana"><strong>@rosdyana</strong></a>
</li>
<li>Signal Plot: Use correct marker when displaying in legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/2172">#2172</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2173">#2173</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Data Generation: Improved floating point precision of <code>RandomNormalValue</code> randomness (<a href="https://github.com/ScottPlot/ScottPlot/issues/2189">#2189</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2206">#2206</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>_
</li>
<li>Finance Plot: Improved SMA calculations for charts with unordered candlesticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/2199">#2199</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2207">#2207</a>) <a href="https://github.com/zachesposito"><strong>@zachesposito</strong></a> and <a href="https://github.com/xenedia"><strong>@xenedia</strong></a>
</li>
<li>Avalonia Control: Fixed subscription to ContexMenu property changes (<a href="https://github.com/ScottPlot/ScottPlot/issues/2215">#2215</a>) <a href="https://github.com/DmitryZhelnin"><strong>@DmitryZhelnin</strong></a>
</li>
<li>Legend: Support horizontal orientation and added cookbook example (<a href="https://github.com/ScottPlot/ScottPlot/issues/2216">#2216</a>) <a href="https://github.com/lucabat"><strong>@lucabat</strong></a>
</li>
<li>Data Generation: Added generic support for <code>Consecutive()</code>, <code>Random()</code>, and <code>RandomWalk()</code>
</li>
<li>SignalPlot: New <code>SignalPlotGeneric</code> type allows <code>AddSignal()</code> to support generic data types (<a href="https://github.com/ScottPlot/ScottPlot/issues/2217">#2217</a>) <a href="https://github.com/codecrafty"><strong>@codecrafty</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/MareMare'>@MareMare</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/ShannonZ'>@ShannonZ</a>, <a href='https://github.com/fe-c'>@fe-c</a>, <a href='https://github.com/phil100vol'>@phil100vol</a>, <a href='https://github.com/rosdyana'>@rosdyana</a>, <a href='https://github.com/martinkleppe'>@martinkleppe</a>, <a href='https://github.com/KonH'>@KonH</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/zachesposito'>@zachesposito</a>, <a href='https://github.com/xenedia'>@xenedia</a>, <a href='https://github.com/DmitryZhelnin'>@DmitryZhelnin</a>, <a href='https://github.com/lucabat'>@lucabat</a>, <a href='https://github.com/codecrafty'>@codecrafty</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/MareMare'><img src='https://scottplot.net/images/contributors/maremare.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ShannonZ'><img src='https://scottplot.net/images/contributors/shannonz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/fe-c'><img src='https://scottplot.net/images/contributors/fe-c.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/phil100vol'><img src='https://scottplot.net/images/contributors/phil100vol.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/rosdyana'><img src='https://scottplot.net/images/contributors/rosdyana.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/martinkleppe'><img src='https://scottplot.net/images/contributors/martinkleppe.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KonH'><img src='https://scottplot.net/images/contributors/konh.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/zachesposito'><img src='https://scottplot.net/images/contributors/zachesposito.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xenedia'><img src='https://scottplot.net/images/contributors/xenedia.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/DmitryZhelnin'><img src='https://scottplot.net/images/contributors/dmitryzhelnin.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/lucabat'><img src='https://scottplot.net/images/contributors/lucabat.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/codecrafty'><img src='https://scottplot.net/images/contributors/codecrafty.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.58</h1>
<div><i>NuGet packages published 2022-09-08</i></div>
<div class='mt-1'>
<ul>
<li>Radar: New <code>Smooth</code> field allows radar areas to be drawn with smooth lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/2067">#2067</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2065">#2065</a>) <a href="https://github.com/theelderwand"><strong>@theelderwand</strong></a>
</li>
<li>Ticks: Setting manual ticks will now throw an immediate <code>ArgumentException</code> if positions and labels have different lengths (<a href="https://github.com/ScottPlot/ScottPlot/issues/2063">#2063</a>) <a href="https://github.com/sergaent"><strong>@sergaent</strong></a>
</li>
<li>VectorFieldList: New plot type for plotting arbitrary coordinate/vector pairs which are not confined to a grid (<a href="https://github.com/ScottPlot/ScottPlot/issues/2064">#2064</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2079">#2079</a>) <a href="https://github.com/sjdemoor"><strong>@sjdemoor</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>HLine and VLine: Line (but not position label) is hidden if <code>LineWidth</code> is <code>0</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2085">#2085</a>) <a href="https://github.com/A1145681"><strong>@A1145681</strong></a>
</li>
<li>Controls: The cursor now reverts to <code>Configuration.DefaultCursor</code> after moving off draggable objects (<a href="https://github.com/ScottPlot/ScottPlot/issues/2091">#2091</a>) <a href="https://github.com/kurupt44"><strong>@kurupt44</strong></a>
</li>
<li>Snapping: SnapNearest classes now expose <code>SnapIndex()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2099">#2099</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Background: Added optional arguments to <code>Style()</code> lets users place a custom background image behind their plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/2016">#2016</a>) <a href="https://github.com/apaaris"><strong>@apaaris</strong></a>
</li>
<li>Axis Line: Remove the ability to drag invisible lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/2110">#2110</a>) <a href="https://github.com/A1145681"><strong>@A1145681</strong></a>
</li>
<li>Controls: Draggable objects can now only be dragged with the left mouse button (<a href="https://github.com/ScottPlot/ScottPlot/issues/2111">#2111</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2120">#2120</a>) <a href="https://github.com/A1145681"><strong>@A1145681</strong></a>
</li>
<li>Heatmap: Prevent rendering artifacts by throwing an exception if the 2D array is larger than 2^15 in either dimension (<a href="https://github.com/ScottPlot/ScottPlot/issues/2119">#2119</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2116">#2116</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/theelderwand'>@theelderwand</a>, <a href='https://github.com/sergaent'>@sergaent</a>, <a href='https://github.com/sjdemoor'>@sjdemoor</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/A1145681'>@A1145681</a>, <a href='https://github.com/kurupt44'>@kurupt44</a>, <a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/apaaris'>@apaaris</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/theelderwand'><img src='https://scottplot.net/images/contributors/theelderwand.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sergaent'><img src='https://scottplot.net/images/contributors/sergaent.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sjdemoor'><img src='https://scottplot.net/images/contributors/sjdemoor.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/A1145681'><img src='https://scottplot.net/images/contributors/a1145681.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kurupt44'><img src='https://scottplot.net/images/contributors/kurupt44.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/apaaris'><img src='https://scottplot.net/images/contributors/apaaris.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.57</h1>
<div><i>NuGet packages published 2022-08-18</i></div>
<div class='mt-1'>
<ul>
<li>Scatter: Improved <code>GetPointNearest()</code> when <code>OnNaN</code> is <code>Gap</code> or <code>Ignore</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2048">#2048</a>) <a href="https://github.com/thopri"><strong>@thopri</strong></a>
</li>
<li>Heatmap and Image: Added <code>Coordinate[] ClippingPoints</code> to give users the ability to clip to an arbitrary polygon (<a href="https://github.com/ScottPlot/ScottPlot/issues/2049">#2049</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2052">#2052</a>) <a href="https://github.com/xichaoqiang"><strong>@xichaoqiang</strong></a>
</li>
<li>Image: Improved automatic axis limits measurement when <code>HeightInAxisUnits</code> is defined
</li>
<li>Plot: Reduced anti-aliasing artifacts at the edge of frameless plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/2051">#2051</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/thopri'>@thopri</a>, <a href='https://github.com/xichaoqiang'>@xichaoqiang</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/thopri'><img src='https://scottplot.net/images/contributors/thopri.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xichaoqiang'><img src='https://scottplot.net/images/contributors/xichaoqiang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.56</h1>
<div><i>NuGet packages published 2022-08-16</i></div>
<div class='mt-1'>
<ul>
<li>Signal: Improved accuracy of <code>GetIndexForX()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2044">#2044</a>) <a href="https://github.com/CharlesMauldin"><strong>@CharlesMauldin</strong></a>
</li>
<li>Palette: Added help messages for users attempting to create custom palettes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1966">#1966</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/CharlesMauldin'>@CharlesMauldin</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/CharlesMauldin'><img src='https://scottplot.net/images/contributors/charlesmauldin.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.55</h1>
<div><i>NuGet packages published 2022-08-14</i></div>
<div class='mt-1'>
<ul>
<li>Scatter: Data may now contain NaN if the <code>OnNaN</code> field is customized. <code>Throw</code> throws an exception of NaN is detected (default behavior), <code>Ignore</code> skips over NaN values (connecting adjacent points with a line), and <code>Gap</code> breaks the line so NaN values appear as gaps. (<a href="https://github.com/ScottPlot/ScottPlot/issues/2040">#2040</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2041">#2041</a>)
</li>
<li>Plot: Added a <code>AddFillError()</code> helper method to create a shaded error polygon for displaying beneath a scatter plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/2037">#2037</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.53</h1>
<div><i>NuGet packages published 2022-08-11</i></div>
<div class='mt-1'>
<ul>
<li>Scatter and Signal Plot: <code>GetYDataRange()</code> now returns the range of Y values between a range of X positions, useful for setting automatic axis limits when plots are zoomed-in (<a href="https://github.com/ScottPlot/ScottPlot/issues/1946">#1946</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1942">#1942</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1929">#1929</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>WPF Control: Right-click copy now renders high quality image to the clipboard (<a href="https://github.com/ScottPlot/ScottPlot/issues/1952">#1952</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Radar, Coxcomb, and Pie Chart: New options to customize hatch pattern and color. See cookbook for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1948">#1948</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1943">#1943</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Signal Plot: Improve support for plots with a single point (<a href="https://github.com/ScottPlot/ScottPlot/issues/1951">#1951</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1949">#1949</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/Fruchtzwerg94"><strong>@Fruchtzwerg94</strong></a>
</li>
<li>Draggable Marker Plots: Improved drag behavior when drag limits are in use (<a href="https://github.com/ScottPlot/ScottPlot/issues/1970">#1970</a>) <a href="https://github.com/xmln17"><strong>@xmln17</strong></a>
</li>
<li>Signal Plot: Added support for plotting <code>byte</code> arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/1945">#1945</a>)
</li>
<li>Axis Line: Added properties to customize alignment of position labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/1972">#1972</a>) <a href="https://github.com/hamhub7"><strong>@hamhub7</strong></a>
</li>
<li>Plot: MatchAxis no longer modifies limits of unintended axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1980">#1980</a>) <a href="https://github.com/PlayCreatively"><strong>@PlayCreatively</strong></a>
</li>
<li>Plot: Improved error reporting for invalid axis limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/1994">#1994</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Signal Plot: Improved <code>GetPointNearestX()</code> accuracy for plots with high zoom (<a href="https://github.com/ScottPlot/ScottPlot/issues/1987">#1987</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2019">#2019</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2020">#2020</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>Draggable: <code>IDraggable</code> now has functions to facilitate snapping (<a href="https://github.com/ScottPlot/ScottPlot/issues/2006">#2006</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2007">#2007</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/2022">#2022</a>) <a href="https://github.com/Agorath"><strong>@Agorath</strong></a>
</li>
<li>Palette: <code>ScottPlot.Palette</code> has been refactored to replace <code>ScottPlot.Drawing.Palette</code> and <code>ScottPlot.Drawing.Colorset</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2024">#2024</a>)
</li>
<li>Palette: Palettes now implement <code>IEnumerable</code> and colors can be retrieved using <code>foreach</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/2028">#2028</a>)
</li>
<li>Render: Improved thread safety of the render lock system (<a href="https://github.com/ScottPlot/ScottPlot/issues/2030">#2030</a>) <a href="https://github.com/anprevost"><strong>@anprevost</strong></a>
</li>
<li>Scatter: Exposed <code>SmoothTension</code> to customize behavior when <code>Smooth</code> is enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1878">#1878</a>)Michael99
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Fruchtzwerg94'>@Fruchtzwerg94</a>, <a href='https://github.com/xmln17'>@xmln17</a>, <a href='https://github.com/hamhub7'>@hamhub7</a>, <a href='https://github.com/PlayCreatively'>@PlayCreatively</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/Agorath'>@Agorath</a>, <a href='https://github.com/anprevost'>@anprevost</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Fruchtzwerg94'><img src='https://scottplot.net/images/contributors/fruchtzwerg94.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xmln17'><img src='https://scottplot.net/images/contributors/xmln17.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/hamhub7'><img src='https://scottplot.net/images/contributors/hamhub7.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PlayCreatively'><img src='https://scottplot.net/images/contributors/playcreatively.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Agorath'><img src='https://scottplot.net/images/contributors/agorath.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/anprevost'><img src='https://scottplot.net/images/contributors/anprevost.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.52</h1>
<div><i>NuGet packages published 2022-07-09</i></div>
<div class='mt-1'>
<ul>
<li>WinForms control: Fixed a bug introduced by the previous version which resulted in flickering while using the mouse to pan or zoom (<a href="https://github.com/ScottPlot/ScottPlot/issues/1938">#1938</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1913">#1913</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>
</li>
<li>Plot: Added obsolete <code>GetLegendBitmap()</code> with message indicating <code>RenderLegend()</code> is to be used instead (<a href="https://github.com/ScottPlot/ScottPlot/issues/1937">#1937</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1936">#1936</a>) <a href="https://github.com/johnfoll"><strong>@johnfoll</strong></a>
</li>
<li>Signal Plot: Improved performance using platform-specific fast paths for common data types to minimize allocations (<a href="https://github.com/ScottPlot/ScottPlot/issues/1927">#1927</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>, <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'>@AbeniMatteo</a>, <a href='https://github.com/johnfoll'>@johnfoll</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'><img src='https://scottplot.net/images/contributors/abenimatteo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/johnfoll'><img src='https://scottplot.net/images/contributors/johnfoll.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.51</h1>
<div><i>NuGet packages published 2022-06-30</i></div>
<div class='mt-1'>
<ul>
<li>WinForms Control: Fixed a bug that caused frequent mouse events to overflow the stack (<a href="https://github.com/ScottPlot/ScottPlot/issues/1906">#1906</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1913">#1913</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>
</li>
<li>Performance: Improve string measurement performance using cached fonts (<a href="https://github.com/ScottPlot/ScottPlot/issues/1915">#1915</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>
</li>
<li>Layout: Improve axis alignment when <code>ManualDataArea()</code> is used (<a href="https://github.com/ScottPlot/ScottPlot/issues/1901">#1901</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1907">#1907</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1911">#1911</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>Cookbook: Improve error message if recipes.json is not found (<a href="https://github.com/ScottPlot/ScottPlot/issues/1917">#1917</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'>@AbeniMatteo</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'><img src='https://scottplot.net/images/contributors/abenimatteo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.50</h1>
<div><i>NuGet packages published 2022-06-26</i></div>
<div class='mt-1'>
<ul>
<li>BarSeries: Lists passed into new BarSeries are preserved and can be modified after instantiation. Added a <code>Count</code> property. Added a <code>AddBarSeries()</code> overload that permits creating an empty BarSeries. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1902">#1902</a>)
</li>
<li>Markers: Improved performance for plot types that render multiple markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/1910">#1910</a>) <a href="https://github.com/AbeniMatteo"><strong>@AbeniMatteo</strong></a>
</li>
<li>Plot: New <code>ManualDataArea()</code> function allows users to define pixel-perfect layouts (<a href="https://github.com/ScottPlot/ScottPlot/issues/1907">#1907</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1901">#1901</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'>@AbeniMatteo</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/AbeniMatteo'><img src='https://scottplot.net/images/contributors/abenimatteo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.49</h1>
<div><i>NuGet packages published 2022-06-21</i></div>
<div class='mt-1'>
<ul>
<li>BarSeries: A new type of bar plot which allows each bar to be individually customized and offers mouse collision detection (<a href="https://github.com/ScottPlot/ScottPlot/issues/1891">#1891</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1749">#1749</a>) <a href="https://github.com/jhm-ciberman"><strong>@jhm-ciberman</strong></a>
</li>
<li>SignalXY: When step mode is activated markers are now only drawn at original data points (<a href="https://github.com/ScottPlot/ScottPlot/issues/1896">#1896</a>) <a href="https://github.com/grabul"><strong>@grabul</strong></a>
</li>
<li>SignalConst: Fixed indexing error affecting the Update() overload that accepted generic arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/1895">#1895</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1893">#1893</a>) <a href="https://github.com/strontiumpku"><strong>@strontiumpku</strong></a>
</li>
<li>Scatter and Signal: When <code>StepDisplay</code> is enabled, the new <code>StepDisplayRight</code> property can toggle step orientation (<a href="https://github.com/ScottPlot/ScottPlot/issues/1894">#1894</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1811">#1811</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>SignalXY: Markers now shown in legend when the plot is zoomed-in enough that they become visible on the plot itself
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/jhm-ciberman'>@jhm-ciberman</a>, <a href='https://github.com/grabul'>@grabul</a>, <a href='https://github.com/strontiumpku'>@strontiumpku</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/jhm-ciberman'><img src='https://scottplot.net/images/contributors/jhm-ciberman.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/grabul'><img src='https://scottplot.net/images/contributors/grabul.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/strontiumpku'><img src='https://scottplot.net/images/contributors/strontiumpku.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.48</h1>
<div><i>NuGet packages published 2022-06-09</i></div>
<div class='mt-1'>
<ul>
<li>Plottable: Collapsed <code>IHasAxisLimits</code>, <code>IHasDataValidation</code>, and <code>IHasLegendItems</code> back into <code>IPlottable</code>, reverting a change introduced by the previous version. The intent of the original change was to promote interface segregation (e.g., colorbar has no axis limits). However, the purpose of this reversion is to maintain consistent behavior for users who implemented their own plottables implementing <code>IPlottable</code> and may not be aware of these new interfaces. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1868">#1868</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1881">#1881</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.47</h1>
<div><i>NuGet packages published 2022-06-07</i></div>
<div class='mt-1'>
<ul>
<li>Scatter Plot: New <code>Smooth</code> property allows data points to be connected by smooth lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/1852">#1852</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1853">#1853</a>) <a href="https://github.com/liuhongran626"><strong>@liuhongran626</strong></a>
</li>
<li>Axis: Improved corner notation for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1875">#1875</a>) <a href="https://github.com/nassaleh"><strong>@nassaleh</strong></a>
</li>
<li>Plottable: Optional segregated interfaces <code>IHasAxisLimits</code>, <code>IHasDataValidation</code>, and <code>IHasLegendItems</code> were broken-out of <code>IPlottable</code>. Note that this change was reverted in the subsequent release. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1868">#1868</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1881">#1881</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/liuhongran626'>@liuhongran626</a>, <a href='https://github.com/nassaleh'>@nassaleh</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/liuhongran626'><img src='https://scottplot.net/images/contributors/liuhongran626.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/nassaleh'><img src='https://scottplot.net/images/contributors/nassaleh.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.46</h1>
<div><i>NuGet packages published 2022-06-05</i></div>
<div class='mt-1'>
<ul>
<li>Image: <code>AddImage()</code> has optional arguments to define rotation, scale, and anchor alignment. The <code>Image</code> plot type has new public properties allowing images to be stretched so position and size can be defined using axis units (see Cookbook). <code>Rotation</code> now respects all anchor alignments. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1847">#1847</a>) <a href="https://github.com/wtywtykk"><strong>@wtywtykk</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Bracket: New plot type to highlight a range of data between two points in coordinate space (<a href="https://github.com/ScottPlot/ScottPlot/issues/1863">#1863</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Heatmap: Added <code>FlipVertically</code> property to invert orientation of original data (<a href="https://github.com/ScottPlot/ScottPlot/issues/1866">#1866</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1864">#1864</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/vtozarks"><strong>@vtozarks</strong></a>
</li>
<li>Axis: Improved placement of horizontal axis tick labels when multiple axes are in use (<a href="https://github.com/ScottPlot/ScottPlot/issues/1861">#1861</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1848">#1848</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/Shengcancheng"><strong>@Shengcancheng</strong></a>
</li>
<li>Crosshair: Now included in automatic axis limit detection. Use its <code>IgnoreAxisAuto</code> property to disable this functionality. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1855">#1855</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1857">#1857</a>) <a href="https://github.com/CarloToso"><strong>@CarloToso</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>BarPlot: Improved automatic axis detection for bar plots containing negative values (<a href="https://github.com/ScottPlot/ScottPlot/issues/1855">#1855</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1857">#1857</a>) <a href="https://github.com/CarloToso"><strong>@CarloToso</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>IHittable: new interface to facilitate mouse click and hover hit detection (<a href="https://github.com/ScottPlot/ScottPlot/issues/1845">#1845</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Tooltip: Added logic to enable detection of mouse hover or click (<a href="https://github.com/ScottPlot/ScottPlot/issues/1843">#1843</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1844">#1844</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1845">#1845</a>) <a href="https://github.com/kkaiser41"><strong>@kkaiser41</strong></a>, <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>, and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Controls: All user controls now have a <code>LeftClickedPlottable</code> event that fires when a plottable implementing <code>IHittable</code> was left-clicked
</li>
<li>FormsPlot: Set <code>Configuration.EnablePlotObjectEditor</code> to <code>true</code> to allow users to launch a plot object property editor from the right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/1842">#1842</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1831">#1831</a>) <a href="https://github.com/bradmartin333"><strong>@bradmartin333</strong></a> and <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>BarPlot: Fixed bug where zooming extremely far in would cause large fills to disappear (<a href="https://github.com/ScottPlot/ScottPlot/issues/1849">#1849</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1850">#1850</a>) <a href="https://github.com/ChrisAtVault"><strong>@ChrisAtVault</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/wtywtykk'>@wtywtykk</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/vtozarks'>@vtozarks</a>, <a href='https://github.com/Shengcancheng'>@Shengcancheng</a>, <a href='https://github.com/CarloToso'>@CarloToso</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/kkaiser41'>@kkaiser41</a>, <a href='https://github.com/bradmartin333'>@bradmartin333</a>, <a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/ChrisAtVault'>@ChrisAtVault</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/wtywtykk'><img src='https://scottplot.net/images/contributors/wtywtykk.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/vtozarks'><img src='https://scottplot.net/images/contributors/vtozarks.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Shengcancheng'><img src='https://scottplot.net/images/contributors/shengcancheng.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/CarloToso'><img src='https://scottplot.net/images/contributors/carlotoso.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kkaiser41'><img src='https://scottplot.net/images/contributors/kkaiser41.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bradmartin333'><img src='https://scottplot.net/images/contributors/bradmartin333.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisAtVault'><img src='https://scottplot.net/images/contributors/chrisatvault.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.45</h1>
<div><i>NuGet packages published 2022-05-05</i></div>
<div class='mt-1'>
<ul>
<li>Plottables: Fields converted to properties and setters paired with getters to facilitate binding (<a href="https://github.com/ScottPlot/ScottPlot/issues/1831">#1831</a>) <a href="https://github.com/bradmartin333"><strong>@bradmartin333</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bradmartin333'>@bradmartin333</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bradmartin333'><img src='https://scottplot.net/images/contributors/bradmartin333.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.44</h1>
<div><i>NuGet packages published 2022-05-05</i></div>
<div class='mt-1'>
<ul>
<li>SignalXY: Permit duplicate X values and improve exception messages when invalid X data is loaded (<a href="https://github.com/ScottPlot/ScottPlot/issues/1832">#1832</a>) <a href="https://github.com/Niravk1997"><strong>@Niravk1997</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Niravk1997'>@Niravk1997</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Niravk1997'><img src='https://scottplot.net/images/contributors/niravk1997.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.43</h1>
<div><i>NuGet packages published 2022-05-02</i></div>
<div class='mt-1'>
<ul>
<li>Draggable Scatter Plot: Fixed a bug where horizontal drag limits were applied to the vertical axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/1795">#1795</a>) <a href="https://github.com/m4se"><strong>@m4se</strong></a>
</li>
<li>Plot: Improved support for user-defined ticks when inverted axis mode is enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1826">#1826</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1814">#1814</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Heatmap: Added <code>GetCellIndexes()</code> to return the heatmap data position for a given coordinate (<a href="https://github.com/ScottPlot/ScottPlot/issues/1822">#1822</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1787">#1787</a>) <a href="https://github.com/tonpimenta"><strong>@tonpimenta</strong></a>
</li>
<li>Controls: Added <code>LeftClicked</code> event to customize left-click actions in GUI environments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1822">#1822</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1787">#1787</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/m4se'>@m4se</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/tonpimenta'>@tonpimenta</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/m4se'><img src='https://scottplot.net/images/contributors/m4se.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tonpimenta'><img src='https://scottplot.net/images/contributors/tonpimenta.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.42</h1>
<div><i>NuGet packages published 2022-05-01</i></div>
<div class='mt-1'>
<ul>
<li>SignalXY: Fixed bug causing plots to disappear when displaying partial data containing duplicated X values. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1803">#1803</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1806">#1806</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/bernhardbreuss"><strong>@bernhardbreuss</strong></a>
</li>
<li>SignalXY: X data is no longer required to be ascending when it is first assigned, improving support for plots utilizing min/max render indexing (<a href="https://github.com/ScottPlot/ScottPlot/issues/1771">#1771</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1777">#1777</a>) <a href="https://github.com/bernhardbreuss"><strong>@bernhardbreuss</strong></a>
</li>
<li>Grid: Calling <code>Plot.Grid(onTop: true)</code> will cause grid lines to be drawn on top of plottables (<a href="https://github.com/ScottPlot/ScottPlot/issues/1780">#1780</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1779">#1779</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1773">#1773</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/KATAMANENI"><strong>@KATAMANENI</strong></a>
</li>
<li>FormsPlot: Fixed a bug that caused the default right-click menu to throw an exception when certain types of plottables were present (<a href="https://github.com/ScottPlot/ScottPlot/issues/1791">#1791</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1794">#1794</a>) <a href="https://github.com/ShenxuanLi"><strong>@ShenxuanLi</strong></a>, <a href="https://github.com/MareMare"><strong>@MareMare</strong></a>, and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Avalonia: Improved middle-click-drag zoom-rectangle behavior (<a href="https://github.com/ScottPlot/ScottPlot/issues/1807">#1807</a>) <a href="https://github.com/kivarsen"><strong>@kivarsen</strong></a>
</li>
<li>Avalonia: Improved position of right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/1809">#1809</a>) <a href="https://github.com/kivarsen"><strong>@kivarsen</strong></a>
</li>
<li>Avalonia: Added double-click support which displays benchmark information by default (<a href="https://github.com/ScottPlot/ScottPlot/issues/1810">#1810</a>) <a href="https://github.com/kivarsen"><strong>@kivarsen</strong></a>
</li>
<li>Axis: Improved support for switching between custom tick label format strings and custom formatter functions (<a href="https://github.com/ScottPlot/ScottPlot/issues/1813">#1813</a>) <a href="https://github.com/schifazl"><strong>@schifazl</strong></a>
</li>
<li>Plot: <code>AutomaticTickPositions()</code> can now be used to undo action of <code>ManualTickPositions()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1814">#1814</a>)
</li>
<li>Plot: <code>AutomaticTickPositions()</code> optionally accepts an array of ticks and labels that can be displayed in addition to the automatic ones (<a href="https://github.com/ScottPlot/ScottPlot/issues/1814">#1814</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Signal Plot: Improved low density display when <code>LineStyle</code> is <code>None</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1797">#1797</a>) <a href="https://github.com/nassaleh"><strong>@nassaleh</strong></a>
</li>
<li>FormsPlot: Detached legend now restores initial legend visibility state on close (<a href="https://github.com/ScottPlot/ScottPlot/issues/1804">#1804</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bernhardbreuss'>@bernhardbreuss</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/KATAMANENI'>@KATAMANENI</a>, <a href='https://github.com/ShenxuanLi'>@ShenxuanLi</a>, <a href='https://github.com/MareMare'>@MareMare</a>, <a href='https://github.com/kivarsen'>@kivarsen</a>, <a href='https://github.com/schifazl'>@schifazl</a>, <a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/nassaleh'>@nassaleh</a>, <a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bernhardbreuss'><img src='https://scottplot.net/images/contributors/bernhardbreuss.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KATAMANENI'><img src='https://scottplot.net/images/contributors/katamaneni.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ShenxuanLi'><img src='https://scottplot.net/images/contributors/shenxuanli.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MareMare'><img src='https://scottplot.net/images/contributors/maremare.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kivarsen'><img src='https://scottplot.net/images/contributors/kivarsen.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/schifazl'><img src='https://scottplot.net/images/contributors/schifazl.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/nassaleh'><img src='https://scottplot.net/images/contributors/nassaleh.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.41</h1>
<div><i>NuGet packages published 2022-04-09</i></div>
<div class='mt-1'>
<ul>
<li>Plot: Added <code>Plot.GetImageHTML()</code> to make it easy to display ScottPlot images in .NET Interactive / Jupyter notebooks (<a href="https://github.com/ScottPlot/ScottPlot/issues/1772">#1772</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/Regenhardt"><strong>@Regenhardt</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/Regenhardt'>@Regenhardt</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Regenhardt'><img src='https://scottplot.net/images/contributors/regenhardt.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.40</h1>
<div><i>NuGet packages published 2022-04-07</i></div>
<div class='mt-1'>
<ul>
<li>SignalPlotXY: Improved support for custom markers (<a href="https://github.com/ScottPlot/ScottPlot/issues/1763">#1763</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1764">#1764</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/ChrisCC6"><strong>@ChrisCC6</strong></a>
</li>
<li>Legend: <code>Plot.Legend()</code> accepts a nullable <code>Location</code> so legends can be enabled/disabled without changing position (<a href="https://github.com/ScottPlot/ScottPlot/issues/1765">#1765</a>) <a href="https://github.com/envine"><strong>@envine</strong></a>
</li>
<li>FormsPlot: The right-click menu now shows &quot;detach legend&quot; even if all plottable items with legends are set to invisible (<a href="https://github.com/ScottPlot/ScottPlot/issues/1765">#1765</a>) <a href="https://github.com/envine"><strong>@envine</strong></a>
</li>
<li>AxisLine: Added a <code>PositionLabelAxis</code> field that can be used to define a specific axis to draw the position label on in multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1766">#1766</a>) <a href="https://github.com/fuxinsen"><strong>@fuxinsen</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/ChrisCC6'>@ChrisCC6</a>, <a href='https://github.com/envine'>@envine</a>, <a href='https://github.com/fuxinsen'>@fuxinsen</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisCC6'><img src='https://scottplot.net/images/contributors/chriscc6.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/envine'><img src='https://scottplot.net/images/contributors/envine.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/fuxinsen'><img src='https://scottplot.net/images/contributors/fuxinsen.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.39</h1>
<div><i>NuGet packages published 2022-04-01</i></div>
<div class='mt-1'>
<ul>
<li>SignalPlotXY: Fixed bug where <code>GetPointNearestX()</code> did not check proximity to the final point (<a href="https://github.com/ScottPlot/ScottPlot/issues/1757">#1757</a>) <a href="https://github.com/MareMare"><strong>@MareMare</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/MareMare'>@MareMare</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/MareMare'><img src='https://scottplot.net/images/contributors/maremare.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.38</h1>
<div><i>NuGet packages published 2022-03-31</i></div>
<div class='mt-1'>
<ul>
<li>Bar plot: Improved automatic axis limit detection for bars with negative offset (<a href="https://github.com/ScottPlot/ScottPlot/issues/1750">#1750</a>) <a href="https://github.com/painstgithub"><strong>@painstgithub</strong></a>
</li>
<li>Axis labels: Added a <code>rotation</code> argument to <code>Axis.LabelStyle()</code> to support flipping label orientation (<a href="https://github.com/ScottPlot/ScottPlot/issues/1754">#1754</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1194">#1194</a>) <a href="https://github.com/zeticabrian"><strong>@zeticabrian</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/painstgithub'>@painstgithub</a>, <a href='https://github.com/zeticabrian'>@zeticabrian</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/painstgithub'><img src='https://scottplot.net/images/contributors/painstgithub.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/zeticabrian'><img src='https://scottplot.net/images/contributors/zeticabrian.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.37</h1>
<div><i>NuGet packages published 2022-03-25</i></div>
<div class='mt-1'>
<ul>
<li>Controls: Improved multi-axis support for mouse tracking by giving <code>GetMouseCoordinates()</code> optional axis index arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1743">#1743</a>) <a href="https://github.com/kv-gits"><strong>@kv-gits</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/kv-gits'>@kv-gits</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/kv-gits'><img src='https://scottplot.net/images/contributors/kv-gits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.36</h1>
<div><i>NuGet packages published 2022-03-19</i></div>
<div class='mt-1'>
<ul>
<li>Axis: Allow grid line and tick mark pixel snapping to be disabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1721">#1721</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1722">#1722</a>) <a href="https://github.com/Xerxes004"><strong>@Xerxes004</strong></a>
</li>
<li>Axis: <code>ResetLayout()</code> sets padding to original values to reverse changes made by adding colorbars (<a href="https://github.com/ScottPlot/ScottPlot/issues/1732">#1732</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1736">#1736</a>) <a href="https://github.com/ccopsey"><strong>@ccopsey</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Xerxes004'>@Xerxes004</a>, <a href='https://github.com/ccopsey'>@ccopsey</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Xerxes004'><img src='https://scottplot.net/images/contributors/xerxes004.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ccopsey'><img src='https://scottplot.net/images/contributors/ccopsey.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.35</h1>
<div><i>NuGet packages published 2022-03-06</i></div>
<div class='mt-1'>
<ul>
<li>Eto.Forms: Improved handling of events (<a href="https://github.com/ScottPlot/ScottPlot/issues/1719">#1719</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1718">#1718</a>) <a href="https://github.com/rafntor"><strong>@rafntor</strong></a> and <a href="https://github.com/VPKSoft"><strong>@VPKSoft</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/rafntor'>@rafntor</a>, <a href='https://github.com/VPKSoft'>@VPKSoft</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/rafntor'><img src='https://scottplot.net/images/contributors/rafntor.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/VPKSoft'><img src='https://scottplot.net/images/contributors/vpksoft.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.34</h1>
<div><i>NuGet packages published 2022-03-03</i></div>
<div class='mt-1'>
<ul>
<li>Bubble plot: Added methods to get the point nearest the cursor (<a href="https://github.com/ScottPlot/ScottPlot/issues/1657">#1657</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1652">#1652</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1705">#1705</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>, <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>, and <a href="https://github.com/adgriff2"><strong>@adgriff2</strong></a>
</li>
<li>Markers: Improved alignment of markers and lines on Linux and MacOS by half a pixel (<a href="https://github.com/ScottPlot/ScottPlot/issues/1660">#1660</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/340">#340</a>)
</li>
<li>Plottable: Added <code>IsHighlighted</code> properties to make some plot types bold (<a href="https://github.com/ScottPlot/ScottPlot/issues/1660">#1660</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Plottable: Segregated existing functionality interfaces for <code>IHasLine</code>, <code>IHasMarker</code>, and <code>IHilightable</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1660">#1660</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Plot: <code>AxisAuto()</code> now throws an exception of margins are defined outside the allowable range (<a href="https://github.com/ScottPlot/ScottPlot/issues/450">#450</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1682">#1682</a>) <a href="https://github.com/xichaoqiang"><strong>@xichaoqiang</strong></a>
</li>
<li>Plot: Added <code>PlotFillRightLeft</code> method for adding horizontal filled scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/450">#450</a>) <a href="https://github.com/xichaoqiang"><strong>@xichaoqiang</strong></a>
</li>
<li>Markers: All shapes are now drawn discretely instead of relying on text rendering for improved performance and consistency (<a href="https://github.com/ScottPlot/ScottPlot/issues/1668">#1668</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1660">#1660</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Scatter Plot: Support distinct <code>LineColor</code> and <code>MarkerColor</code> colors (<a href="https://github.com/ScottPlot/ScottPlot/issues/1668">#1668</a>)
</li>
<li>SignalXY: Fix bug affecting the edge of the plot when step mode is active (<a href="https://github.com/ScottPlot/ScottPlot/issues/1703">#1703</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1699">#1699</a>) <a href="https://github.com/PeppermintKing"><strong>@PeppermintKing</strong></a>
</li>
<li>SignalXY: Improve appearance of filled regions when step mode is active (<a href="https://github.com/ScottPlot/ScottPlot/issues/1703">#1703</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1697">#1697</a>) <a href="https://github.com/PeppermintKing"><strong>@PeppermintKing</strong></a>
</li>
<li>Axis Span: Added options to customize fill pattern and border (<a href="https://github.com/ScottPlot/ScottPlot/issues/1692">#1692</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Markers: Additional customization options such as <code>MarkerLineWidth</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1690">#1690</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Legend Viewer: New functionality to customize line, marker, and highlight options have been added to the the right-click menu of the Windows Forms control (<a href="https://github.com/ScottPlot/ScottPlot/issues/1655">#1655</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1651">#1651</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/Maoyao233'>@Maoyao233</a>, <a href='https://github.com/adgriff2'>@adgriff2</a>, <a href='https://github.com/xichaoqiang'>@xichaoqiang</a>, <a href='https://github.com/PeppermintKing'>@PeppermintKing</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Maoyao233'><img src='https://scottplot.net/images/contributors/maoyao233.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/adgriff2'><img src='https://scottplot.net/images/contributors/adgriff2.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xichaoqiang'><img src='https://scottplot.net/images/contributors/xichaoqiang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PeppermintKing'><img src='https://scottplot.net/images/contributors/peppermintking.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.33</h1>
<div><i>NuGet packages published 2022-02-04</i></div>
<div class='mt-1'>
<ul>
<li>Spline Interpolation: Added new methods for data smoothing including Bézier interpolation (<a href="https://github.com/ScottPlot/ScottPlot/issues/1593">#1593</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1606">#1606</a>)
</li>
<li>Detachable Legend: Added an option to detach the legend to the right-click menu in the Windows Forms control. Clicking items in the detached legend toggles their visibility on the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/1589">#1589</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1573">#1573</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1326">#1326</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Marker: Added an optional <code>Text</code> (and <code>TextFont</code>) for displaying a message that moves with a marker (<a href="https://github.com/ScottPlot/ScottPlot/issues/1599">#1599</a>)
</li>
<li>Heatmap: Heatmaps with custom X and Y sizing or positioning no longer call <code>AxisScaleLock()</code> automatically (<a href="https://github.com/ScottPlot/ScottPlot/issues/1145">#1145</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axis: GetCoordinateY() now returns more accurate coordinate (<a href="https://github.com/ScottPlot/ScottPlot/issues/1625">#1625</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1616">#1616</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Text: Now has <code>IsDraggable</code> field and improved mouseover detection that supports rotation (<a href="https://github.com/ScottPlot/ScottPlot/issues/1616">#1616</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1599">#1599</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a> and <a href="https://github.com/Niravk1997"><strong>@Niravk1997</strong></a>
</li>
<li>Plot: <code>Frameless()</code> no longer results in an image with a 3 pixel transparent border (<a href="https://github.com/ScottPlot/ScottPlot/issues/1571">#1571</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1605">#1605</a>) <a href="https://github.com/sjlai1993"><strong>@sjlai1993</strong></a>
</li>
<li>Colorbar: <code>AddColorbar()</code> has new optional argument to enable placement on the left side of the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/1524">#1524</a>) <a href="https://github.com/Niravk1997"><strong>@Niravk1997</strong></a>
</li>
<li>Heatmap: Fixed bug affecting manually-scaled heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/1485">#1485</a>) <a href="https://github.com/ZPYin"><strong>@ZPYin</strong></a>, <a href="https://github.com/mYcheng-95"><strong>@mYcheng-95</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Colorbar: Exposed <code>DataAreaPadding</code> to improve layout customization for multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1637">#1637</a>) <a href="https://github.com/ccopsey"><strong>@ccopsey</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Niravk1997'>@Niravk1997</a>, <a href='https://github.com/sjlai1993'>@sjlai1993</a>, <a href='https://github.com/ZPYin'>@ZPYin</a>, <a href='https://github.com/mYcheng-95'>@mYcheng-95</a>, <a href='https://github.com/ccopsey'>@ccopsey</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Niravk1997'><img src='https://scottplot.net/images/contributors/niravk1997.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/sjlai1993'><img src='https://scottplot.net/images/contributors/sjlai1993.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ZPYin'><img src='https://scottplot.net/images/contributors/zpyin.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mYcheng-95'><img src='https://scottplot.net/images/contributors/mycheng-95.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ccopsey'><img src='https://scottplot.net/images/contributors/ccopsey.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.32</h1>
<div><i>NuGet packages published 2022-01-23</i></div>
<div class='mt-1'>
<ul>
<li>Interpolation: New cubic interpolation module with improved stability and simplified API (<a href="https://github.com/ScottPlot/ScottPlot/issues/1433">#1433</a>) <a href="https://github.com/allopatin"><strong>@allopatin</strong></a>
</li>
<li>Legend: <code>GetBitmap()</code> returns a transparent image instead of throwing an exception if there are no items in the legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/1578">#1578</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Legend: Added <code>Count</code>, <code>HasItems</code>, and <code>GetItems()</code> so users can inspect legend contents to if/how they want to display it (<a href="https://github.com/ScottPlot/ScottPlot/issues/1578">#1578</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Plot: Exposed <code>GetDraggable()</code> to allow users to retrieve the plotted objects at specific pixel positions (<a href="https://github.com/ScottPlot/ScottPlot/issues/1578">#1578</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Axis Limits: Improved handling of axis limits for plots containing no data (<a href="https://github.com/ScottPlot/ScottPlot/issues/1581">#1581</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Repeating Axis Line: Improved display of text labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/1586">#1586</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1557">#1557</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Axis: Improved multi-axis support for <code>GetPixel()</code> methods (<a href="https://github.com/ScottPlot/ScottPlot/issues/1584">#1584</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1587">#1587</a>) <a href="https://github.com/ChrisCC6"><strong>@ChrisCC6</strong></a> and <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Error Bar: <code>Plot.AddErrorBars()</code> can now be used to place 1D or 2D error bars anywhere on the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/1466">#1466</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1588">#1588</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Scatter Plot List: Added generic support to <code>ScatterPlotList&lt;T&gt;</code> as demonstrated in the cookbook (<a href="https://github.com/ScottPlot/ScottPlot/issues/1463">#1463</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1592">#1592</a>) <a href="https://github.com/tyrbentsen"><strong>@tyrbentsen</strong></a>
</li>
<li>Draggable Scatter Plot: Created a new <code>ScatterPlotListDraggable</code> that supports dragging points and custom clamp logic as seen in the cookbook (<a href="https://github.com/ScottPlot/ScottPlot/issues/1422">#1422</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a> and <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Axis: Users may now customize the number of minor ticks and grid lines when log scale is enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1594">#1594</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1595">#1595</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1583">#1583</a>) <a href="https://github.com/hibus"><strong>@hibus</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/allopatin'>@allopatin</a>, <a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/ChrisCC6'>@ChrisCC6</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/tyrbentsen'>@tyrbentsen</a>, <a href='https://github.com/hibus'>@hibus</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/allopatin'><img src='https://scottplot.net/images/contributors/allopatin.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisCC6'><img src='https://scottplot.net/images/contributors/chriscc6.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tyrbentsen'><img src='https://scottplot.net/images/contributors/tyrbentsen.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/hibus'><img src='https://scottplot.net/images/contributors/hibus.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.31</h1>
<div><i>NuGet packages published 2022-01-17</i></div>
<div class='mt-1'>
<ul>
<li>MultiAxis: Improved support for draggable items placed on non-primary axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1556">#1556</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1545">#1545</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>RepeatingAxisLine: New plot types <code>RepeatingVLine</code> and <code>RepeatingHLine</code> show a primary line and a user-defined number of harmonics. See cookbook for example and usage notes. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1535">#1535</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1775">#1775</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Scatter: The new <code>ScatterPlotDraggable</code> plot type is for creating scatter plots with mouse-draggable points (<a href="https://github.com/ScottPlot/ScottPlot/issues/1560">#1560</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1422">#1422</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a> and <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Controls: Improved middle-click-drag zoom rectangle support for plots with multiple axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1559">#1559</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1537">#1537</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Marker: New plot types <code>DraggableMarkerPlot</code> and <code>DraggableMarkerPlotInVector</code> give users options to add mouse-interactive markers to plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1558">#1558</a>) <a href="https://github.com/BambOoxX"><strong>@BambOoxX</strong></a>
</li>
<li>Bar Plot: New <code>ValueFormatter</code> option allows users to customize the text displayed above bars (<a href="https://github.com/ScottPlot/ScottPlot/issues/1542">#1542</a>) <a href="https://github.com/jankri"><strong>@jankri</strong></a>
</li>
<li>Plot: <code>Title()</code> now has additional arguments for customizing text above the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/1564">#1564</a>)Hendri
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/BambOoxX'>@BambOoxX</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/jankri'>@jankri</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/BambOoxX'><img src='https://scottplot.net/images/contributors/bambooxx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jankri'><img src='https://scottplot.net/images/contributors/jankri.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.30</h1>
<div><i>NuGet packages published 2022-01-15</i></div>
<div class='mt-1'>
<ul>
<li>Plot: Improve values returned by <code>GetDataLimits()</code> when axis lines and spans are in use (<a href="https://github.com/ScottPlot/ScottPlot/issues/1415">#1415</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1505">#1505</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1532">#1532</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Rendering: Revert default text hinting from ClearType back to AntiAliased to improve text appearance on transparent backgrounds. Users may call <code>ScottPlot.Drawing.GDI.ClearType(true)</code> to opt-in to ClearType rendering which is superior for most situations. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1553">#1553</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1550">#1550</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1528">#1528</a>) <a href="https://github.com/r84r"><strong>@r84r</strong></a>, <a href="https://github.com/wangyexiang"><strong>@wangyexiang</strong></a>, <a href="https://github.com/Elgot"><strong>@Elgot</strong></a>, <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>, and <a href="https://github.com/saklanmazozgur"><strong>@saklanmazozgur</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/r84r'>@r84r</a>, <a href='https://github.com/wangyexiang'>@wangyexiang</a>, <a href='https://github.com/Elgot'>@Elgot</a>, <a href='https://github.com/saklanmazozgur'>@saklanmazozgur</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/r84r'><img src='https://scottplot.net/images/contributors/r84r.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/wangyexiang'><img src='https://scottplot.net/images/contributors/wangyexiang.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Elgot'><img src='https://scottplot.net/images/contributors/elgot.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/saklanmazozgur'><img src='https://scottplot.net/images/contributors/saklanmazozgur.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.29</h1>
<div><i>NuGet packages published 2022-01-02</i></div>
<div class='mt-1'>
<ul>
<li>WinForms Control: Improve ClearType text rendering by no longer defaulting to a transparent control background color (<a href="https://github.com/ScottPlot/ScottPlot/issues/1496">#1496</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.28</h1>
<div><i>NuGet packages published 2022-01-01</i></div>
<div class='mt-1'>
<ul>
<li>Eto Control: New ScottPlot control for the Eto GUI framework (<a href="https://github.com/ScottPlot/ScottPlot/issues/1425">#1425</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1438">#1438</a>) <a href="https://github.com/rafntor"><strong>@rafntor</strong></a>
</li>
<li>Radar Plot: <code>OutlineWidth</code> now allows customization of the line around radar plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1426">#1426</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1277">#1277</a>) <a href="https://github.com/Rayffer"><strong>@Rayffer</strong></a>
</li>
<li>Ticks: Improved minor tick and minor grid line placement (<a href="https://github.com/ScottPlot/ScottPlot/issues/1420">#1420</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1421">#1421</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Palette: Added Amber and Nero palettes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1411">#1411</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1412">#1412</a>) <a href="https://github.com/gauravagrwal"><strong>@gauravagrwal</strong></a>
</li>
<li>Style: Hazel style (<a href="https://github.com/ScottPlot/ScottPlot/issues/1414">#1414</a>) <a href="https://github.com/gauravagrwal"><strong>@gauravagrwal</strong></a>
</li>
<li>MarkerPlot: Improved data area clipping (<a href="https://github.com/ScottPlot/ScottPlot/issues/1423">#1423</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1459">#1459</a>) <a href="https://github.com/PremekTill"><strong>@PremekTill</strong></a>, <a href="https://github.com/lucabat"><strong>@lucabat</strong></a>, and <a href="https://github.com/AndXaf"><strong>@AndXaf</strong></a>
</li>
<li>MarkerPlot: Improved key in legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/1459">#1459</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1454">#1454</a>) <a href="https://github.com/PremekTill"><strong>@PremekTill</strong></a> and <a href="https://github.com/Logicman111"><strong>@Logicman111</strong></a>
</li>
<li>Style: Plottables that implement <code>IStylable</code> are now styled when <code>Plot.Style()</code> is called. Styles are now improved for <code>ScaleBar</code> and <code>Colorbar</code> plot types. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1451">#1451</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1447">#1447</a>) <a href="https://github.com/diluculo"><strong>@diluculo</strong></a>
</li>
<li>Population plot: Population plots <code>DataFormat</code> now have a <code>DataFormat</code> member that displays individual data points on top of a bar graph representing their mean and variance (<a href="https://github.com/ScottPlot/ScottPlot/issues/1440">#1440</a>) Thanks <a href="https://github.com/Syntaxrabbit"><strong>@Syntaxrabbit</strong></a>
</li>
<li>SignalXY: Fixed bug affecting filled plots with zero area (<a href="https://github.com/ScottPlot/ScottPlot/issues/1476">#1476</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1477">#1477</a>) <a href="https://github.com/chenxuuu"><strong>@chenxuuu</strong></a>
</li>
<li>Cookbook: Added example showing how to place markers colored according to a colormap displayed in a colorbar (<a href="https://github.com/ScottPlot/ScottPlot/issues/1461">#1461</a>) <a href="https://github.com/obnews"><strong>@obnews</strong></a>
</li>
<li>Ticks: Added option to invert tick mark direction (<a href="https://github.com/ScottPlot/ScottPlot/issues/1489">#1489</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1475">#1475</a>) <a href="https://github.com/wangyexiang"><strong>@wangyexiang</strong></a>
</li>
<li>FormsPlot: Improved support for WinForms 6 (<a href="https://github.com/ScottPlot/ScottPlot/issues/1430">#1430</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1483">#1483</a>) <a href="https://github.com/SuperDaveOsbourne"><strong>@SuperDaveOsbourne</strong></a>
</li>
<li>Axes: Fixed bug where <code>AxisAuto()</code> failed to adjust all axes in multi-axis plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1497">#1497</a>) <a href="https://github.com/Niravk1997"><strong>@Niravk1997</strong></a>
</li>
<li>Radial Gauge Plot: Fixed bug affecting rendering of extremely small gauge angles (<a href="https://github.com/ScottPlot/ScottPlot/issues/1492">#1492</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1474">#1474</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Text plot and arrow plot: Now have <code>PixelOffsetX</code> and <code>PixelOffsetY</code> to facilitate small adjustments at render time (<a href="https://github.com/ScottPlot/ScottPlot/issues/1392">#1392</a>)
</li>
<li>Image: New <code>Scale</code> property allows customization of image size (<a href="https://github.com/ScottPlot/ScottPlot/issues/1406">#1406</a>)
</li>
<li>Axis: <code>Plot.GetDataLimits()</code> returns the boundaries of all data from all visible plottables regardless of the current axis limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/1415">#1415</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Rendering: Improved support for scaled plots when passing scale as a <code>Plot.Render()</code> argument (<a href="https://github.com/ScottPlot/ScottPlot/issues/1416">#1416</a>) <a href="https://github.com/Andreas"><strong>@Andreas</strong></a>
</li>
<li>Text: Improved support for rotated text and background fills using custom alignments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1417">#1417</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1516">#1516</a>) <a href="https://github.com/riquich"><strong>@riquich</strong></a> and <a href="https://github.com/AndXaf"><strong>@AndXaf</strong></a>
</li>
<li>Text: Added options for custom borders (<a href="https://github.com/ScottPlot/ScottPlot/issues/1417">#1417</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1516">#1516</a>) <a href="https://github.com/AndXaf"><strong>@AndXaf</strong></a> and <a href="https://github.com/MachineFossil"><strong>@MachineFossil</strong></a>
</li>
<li>Plot: New <code>RemoveAxis()</code> method allows users to remove axes placed by <code>AddAxis()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1458">#1458</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
<li>Benchmark: <code>Plot.BenchmarkTimes()</code> now returns an array of recent frame render times (<a href="https://github.com/ScottPlot/ScottPlot/issues/1493">#1493</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1491">#1491</a>) <a href="https://github.com/anose001"><strong>@anose001</strong></a>
</li>
<li>Ticks: Disabling log-scaled minor ticks now disables tick label integer rounding (<a href="https://github.com/ScottPlot/ScottPlot/issues/1419">#1419</a>) <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Rendering: Improve appearance of text by defaulting to ClearType font rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/1496">#1496</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/823">#823</a>) <a href="https://github.com/Elgot"><strong>@Elgot</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/rafntor'>@rafntor</a>, <a href='https://github.com/Rayffer'>@Rayffer</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/gauravagrwal'>@gauravagrwal</a>, <a href='https://github.com/PremekTill'>@PremekTill</a>, <a href='https://github.com/lucabat'>@lucabat</a>, <a href='https://github.com/AndXaf'>@AndXaf</a>, <a href='https://github.com/Logicman111'>@Logicman111</a>, <a href='https://github.com/diluculo'>@diluculo</a>, <a href='https://github.com/Syntaxrabbit'>@Syntaxrabbit</a>, <a href='https://github.com/chenxuuu'>@chenxuuu</a>, <a href='https://github.com/obnews'>@obnews</a>, <a href='https://github.com/wangyexiang'>@wangyexiang</a>, <a href='https://github.com/SuperDaveOsbourne'>@SuperDaveOsbourne</a>, <a href='https://github.com/Niravk1997'>@Niravk1997</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/Andreas'>@Andreas</a>, <a href='https://github.com/riquich'>@riquich</a>, <a href='https://github.com/MachineFossil'>@MachineFossil</a>, <a href='https://github.com/gobikulandaisamy'>@gobikulandaisamy</a>, <a href='https://github.com/anose001'>@anose001</a>, <a href='https://github.com/Elgot'>@Elgot</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/rafntor'><img src='https://scottplot.net/images/contributors/rafntor.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Rayffer'><img src='https://scottplot.net/images/contributors/rayffer.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gauravagrwal'><img src='https://scottplot.net/images/contributors/gauravagrwal.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PremekTill'><img src='https://scottplot.net/images/contributors/premektill.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/lucabat'><img src='https://scottplot.net/images/contributors/lucabat.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AndXaf'><img src='https://scottplot.net/images/contributors/andxaf.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Logicman111'><img src='https://scottplot.net/images/contributors/logicman111.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/diluculo'><img src='https://scottplot.net/images/contributors/diluculo.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Syntaxrabbit'><img src='https://scottplot.net/images/contributors/syntaxrabbit.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/chenxuuu'><img src='https://scottplot.net/images/contributors/chenxuuu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/obnews'><img src='https://scottplot.net/images/contributors/obnews.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/wangyexiang'><img src='https://scottplot.net/images/contributors/wangyexiang.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SuperDaveOsbourne'><img src='https://scottplot.net/images/contributors/superdaveosbourne.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Niravk1997'><img src='https://scottplot.net/images/contributors/niravk1997.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Andreas'><img src='https://scottplot.net/images/contributors/andreas.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/riquich'><img src='https://scottplot.net/images/contributors/riquich.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MachineFossil'><img src='https://scottplot.net/images/contributors/machinefossil.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gobikulandaisamy'><img src='https://scottplot.net/images/contributors/gobikulandaisamy.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/anose001'><img src='https://scottplot.net/images/contributors/anose001.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Elgot'><img src='https://scottplot.net/images/contributors/elgot.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.27</h1>
<div><i>NuGet packages published 2021-10-24</i></div>
<div class='mt-1'>
<ul>
<li>Colorbar: Exposed fields for additional tick line and tick label customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/1360">#1360</a>) <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>
</li>
<li>Plot: Improved <code>AxisAutoY()</code> margins (<a href="https://github.com/ScottPlot/ScottPlot/issues/1363">#1363</a>) <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>
</li>
<li>Radar Plot: <code>LineWidth</code> may now be customized (<a href="https://github.com/ScottPlot/ScottPlot/issues/1277">#1277</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1369">#1369</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Controls: Stretching due to display scaling can be disabled with <code>Configuration.DpiStretch</code> in WPF and Avalonia controls (<a href="https://github.com/ScottPlot/ScottPlot/issues/1352">#1352</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1364">#1364</a>) <a href="https://github.com/ktheijs"><strong>@ktheijs</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axes: Improved support for log-distributed minor tick and grid lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/1386">#1386</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1393">#1393</a>) <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Axes: <code>GetTicks()</code> can be used to get the tick positions and labels from the previous render
</li>
<li>WPF Control: Improved responsiveness while dragging with the mouse to pan or zoom (<a href="https://github.com/ScottPlot/ScottPlot/issues/1387">#1387</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1388">#1388</a>) <a href="https://github.com/jbuckmccready"><strong>@jbuckmccready</strong></a>
</li>
<li>Layout: <code>MatchLayout()</code> has improved alignment for plots containing colorbars (<a href="https://github.com/ScottPlot/ScottPlot/issues/1338">#1338</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1349">#1349</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1351">#1351</a>) <a href="https://github.com/dhgigisoave"><strong>@dhgigisoave</strong></a>
</li>
<li>Axes: Added multi-axis support for <code>SetInnerViewLimits()</code> and <code>SetOuterViewLimits()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1357">#1357</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1361">#1361</a>) <a href="https://github.com/saroldhand"><strong>@saroldhand</strong></a>
</li>
<li>Axes: Created simplified overloads for <code>AxisAuto()</code> and <code>Margins()</code> that lack multi-axis arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1367">#1367</a>) <a href="https://github.com/cdytoby"><strong>@cdytoby</strong></a>
</li>
<li>Signal Plot: <code>FillAbove()</code>, <code>FillBelow()</code>, and <code>FillAboveAndBelow()</code> methods have been added to simplify configuration and reduce run-time errors. Direct access to fill-related fields has been deprecated. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1401">#1401</a>)
</li>
<li>Plot: <code>AddFill()</code> now has an overload to fill between two Y curves with shared X values
</li>
<li>Palette: Made all <code>Palette</code> classes public (<a href="https://github.com/ScottPlot/ScottPlot/issues/1394">#1394</a>) <a href="https://github.com/Terebi42"><strong>@Terebi42</strong></a>
</li>
<li>Colorbar: Added <code>AutomaticTicks()</code> to let the user further customize tick positions and labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/1403">#1403</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1362">#1362</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Heatmap: Improved support for automatic tick placement in colorbars (<a href="https://github.com/ScottPlot/ScottPlot/issues/1403">#1403</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1362">#1362</a>)
</li>
<li>Heatmap: Added <code>XMin</code>, <code>XMax</code>, <code>YMin</code>, and <code>YMax</code> to help configure placement and edge alignment (<a href="https://github.com/ScottPlot/ScottPlot/issues/1405">#1405</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Coordinated Heatmap: This plot type has been deprecated now that the special functionality it provided is present in the standard <code>Heatmap</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1405">#1405</a>)
</li>
<li>Marker: Created a new <code>Marker</code> class to simplify the marker API. Currently it is a pass-through for <code>MarkerShape</code> enumeration members.
</li>
<li>Plot: <code>AddMarker()</code> makes it easy to place a styled marker at an X/Y position on the plot. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1391">#1391</a>)
</li>
<li>Plottable: <code>AddPoint()</code> now returns a <code>MarkerPlot</code> rather than a <code>ScatterPlot</code> with a single point (<a href="https://github.com/ScottPlot/ScottPlot/issues/1407">#1407</a>)
</li>
<li>Axis lines: Added <code>Min</code> and <code>Max</code> properties to terminate the line at a finite point (<a href="https://github.com/ScottPlot/ScottPlot/issues/1390">#1390</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1399">#1399</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Maoyao233'>@Maoyao233</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/ktheijs'>@ktheijs</a>, <a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/jbuckmccready'>@jbuckmccready</a>, <a href='https://github.com/dhgigisoave'>@dhgigisoave</a>, <a href='https://github.com/saroldhand'>@saroldhand</a>, <a href='https://github.com/cdytoby'>@cdytoby</a>, <a href='https://github.com/Terebi42'>@Terebi42</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Maoyao233'><img src='https://scottplot.net/images/contributors/maoyao233.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ktheijs'><img src='https://scottplot.net/images/contributors/ktheijs.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jbuckmccready'><img src='https://scottplot.net/images/contributors/jbuckmccready.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/dhgigisoave'><img src='https://scottplot.net/images/contributors/dhgigisoave.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/saroldhand'><img src='https://scottplot.net/images/contributors/saroldhand.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cdytoby'><img src='https://scottplot.net/images/contributors/cdytoby.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Terebi42'><img src='https://scottplot.net/images/contributors/terebi42.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.26</h1>
<div><i>NuGet packages published 2021-10-12</i></div>
<div class='mt-1'>
<ul>
<li>SignalPlotYX: Improve support for step display (<a href="https://github.com/ScottPlot/ScottPlot/issues/1342">#1342</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Heatmap: Improve automatic axis limit detection (<a href="https://github.com/ScottPlot/ScottPlot/issues/1278">#1278</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot: Added <code>Margins()</code> to set default margins to use when <code>AxisAuto()</code> is called without arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1345">#1345</a>)
</li>
<li>Heatmap: Deprecated <code>ShowAxisLabels</code> in favor of tight margins (see cookbook) (<a href="https://github.com/ScottPlot/ScottPlot/issues/1278">#1278</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Histogram: Fixed bug affecting binning of values at the upper edge of the final bin (<a href="https://github.com/ScottPlot/ScottPlot/issues/1348">#1348</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1350">#1350</a>) <a href="https://github.com/jw-suh"><strong>@jw-suh</strong></a>
</li>
<li>NuGet: Packages have improved debug experience with SourceLink and snupkg format symbols (<a href="https://github.com/ScottPlot/ScottPlot/issues/1285">#1285</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/jw-suh'>@jw-suh</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jw-suh'><img src='https://scottplot.net/images/contributors/jw-suh.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.25</h1>
<div><i>NuGet packages published 2021-10-06</i></div>
<div class='mt-1'>
<ul>
<li>Palette: <code>ScottPlot.Palette</code> has been created and cookbook recipes have been updated to use it. The module it replaces (<code>ScottPlot.Drawing.Palette</code>) will not be marked obsolete until ScottPlot 5. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1299">#1299</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1304">#1304</a>)
</li>
<li>Style: Refactored to use static classes instead of enumeration members (<a href="https://github.com/ScottPlot/ScottPlot/issues/1299">#1299</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1291">#1291</a>)
</li>
<li>NuGet: Improved System.Drawing.Common dependencies in user control packages (<a href="https://github.com/ScottPlot/ScottPlot/issues/1311">#1311</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1310">#1310</a>) <a href="https://github.com/Kritner"><strong>@Kritner</strong></a>
</li>
<li>Avalonia Control: Now targets .NET 5 (<a href="https://github.com/ScottPlot/ScottPlot/issues/1306">#1306</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1309">#1309</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot: Fixed bug causing <code>GetPixel()</code> to return incorrect values for some axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1329">#1329</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1330">#1330</a>) <a href="https://github.com/riquich"><strong>@riquich</strong></a>
</li>
<li>New Palettes:
</li>
<li>New Styles:
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Kritner'>@Kritner</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/riquich'>@riquich</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Kritner'><img src='https://scottplot.net/images/contributors/kritner.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/riquich'><img src='https://scottplot.net/images/contributors/riquich.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.23</h1>
<div><i>NuGet packages published 2021-09-26</i></div>
<div class='mt-1'>
<ul>
<li>NuGet: use deterministic builds, add source link support, and include compiler flags (<a href="https://github.com/ScottPlot/ScottPlot/issues/1285">#1285</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.22</h1>
<div><i>NuGet packages published 2021-09-26</i></div>
<div class='mt-1'>
<ul>
<li>Coxcomb Plots: Added support for image labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/1265">#1265</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1275">#1275</a>) <a href="https://github.com/Rayffer"><strong>@Rayffer</strong></a>
</li>
<li>Palette: Added overloads for <code>GetColor()</code> and <code>GetColors()</code> to support transparency
</li>
<li>Plot Viewer: fixed bug causing render warning to appear in WinForms and Avalonia plot viewers (<a href="https://github.com/ScottPlot/ScottPlot/issues/1265">#1265</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1238">#1238</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>, <a href="https://github.com/Nexus452"><strong>@Nexus452</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Rayffer'>@Rayffer</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/Nexus452'>@Nexus452</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Rayffer'><img src='https://scottplot.net/images/contributors/rayffer.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Nexus452'><img src='https://scottplot.net/images/contributors/nexus452.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.21</h1>
<div><i>NuGet packages published 2021-09-18</i></div>
<div class='mt-1'>
<ul>
<li>Legend: Throw an exception if <code>RenderLegend()</code> is called on a plot with no labeled plottables (<a href="https://github.com/ScottPlot/ScottPlot/issues/1257">#1257</a>)
</li>
<li>Radar: Improved support for category labels. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1261">#1261</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1262">#1262</a>) <a href="https://github.com/Rayffer"><strong>@Rayffer</strong></a>
</li>
<li>Controls: Now have a <code>Refresh()</code> method as an alias of <code>Render()</code> for manually redrawing the plot and updating the image on the screen. Using <code>Render()</code> in user controls is more similar to similar plotting libraries and less likely to be confused with <code>Plot.Render()</code> in documentation and warning messages. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1264">#1264</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1270">#1270</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1263">#1263</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1245">#1245</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1165">#1165</a>)
</li>
<li>Controls: Decreased visibility of the render warning (introduced in ScottPlot 4.1.19) by allowing it only to appear when the debugger is attached (<a href="https://github.com/ScottPlot/ScottPlot/issues/1165">#1165</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1264">#1264</a>)
</li>
<li>Radial Gaugue Plot: Fixed divide-by-zero bug affecting normalized gauges (<a href="https://github.com/ScottPlot/ScottPlot/issues/1272">#1272</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Rayffer'>@Rayffer</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Rayffer'><img src='https://scottplot.net/images/contributors/rayffer.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.20</h1>
<div><i>NuGet packages published 2021-09-09</i></div>
<div class='mt-1'>
<ul>
<li>Ticks: Fixed bug where corner labels would not render when multiplier or offset notation is in use (<a href="https://github.com/ScottPlot/ScottPlot/issues/1252">#1252</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1253">#1253</a>) <a href="https://github.com/DavidBergstromSWE"><strong>@DavidBergstromSWE</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/DavidBergstromSWE'>@DavidBergstromSWE</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/DavidBergstromSWE'><img src='https://scottplot.net/images/contributors/davidbergstromswe.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.19</h1>
<div><i>NuGet packages published 2021-09-08</i></div>
<div class='mt-1'>
<ul>
<li>Controls: Fixed bug where render warning message is not hidden if <code>RenderRequest()</code> is called (<a href="https://github.com/ScottPlot/ScottPlot/issues/1165">#1165</a>) <a href="https://github.com/gigios"><strong>@gigios</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/gigios'>@gigios</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/gigios'><img src='https://scottplot.net/images/contributors/gigios.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.18</h1>
<div><i>NuGet packages published 2021-09-08</i></div>
<div class='mt-1'>
<ul>
<li>Ticks: Improve placement when axis scale lock is enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1229">#1229</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1197">#1197</a>)
</li>
<li>Plot: <code>SetViewLimits()</code> replaced by <code>SetOuterViewLimits()</code> and <code>SetInnerViewLimits()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1197">#1197</a>) <a href="https://github.com/noob765"><strong>@noob765</strong></a>
</li>
<li>Plot: <code>EqualScaleMode</code> (an enumeration accepted by <code>AxisScaleLock()</code>) now has <code>PreserveSmallest</code> and <code>PreserveLargest</code> members to indicate which axis to prioritize when adjusting zoom level. The new default is <code>PreserveSmallest</code> which prevents data from falling off the edge of the plot when resizing. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1197">#1197</a>) <a href="https://github.com/noob765"><strong>@noob765</strong></a>
</li>
<li>Axis: Improved alignment of 90º rotated ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/1194">#1194</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1201">#1201</a>) <a href="https://github.com/gigios"><strong>@gigios</strong></a>
</li>
<li>Controls: Fix bug where middle-click-drag zoom rectangle would persist if combined with scroll wheel events (<a href="https://github.com/ScottPlot/ScottPlot/issues/1226">#1226</a>) <a href="https://github.com/Elgot"><strong>@Elgot</strong></a>
</li>
<li>Scatter Plot: Fixed bug affecting plots where <code>YError</code> is set but <code>XError</code> is not (<a href="https://github.com/ScottPlot/ScottPlot/issues/1237">#1237</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1238">#1238</a>) <a href="https://github.com/simmdan"><strong>@simmdan</strong></a>
</li>
<li>Palette: Added <code>Microcharts</code> colorset (<a href="https://github.com/ScottPlot/ScottPlot/issues/1235">#1235</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>SignalPlotXY: Added support for <code>FillType</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1232">#1232</a>) <a href="https://github.com/ddrrrr"><strong>@ddrrrr</strong></a>
</li>
<li>Arrow: New plot type for rendering arrows on plots. Arrowhead functionality of scatter plots has been deprecated. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1241">#1241</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1240">#1240</a>)
</li>
<li>Controls: Automatic rendering has been deprecated. Users must call Render() manually at least once. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1165">#1165</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1117">#1117</a>)
</li>
<li>Radial Gauge Plots: <code>AddRadialGauge()</code> now adds a radial gauge plot (a new circular plot type where values are represented as arcs spanning a curve). See cookbook for examples and documentation. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1242">#1242</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/noob765'>@noob765</a>, <a href='https://github.com/gigios'>@gigios</a>, <a href='https://github.com/Elgot'>@Elgot</a>, <a href='https://github.com/simmdan'>@simmdan</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/ddrrrr'>@ddrrrr</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/noob765'><img src='https://scottplot.net/images/contributors/noob765.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gigios'><img src='https://scottplot.net/images/contributors/gigios.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Elgot'><img src='https://scottplot.net/images/contributors/elgot.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/simmdan'><img src='https://scottplot.net/images/contributors/simmdan.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ddrrrr'><img src='https://scottplot.net/images/contributors/ddrrrr.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.17</h1>
<div><i>NuGet packages published 2021-08-25</i></div>
<div class='mt-1'>
<ul>
<li>Improved <code>RadarPlot.Update()</code> default arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1097">#1097</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Radar Plot: Improved <code>Update()</code> default arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/1097">#1097</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Crosshair: Added <code>XLabelOnTop</code> and <code>YLabelOnRight</code> options to improve multi-axis support and label customization (<a href="https://github.com/ScottPlot/ScottPlot/issues/1147">#1147</a>) <a href="https://github.com/rutkowskit"><strong>@rutkowskit</strong></a>
</li>
<li>Signal Plot: Added <code>StepDisplay</code> option to render signal plots as step plots when zoomed in (<a href="https://github.com/ScottPlot/ScottPlot/issues/1092">#1092</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1128">#1128</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Testing: Improved error reporting on failed XML documentation tests (<a href="https://github.com/ScottPlot/ScottPlot/issues/1127">#1127</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Histogram: Marked <code>ScottPlot.Statistics.Histogram</code> obsolete in favor of static methods in <code>ScottPlot.Statistics.Common</code> designed to create histograms and probability function curves (<a href="https://github.com/ScottPlot/ScottPlot/issues/1051">#1051</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1166">#1166</a>). See cookbook for usage examples. <a href="https://github.com/breakwinz"><strong>@breakwinz</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>WpfPlot: Improve memory management for dynamically created and destroyed WpfPlot controls by properly unloading the dispatcher timer (<a href="https://github.com/ScottPlot/ScottPlot/issues/1115">#1115</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1117">#1117</a>) <a href="https://github.com/RamsayGit"><strong>@RamsayGit</strong></a>, <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>, <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>, and <a href="https://github.com/Orace"><strong>@Orace</strong></a>
</li>
<li>Mouse Processing: Improved bug that affected fast drag-dropping of draggable objects (<a href="https://github.com/ScottPlot/ScottPlot/issues/1076">#1076</a>)
</li>
<li>Rendering: Fixed clipping bug that caused some plot types to be rendered above data area frames (<a href="https://github.com/ScottPlot/ScottPlot/issues/1084">#1084</a>)
</li>
<li>Plot: Added <code>Width</code> and <code>Height</code> properties
</li>
<li>Plot: <code>GetImageBytes()</code> now returns bytes for a PNG file for easier storage in cloud applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/1107">#1107</a>)
</li>
<li>Axis: Added a <code>GetSettings()</code> method for developers, testers, and experimenters to gain access to experimental objects which are normally private for extreme customization
</li>
<li>Axis: Axis ticks now have a <code>Ticks()</code> overload which allows selective control over major tick lines and major tick labels separately (<a href="https://github.com/ScottPlot/ScottPlot/issues/1118">#1118</a>) <a href="https://github.com/kegesch"><strong>@kegesch</strong></a>
</li>
<li>Plot: <code>AxisAuto()</code> now has <code>xAxisIndex</code> and <code>yAxisIndex</code> arguments to selectively adjust axes to fit data on a specified index (<a href="https://github.com/ScottPlot/ScottPlot/issues/1123">#1123</a>)
</li>
<li>Crosshair: Refactored to use two <code>AxisLine</code>s so custom formatters can now be used and lines can be independently styled (<a href="https://github.com/ScottPlot/ScottPlot/issues/1173">#1173</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1172">#1172</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1122">#1122</a>, 1195) <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a> and <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>ClevelandDotPlot: Improve automatic axis limit detection (<a href="https://github.com/ScottPlot/ScottPlot/issues/1185">#1185</a>) <a href="https://github.com/Nextra"><strong>@Nextra</strong></a>
</li>
<li>ScatterPlotList: Improved legend formatting (<a href="https://github.com/ScottPlot/ScottPlot/issues/1190">#1190</a>) <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>
</li>
<li>Plot: Added an optional argument to <code>Frameless()</code> to reverse its behavior and deprecated <code>Frame()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1112">#1112</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1192">#1192</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>AxisLine: Added <code>PositionLabel</code> option for displaying position as text (using a user-customizable formatter function) on the axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/1122">#1122</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1195">#1195</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1172">#1172</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1173">#1173</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a> and <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>
</li>
<li>Radar Plot: Fixed rendering artifact that occurred when axis maximum is zero (<a href="https://github.com/ScottPlot/ScottPlot/issues/1139">#1139</a>) <a href="https://github.com/petersesztak"><strong>@petersesztak</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Mouse Processing: Improved panning behavior when view limits (axis boundaries) are active (<a href="https://github.com/ScottPlot/ScottPlot/issues/1148">#1148</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1203">#1203</a>) <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Signal Plot: Fixed bug causing render artifacts when using fill modes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1163">#1163</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1205">#1205</a>)
</li>
<li>Scatter Plot: Added support for <code>OffsetX</code> and <code>OffsetY</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1164">#1164</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1213">#1213</a>)
</li>
<li>Coxcomb: Added a new plot type for categorical data. See cookbook for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1188">#1188</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axes: Added <code>LockLimits()</code> to control pan/zoom manipulation so individual axes can be manipulated in multi-axis plots. See demo application for example. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1179">#1179</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1210">#1210</a>) <a href="https://github.com/kkaiser41"><strong>@kkaiser41</strong></a>
</li>
<li>Vector Plot: Add additional options to customize arrowhead style and position. See cookbook for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1202">#1202</a>) <a href="https://github.com/hhubschle"><strong>@hhubschle</strong></a>
</li>
<li>Finance Plot: Fixed bug affecting plots with no data points (<a href="https://github.com/ScottPlot/ScottPlot/issues/1200">#1200</a>) <a href="https://github.com/Maoyao233"><strong>@Maoyao233</strong></a>
</li>
<li>Ticks: Improve display of rotated ticks on secondary axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/1201">#1201</a>) <a href="https://github.com/gigios"><strong>@gigios</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/rutkowskit'>@rutkowskit</a>, <a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/breakwinz'>@breakwinz</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/RamsayGit'>@RamsayGit</a>, <a href='https://github.com/Orace'>@Orace</a>, <a href='https://github.com/kegesch'>@kegesch</a>, <a href='https://github.com/Maoyao233'>@Maoyao233</a>, <a href='https://github.com/Nextra'>@Nextra</a>, <a href='https://github.com/petersesztak'>@petersesztak</a>, <a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/kkaiser41'>@kkaiser41</a>, <a href='https://github.com/hhubschle'>@hhubschle</a>, <a href='https://github.com/gigios'>@gigios</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/rutkowskit'><img src='https://scottplot.net/images/contributors/rutkowskit.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/breakwinz'><img src='https://scottplot.net/images/contributors/breakwinz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RamsayGit'><img src='https://scottplot.net/images/contributors/ramsaygit.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Orace'><img src='https://scottplot.net/images/contributors/orace.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kegesch'><img src='https://scottplot.net/images/contributors/kegesch.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Maoyao233'><img src='https://scottplot.net/images/contributors/maoyao233.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Nextra'><img src='https://scottplot.net/images/contributors/nextra.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/petersesztak'><img src='https://scottplot.net/images/contributors/petersesztak.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kkaiser41'><img src='https://scottplot.net/images/contributors/kkaiser41.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/hhubschle'><img src='https://scottplot.net/images/contributors/hhubschle.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gigios'><img src='https://scottplot.net/images/contributors/gigios.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.16</h1>
<div><i>NuGet packages published 2021-05-30</i></div>
<div class='mt-1'>
<ul>
<li>Made it easier to use custom color palettes (see cookbook) (<a href="https://github.com/ScottPlot/ScottPlot/issues/1058">#1058</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1082">#1082</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Added a <code>IgnoreAxisAuto</code> field to axis lines and spans (<a href="https://github.com/ScottPlot/ScottPlot/issues/999">#999</a>) <a href="https://github.com/kirsan31"><strong>@kirsan31</strong></a>
</li>
<li>Heatmaps now have a <code>Smooth</code> field which uses bicubic interpolation to display smooth heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/1003">#1003</a>) <a href="https://github.com/xichaoqiang"><strong>@xichaoqiang</strong></a>
</li>
<li>Radar plots now have an <code>Update()</code> method for updating data values without clearing the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/1086">#1086</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1091">#1091</a>) <a href="https://github.com/arthurits"><strong>@arthurits</strong></a>
</li>
<li>Controls now automatically render after the list of plottables is modified (previously it was after the number of plottables changed). This behavior can be disabled by setting a public field in the control's <code>Configuration</code> module. (<a href="https://github.com/ScottPlot/ScottPlot/issues/1087">#1087</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1088">#1088</a>) <a href="https://github.com/bftrock"><strong>@bftrock</strong></a>
</li>
<li>New <code>Crosshair</code> plot type draws lines to highlight a point on the plot and labels their coordinates in the axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/999">#999</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1093">#1093</a>) <a href="https://github.com/kirsan31"><strong>@kirsan31</strong></a>
</li>
<li>Added support for a custom <code>Func&lt;double, string&gt;</code> to be used as custom tick label formatters (see cookbook) (<a href="https://github.com/ScottPlot/ScottPlot/issues/926">#926</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1070">#1070</a>) <a href="https://github.com/damiandixon"><strong>@damiandixon</strong></a> and <a href="https://github.com/ssalsinha"><strong>@ssalsinha</strong></a>
</li>
<li>Added <code>Move</code>, <code>MoveFirst</code>, and <code>MoveLast</code> to the <code>Plot</code> module for added control over which plottables appear on top (<a href="https://github.com/ScottPlot/ScottPlot/issues/1090">#1090</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>
</li>
<li>Fixed bug preventing expected behavior when calling <code>AxisAutoX</code> and <code>AxisAutoY</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/1089">#1089</a>) <a href="https://github.com/EFeru"><strong>@EFeru</strong></a>_
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/EFeru'>@EFeru</a>, <a href='https://github.com/kirsan31'>@kirsan31</a>, <a href='https://github.com/xichaoqiang'>@xichaoqiang</a>, <a href='https://github.com/arthurits'>@arthurits</a>, <a href='https://github.com/bftrock'>@bftrock</a>, <a href='https://github.com/damiandixon'>@damiandixon</a>, <a href='https://github.com/ssalsinha'>@ssalsinha</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/EFeru'><img src='https://scottplot.net/images/contributors/eferu.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kirsan31'><img src='https://scottplot.net/images/contributors/kirsan31.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/xichaoqiang'><img src='https://scottplot.net/images/contributors/xichaoqiang.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/arthurits'><img src='https://scottplot.net/images/contributors/arthurits.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bftrock'><img src='https://scottplot.net/images/contributors/bftrock.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/damiandixon'><img src='https://scottplot.net/images/contributors/damiandixon.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ssalsinha'><img src='https://scottplot.net/images/contributors/ssalsinha.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.15</h1>
<div><i>NuGet packages published 2021-05-27</i></div>
<div class='mt-1'>
<ul>
<li>Hide design-time error message component at run time to reduce flicking when resizing (<a href="https://github.com/ScottPlot/ScottPlot/issues/1073">#1073</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1075">#1075</a>) <a href="https://github.com/Superberti"><strong>@Superberti</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Added a modern <code>Plot.GetBitmap()</code> overload suitable for the new stateless rendering system (<a href="https://github.com/ScottPlot/ScottPlot/issues/913">#913</a> <a href="https://github.com/ScottPlot/ScottPlot/issues/1063">#1063</a>)
</li>
<li>Controls now have <code>PlottableDragged</code> and <code>PlottableDropped</code> event handlers (<a href="https://github.com/ScottPlot/ScottPlot/issues/1072">#1072</a>) <a href="https://github.com/JS-BGResearch"><strong>@JS-BGResearch</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Superberti'>@Superberti</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/JS-BGResearch'>@JS-BGResearch</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Superberti'><img src='https://scottplot.net/images/contributors/superberti.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JS-BGResearch'><img src='https://scottplot.net/images/contributors/js-bgresearch.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.14</h1>
<div><i>NuGet packages published 2021-05-23</i></div>
<div class='mt-1'>
<ul>
<li>Add support for custom linestyles in SignalXY plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/1017">#1017</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1016">#1016</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/breakwinz"><strong>@breakwinz</strong></a>
</li>
<li>Improved Avalonia dependency versioning (<a href="https://github.com/ScottPlot/ScottPlot/issues/1018">#1018</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1041">#1041</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Controls now properly process <code>MouseEnter</code> and <code>MouseLeave</code> events (<a href="https://github.com/ScottPlot/ScottPlot/issues/999">#999</a>) <a href="https://github.com/kirsan31"><strong>@kirsan31</strong></a> and <a href="https://github.com/breakwinz"><strong>@breakwinz</strong></a>
</li>
<li>Controls now have a <code>RenderRequest()</code> method that uses a render queue to facilitate non-blocking render calls (<a href="https://github.com/ScottPlot/ScottPlot/issues/813">#813</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1034">#1034</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added Last() to finance plots to make it easier to access the final OHLC (<a href="https://github.com/ScottPlot/ScottPlot/issues/1038">#1038</a>) <a href="https://github.com/CalderWhite"><strong>@CalderWhite</strong></a>
</li>
<li>Controls that fail to render in design mode now display the error message in a textbox to prevent Visual Studio exceptions (<a href="https://github.com/ScottPlot/ScottPlot/issues/1048">#1048</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/breakwinz'>@breakwinz</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/kirsan31'>@kirsan31</a>, <a href='https://github.com/CalderWhite'>@CalderWhite</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/breakwinz'><img src='https://scottplot.net/images/contributors/breakwinz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/kirsan31'><img src='https://scottplot.net/images/contributors/kirsan31.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/CalderWhite'><img src='https://scottplot.net/images/contributors/calderwhite.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.13-beta</h1>
<div><i>NuGet packages published 2021-05-02</i></div>
<div class='mt-1'>
<ul>
<li><code>Plot.Render()</code> and <code>Plot.SaveFig()</code> now have a <code>scale</code> argument to allow for the creation of high resolution scaled plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/983">#983</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/982">#982</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/981">#981</a>) <a href="https://github.com/PeterDavidson"><strong>@PeterDavidson</strong></a>
</li>
<li>A <code>BubblePlot</code> has been added to allow display of circles with custom colors and sizes. See cookbook for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/984">#984</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/973">#973</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/960">#960</a>) <a href="https://github.com/PeterDavidson"><strong>@PeterDavidson</strong></a>
</li>
<li>Avalonia 0.10.3 is now supported (<a href="https://github.com/ScottPlot/ScottPlot/issues/986">#986</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Default version of System.Drawing.Common has been changed from <code>5.0.0</code> to <code>4.6.1</code> to minimize errors associated with downgrading (<a href="https://github.com/ScottPlot/ScottPlot/issues/1004">#1004</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/1005">#1005</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/993">#993</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/924">#924</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/655">#655</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/PeterDavidson'>@PeterDavidson</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/PeterDavidson'><img src='https://scottplot.net/images/contributors/peterdavidson.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.12-beta</h1>
<div><i>NuGet packages published 2021-04-12</i></div>
<div class='mt-1'>
<ul>
<li>Added &quot;Open in New Window&quot; option to right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/958">#958</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/969">#969</a>) <a href="https://github.com/ademkaya"><strong>@ademkaya</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>User control <code>Configuration</code> module now has customizable scroll wheel zoom fraction (<a href="https://github.com/ScottPlot/ScottPlot/issues/940">#940</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/937">#937</a>) <a href="https://github.com/PassionateDeveloper86"><strong>@PassionateDeveloper86</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added options to <code>Plot.AxisScaleLock()</code> to let the user define scaling behavior when the plot is resized (<a href="https://github.com/ScottPlot/ScottPlot/issues/933">#933</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/857">#857</a>) <a href="https://github.com/boingo100p"><strong>@boingo100p</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved XML documentation for <code>DataGen</code> module (<a href="https://github.com/ScottPlot/ScottPlot/issues/903">#903</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/902">#902</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed bug where tick labels would not render for axes with a single tick (<a href="https://github.com/ScottPlot/ScottPlot/issues/945">#945</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/828">#828</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/725">#725</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/925">#925</a>) <a href="https://github.com/saklanmazozgur"><strong>@saklanmazozgur</strong></a> and <a href="https://github.com/audun"><strong>@audun</strong></a>
</li>
<li>Added option to manually refine tick density (<a href="https://github.com/ScottPlot/ScottPlot/issues/828">#828</a>) <a href="https://github.com/ChrisAtVault"><strong>@ChrisAtVault</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved tick density calculations for DateTime axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/725">#725</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed SignalXY rendering artifact affecting the right edge of the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/929">#929</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/931">#931</a>) <a href="https://github.com/damiandixon"><strong>@damiandixon</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved line style customization for signal plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/929">#929</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/931">#931</a>) <a href="https://github.com/damiandixon"><strong>@damiandixon</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Fixed bug where negative bar plots would default to red fill color (<a href="https://github.com/ScottPlot/ScottPlot/issues/968">#968</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/946">#946</a>) <a href="https://github.com/pietcoussens"><strong>@pietcoussens</strong></a>
</li>
<li>Fixed bug where custom vertical margin was not respected when <code>AxisAuto()</code> was called with a middle-click (<a href="https://github.com/ScottPlot/ScottPlot/issues/943">#943</a>)Andreas
</li>
<li>Added a minimum distance the mouse must travel while click-dragging for the action to be considered a drag instead of a click (<a href="https://github.com/ScottPlot/ScottPlot/issues/962">#962</a>)
</li>
<li>Improved Histogram documentation and simplified access to probability curves (<a href="https://github.com/ScottPlot/ScottPlot/issues/930">#930</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/932">#932</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/971">#971</a>) <a href="https://github.com/LB767"><strong>@LB767</strong></a>, <a href="https://github.com/breakwinz"><strong>@breakwinz</strong></a>, and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ademkaya'>@ademkaya</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/PassionateDeveloper86'>@PassionateDeveloper86</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/boingo100p'>@boingo100p</a>, <a href='https://github.com/saklanmazozgur'>@saklanmazozgur</a>, <a href='https://github.com/audun'>@audun</a>, <a href='https://github.com/ChrisAtVault'>@ChrisAtVault</a>, <a href='https://github.com/damiandixon'>@damiandixon</a>, <a href='https://github.com/pietcoussens'>@pietcoussens</a>, <a href='https://github.com/LB767'>@LB767</a>, <a href='https://github.com/breakwinz'>@breakwinz</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ademkaya'><img src='https://scottplot.net/images/contributors/ademkaya.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/PassionateDeveloper86'><img src='https://scottplot.net/images/contributors/passionatedeveloper86.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/boingo100p'><img src='https://scottplot.net/images/contributors/boingo100p.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/saklanmazozgur'><img src='https://scottplot.net/images/contributors/saklanmazozgur.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/audun'><img src='https://scottplot.net/images/contributors/audun.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisAtVault'><img src='https://scottplot.net/images/contributors/chrisatvault.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/damiandixon'><img src='https://scottplot.net/images/contributors/damiandixon.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/pietcoussens'><img src='https://scottplot.net/images/contributors/pietcoussens.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LB767'><img src='https://scottplot.net/images/contributors/lb767.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/breakwinz'><img src='https://scottplot.net/images/contributors/breakwinz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.11-beta</h1>
<div><i>NuGet packages published 2021-03-30</i></div>
<div class='mt-1'>
<ul>
<li>FormsPlot mouse events are now properly forwarded to the base control (<a href="https://github.com/ScottPlot/ScottPlot/issues/892">#892</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/919">#919</a>) <a href="https://github.com/grabul"><strong>@grabul</strong></a>
</li>
<li>Prevent right-click menu from deploying after right-click-drag (<a href="https://github.com/ScottPlot/ScottPlot/issues/891">#891</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/917">#917</a>)
</li>
<li>Add offset support to SignalXY (<a href="https://github.com/ScottPlot/ScottPlot/issues/894">#894</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/890">#890</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Eliminate rendering artifacts in SignalXY plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/893">#893</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/889">#889</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/grabul"><strong>@grabul</strong></a>
</li>
<li>Optimize cookbook generation and test execution (<a href="https://github.com/ScottPlot/ScottPlot/issues/901">#901</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/grabul'>@grabul</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/grabul'><img src='https://scottplot.net/images/contributors/grabul.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.10-beta</h1>
<div><i>NuGet packages published 2021-03-21</i></div>
<div class='mt-1'>
<ul>
<li>Fixed a bug where applying the Seabourn style modified axis frame and minor tick distribution (<a href="https://github.com/ScottPlot/ScottPlot/issues/866">#866</a>) <a href="https://github.com/oszymczak"><strong>@oszymczak</strong></a>
</li>
<li>Improved XML documentation and error reporting for getting legend bitmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/860">#860</a>) <a href="https://github.com/mzemljak"><strong>@mzemljak</strong></a>
</li>
<li>Fixed rendering bug affecting finance plots with thin borders (<a href="https://github.com/ScottPlot/ScottPlot/issues/837">#837</a>) <a href="https://github.com/AlgoExecutor"><strong>@AlgoExecutor</strong></a>
</li>
<li>Improved argument names and XML docs for SMA and Bollinger band calculation methods (<a href="https://github.com/ScottPlot/ScottPlot/issues/830">#830</a>) <a href="https://github.com/ticool"><strong>@ticool</strong></a>
</li>
<li>Improved GetPointNearest support for generic signal plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/809">#809</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/882">#882</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/886">#886</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>, <a href="https://github.com/at2software"><strong>@at2software</strong></a>, and <a href="https://github.com/mrradd"><strong>@mrradd</strong></a>
</li>
<li>Added support for custom slice label colors in pie charts (<a href="https://github.com/ScottPlot/ScottPlot/issues/883">#883</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/844">#844</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>, <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>, and <a href="https://github.com/Timothy343"><strong>@Timothy343</strong></a>
</li>
<li>Improved support for transparent heatmaps using nullable double arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/849">#849</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/852">#852</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Deprecated bar plot <code>IsHorizontal</code> and <code>IsVertical</code> in favor of an <code>Orientation</code> enumeration
</li>
<li>Deprecated bar plot <code>xs</code> and <code>ys</code> in favor of <code>positions</code> and <code>values</code> which are better orientation-agnostic names
</li>
<li>Added Lollipop and Cleveland plots as new types of bar plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/842">#842</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/817">#817</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed a bug where <code>Plot.AddBarGroups()</code> returned an array of nulls (<a href="https://github.com/ScottPlot/ScottPlot/issues/839">#839</a>) <a href="https://github.com/rhys-wootton"><strong>@rhys-wootton</strong></a>
</li>
<li>Fixed a bug affecting manual tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/829">#829</a>) <a href="https://github.com/ohru131"><strong>@ohru131</strong></a>
</li>
<li>Implemented an optional render queue to allow asynchronous rendering in user controls (<a href="https://github.com/ScottPlot/ScottPlot/issues/813">#813</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/oszymczak'>@oszymczak</a>, <a href='https://github.com/mzemljak'>@mzemljak</a>, <a href='https://github.com/AlgoExecutor'>@AlgoExecutor</a>, <a href='https://github.com/ticool'>@ticool</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/mrradd'>@mrradd</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Timothy343'>@Timothy343</a>, <a href='https://github.com/rhys-wootton'>@rhys-wootton</a>, <a href='https://github.com/ohru131'>@ohru131</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/oszymczak'><img src='https://scottplot.net/images/contributors/oszymczak.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mzemljak'><img src='https://scottplot.net/images/contributors/mzemljak.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AlgoExecutor'><img src='https://scottplot.net/images/contributors/algoexecutor.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ticool'><img src='https://scottplot.net/images/contributors/ticool.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/mrradd'><img src='https://scottplot.net/images/contributors/mrradd.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Timothy343'><img src='https://scottplot.net/images/contributors/timothy343.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/rhys-wootton'><img src='https://scottplot.net/images/contributors/rhys-wootton.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ohru131'><img src='https://scottplot.net/images/contributors/ohru131.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.9-beta</h1>
<div><i>NuGet packages published 2021-02-21</i></div>
<div class='mt-1'>
<ul>
<li>Improved support for negative DateTimes when using DateTime axis mode (<a href="https://github.com/ScottPlot/ScottPlot/issues/806">#806</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/807">#807</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Improved axis limit detection when using tooltips (<a href="https://github.com/ScottPlot/ScottPlot/issues/805">#805</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/811">#811</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/ChrisAtVault"><strong>@ChrisAtVault</strong></a>
</li>
<li>Added <code>WickColor</code> field to candlestick plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/803">#803</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved rendering of candlesticks that open and close at the same price (<a href="https://github.com/ScottPlot/ScottPlot/issues/803">#803</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/800">#800</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/AlgoExecutor"><strong>@AlgoExecutor</strong></a>
</li>
<li>Improved rendering of SignalXY plots near the edge of the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/795">#795</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>new <code>AddScatterStep()</code> helper method creates a scatter plot with the step style (<a href="https://github.com/ScottPlot/ScottPlot/issues/808">#808</a>) <a href="https://github.com/KlaskSkovby"><strong>@KlaskSkovby</strong></a>
</li>
<li>Marked <code>MultiPlot</code> obsolete
</li>
<li>Refactored <code>Colormap</code> module to use classes instead of reflection (<a href="https://github.com/ScottPlot/ScottPlot/issues/767">#767</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/773">#773</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Refactored <code>OHLC</code> fields and finance plots to store <code>DateTime</code> and <code>TimeSpan</code> instead of <code>double</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/795">#795</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/ChrisAtVault'>@ChrisAtVault</a>, <a href='https://github.com/AlgoExecutor'>@AlgoExecutor</a>, <a href='https://github.com/KlaskSkovby'>@KlaskSkovby</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ChrisAtVault'><img src='https://scottplot.net/images/contributors/chrisatvault.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AlgoExecutor'><img src='https://scottplot.net/images/contributors/algoexecutor.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/KlaskSkovby'><img src='https://scottplot.net/images/contributors/klaskskovby.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.8-beta</h1>
<div><i>NuGet packages published 2021-02-16</i></div>
<div class='mt-1'>
<ul>
<li>Improved validation and error reporting for large heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/772">#772</a>) <a href="https://github.com/Matthias-C"><strong>@Matthias-C</strong></a>
</li>
<li>Removed noisy console output in <code>ScatterPlotList</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/780">#780</a>) <a href="https://github.com/Scr0nch"><strong>@Scr0nch</strong></a>
</li>
<li>Improved rendering bug in signal plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/783">#783</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/788">#788</a>) <a href="https://github.com/AlgoExecutor"><strong>@AlgoExecutor</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Fix bug that hid grid lines in frameless plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/779">#779</a>)
</li>
<li>Improved appearance of marker-only scatter plots in the legend (<a href="https://github.com/ScottPlot/ScottPlot/issues/790">#790</a>) <a href="https://github.com/AlgoExecutor"><strong>@AlgoExecutor</strong></a>
</li>
<li><code>AddPoint()</code> now has a <code>label</code> argument to match <code>AddScatter()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/787">#787</a>) <a href="https://github.com/AlgoExecutor"><strong>@AlgoExecutor</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Matthias-C'>@Matthias-C</a>, <a href='https://github.com/Scr0nch'>@Scr0nch</a>, <a href='https://github.com/AlgoExecutor'>@AlgoExecutor</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Matthias-C'><img src='https://scottplot.net/images/contributors/matthias-c.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Scr0nch'><img src='https://scottplot.net/images/contributors/scr0nch.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AlgoExecutor'><img src='https://scottplot.net/images/contributors/algoexecutor.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.7-beta</h1>
<div><i>NuGet packages published 2021-02-14</i></div>
<div class='mt-1'>
<ul>
<li>Added support for image axis labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/759">#759</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/446">#446</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/716">#716</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Added <code>MinRenderIndex</code> and <code>MaxRenderIndex</code> support to Scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/737">#737</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/763">#763</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved display of horizontal manual axis tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/724">#724</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/762">#762</a>) <a href="https://github.com/inqb"><strong>@inqb</strong></a> and <a href="https://github.com/Saklut"><strong>@Saklut</strong></a>
</li>
<li>Added support for listing and retrieving colormaps by their names (<a href="https://github.com/ScottPlot/ScottPlot/issues/767">#767</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/773">#773</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Enabled mouse pan and zoom for plots with infinitely small width and height (<a href="https://github.com/ScottPlot/ScottPlot/issues/768">#768</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/733">#733</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/764">#764</a>) <a href="https://github.com/saklanmazozgur"><strong>@saklanmazozgur</strong></a>
</li>
<li>A descriptive exception is now thrown when attempting to create heatmaps of unsupported dimensions (<a href="https://github.com/ScottPlot/ScottPlot/issues/722">#722</a>) <a href="https://github.com/Matthias-C"><strong>@Matthias-C</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/inqb'>@inqb</a>, <a href='https://github.com/Saklut'>@Saklut</a>, <a href='https://github.com/saklanmazozgur'>@saklanmazozgur</a>, <a href='https://github.com/Matthias-C'>@Matthias-C</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/inqb'><img src='https://scottplot.net/images/contributors/inqb.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Saklut'><img src='https://scottplot.net/images/contributors/saklut.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/saklanmazozgur'><img src='https://scottplot.net/images/contributors/saklanmazozgur.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Matthias-C'><img src='https://scottplot.net/images/contributors/matthias-c.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.6-beta</h1>
<div><i>NuGet packages published 2021-02-08</i></div>
<div class='mt-1'>
<ul>
<li>Fixed single point render bug in Signal plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/744">#744</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/745">#745</a>) <a href="https://github.com/at2software"><strong>@at2software</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved display scaling support for WPF control (<a href="https://github.com/ScottPlot/ScottPlot/issues/721">#721</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/720">#720</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>User control <code>OnAxesChanged</code> events now send the control itself as the sender object (<a href="https://github.com/ScottPlot/ScottPlot/issues/743">#743</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/756">#756</a>) <a href="https://github.com/at2software"><strong>@at2software</strong></a>
</li>
<li>Fixed configuration bug related to Alt + middle-click-drag-zoom (<a href="https://github.com/ScottPlot/ScottPlot/issues/741">#741</a>) <a href="https://github.com/JS-BGResearch"><strong>@JS-BGResearch</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed render bug related to ALT + middle-click-drag zoom box (<a href="https://github.com/ScottPlot/ScottPlot/issues/742">#742</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed render bug for extremely small plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/735">#735</a>)
</li>
<li>Added a coordinated heatmap plot type (<a href="https://github.com/ScottPlot/ScottPlot/issues/707">#707</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved appearance of heatmap edges (<a href="https://github.com/ScottPlot/ScottPlot/issues/713">#713</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved design-time rendering of Windows Forms control
</li>
<li>Added and expanded XML documentation for Plot and Plottable classes
</li>
<li>Created a new cookbook website generator that combines reflection with XML documentation (<a href="https://github.com/ScottPlot/ScottPlot/issues/727">#727</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/738">#738</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/756">#756</a>)
</li>
<li>ScottPlot is now a reserved prefix on NuGet
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/at2software'>@at2software</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/JS-BGResearch'>@JS-BGResearch</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/at2software'><img src='https://scottplot.net/images/contributors/at2software.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JS-BGResearch'><img src='https://scottplot.net/images/contributors/js-bgresearch.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.5-beta</h1>
<div><i>NuGet packages published 2021-02-01</i></div>
<div class='mt-1'>
<ul>
<li>Helper methods were added for creating scatter plots with just lines (<code>AddScatterLines()</code>) or just markers (<code>AddScatterPoints()</code>).
</li>
<li>Scatter and Signal plots have <code>GetPointNearest()</code> which now has a <code>xyRatio</code> argument to support identifying points near the cursor in pixel space (<a href="https://github.com/ScottPlot/ScottPlot/issues/709">#709</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/722">#722</a>) <a href="https://github.com/oszymczak"><strong>@oszymczak</strong></a>, <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>, <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved display of manual tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/724">#724</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/oszymczak'>@oszymczak</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/oszymczak'><img src='https://scottplot.net/images/contributors/oszymczak.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.4-beta</h1>
<div><i>NuGet packages published 2021-01-25</i></div>
<div class='mt-1'>
<ul>
<li>User controls have been extensively redesigned (<a href="https://github.com/ScottPlot/ScottPlot/issues/683">#683</a>)
</li>
<li>New methods were added to <code>ScottPlot.Statistics.Common</code> which efficiently find the Nth smallest number, quartiles, or other quantiles from arrays of numbers (<a href="https://github.com/ScottPlot/ScottPlot/issues/690">#690</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>New tooltip plot type (<a href="https://github.com/ScottPlot/ScottPlot/issues/696">#696</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Fixed simple moving average (SMA) calculation (<a href="https://github.com/ScottPlot/ScottPlot/issues/703">#703</a>) <a href="https://github.com/Saklut"><strong>@Saklut</strong></a>
</li>
<li>Improved multi-axis rendering (<a href="https://github.com/ScottPlot/ScottPlot/issues/706">#706</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved <code>SetSourceAsync()</code> for segmented trees (<a href="https://github.com/ScottPlot/ScottPlot/issues/705">#705</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/692">#692</a>) <a href="https://github.com/jl0pd"><strong>@jl0pd</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved layout for axes with rotated ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/706">#706</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/699">#699</a>) <a href="https://github.com/MisterRedactus"><strong>@MisterRedactus</strong></a> and <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>ScottPlot now multi-targets more platforms and supports the latest C# language version on modern platforms but restricts the language to C# 7.3 for .NET Framework projects (<a href="https://github.com/ScottPlot/ScottPlot/issues/691">#691</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/711">#711</a>) <a href="https://github.com/jl0pd"><strong>@jl0pd</strong></a>
</li>
<li>Improved project file to install <code>System.ValueTuple</code> when targeting .NET Framework 4.6.1 (<a href="https://github.com/ScottPlot/ScottPlot/issues/88">#88</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/691">#691</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Saklut'>@Saklut</a>, <a href='https://github.com/jl0pd'>@jl0pd</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/MisterRedactus'>@MisterRedactus</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Saklut'><img src='https://scottplot.net/images/contributors/saklut.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jl0pd'><img src='https://scottplot.net/images/contributors/jl0pd.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MisterRedactus'><img src='https://scottplot.net/images/contributors/misterredactus.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.3-beta</h1>
<div><i>NuGet packages published 2020-12-27</i></div>
<div class='mt-1'>
<ul>
<li>Scott will make a document to summarize 4.0 → 4.1 changes as we get closer to a non-beta release
</li>
<li>Fixed rendering bug affecting axis spans when zoomed far in (<a href="https://github.com/ScottPlot/ScottPlot/issues/662">#662</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved Gaussian blur performance (<a href="https://github.com/ScottPlot/ScottPlot/issues/667">#667</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Largely refactored heatmaps (<a href="https://github.com/ScottPlot/ScottPlot/issues/679">#679</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/680">#680</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>New <code>Colorbar</code> plot type (<a href="https://github.com/ScottPlot/ScottPlot/issues/681">#681</a>)
</li>
<li>Improved SMA and Bollinger band generators (<a href="https://github.com/ScottPlot/ScottPlot/issues/647">#647</a>) <a href="https://github.com/Saklut"><strong>@Saklut</strong></a>
</li>
<li>Improved tick label rounding (<a href="https://github.com/ScottPlot/ScottPlot/issues/657">#657</a>)
</li>
<li>Improved setting of tick label color (<a href="https://github.com/ScottPlot/ScottPlot/issues/672">#672</a>)
</li>
<li>Improved fill above and below for scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/676">#676</a>) <a href="https://github.com/MithrilMan"><strong>@MithrilMan</strong></a>
</li>
<li>Additional customizations for radar charts (<a href="https://github.com/ScottPlot/ScottPlot/issues/634">#634</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/628">#628</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/635">#635</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/SommerEngineering"><strong>@SommerEngineering</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Saklut'>@Saklut</a>, <a href='https://github.com/MithrilMan'>@MithrilMan</a>, <a href='https://github.com/SommerEngineering'>@SommerEngineering</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Saklut'><img src='https://scottplot.net/images/contributors/saklut.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/MithrilMan'><img src='https://scottplot.net/images/contributors/mithrilman.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SommerEngineering'><img src='https://scottplot.net/images/contributors/sommerengineering.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.1.0-beta</h1>
<div><i>NuGet packages published 2020-11-29</i></div>
<div class='mt-1'>
<ul>
<li>In November, 2020 ScottPlot 4.0 branched into a permanent <code>stable</code> branch, and ScottPlot 4.1 began development as beta / pre-release in the main branch. ScottPlot 4.0 continues to be maintained, but modifications are aimed at small bugfixes rather than large refactoring or the addition of new features. ScottPlot 4.1 merged into the master branch in November, 2020 (<a href="https://github.com/ScottPlot/ScottPlot/issues/605">#605</a>). Improvements are focused at enhanced performance, improved thread safety, support for multiple axes, and options for data validation.
</li>
<li>Most plotting methods are unchanged so many users will not experience any breaking changes.
</li>
<li>Axis Limits: Axis limits are described by a <code>AxisLimits</code> struct (previously <code>double[]</code> was used)
</li>
<li>Axis Limits: Methods which modify axis limits do not return anything (previously they returned <code>double[]</code>)
</li>
<li>Axis Limits: To get the latest axis limits call <code>Plot.AxisLimits()</code> which returns a <code>AxisLimits</code> object
</li>
<li>Multiple Axes: Multiple axes are now supported! There is no change to the traditional workflow if this feature is not used.
</li>
<li>Multiple Axes: Most axis methods accept a <code>xAxisIndex</code> and <code>yAxisIndex</code> arguments to specify which axes they will modify or return
</li>
<li>Multiple Axes: Most plottable objects have <code>xAxisIndex</code> and <code>yAxisIndex</code> fields which specify which axes they will render on
</li>
<li>Multiple Axes: You can enable a second Y and X axis by calling <code>YLabel2</code> and <code>XLabel2()</code>
</li>
<li>Multiple Axes: You can obtain an axis by calling <code>GetXAxis(xAxisIndex)</code> or <code>GetYAxis(yAxisIndex)</code>, then modify its public fields to customize its behavior
</li>
<li>Multiple Axes: The default axes (left and bottom) both use axis index <code>0</code>
</li>
<li>Multiple Axes: The secondary axes (right and top) both use axis index <code>1</code>
</li>
<li>Multiple Axes: You can create additional axes by calling <code>Plot.AddAxis()</code> and customize it by modifying fields of the <code>Axis</code> it returns.
</li>
<li>Layout: The layout is re-calculated on every render, so it automatically adjusts to accommodate axis labels and ticks.
</li>
<li>Layout: To achieve extra space around the data area, call <code>Layout()</code> to supply a minimum size for each axis.
</li>
<li>Layout: To achieve a frameless plot where the data area fills the full figure, call <code>LayoutFrameless()</code>
</li>
<li>Naming: The <code>Plottable</code> base class has been replaced with an <code>IPlottable</code> interface
</li>
<li>Naming: Plottables have been renamed and moved into a <code>Plottable</code> namespace (e.g., <code>PlottableScatter</code> is  now <code>Plottable.ScatterPlot</code>)
</li>
<li>Naming: Several enums have been renamed
</li>
<li>Settings: It is still private, but you can request it with <code>Plot.GetSettings()</code>
</li>
<li>Settings: Many of its objects implement <code>IRenderable</code>, so their customization options are stored at the same level as their render methods.
</li>
<li>Rendering: <code>Bitmap</code> objects are never stored. The <code>Render()</code> method will create and return a new <code>Bitmap</code> when called, or will render onto an existing <code>Bitmap</code> if it is supplied as an argument. This allows controls to manage their own performance optimization by optionally re-using a <code>Bitmap</code> for multiple renders.
</li>
<li>Rendering: Drawing is achieved with <code>using</code> statements which respect all <code>IDisposable</code> drawing objects, improving thread safety and garbage collection performance.
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.46</h1>
<div><i>NuGet packages published 2020-12-11</i></div>
<div class='mt-1'>
<ul>
<li>Improved ticks for small plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/724">#724</a>) <a href="https://github.com/Saklut"><strong>@Saklut</strong></a>
</li>
<li>Improved display of manual ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/724">#724</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Saklut'>@Saklut</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Saklut'><img src='https://scottplot.net/images/contributors/saklut.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.45</h1>
<div><i>NuGet packages published 2020-11-25</i></div>
<div class='mt-1'>
<ul>
<li>Fixed a bug that affected very small plots with the benchmark enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/626">#626</a>) <a href="https://github.com/martin-brajer"><strong>@martin-brajer</strong></a>
</li>
<li>Improved labels in bar graphs using a yOffset (<a href="https://github.com/ScottPlot/ScottPlot/issues/584">#584</a>)Terbaco
</li>
<li>Added <code>RenderLock()</code> and <code>RenderUnlock()</code> to the Plot module to facilitate multi-threaded plot modification (<a href="https://github.com/ScottPlot/ScottPlot/issues/609">#609</a>) <a href="https://github.com/ZTaiIT1025"><strong>@ZTaiIT1025</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/martin-brajer'>@martin-brajer</a>, <a href='https://github.com/ZTaiIT1025'>@ZTaiIT1025</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/martin-brajer'><img src='https://scottplot.net/images/contributors/martin-brajer.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ZTaiIT1025'><img src='https://scottplot.net/images/contributors/ztaiit1025.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.44</h1>
<div><i>NuGet packages published 2020-11-22</i></div>
<div class='mt-1'>
<ul>
<li>Improved limits for fixed-size axis spans (<a href="https://github.com/ScottPlot/ScottPlot/issues/586">#586</a>) <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Mouse drag/drop events now send useful event arguments (<a href="https://github.com/ScottPlot/ScottPlot/issues/593">#593</a>) <a href="https://github.com/charlescao460"><strong>@charlescao460</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Fixed a bug that affected plots with extremely small (&lt;1E-10) axis spans (<a href="https://github.com/ScottPlot/ScottPlot/issues/607">#607</a>) <a href="https://github.com/RFIsoft"><strong>@RFIsoft</strong></a>
</li>
<li><code>Plot.SaveFig()</code> now returns the full path to the file it created (<a href="https://github.com/ScottPlot/ScottPlot/issues/608">#608</a>)
</li>
<li>Fixed <code>AxisAuto()</code> bug affecting signal plots using min/max render indexes with a custom sample rate (<a href="https://github.com/ScottPlot/ScottPlot/issues/621">#621</a>) <a href="https://github.com/LB767"><strong>@LB767</strong></a>
</li>
<li>Fixed a bug affecting histogram normalization (<a href="https://github.com/ScottPlot/ScottPlot/issues/624">#624</a>) <a href="https://github.com/LB767"><strong>@LB767</strong></a>
</li>
<li>WPF and Windows Forms user controls now also target .NET 5
</li>
<li>Improved appearance of semi-transparent legend items (<a href="https://github.com/ScottPlot/ScottPlot/issues/567">#567</a>)
</li>
<li>Improved tick labels for ticks smaller than 1E-5 (<a href="https://github.com/ScottPlot/ScottPlot/issues/568">#568</a>) <a href="https://github.com/ozgur640"><strong>@ozgur640</strong></a>
</li>
<li>Improved support for Avalonia 0.10 (<a href="https://github.com/ScottPlot/ScottPlot/issues/571">#571</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/apkrymov"><strong>@apkrymov</strong></a>
</li>
<li>Improved positions for base16 ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/582">#582</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/581">#581</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/charlescao460'>@charlescao460</a>, <a href='https://github.com/RFIsoft'>@RFIsoft</a>, <a href='https://github.com/LB767'>@LB767</a>, <a href='https://github.com/ozgur640'>@ozgur640</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/apkrymov'>@apkrymov</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/charlescao460'><img src='https://scottplot.net/images/contributors/charlescao460.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RFIsoft'><img src='https://scottplot.net/images/contributors/rfisoft.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LB767'><img src='https://scottplot.net/images/contributors/lb767.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ozgur640'><img src='https://scottplot.net/images/contributors/ozgur640.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/apkrymov'><img src='https://scottplot.net/images/contributors/apkrymov.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.42</h1>
<div><i>NuGet packages published 2020-09-27</i></div>
<div class='mt-1'>
<ul>
<li>Improved DPI scaling support when using WinForms in .NET Core applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/563">#563</a>) <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
<li>Improved DPI scaling support for draggable axis lines and spans (<a href="https://github.com/ScottPlot/ScottPlot/issues/563">#563</a>) <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.41</h1>
<div><i>NuGet packages published 2020-09-26</i></div>
<div class='mt-1'>
<ul>
<li>Improved density of DateTime ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/564">#564</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/561">#561</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/waynetheron"><strong>@waynetheron</strong></a>
</li>
<li>Improved display of DateTime tick labels containing multiple spaces (<a href="https://github.com/ScottPlot/ScottPlot/issues/539">#539</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/564">#564</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/waynetheron'>@waynetheron</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/waynetheron'><img src='https://scottplot.net/images/contributors/waynetheron.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.40</h1>
<div><i>NuGet packages published 2020-09-20</i></div>
<div class='mt-1'>
<ul>
<li>Added user control for Avalonia (<a href="https://github.com/ScottPlot/ScottPlot/issues/496">#496</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/503">#503</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Holding shift while left-click-dragging the edge of a span moves it instead of resizing it (<a href="https://github.com/ScottPlot/ScottPlot/issues/509">#509</a>) <a href="https://github.com/Torgano"><strong>@Torgano</strong></a>
</li>
<li>CSV export is now culture invariant for improved support on systems where commas are decimal separators (<a href="https://github.com/ScottPlot/ScottPlot/issues/512">#512</a>)Daniel
</li>
<li>Added fill support to scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/529">#529</a>) <a href="https://github.com/AlexFsmn"><strong>@AlexFsmn</strong></a>
</li>
<li>Fix bug that occurred when calling <code>GetLegendBitmap()</code> before the plot was rendered (<a href="https://github.com/ScottPlot/ScottPlot/issues/527">#527</a>) <a href="https://github.com/el-aasi"><strong>@el-aasi</strong></a>
</li>
<li>Improved DateTime tick placement and added support for milliseconds (<a href="https://github.com/ScottPlot/ScottPlot/issues/539">#539</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Pie charts now have an optional hollow center to produce donut plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/534">#534</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/AlexFsmn"><strong>@AlexFsmn</strong></a>
</li>
<li>Added electrocardiogram (ECG) simulator to the DataGen module (<a href="https://github.com/ScottPlot/ScottPlot/issues/540">#540</a>) <a href="https://github.com/AteCoder"><strong>@AteCoder</strong></a>
</li>
<li>Improved mouse scroll wheel responsiveness by delaying high quality render (<a href="https://github.com/ScottPlot/ScottPlot/issues/545">#545</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/543">#543</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/550">#550</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>Plot.PlotBitmap()</code> allows Bitmaps to be placed at specific coordinates (<a href="https://github.com/ScottPlot/ScottPlot/issues/528">#528</a>) <a href="https://github.com/AlexFsmn"><strong>@AlexFsmn</strong></a>
</li>
<li><code>DataGen.SampleImage()</code> returns a sample Bitmap that can be used for testing
</li>
<li>Bar graphs now have a hatchStyle property to customize fill pattern (<a href="https://github.com/ScottPlot/ScottPlot/issues/555">#555</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Support timecode tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/537">#537</a>) <a href="https://github.com/vrdriver"><strong>@vrdriver</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/Torgano'>@Torgano</a>, <a href='https://github.com/AlexFsmn'>@AlexFsmn</a>, <a href='https://github.com/el-aasi'>@el-aasi</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/AteCoder'>@AteCoder</a>, <a href='https://github.com/vrdriver'>@vrdriver</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Torgano'><img src='https://scottplot.net/images/contributors/torgano.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AlexFsmn'><img src='https://scottplot.net/images/contributors/alexfsmn.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/el-aasi'><img src='https://scottplot.net/images/contributors/el-aasi.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/AteCoder'><img src='https://scottplot.net/images/contributors/atecoder.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/vrdriver'><img src='https://scottplot.net/images/contributors/vrdriver.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.39</h1>
<div><i>NuGet packages published 2020-08-09</i></div>
<div class='mt-1'>
<ul>
<li>Legend now reflects LineStyle of Signal and SignalXY plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/488">#488</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved mouse wheel zoom-to-cursor and middle-click-drag rectangle zoom in the WPF control for systems that use display scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/490">#490</a>) <a href="https://github.com/nashilnik"><strong>@nashilnik</strong></a>
</li>
<li>The <code>Configure()</code> method of user controls now has a <code>lowQualityAlways</code> argument to let the user easily enable/disable anti-aliasing at the control level. Previously this was only configurable by reaching into the control's plot object and calling its <code>AntiAlias()</code> method. (<a href="https://github.com/ScottPlot/ScottPlot/issues/499">#499</a>) <a href="https://github.com/RachamimYaakobov"><strong>@RachamimYaakobov</strong></a>
</li>
<li>SignalXY now supports parallel processing (<a href="https://github.com/ScottPlot/ScottPlot/issues/500">#500</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>SignalXY now respects index-based render limits (<a href="https://github.com/ScottPlot/ScottPlot/issues/493">#493</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/500">#500</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/envine"><strong>@envine</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/nashilnik'>@nashilnik</a>, <a href='https://github.com/RachamimYaakobov'>@RachamimYaakobov</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/envine'>@envine</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/nashilnik'><img src='https://scottplot.net/images/contributors/nashilnik.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RachamimYaakobov'><img src='https://scottplot.net/images/contributors/rachamimyaakobov.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/envine'><img src='https://scottplot.net/images/contributors/envine.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.38</h1>
<div><i>NuGet packages published 2020-07-07</i></div>
<div class='mt-1'>
<ul>
<li>Improved <code>Plot.PlotFillAboveBelow()</code> rendering of data with a non-zero baseline (<a href="https://github.com/ScottPlot/ScottPlot/issues/477">#477</a>) <a href="https://github.com/el-aasi"><strong>@el-aasi</strong></a>
</li>
<li>Added <code>Plot.PlotWaterfall()</code> for easy creation of waterfall-style bar plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/463">#463</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/476">#476</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Axis tick labels can be displayed using notations other than base 10 by supplying <code>Plot.Ticks()</code> with <code>base</code> and <code>prefix</code> arguments, allowing axes that display binary (e.g., <code>0b100110</code>) or hexadecimal (eg., <code>0x4B0D10</code>) tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/469">#469</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/457">#457</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Added options to <code>PlotBar()</code> to facilitate customization of text displayed above bars when <code>showValue</code> is enabled (<a href="https://github.com/ScottPlot/ScottPlot/issues/483">#483</a>) <a href="https://github.com/WillemWever"><strong>@WillemWever</strong></a>
</li>
<li>Plot objects are colored based on a pre-defined set of colors. The default colorset (category10) is the same palette of colors used by matplotlib. A new <code>Colorset</code> module has been created to better define this behavior, and <code>Plot.Colorset()</code> makes it easy to plot data using alternative colorsets. (<a href="https://github.com/ScottPlot/ScottPlot/issues/481">#481</a>)
</li>
<li>Fixed a bug that caused instability when a population plot is zoomed-out so much that its fractional distribution curve is smaller than a single pixel (<a href="https://github.com/ScottPlot/ScottPlot/issues/480">#480</a>) <a href="https://github.com/HowardWhile"><strong>@HowardWhile</strong></a>
</li>
<li>Added <code>Plot.Remove()</code> method to make it easier to specifically remove an individual plottable after it has been plotted. <code>Plot.Clear()</code> is similar, but designed to remove classes of plot types rather than a specific plot object. (<a href="https://github.com/ScottPlot/ScottPlot/issues/479">#479</a>) <a href="https://github.com/cstyx"><strong>@cstyx</strong></a> and <a href="https://github.com/Resonanz"><strong>@Resonanz</strong></a>
</li>
<li>Signal plots can now be created with a defined <code>minRenderIndex</code> (in addition to the already-supported <code>maxRenderIndex</code>) to facilitate partial display of large arrays (<a href="https://github.com/ScottPlot/ScottPlot/issues/474">#474</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/el-aasi'>@el-aasi</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/WillemWever'>@WillemWever</a>, <a href='https://github.com/HowardWhile'>@HowardWhile</a>, <a href='https://github.com/cstyx'>@cstyx</a>, <a href='https://github.com/Resonanz'>@Resonanz</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/el-aasi'><img src='https://scottplot.net/images/contributors/el-aasi.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/WillemWever'><img src='https://scottplot.net/images/contributors/willemwever.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/HowardWhile'><img src='https://scottplot.net/images/contributors/howardwhile.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/cstyx'><img src='https://scottplot.net/images/contributors/cstyx.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Resonanz'><img src='https://scottplot.net/images/contributors/resonanz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.37</h1>
<div><i>NuGet packages published 2020-06-22</i></div>
<div class='mt-1'>
<ul>
<li>Fixed a long-running issue related to strong assembly versioning that caused the WPF control to fail to render in the Visual Studio designer in .NET Framework (but not .NET Core) projects (<a href="https://github.com/ScottPlot/ScottPlot/issues/473">#473</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/466">#466</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/356">#356</a>) <a href="https://github.com/bhairav-thakkar"><strong>@bhairav-thakkar</strong></a>, <a href="https://github.com/riquich"><strong>@riquich</strong></a>, <a href="https://github.com/Helitune-RobMcKay"><strong>@Helitune-RobMcKay</strong></a>, and <a href="https://github.com/iu2kxv"><strong>@iu2kxv</strong></a>
</li>
<li>User controls now also target <code>net472</code> (while still supporting <code>net461</code> and <code>netcoreapp3.0</code>) to produce a build folder with just 3 DLLs (compared to over 100 when building with .NET Framework 4.6.1)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bhairav-thakkar'>@bhairav-thakkar</a>, <a href='https://github.com/riquich'>@riquich</a>, <a href='https://github.com/Helitune-RobMcKay'>@Helitune-RobMcKay</a>, <a href='https://github.com/iu2kxv'>@iu2kxv</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bhairav-thakkar'><img src='https://scottplot.net/images/contributors/bhairav-thakkar.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/riquich'><img src='https://scottplot.net/images/contributors/riquich.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Helitune-RobMcKay'><img src='https://scottplot.net/images/contributors/helitune-robmckay.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/iu2kxv'><img src='https://scottplot.net/images/contributors/iu2kxv.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.36</h1>
<div><i>NuGet packages published 2020-06-22</i></div>
<div class='mt-1'>
<ul>
<li><code>PlotSignal()</code> and <code>PlotSignalXY()</code> plots now have an optional <code>useParallel</code> argument (and public property on the objects they return) to allow the user to decide whether parallel or sequential calculations will be performed. (<a href="https://github.com/ScottPlot/ScottPlot/issues/454">#454</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/419">#419</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/245">#245</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/72">#72</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved minor tick alignment to prevent rare single-pixel artifacts (<a href="https://github.com/ScottPlot/ScottPlot/issues/417">#417</a>)
</li>
<li>Improved horizontal axis tick label positions in ruler mode (<a href="https://github.com/ScottPlot/ScottPlot/issues/453">#453</a>)
</li>
<li>Added a <code>Statistics.Interpolation</code> module to generate smooth interpolated splines from a small number of input data points. See advanced statistics cookbook example for usage information. (<a href="https://github.com/ScottPlot/ScottPlot/issues/459">#459</a>)Hans-Peter Moser
</li>
<li>Improved automatic axis adjustment when adding bar plots with negative values (<a href="https://github.com/ScottPlot/ScottPlot/issues/461">#461</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/462">#462</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Created <code>Drawing.Colormaps</code> module which has over a dozen colormaps for easily converting a fractional value to a color for use in plotting or heatmap displays (<a href="https://github.com/ScottPlot/ScottPlot/issues/457">#457</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/458">#458</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Updated <code>Plot.Clear()</code> to accept any <code>Plottable</code> as an argument, and all <code>Plottable</code> objects of the same type will be cleared (<a href="https://github.com/ScottPlot/ScottPlot/issues/464">#464</a>) <a href="https://github.com/imka-code"><strong>@imka-code</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/imka-code'>@imka-code</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/imka-code'><img src='https://scottplot.net/images/contributors/imka-code.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.35</h1>
<div><i>NuGet packages published 2020-06-09</i></div>
<div class='mt-1'>
<ul>
<li>Added <code>processEvents</code> argument to <code>formsPlot2.Render()</code> to provide a performance enhancement when linking axes of two <code>FormsPlot</code> controls together (by calling <code>Plot.MatchAxis()</code> from the control's <code>AxesChanged</code> event, as seen in theLinked Axes demo application) (<a href="https://github.com/ScottPlot/ScottPlot/issues/451">#451</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/452">#452</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/robokamran"><strong>@robokamran</strong></a>
</li>
<li>New <code>Plot.PlotVectorField()</code> method for displaying vector fields (sometimes called quiver plots) (<a href="https://github.com/ScottPlot/ScottPlot/issues/438">#438</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/439">#439</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/440">#440</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/hhubschle"><strong>@hhubschle</strong></a>
</li>
<li>Included an experimental colormap module which is likely to evolve over subsequent releases (<a href="https://github.com/ScottPlot/ScottPlot/issues/420">#420</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/424">#424</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/442">#442</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li><code>PlotScatterHighlight()</code> was created as a type of scatter plot designed specifically for applications where &quot;show value on hover&quot; functionality is desired. Examples are both in the cookbook and WinForms and WPF demo applications. (<a href="https://github.com/ScottPlot/ScottPlot/issues/415">#415</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/414">#414</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>PlotRadar()</code> is a new plot type for creating Radar plots (also called spider plots or star plots). See cookbook and demo application for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/428">#428</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/430">#430</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li><code>PlotPlolygons()</code> is a new performance-optimized variant of <code>PlotPolygon()</code> designed for displaying large numbers of complex shapes (<a href="https://github.com/ScottPlot/ScottPlot/issues/426">#426</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>The WinForms control's <code>Configure()</code> now has a <code>showCoordinatesTooltip</code> argument to continuously display the position at the tip of the cursor as a tooltip (<a href="https://github.com/ScottPlot/ScottPlot/issues/410">#410</a>) <a href="https://github.com/jcbeppler"><strong>@jcbeppler</strong></a>
</li>
<li>User controls now use SHIFT (previously ALT) to lock the horizontal axis and ALT (previously SHIFT) while left-click-dragging for zoom-to-region. Holding CTRL+SHIFT while right-click-dragging now zooms evenly, without X/Y distortion. (<a href="https://github.com/ScottPlot/ScottPlot/issues/436">#436</a>) <a href="https://github.com/tomwimmenhove"><strong>@tomwimmenhove</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Parallel processing is now enabled by default. Performance improvements will be most noticeable on Signal plots. (<a href="https://github.com/ScottPlot/ScottPlot/issues/419">#419</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/245">#245</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/72">#72</a>)
</li>
<li><code>Plot.PlotBar()</code> now has an <code>autoAxis</code> argument (which defaults <code>true</code>) that automatically adjusts the axis limits so the base of the bar graphs touch the edge of the plot area. (<a href="https://github.com/ScottPlot/ScottPlot/issues/406">#406</a>)
</li>
<li>OSX-specific DLLs are now only retrieved by NuGet on OSX (<a href="https://github.com/ScottPlot/ScottPlot/issues/433">#433</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/211">#211</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/212">#212</a>)
</li>
<li>Pie charts can now be made with <code>plt.PlotPie()</code>. See cookbook and demo application for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/421">#421</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/423">#423</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li><code>ScottPlot.FormsPlotViewer(Plot)</code> no longer resets the new window's plot to the default style (<a href="https://github.com/ScottPlot/ScottPlot/issues/416">#416</a>)  <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Controls now have a <code>recalculateLayoutOnMouseUp</code> option to prevent resetting of manually-defined data area padding
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/robokamran'>@robokamran</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/hhubschle'>@hhubschle</a>, <a href='https://github.com/jcbeppler'>@jcbeppler</a>, <a href='https://github.com/tomwimmenhove'>@tomwimmenhove</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/robokamran'><img src='https://scottplot.net/images/contributors/robokamran.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/hhubschle'><img src='https://scottplot.net/images/contributors/hhubschle.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/jcbeppler'><img src='https://scottplot.net/images/contributors/jcbeppler.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/tomwimmenhove'><img src='https://scottplot.net/images/contributors/tomwimmenhove.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.34</h1>
<div><i>NuGet packages published 2020-05-18</i></div>
<div class='mt-1'>
<ul>
<li>Improve display of <code>PlotSignalXY()</code> by not rendering markers when zoomed very far out (<a href="https://github.com/ScottPlot/ScottPlot/issues/402">#402</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
<li>Optimized rendering of solid lines which have a user-definable <code>LineStyle</code> property. This modification improves grid line rendering and increases performance for most types of plots. (<a href="https://github.com/ScottPlot/ScottPlot/issues/401">#401</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/327">#327</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'>@gobikulandaisamy</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'><img src='https://scottplot.net/images/contributors/gobikulandaisamy.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.33</h1>
<div><i>NuGet packages published 2020-05-18</i></div>
<div class='mt-1'>
<ul>
<li>Force grid lines to always draw using anti-aliasing. This compensates for a bug in <code>System.Drawing</code> that may cause diagonal line artifacts to appear when the user controls were panned or zoomed. (<a href="https://github.com/ScottPlot/ScottPlot/issues/401">#401</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/327">#327</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.32</h1>
<div><i>NuGet packages published 2020-05-17</i></div>
<div class='mt-1'>
<ul>
<li>User controls now have a <code>GetMouseCoordinates()</code> method which returns the DPI-aware position of the mouse in graph coordinates (<a href="https://github.com/ScottPlot/ScottPlot/issues/379">#379</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/380">#380</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Default grid color was lightened in the user controls to match the default style (<a href="https://github.com/ScottPlot/ScottPlot/issues/372">#372</a>)
</li>
<li>New <code>PlotSignalXY()</code> method for high-speed rendering of signal data that has unevenly-spaced X coordinates (<a href="https://github.com/ScottPlot/ScottPlot/issues/374">#374</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/375">#375</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/LogDogg"><strong>@LogDogg</strong></a>
</li>
<li>Modify <code>Tools.Log10()</code> to return <code>0</code> instead of <code>NaN</code>, improving automatic axis limit detection (<a href="https://github.com/ScottPlot/ScottPlot/issues/376">#376</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/377">#377</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>WpfPlotViewer and FormsPlotViewer launch in center of parent window (<a href="https://github.com/ScottPlot/ScottPlot/issues/378">#378</a>)
</li>
<li>Improve reliability of <code>Plot.AxisAutoX()</code> and <code>Plot.AxisAutoY()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/382">#382</a>)
</li>
<li>The <code>Configure()</code> method of FormsPlot and WpfPlot controls now have <code>middleClickMarginX</code> and <code>middleClickMarginY</code> arguments which define horizontal and vertical auto-axis margin used for middle-clicking. Setting horizontal margin to 0 is typical when plotting signals. (<a href="https://github.com/ScottPlot/ScottPlot/issues/383">#383</a>)
</li>
<li><code>Plot.Grid()</code> and <code>Plot.Ticks()</code> now have a <code>snapToNearestPixel</code> argument which controls whether these lines appear anti-aliased or not. For static images non-anti-aliased grid lines and tick marks look best, but for continuously-panning plots anti-aliased lines look better. The default behavior is to enable snapping to the nearest pixel, consistent with previous releases. (<a href="https://github.com/ScottPlot/ScottPlot/issues/384">#384</a>)
</li>
<li>Mouse events (MouseDown, MouseMove, etc.) are now properly forwarded to the FormsPlot control (<a href="https://github.com/ScottPlot/ScottPlot/issues/390">#390</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Improved rendering of very small candlesticks and OHLCs in financial plots
</li>
<li>Labeled plottables now display their label in the ToString() output. This is useful when viewing plottables listed in the FormsPlot settings window <a href="https://github.com/ScottPlot/ScottPlot/issues/391">#391</a> <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Added a Statistics.Finance module with methods for creating Simple Moving Average (SMA) and Bollinger band technical indicators to Candlestick and OHLC charts. Examples are in the cookbook and demo program. (<a href="https://github.com/ScottPlot/ScottPlot/issues/397">#397</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Scatter plots, filled plots, and polygon plots now support Xs and Ys which contain <code>double.NaN</code> <a href="https://github.com/ScottPlot/ScottPlot/issues/396">#396</a>
</li>
<li>Added support for line styles to Signal plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/392">#392</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/LogDogg'>@LogDogg</a>, <a href='https://github.com/Minu476'>@Minu476</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LogDogg'><img src='https://scottplot.net/images/contributors/logdogg.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Minu476'><img src='https://scottplot.net/images/contributors/minu476.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.31</h1>
<div><i>NuGet packages published 2020-05-06</i></div>
<div class='mt-1'>
<ul>
<li>Created <code>Plot.PlotBarGroups()</code> for easier construction of grouped bar plots from 2D data (<a href="https://github.com/ScottPlot/ScottPlot/issues/367">#367</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Plot.PlotScaleBar() adds an L-shaped scalebar to the corner of the plot (<a href="https://github.com/ScottPlot/ScottPlot/issues/363">#363</a>)
</li>
<li>Default grid color lightened from #D3D3D3 (Color.LightGray) to #EFEFEF (<a href="https://github.com/ScottPlot/ScottPlot/issues/372">#372</a>)
</li>
<li>Improved error reporting for scatter plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/369">#369</a>) <a href="https://github.com/JagDTalcyon"><strong>@JagDTalcyon</strong></a>
</li>
<li>Improve pixel alignment by hiding grid lines and snapping tick marks that are 1px away from the lower left edge (<a href="https://github.com/ScottPlot/ScottPlot/issues/359">#359</a>)
</li>
<li>PlotText() ignores defaults to upperLeft alignment when rotation is used (<a href="https://github.com/ScottPlot/ScottPlot/issues/362">#362</a>)
</li>
<li>Improved minor tick positioning to prevent cases where minor ticks are 1px away from major ticks (<a href="https://github.com/ScottPlot/ScottPlot/issues/373">#373</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/JagDTalcyon'>@JagDTalcyon</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JagDTalcyon'><img src='https://scottplot.net/images/contributors/jagdtalcyon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.30</h1>
<div><i>NuGet packages published 2020-05-04</i></div>
<div class='mt-1'>
<ul>
<li><code>Plot.PlotCandlestick()</code> and <code>Plot.PlotOHLC()</code>
</li>
<li>Fixed a marker/line alignment issue that only affeced low-density Signal plots on Linux and MacOS (<a href="https://github.com/ScottPlot/ScottPlot/issues/340">#340</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li>WPF control now appears in Toolbox (<a href="https://github.com/ScottPlot/ScottPlot/issues/151">#151</a>) <a href="https://github.com/RalphLAtGitHub"><strong>@RalphLAtGitHub</strong></a>
</li>
<li>Plot titles are now center-aligned with the data area, not the figure. This improves the look of small plots with titles. (<a href="https://github.com/ScottPlot/ScottPlot/issues/365">#365</a>) <a href="https://github.com/Resonanz"><strong>@Resonanz</strong></a>
</li>
<li>Fixed bug that ignored <code>Configure(enableRightClickMenu: false)</code> in WPF and WinForms user controls. (<a href="https://github.com/ScottPlot/ScottPlot/issues/365">#365</a>) <a href="https://github.com/thunderstatic"><strong>@thunderstatic</strong></a>
</li>
<li>Updated <code>Configure(enableScrollWheelZoom: false)</code> to disable middle-click-drag zooming. (<a href="https://github.com/ScottPlot/ScottPlot/issues/365">#365</a>) <a href="https://github.com/eduhza"><strong>@eduhza</strong></a>
</li>
<li>Added color mixing methods to ScottPlot.Drawing.GDI (<a href="https://github.com/ScottPlot/ScottPlot/issues/361">#361</a>)
</li>
<li>Middle-click-drag zooming now respects locked axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/353">#353</a>) <a href="https://github.com/LogDogg"><strong>@LogDogg</strong></a>
</li>
<li>Improved user control zooming of high-precision DateTime axis data (<a href="https://github.com/ScottPlot/ScottPlot/issues/351">#351</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Plot.AxisBounds() now lets user set absolute bounds for drag and pan operations (<a href="https://github.com/ScottPlot/ScottPlot/issues/349">#349</a>) <a href="https://github.com/LogDogg"><strong>@LogDogg</strong></a>
</li>
<li>WPF control uses improved Bitmap conversion method (<a href="https://github.com/ScottPlot/ScottPlot/issues/350">#350</a>)
</li>
<li>Function plots have improved handling of functions with infinite values (<a href="https://github.com/ScottPlot/ScottPlot/issues/370">#370</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/SeidChr'>@SeidChr</a>, <a href='https://github.com/RalphLAtGitHub'>@RalphLAtGitHub</a>, <a href='https://github.com/Resonanz'>@Resonanz</a>, <a href='https://github.com/thunderstatic'>@thunderstatic</a>, <a href='https://github.com/eduhza'>@eduhza</a>, <a href='https://github.com/LogDogg'>@LogDogg</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/SeidChr'><img src='https://scottplot.net/images/contributors/seidchr.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/RalphLAtGitHub'><img src='https://scottplot.net/images/contributors/ralphlatgithub.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Resonanz'><img src='https://scottplot.net/images/contributors/resonanz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/thunderstatic'><img src='https://scottplot.net/images/contributors/thunderstatic.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/eduhza'><img src='https://scottplot.net/images/contributors/eduhza.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/LogDogg'><img src='https://scottplot.net/images/contributors/logdogg.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.29</h1>
<div><i>NuGet packages published 2020-04-11</i></div>
<div class='mt-1'>
<ul>
<li><code>Plot.PlotFill()</code> can be used to make scatter plots with shaded regions. Giving it a single pair of X/Y values (<code>xs, ys</code>) lets you shade beneath the curve to the <code>baseline</code> value (which defaults to 0). You can also give it a pair of X/Y values (<code>xs1, ys1, xs2, ys2</code>) and the area between the two curves will be shaded (the two curves do not need to be the same length). See cookbook for examples. (<a href="https://github.com/ScottPlot/ScottPlot/issues/255">#255</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
<li><code>DataGen.Range()</code> now has <code>includeStop</code> argument to include the last value in the returned array.
</li>
<li><code>Tools.Pad()</code> has been created to return a copy of a given array padded with data values on each side. (<a href="https://github.com/ScottPlot/ScottPlot/issues/255">#255</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
<li><a href="https://seaborn.pydata.org/">Seaborn</a> style can be activated using <code>Plot.Style(Style.Seaborn)</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/339">#339</a>)
</li>
<li>The <code>enableZooming</code> argument in <code>WpfPlot.Configure()</code> and <code>FormsPlot.Configure()</code> has been replaced by two arguments <code>enableRightClickZoom</code> and <code>enableScrollWheelZoom</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/338">#338</a>)Zach
</li>
<li>Improved rendering of legend items for polygons and filled plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/341">#341</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li>Improved Linux rendering of legend items which use thick lines: axis spans, fills, polygons, etc. (<a href="https://github.com/ScottPlot/ScottPlot/issues/340">#340</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li>Addded <code>Plot.PlotFillAboveBelow()</code> to create a shaded line plot with different colors above/below the baseline. (<a href="https://github.com/ScottPlot/ScottPlot/issues/255">#255</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
<li>Improved rendering in Linux and MacOS by refactoring the font measurement system (<a href="https://github.com/ScottPlot/ScottPlot/issues/340">#340</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ckovamees'>@ckovamees</a>, <a href='https://github.com/SeidChr'>@SeidChr</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ckovamees'><img src='https://scottplot.net/images/contributors/ckovamees.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SeidChr'><img src='https://scottplot.net/images/contributors/seidchr.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.28</h1>
<div><i>NuGet packages published 2020-04-07</i></div>
<div class='mt-1'>
<ul>
<li><code>Ticks()</code> now has arguments for numericStringFormat (X and Y) to make it easy to customize formatting of tick labels (percentage, currency, scientific notation, etc.) using standard <a href="https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings">numeric format strings</a>. Example use is demonstrated in the cookbook. (<a href="https://github.com/ScottPlot/ScottPlot/issues/336">#336</a>) <a href="https://github.com/deiruch"><strong>@deiruch</strong></a>
</li>
<li>The right-click menu can now be more easily customized by writing a custom menu to <code>FormsPlot.ContextMenuStrip</code> or <code>WpfPlot.ContextMenu</code>. Demonstrations of both are in the demo application. (<a href="https://github.com/ScottPlot/ScottPlot/issues/337">#337</a>) <a href="https://github.com/Antracik"><strong>@Antracik</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/deiruch'>@deiruch</a>, <a href='https://github.com/Antracik'>@Antracik</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/deiruch'><img src='https://scottplot.net/images/contributors/deiruch.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Antracik'><img src='https://scottplot.net/images/contributors/antracik.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.27</h1>
<div><i>NuGet packages published 2020-04-05</i></div>
<div class='mt-1'>
<ul>
<li><code>Plot.Polygon()</code> can now be used to plot polygons from X/Y points (<a href="https://github.com/ScottPlot/ScottPlot/issues/255">#255</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
<li>User controls now have an &quot;open in new window&quot; item in their right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/280">#280</a>)
</li>
<li>Plots now have offset notation and multiplier notation disabled by default. Layouts are automatically calculated before the first render, or manually after MouseUp events in the user controls. (<a href="https://github.com/ScottPlot/ScottPlot/issues/310">#310</a>)
</li>
<li><code>Plot.Annotation()</code> allows for the placement of text on the figure using pixel coordinates (not unit coordinates on the data grid). This is useful for creating custom static labels or information messages. (<a href="https://github.com/ScottPlot/ScottPlot/issues/321">#321</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li><code>FormsPlot.MouseDoubleClicked</code> event now passes a proper <code>MouseEventArgs</code> instead of <code>null</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/331">#331</a>) <a href="https://github.com/ismdiego"><strong>@ismdiego</strong></a>
</li>
<li>Added a right-click menu to <code>WpfPlot</code> with items (save image, copy image, open in new window, help, etc.) similar to <code>FormsPlot</code>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ckovamees'>@ckovamees</a>, <a href='https://github.com/SeidChr'>@SeidChr</a>, <a href='https://github.com/ismdiego'>@ismdiego</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ckovamees'><img src='https://scottplot.net/images/contributors/ckovamees.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SeidChr'><img src='https://scottplot.net/images/contributors/seidchr.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ismdiego'><img src='https://scottplot.net/images/contributors/ismdiego.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.26</h1>
<div><i>NuGet packages published 2020-04-05</i></div>
<div class='mt-1'>
<ul>
<li>The <code>ScottPlot.WPF</code> package (which provides the <code>WpfPlot</code> user control) now targets .NET Framework 4.7.2 (in addition to .NET Core 3.0), allowing it to be used in applications which target either platform. The ScottPlot demo application now targets .NET Framework 4.7.2 which should be easier to run on most Windows systems. (<a href="https://github.com/ScottPlot/ScottPlot/issues/333">#333</a>)
</li>
<li>The <code>ScottPlot.WinForms</code> package (which produves the <code>FormsPlot</code> control) now only targets .NET Framework 4.6.1 and .NET Core 3.0 platforms (previously it also had build targets for .NET Framework 4.7.2 and .NET Framework 4.8). It is important to note that no functionality was lost here. (<a href="https://github.com/ScottPlot/ScottPlot/issues/330">#330</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/333">#333</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.25</h1>
<div><i>NuGet packages published 2020-03-29</i></div>
<div class='mt-1'>
<ul>
<li><code>PlotBar()</code> now supports displaying values above each bar graph by setting the <code>showValues</code> argument.
</li>
<li><code>PlotPopulations()</code> has extensive capabilities for plotting grouped population data using box plots, bar plots, box and whisper plots, scatter data with distribution curves, and more! See the cookbook for details. (<a href="https://github.com/ScottPlot/ScottPlot/issues/315">#315</a>)
</li>
<li><code>Histogram</code> objects now have a <code>population</code> property.
</li>
<li><code>PopulationStats</code> has been renamed to <code>Population</code> and has additional properties and methods useful for reporting population statistics.
</li>
<li>Improved grid rendering rare artifacts which appear as unwanted diagnal lines when anti-aliasing is disabled. (<a href="https://github.com/ScottPlot/ScottPlot/issues/327">#327</a>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.24</h1>
<div><i>NuGet packages published 2020-03-27</i></div>
<div class='mt-1'>
<ul>
<li><code>Plot.Clear()</code> has been improved to more effectively clear plottable objects. Various overloads are provided to selectively clear or preserve certain plot types. (<a href="https://github.com/ScottPlot/ScottPlot/issues/275">#275</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>PlotBar()</code> has been lightly refactored. Argument order has been adjusted, and additional options have been added. Error cap width is now in fractional units instead of pixel units. Horizontal bar charts are now supported. (<a href="https://github.com/ScottPlot/ScottPlot/issues/277">#277</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/315">#315</a>) <a href="https://github.com/bonzaiferroni"><strong>@bonzaiferroni</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bonzaiferroni'>@bonzaiferroni</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bonzaiferroni'><img src='https://scottplot.net/images/contributors/bonzaiferroni.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.23</h1>
<div><i>NuGet packages published 2020-03-23</i></div>
<div class='mt-1'>
<ul>
<li>Interactive plot viewers were created to make it easy to interactively display data in a pop-up window without having to write any GUI code: <code>ScottPlot.WpfPlotViewer</code> for WPF and <code>ScottPlot.FormsPlotViewer</code> for Windows Forms
</li>
<li>Fixed bug that affected the <code>ySpacing</code> argument of <code>Plot.Grid()</code>
</li>
<li><code>Plot.Add()</code> makes it easy to add a custom <code>Plottable</code> to the plot
</li>
<li><code>Plot.XLabels()</code> and <code>Plot.YLabels()</code> can now accept just a string array (x values are auto-populated as a consecutive series of numbers).
</li>
<li>Aliased <code>Plot.AxisAuto()</code> to <code>Plot.AutoAxis()</code> and <code>Plot.AutoScale()</code> to make this function easier to locate for users who may have experience with other plot libraries. (<a href="https://github.com/ScottPlot/ScottPlot/issues/309">#309</a>) <a href="https://github.com/Resonanz"><strong>@Resonanz</strong></a>
</li>
<li>Empty plots now render grid lines, ticks, and tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/313">#313</a>)
</li>
<li>New plot type: Error bars. They allow the user to define error bar size in all 4 directions by calling <code>plt.PlotErrorBars()</code>. (<a href="https://github.com/ScottPlot/ScottPlot/issues/316">#316</a>) <a href="https://github.com/zrolfs"><strong>@zrolfs</strong></a>
</li>
<li>Improve how dashed lines appear in the legend
</li>
<li>Improved minor tick positions when using log scales with <code>logScaleX</code> and <code>logScaleY</code> arguments of <code>plt.Ticks()</code> method
</li>
<li>Fixed bug that caused the center of the coordinate field to shift when calling <code>Plot.AxisZoom()</code>
</li>
<li>Grid line thickness and style (dashed, dotted, etc) can be customized with new arguments in the <code>Plot.Grid()</code> method
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Resonanz'>@Resonanz</a>, <a href='https://github.com/zrolfs'>@zrolfs</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Resonanz'><img src='https://scottplot.net/images/contributors/resonanz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/zrolfs'><img src='https://scottplot.net/images/contributors/zrolfs.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.22</h1>
<div><i>NuGet packages published 2020-03-17</i></div>
<div class='mt-1'>
<ul>
<li>Added support for custom horizontal axis tick rotation (<a href="https://github.com/ScottPlot/ScottPlot/issues/300">#300</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li>Added support for fixed grid spacing when using DateTime axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/299">#299</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
<li>Updated ScottPlot icon (removed small text, styled icon after emoji)
</li>
<li>Improved legend font size when using display scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/289">#289</a>)
</li>
<li>Scroll wheel zooming now zooms to cursor (instead of center) in WPF control. This feature works now even if display scaling is used. (<a href="https://github.com/ScottPlot/ScottPlot/issues/281">#281</a>)
</li>
<li>Added <code>Plot.EqualAxis</code> property to make it easy to lock axis scales together (<a href="https://github.com/ScottPlot/ScottPlot/issues/306">#306</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/SeidChr'>@SeidChr</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/SeidChr'><img src='https://scottplot.net/images/contributors/seidchr.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.21</h1>
<div><i>NuGet packages published 2020-03-15</i></div>
<div class='mt-1'>
<ul>
<li>Created new cookbook and demo applications for WinForms and WPF (<a href="https://github.com/ScottPlot/ScottPlot/issues/271">#271</a>)
</li>
<li>The <code>FormsPlot.MouseMoved</code> event now has <code>MouseEventArgs</code> (instead of <code>EventArgs</code>). The purpose of this was to make it easy to access mouse pixel coordinates via <code>e.X</code> and <code>e.Y</code>, but this change may require modifications to applications which use the old event signature.
</li>
<li>WpfPlot now has an <code>AxisChanged</code> event (like FormsPlot)
</li>
<li>Fixed bug that caused <code>Plot.CoordinateFromPixelY()</code> to return incorrect value
</li>
<li>Fixed bug causing cursor to show arrows when hovered over some non-draggable objects
</li>
<li>Improved support for WinForms and WpfPlot transparency (<a href="https://github.com/ScottPlot/ScottPlot/issues/286">#286</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/envine"><strong>@envine</strong></a>
</li>
<li>Added <code>DataGen.Zeros()</code> and <code>DataGen.Ones()</code> to generate arrays filled with values using methods familiar to numpy users.
</li>
<li>Added <code>equalAxes</code> argument to <code>WpfPlot.Configure()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/272">#272</a>)
</li>
<li>Fixed a bug affecting the <code>equalAxes</code> argument in <code>FormsPlot.Configure()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/272">#272</a>)
</li>
<li>Made all <code>Plot.Axis</code> methods return axis limits as <code>double[]</code> (previously many of them returned <code>void</code>)
</li>
<li>Added overload for <code>Plot.PlotLine()</code> which accepts a slope, offset, and start and end X points to make it easy to plot a linear line with known formula. Using PlotFormula() will produce the same output, but this may be simpler to use for straight lines.
</li>
<li>Added <code>rSquared</code> property to linear regression fits (<a href="https://github.com/ScottPlot/ScottPlot/issues/290">#290</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added <code>Tools.ConvertPolarCoordinates()</code> to make it easier to display polar data on ScottPlot's Cartesian axes (<a href="https://github.com/ScottPlot/ScottPlot/issues/298">#298</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Improved <code>Plot.Function()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/243">#243</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Added overload for <code>Plot.SetCulture()</code> to let the user define number and date formatting rather than relying on pre-made cultures (<a href="https://github.com/ScottPlot/ScottPlot/issues/301">#301</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/236">#236</a>) <a href="https://github.com/SeidChr"><strong>@SeidChr</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/envine'>@envine</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/SeidChr'>@SeidChr</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/envine'><img src='https://scottplot.net/images/contributors/envine.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/SeidChr'><img src='https://scottplot.net/images/contributors/seidchr.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.19</h1>
<div><i>NuGet packages published 2020-02-29</i></div>
<div class='mt-1'>
<ul>
<li>Improved how markers are drawn in Signal and SignalConst plots at the transition area between zoomed out and zoomed in (<a href="https://github.com/ScottPlot/ScottPlot/issues/263">#263</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved support for zero lineSize and markerSize in Signal and SignalConst plots (<a href="https://github.com/ScottPlot/ScottPlot/issues/263">#263</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/264">#264</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved thread safety of interactive graphs (<a href="https://github.com/ScottPlot/ScottPlot/issues/245">#245</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added <code>CoordinateFromPixelX()</code> and <code>CoordinateFromPixelY()</code> to getdouble precision coordinates from a pixel location. Previously only SizeF (float) precision was available. This improvement is especially useful when using DateTime axes. (<a href="https://github.com/ScottPlot/ScottPlot/issues/269">#269</a>)Chris
</li>
<li>Added <code>AxisScale()</code> to adjust axis limits to set a defined scale (units per pixel) for each axis.
</li>
<li>Added <code>AxisEqual()</code> to adjust axis limits to set the scale of both axes to be the same regardless of the size of each axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/272">#272</a>) <a href="https://github.com/gberrante"><strong>@gberrante</strong></a>
</li>
<li><code>PlotHSpan()</code> and <code>PlotVSpan()</code> now return <code>PlottableHSpan</code> and <code>PlottableVSpan</code> objects (instead of a <code>PlottableAxSpan</code> with a <code>vertical</code> property)
</li>
<li><code>PlotHLine()</code> and <code>PlotVLine()</code> now return <code>PlottableHLine</code> and <code>PlottableVLine</code> objects (instead of a <code>PlottableAxLine</code> with a <code>vertical</code> property)
</li>
<li>MultiPlot now has a <code>GetSubplot()</code> method which returns the Plot from a row and column index (<a href="https://github.com/ScottPlot/ScottPlot/issues/242">#242</a>) <a href="https://github.com/Resonanz"><strong>@Resonanz</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Created <code>DataGen.Range()</code> to make it easy to create double arrays with evenly spaced data (<a href="https://github.com/ScottPlot/ScottPlot/issues/259">#259</a>)
</li>
<li>Improved support for display scaling (<a href="https://github.com/ScottPlot/ScottPlot/issues/273">#273</a>) <a href="https://github.com/zrolfs"><strong>@zrolfs</strong></a>
</li>
<li>Improved event handling (<a href="https://github.com/ScottPlot/ScottPlot/issues/266">#266</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/238">#238</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved legend positioning (<a href="https://github.com/ScottPlot/ScottPlot/issues/253">#253</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/gberrante'>@gberrante</a>, <a href='https://github.com/Resonanz'>@Resonanz</a>, <a href='https://github.com/zrolfs'>@zrolfs</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/gberrante'><img src='https://scottplot.net/images/contributors/gberrante.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Resonanz'><img src='https://scottplot.net/images/contributors/resonanz.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/zrolfs'><img src='https://scottplot.net/images/contributors/zrolfs.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.18</h1>
<div><i>NuGet packages published 2020-02-07</i></div>
<div class='mt-1'>
<ul>
<li>Added <code>Plot.SetCulture()</code> for improved local culture formatting of numerical and DateTime axis tick labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/236">#236</a>) <a href="https://github.com/teejay-87"><strong>@teejay-87</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/teejay-87'>@teejay-87</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/teejay-87'><img src='https://scottplot.net/images/contributors/teejay-87.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.17</h1>
<div><i>NuGet packages published 2020-02-06</i></div>
<div class='mt-1'>
<ul>
<li>Added <code>mouseCoordinates</code> property to WinForms and WPF controls (<a href="https://github.com/ScottPlot/ScottPlot/issues/235">#235</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Fixed rendering bug that affected horizontal lines when anti-aliasing was turned off (<a href="https://github.com/ScottPlot/ScottPlot/issues/232">#232</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Improved responsiveness while dragging axis lines and axis spans (<a href="https://github.com/ScottPlot/ScottPlot/issues/228">#228</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.16</h1>
<div><i>NuGet packages published 2020-02-02</i></div>
<div class='mt-1'>
<ul>
<li>Improved support for MacOS and Linux (<a href="https://github.com/ScottPlot/ScottPlot/issues/211">#211</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/212">#212</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/216">#216</a>) <a href="https://github.com/hexxone"><strong>@hexxone</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Fixed a bug affecting the <code>ySpacing</code> argument in <code>Plot.Grid()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/221">#221</a>) <a href="https://github.com/teejay-87"><strong>@teejay-87</strong></a>
</li>
<li>Enabled <code>visible</code> argument in <code>Title()</code>, <code>XLabel()</code>, and <code>YLabel()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/222">#222</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
<li>AxisSpan: Edges are now optionally draggable (<a href="https://github.com/ScottPlot/ScottPlot/issues/228">#228</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>AxisSpan: Can now be selectively removed with <code>Clear()</code> argument
</li>
<li>AxisSpan: Fixed bug caused by zooming far into an axis span (<a href="https://github.com/ScottPlot/ScottPlot/issues/226">#226</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>WinForms control: now supports draggable axis lines and axis spans
</li>
<li>WinForms control: Right-click menu now has &quot;copy image&quot; option (<a href="https://github.com/ScottPlot/ScottPlot/issues/220">#220</a>)
</li>
<li>WinForms control: Settings screen now has &quot;copy CSV&quot; button to export data (<a href="https://github.com/ScottPlot/ScottPlot/issues/220">#220</a>)
</li>
<li>WPF control: now supports draggable axis lines and axis spans
</li>
<li>WPF control: Configure() to set various WPF control options
</li>
<li>Improved axis handling, expansion, and auto-axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/219">#219</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/230">#230</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added more options to <code>DataGen.Cos()</code>
</li>
<li>Tick labels can be hidden with <code>Ticks()</code> argument (<a href="https://github.com/ScottPlot/ScottPlot/issues/223">#223</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/hexxone'>@hexxone</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/teejay-87'>@teejay-87</a>, <a href='https://github.com/ckovamees'>@ckovamees</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/hexxone'><img src='https://scottplot.net/images/contributors/hexxone.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/teejay-87'><img src='https://scottplot.net/images/contributors/teejay-87.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ckovamees'><img src='https://scottplot.net/images/contributors/ckovamees.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.14</h1>
<div><i>NuGet packages published 2020-01-24</i></div>
<div class='mt-1'>
<ul>
<li>Improved <code>MatchAxis()</code> and <code>MatchLayout()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/217">#217</a>) <a href="https://github.com/ckovamees"><strong>@ckovamees</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ckovamees'>@ckovamees</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ckovamees'><img src='https://scottplot.net/images/contributors/ckovamees.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.13</h1>
<div><i>NuGet packages published 2020-01-21</i></div>
<div class='mt-1'>
<ul>
<li>Improved support for Linux and MacOS <a href="https://github.com/hexxone"><strong>@hexxone</strong></a>
</li>
<li>Improved font validation (<a href="https://github.com/ScottPlot/ScottPlot/issues/211">#211</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/212">#212</a>) <a href="https://github.com/hexxone"><strong>@hexxone</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/hexxone'>@hexxone</a>, <a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/hexxone'><img src='https://scottplot.net/images/contributors/hexxone.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.11</h1>
<div><i>NuGet packages published 2020-01-19</i></div>
<div class='mt-1'>
<ul>
<li>User controls now have a <code>cursor</code> property which can be set to allow custom cursors. (<a href="https://github.com/ScottPlot/ScottPlot/issues/187">#187</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
<li>User controls now have a <code>mouseCoordinates</code> property which make it easy to get the X/Y location of the cursor. (<a href="https://github.com/ScottPlot/ScottPlot/issues/187">#187</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'>@gobikulandaisamy</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'><img src='https://scottplot.net/images/contributors/gobikulandaisamy.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.10</h1>
<div><i>NuGet packages published 2020-01-18</i></div>
<div class='mt-1'>
<ul>
<li>Improved density colormap (<a href="https://github.com/ScottPlot/ScottPlot/issues/192">#192</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/194">#194</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Added linear regression tools and cookbook example (<a href="https://github.com/ScottPlot/ScottPlot/issues/198">#198</a>) <a href="https://github.com/bclehmann"><strong>@bclehmann</strong></a>
</li>
<li>Added <code>maxRenderIndex</code> to Signal to allow partial plotting of large arrays intended to be used with live, incoming data (<a href="https://github.com/ScottPlot/ScottPlot/issues/202">#202</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a> and <a href="https://github.com/plumforest"><strong>@plumforest</strong></a>
</li>
<li>MadeShift + Left-click-drag zoom into a rectangle light middle-click-drag (in WinForms and WPF controls) to add support for mice with no middle button (<a href="https://github.com/ScottPlot/ScottPlot/issues/90">#90</a>) <a href="https://github.com/JagDTalcyon"><strong>@JagDTalcyon</strong></a>
</li>
<li>Throw an exception if <code>SaveFig()</code> is called before the image is properly sized (<a href="https://github.com/ScottPlot/ScottPlot/issues/192">#192</a>) <a href="https://github.com/karimshams"><strong>@karimshams</strong></a> and <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>Ticks()</code> now has arguments for <code>FontName</code> and <code>FontSize</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/204">#204</a>)Clay
</li>
<li>Fixed a bug that caused poor layout due to incorrect title label size estimation (<a href="https://github.com/ScottPlot/ScottPlot/issues/205">#205</a>)Clay
</li>
<li><code>Grid()</code> now has arguments to selectively enable/disable horizontal and vertical grid lines (<a href="https://github.com/ScottPlot/ScottPlot/issues/206">#206</a>)Clay
</li>
<li>Added tool and cookbook example to make it easier to plot data on a log axis (<a href="https://github.com/ScottPlot/ScottPlot/issues/207">#207</a>) <a href="https://github.com/senged"><strong>@senged</strong></a>
</li>
<li>Arrows can be plotted using <code>plt.PlotArrow()</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/201">#201</a>)Clay
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/bclehmann'>@bclehmann</a>, <a href='https://github.com/plumforest'>@plumforest</a>, <a href='https://github.com/JagDTalcyon'>@JagDTalcyon</a>, <a href='https://github.com/karimshams'>@karimshams</a>, <a href='https://github.com/senged'>@senged</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bclehmann'><img src='https://scottplot.net/images/contributors/bclehmann.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/plumforest'><img src='https://scottplot.net/images/contributors/plumforest.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/JagDTalcyon'><img src='https://scottplot.net/images/contributors/jagdtalcyon.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/karimshams'><img src='https://scottplot.net/images/contributors/karimshams.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/senged'><img src='https://scottplot.net/images/contributors/senged.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.9</h1>
<div><i>NuGet packages published 2019-12-03</i></div>
<div class='mt-1'>
<ul>
<li>Use local regional display settings when formatting the month tick of DateTime axes. (<a href="https://github.com/ScottPlot/ScottPlot/issues/108">#108</a>) <a href="https://github.com/FadyDev2"><strong>@FadyDev2</strong></a>
</li>
<li>Debug symbols are now packaged in the NuGet file
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/FadyDev2'>@FadyDev2</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/FadyDev2'><img src='https://scottplot.net/images/contributors/fadydev2.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.7</h1>
<div><i>NuGet packages published 2019-12-01\</i></div>
<div class='mt-1'>
<ul>
<li>Added WinForms support for .NET Framework 4.7.2 and 4.8
</li>
<li>Fixed bug in WinForms control that only affected .NET Core 3.0 applications (<a href="https://github.com/ScottPlot/ScottPlot/issues/189">#189</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/138">#138</a>) <a href="https://github.com/petarpetrovt"><strong>@petarpetrovt</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/petarpetrovt'>@petarpetrovt</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/petarpetrovt'><img src='https://scottplot.net/images/contributors/petarpetrovt.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.6</h1>
<div><i>NuGet packages published 2019-11-29\</i></div>
<div class='mt-1'>
<ul>
<li>fixed bug that affected the settings dialog window in the WinForms control. (<a href="https://github.com/ScottPlot/ScottPlot/issues/187">#187</a>) <a href="https://github.com/gobikulandaisamy"><strong>@gobikulandaisamy</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'>@gobikulandaisamy</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/gobikulandaisamy'><img src='https://scottplot.net/images/contributors/gobikulandaisamy.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.5</h1>
<div><i>NuGet packages published 2019-11-27</i></div>
<div class='mt-1'>
<ul>
<li>improved spacing for non-uniformly distributed OHLC and candlestick plots. (<a href="https://github.com/ScottPlot/ScottPlot/issues/184">#184</a>) <a href="https://github.com/Luvnet-890"><strong>@Luvnet-890</strong></a>
</li>
<li>added <code>fixedLineWidth</code> to <code>Legend()</code> to allow the user to control whether legend lines are dynamically sized. (<a href="https://github.com/ScottPlot/ScottPlot/issues/185">#185</a>) <a href="https://github.com/ab-tools"><strong>@ab-tools</strong></a>
</li>
<li>legend now hides lines or markers of they're hidden in the plottable
</li>
<li>DateTime axes now use local display format (<a href="https://github.com/ScottPlot/ScottPlot/issues/108">#108</a>) <a href="https://github.com/FadyDev2"><strong>@FadyDev2</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Luvnet-890'>@Luvnet-890</a>, <a href='https://github.com/ab-tools'>@ab-tools</a>, <a href='https://github.com/FadyDev2'>@FadyDev2</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Luvnet-890'><img src='https://scottplot.net/images/contributors/luvnet-890.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/ab-tools'><img src='https://scottplot.net/images/contributors/ab-tools.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/FadyDev2'><img src='https://scottplot.net/images/contributors/fadydev2.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.4</h1>
<div><i>NuGet packages published 2019-11-24</i></div>
<div class='mt-1'>
<ul>
<li><code>PlotText()</code> now supports a background frame (<a href="https://github.com/ScottPlot/ScottPlot/issues/181">#181</a>) <a href="https://github.com/Luvnet-890"><strong>@Luvnet-890</strong></a>
</li>
<li>OHLC objects can be created with a double or a DateTime (<a href="https://github.com/ScottPlot/ScottPlot/issues/182">#182</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Improved <code>AxisAuto()</code> fixes bug for mixed 2d and axis line plots
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Luvnet-890'>@Luvnet-890</a>, <a href='https://github.com/Minu476'>@Minu476</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Luvnet-890'><img src='https://scottplot.net/images/contributors/luvnet-890.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Minu476'><img src='https://scottplot.net/images/contributors/minu476.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.3</h1>
<div><i>NuGet packages published 2019-11-23</i></div>
<div class='mt-1'>
<ul>
<li>Fixed bug when plotting single-point candlestick (<a href="https://github.com/ScottPlot/ScottPlot/issues/172">#172</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Improved style editing of plotted objects (<a href="https://github.com/ScottPlot/ScottPlot/issues/173">#173</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Fixed pan/zoom axis lock when holding CTRL or ALT (<a href="https://github.com/ScottPlot/ScottPlot/issues/90">#90</a>) <a href="https://github.com/FadyDev2"><strong>@FadyDev2</strong></a>
</li>
<li>Simplified the look of the user controls in designer mode
</li>
<li>Improved WPF control mouse tracking when using DPI scaling
</li>
<li>Added support for manual tick positions and labels (<a href="https://github.com/ScottPlot/ScottPlot/issues/174">#174</a>) <a href="https://github.com/Minu476"><strong>@Minu476</strong></a>
</li>
<li>Improved tick system when using DateTime units (<a href="https://github.com/ScottPlot/ScottPlot/issues/108">#108</a>) <a href="https://github.com/Padanian"><strong>@Padanian</strong></a>, <a href="https://github.com/FadyDev2"><strong>@FadyDev2</strong></a>, and <a href="https://github.com/Bhandejiya"><strong>@Bhandejiya</strong></a>
</li>
<li>Created <code>Tools.DateTimesToDoubles(DateTime[] array)</code> to easily convert an array of dates to doubles which can be plotted with ScottPlot, then displayed as time using <code>plt.Ticks(dateTimeX: true)</code>.
</li>
<li>Added an inverted sign flag to allow display of an axis with descending units. (<a href="https://github.com/ScottPlot/ScottPlot/issues/177">#177</a>)Bart
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/Minu476'>@Minu476</a>, <a href='https://github.com/FadyDev2'>@FadyDev2</a>, <a href='https://github.com/Padanian'>@Padanian</a>, <a href='https://github.com/Bhandejiya'>@Bhandejiya</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/Minu476'><img src='https://scottplot.net/images/contributors/minu476.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/FadyDev2'><img src='https://scottplot.net/images/contributors/fadydev2.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Padanian'><img src='https://scottplot.net/images/contributors/padanian.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Bhandejiya'><img src='https://scottplot.net/images/contributors/bhandejiya.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.2</h1>
<div><i>NuGet packages published 2019-11-09</i></div>
<div class='mt-1'>
<ul>
<li>Multi-plot figures: Images with several plots can be created using <code>ScottPlot.MultiPlot()</code>
</li>
<li><code>ScottPlot.DataGen</code> functions which require a <code>Random</code> can accept null (they will create a <code>Random</code> if null is given)
</li>
<li><code>plt.MatchAxis()</code> and <code>plt.MatchLayout()</code> have been improved
</li>
<li><code>plt.PlotText()</code> now supports rotated text using the <code>rotation</code> argument. (<a href="https://github.com/ScottPlot/ScottPlot/issues/160">#160</a>) <a href="https://github.com/gwilson9"><strong>@gwilson9</strong></a>
</li>
<li><code>ScottPlot.WinForms</code> user control has new events and <code>formsPlot1.Configure()</code> arguments to make it easy to replace the default functionality for double-clicking and deploying the right-click menu (<a href="https://github.com/ScottPlot/ScottPlot/issues/166">#166</a>). <a href="https://github.com/FadyDev2"><strong>@FadyDev2</strong></a>
</li>
<li>All plottables now have a <code>visible</code> property which makes it easy to toggle visibility on/off after they've been plotted. <a href="https://github.com/Nasser"><strong>@Nasser</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/gwilson9'>@gwilson9</a>, <a href='https://github.com/FadyDev2'>@FadyDev2</a>, <a href='https://github.com/Nasser'>@Nasser</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/gwilson9'><img src='https://scottplot.net/images/contributors/gwilson9.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/FadyDev2'><img src='https://scottplot.net/images/contributors/fadydev2.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Nasser'><img src='https://scottplot.net/images/contributors/nasser.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 4.0.1</h1>
<div><i>NuGet packages published 2019-11-03</i></div>
<div class='mt-1'>
<ul>
<li>ScottPlot now targets .NET Standard 2.0 so in addition to .NET Framework projects it can now be used in .NET Core applications, ASP projects, Xamarin apps, etc.
</li>
<li>The WinForms control has its own package which targets both .NET Framework 4.6.1 and .NET Core 3.0 <a href="https://github.com/petarpetrovt"><strong>@petarpetrovt</strong></a>
</li>
<li>The WPF control has its own package targeting .NET Core 3.0 <a href="https://github.com/petarpetrovt"><strong>@petarpetrovt</strong></a>
</li>
<li>Better layout system and control of padding <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
<li>Added ruler mode to <code>plt.Ticks()</code> <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
<li><code>plt.MatchLayout()</code> no longer throws exceptions
</li>
<li>Eliminated <code>MouseTracker</code> class (tracking is now in user controls)
</li>
<li>Use NUnit (not MSTest) for tests
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/petarpetrovt'>@petarpetrovt</a>, <a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/petarpetrovt'><img src='https://scottplot.net/images/contributors/petarpetrovt.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.1.6</h1>
<div><i>NuGet packages published 2019-10-20</i></div>
<div class='mt-1'>
<ul>
<li>Reduced designer mode checks to increase render speed <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Fixed cursor bug that occurred when draggable axis lines were used <a href="https://github.com/Kamran"><strong>@Kamran</strong></a>
</li>
<li>Fully deleted the outdated <code>ScottPlotUC</code>
</li>
<li>Fixed infinite zoom bug caused by calling AxisAuto() when plotting a single point (or perfectly straight horizontal or vertical line)
</li>
<li>Added <code>ToolboxItem</code> and <code>DesignTimeVisible</code> delegates to WpfPlot control to try to get it to appear in the toolbox (but it doesn't seem to be working)
</li>
<li>Improved figure padding when axes frames are disabled <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
<li>Improved rendering of ticks at the edge of the plottable area <a href="https://github.com/Ichibot200"><strong>@Ichibot200</strong></a>
</li>
<li>Added <code>AxesChanged</code> event to user control to make it easier to sync axes between multiple plots
</li>
<li>Disabled drawing of arrows on user control in designer mode
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/Kamran'>@Kamran</a>, <a href='https://github.com/Ichibot200'>@Ichibot200</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Kamran'><img src='https://scottplot.net/images/contributors/kamran.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Ichibot200'><img src='https://scottplot.net/images/contributors/ichibot200.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.1.5</h1>
<div><i>NuGet packages published 2019-10-06</i></div>
<div class='mt-1'>
<ul>
<li>WPF user control improved support for display scaling <a href="https://github.com/morningkyle"><strong>@morningkyle</strong></a>
</li>
<li>Fixed bug that crashed on extreme zoom-outs <a href="https://github.com/morningkyle"><strong>@morningkyle</strong></a>
</li>
<li>WPF user control improvements (middle-click autoaxis, scrollwheel zoom)
</li>
<li>ScottPlot user control has a new look in designer mode. Exceptions in user controls in designer mode can crash Visual Studio, so this risk is greatly reduced by not attempting to render a ScottPlotinside Visual Studio.
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/morningkyle'>@morningkyle</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/morningkyle'><img src='https://scottplot.net/images/contributors/morningkyle.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.1.4</h1>
<div><i>NuGet packages published 2019-09-22</i></div>
<div class='mt-1'>
<ul>
<li>middle-click-drag zooms into a rectangle drawn with the mouse
</li>
<li>Fixed bug that caused user control to crash Visual Studio on some systems that used DPI scaling. (<a href="https://github.com/ScottPlot/ScottPlot/issues/125">#125</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/111">#111</a>) <a href="https://github.com/ab-tools"><strong>@ab-tools</strong></a> and <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Fixed poor rendering for extremely small plots
</li>
<li>Fixed bug when making a scatter plot with a single point (<a href="https://github.com/ScottPlot/ScottPlot/issues/126">#126</a>). <a href="https://github.com/bonzaiferroni"><strong>@bonzaiferroni</strong></a>
</li>
<li>Added more options to right-click settings menu (grid options, legend options, axis labels, editable plot labels, etc.)
</li>
<li>Improved axis padding and image tightening
</li>
<li>Greatly refactored the settings module (no change in functionality)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/ab-tools'>@ab-tools</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/bonzaiferroni'>@bonzaiferroni</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/ab-tools'><img src='https://scottplot.net/images/contributors/ab-tools.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bonzaiferroni'><img src='https://scottplot.net/images/contributors/bonzaiferroni.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.1.3</h1>
<div><i>NuGet packages published 2019-08-25</i></div>
<div class='mt-1'>
<ul>
<li>FormsPlot: middle-click-drag zooms into a rectangle
</li>
<li>FormsPlot: CTRL+scroll to lock vertical axis
</li>
<li>FormsPlot: ALT+scroll to loch horizontal axis
</li>
<li>FormsPlot: Improved (and overridable) right-click menu
</li>
<li>Ticks: rudimentary support for date tick labels (<code>dateTimeX</code> and <code>dateTimeY</code>)
</li>
<li>Ticks: options to customize notation (<code>useExponentialNotation</code>, <code>useOffsetNotation</code>, and <code>useMultiplierNotation</code>)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.1.0</h1>
<div><i>NuGet packages published 2019-08-19</i></div>
<div class='mt-1'>
<ul>
<li><code>ScottPlotUC</code> was renamed to <code>FormsPlot</code>
</li>
<li><code>ScottPlotWPF</code> was renamed to <code>WpfPlot</code>
</li>
<li>The right-click menu has improved. It responds faster and has improved controls to adjust plot settings.
</li>
<li>Plots can now be saved in BMP, PNG, JPG, and TIF format
</li>
<li>Holding <code>CTRL</code> while click-dragging locks the horizontal axis
</li>
<li>Holding <code>ALT</code> while click-dragging locks the vertical axis
</li>
<li>Minor ticks are now displayed (and can be turned on or off with <code>Ticks()</code>)
</li>
<li>Legend can be accessed for external display with <code>GetLegendBitmap()</code>
</li>
<li>anti-aliasing is turned off while click-dragging to increase responsiveness (<a href="https://github.com/ScottPlot/ScottPlot/issues/93">#93</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>PlotSignalConst</code> now has support for generics and improved performance using single-precision floating-point math. <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Legend draws more reliably (<a href="https://github.com/ScottPlot/ScottPlot/issues/104">#104</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/106">#106</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>AxisAuto()</code> now has <code>expandOnly</code> arguments
</li>
<li>Axis lines with custom lineStyles display properly in the legend
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.9</h1>
<div><i>NuGet packages published 2019-08-12</i></div>
<div class='mt-1'>
<ul>
<li>New Plot Type: <code>PlotSignalConst</code> for extremely large arrays of data which are not expected to change after being plotted. Plots generated with this method can be much faster than <code>PlotSignal</code>. (<a href="https://github.com/ScottPlot/ScottPlot/issues/70">#70</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Greatly improved axis tick labels. Axis tick labels are now less likely to overlap with axis labels, and it displays very large and very small numbers well using exponential notation. (<a href="https://github.com/ScottPlot/ScottPlot/issues/47">#47</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/68">#68</a>) <a href="https://github.com/Padanian"><strong>@Padanian</strong></a>
</li>
<li>Parallel processing support for <code>SignalPlot</code> (<a href="https://github.com/ScottPlot/ScottPlot/issues/72">#72</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li>Every <code>Plot</code> function now returns a <code>Plottable</code>. When creating things like scatter plots, text, and axis lines, the returned object can now be used to update the data, position, styling, or call plot-type-specific methods.
</li>
<li>Right-click menu now displays ScottPlot and .NET Framework version
</li>
<li>Improved rendering of extremely zoomed-out signals
</li>
<li>Rendering speed increased now that <code>Format32bppPArgb</code> is the default PixelFormat (<a href="https://github.com/ScottPlot/ScottPlot/issues/83">#83</a>) <a href="https://github.com/StendProg"><strong>@StendProg</strong></a>
</li>
<li><code>DataGen.NoisySin()</code> was added
</li>
<li>Code was tested in .NET Core 3.0 preview and compiled without error. Therefore, the next release will likely be for .NET Core 3.0 (<a href="https://github.com/ScottPlot/ScottPlot/issues/85">#85</a>, <a href="https://github.com/ScottPlot/ScottPlot/issues/86">#86</a>) <a href="https://github.com/petarpetrovt"><strong>@petarpetrovt</strong></a>
</li>
<li>User controls now render graphs with anti-alias mode off (faster) while the mouse is being dragged. Upon release a high quality render is performed.
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/StendProg'>@StendProg</a>, <a href='https://github.com/Padanian'>@Padanian</a>, <a href='https://github.com/petarpetrovt'>@petarpetrovt</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/StendProg'><img src='https://scottplot.net/images/contributors/stendprog.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/Padanian'><img src='https://scottplot.net/images/contributors/padanian.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/petarpetrovt'><img src='https://scottplot.net/images/contributors/petarpetrovt.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.8</h1>
<div><i>NuGet packages published 2019-08-04</i></div>
<div class='mt-1'>
<ul>
<li>WPF User Control: A ScottPlotWPF user control was created to allow provide a simple mouse-interactive ScottPlot control to WPF applications. It is not as full-featured as the winforms control (it lacks a right-click menu and click-and-drag functions), but it is simple to review the code (&lt;100 lines) and easy to use.
</li>
<li>New plot type: <code>plt.AxisSpan()</code> shades a region of the graph (semi-transparency is supported)
</li>
<li>Ticks: Vertical ticks no longer overlap with vertical axis label (<a href="https://github.com/ScottPlot/ScottPlot/issues/47">#47</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
<li>Ticks: When axis tick labels contain very large or very small numbers, scientific notation mode is engaged
</li>
<li>Ticks: Horizontal tick mark spacing increased to prevent overlapping
</li>
<li>Ticks: Vertical tick mark spacing increased to be consistent with horizontal tick spacing
</li>
<li>Plottable objects now have a <code>SaveCSV(filename)</code> method. Scatter and Signal plot data can be saved from the user control through the right-click menu.
</li>
<li>Added <code>lineStyle</code> arguments to Scatter plots
</li>
<li>Improved legend: ability to set location, ability to set shadow direction, markers and lines are now rendered in the legend
</li>
<li>Improved ability to use custom fonts
</li>
<li>Segoe UI is now the default font for all plot components
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.7</h1>
<div><i>NuGet packages published 2019-07-27</i></div>
<div class='mt-1'>
<ul>
<li>New plot type: <code>plt.PlotStep()</code>
</li>
<li>New plot type <code>plt.PlotCandlestick()</code>
</li>
<li>New plot type <code>plt.PlotOHLC()</code>
</li>
<li><code>plt.MatchPadding()</code> copies the data frame layout from one ScottPlot onto another (useful for making plots of matching size)
</li>
<li><code>plt.MatchAxis()</code> copies the axes from one ScottPlot onto another (useful for making plots match one or both axis)
</li>
<li><code>plt.Legend()</code> improvements: The <code>location</code> argument allows the user to place the legend at one of 9 different places on the plot. The <code>shadowDirection</code> argument allows the user to control if a shadow is shown and at what angle.
</li>
<li>Custom marker shapes can be specified using the <code>markerShape</code> argument.
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.6</h1>
<div><i>NuGet packages published 2019-06-30</i></div>
<div class='mt-1'>
<ul>
<li>Bar plot: The plot module now has a <code>Bar()</code> method that lets users create various types of bar plots
</li>
<li>Histogram: The new <code>ScottPlot.Histogram</code> class has tools to create and analyze histogram data (including cumulative probability)
</li>
<li>Step plot: Scatter plots can now render as step plots. Use this feature by setting the <code>stepDisplay</code> argument with <code>PlotScatter()</code>
</li>
<li>Manual grid spacing: Users can now manually define the grid density by setting the <code>xSpacing</code> and <code>ySpacing</code> arguments in <code>Grid()</code>
</li>
<li>Draggable axis lines: Axis lines can be dragged with the mouse if the <code>draggable</code> argument is set to <code>true</code> in <code>PlotHLine()</code> and <code>PlotHLine()</code>. Draggable axis line limits can also be set by defining additional arguments.
</li>
<li>Using the scrollwheel to zoom now zooms to the cursor position rather than the center of the plot area
</li>
<li><code>ScottPlot.DataGen.RandomNormal()</code> was created to create arbitrary amounts of normally-distributed random data
</li>
<li>Fixed bug causing axis line color to appear incorrectly in the legend
</li>
<li><code>AxisAuto()</code> is now called automatically on the first render. This means users no longer have to call this function manually for most applications. This simplifies quickstart programs to just: instantiate plot, plot data, render (now 3 lines in total instead of 4).
</li>
<li>Throw exceptions if scatter, bar, or signal data inputs are null (rather than failing later)
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.5</h1>
<div><i>NuGet packages published 2019-06-23</i></div>
<div class='mt-1'>
<ul>
<li>Improved pan and zoom performance
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.4</h1>
<div><i>NuGet packages published 2019-06-23</i></div>
<div class='mt-1'>
<ul>
<li>Bar graphs: New <code>plotBar()</code> method allow creation of bar graphs. By customizing the <code>barWidth</code> and <code>xOffset</code> arguments you can push bars together to create grouped bar graphs. Error bars can also be added with the <code>yError</code> argument.
</li>
<li>Scatter plots support X and Y error bars: <code>plotScatter()</code> now has arguments to allow X and Y error bars with adjustable error bar line width and cap size.
</li>
<li>Draggable axis lines: <code>plotHLine()</code> and <code>plotVLine()</code> now have a <code>draggable</code> argument which lets those axis lines be dragged around with the mouse (<a href="https://github.com/ScottPlot/ScottPlot/issues/11">#11</a>) <a href="https://github.com/plumforest"><strong>@plumforest</strong></a>
</li>
<li>Fixed errors caused by resizing to 0px
</li>
<li>Fixed a capitalization inconsistency in the <code>plotSignal</code> argument list
</li>
<li><code>axisAuto()</code> now includes positions of axis lines (previously they were ignored)
</li>
<li>Fixed an that caused SplitContainer splitters to freeze (<a href="https://github.com/ScottPlot/ScottPlot/issues/23">#23</a>) <a href="https://github.com/bukkideme"><strong>@bukkideme</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/plumforest'>@plumforest</a>, <a href='https://github.com/bukkideme'>@bukkideme</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/plumforest'><img src='https://scottplot.net/images/contributors/plumforest.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/bukkideme'><img src='https://scottplot.net/images/contributors/bukkideme.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.3</h1>
<div><i>NuGet packages published 2019-05-29</i></div>
<div class='mt-1'>
<ul>
<li>Update NuGet package to depend on System.Drawing.Common
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.2</h1>
<div><i>NuGet packages published 2019-05-28</i></div>
<div class='mt-1'>
<ul>
<li>Changed target from .NET Framework 4.5 to 4.7.2 (<a href="https://github.com/ScottPlot/ScottPlot/issues/15">#15</a>) <a href="https://github.com/plumforest"><strong>@plumforest</strong></a>
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/plumforest'>@plumforest</a>, <a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/plumforest'><img src='https://scottplot.net/images/contributors/plumforest.png' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>
<section class='mb-5'>
<h1 class='mb-0'>ScottPlot 3.0.1</h1>
<div><i>NuGet packages published 2019-05-28</i></div>
<div class='mt-1'>
<ul>
<li>First version of ScottPlot published on NuGet
</li>
</ul>
</div>
<h3 class='text-center fw-light'>Contributors</h3>
<div class='text-center'>
<a href='https://github.com/swharden'>@swharden</a>
</div>
<div class='text-center'>
<a href='https://github.com/swharden'><img src='https://scottplot.net/images/contributors/swharden.jpg' width=75 height=75 style='border-radius: 50%;' class='m-1'/></a>
</div>

</section>

<div class='mt-5 mb-3 text-muted'>
If you changed your GitHub avatar and wish to update the image on this page, 
go to <a href='https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors'>
https://github.com/ScottPlot/ScottPlot.NET/tree/main/static/images/contributors</a> 
and create a pull request which deletes the file with your GitHub username. 
Your new avatar will be downloaded the next time the changelog is updated. 
</div>
