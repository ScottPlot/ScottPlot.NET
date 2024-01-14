---
Title: User Control Advanced Configuration - ScottPlot FAQ
Description: Interact with the control configuration object to achieve advanced customizations of user control style and behavior
date: 2023-12-13
---

{{< banner-sp5 >}}

{{< specific-sp4 >}}

# User Control Advanced Configuration

**ScottPlot user controls have a `Plot` object you're probably familiar with, but they also have a `Configuration` object which lets users modify the default behavior of user controls.** Options in this configuration object are typically related to user interaction, such as whether scroll-wheel-zoom is enabled, or left-click-pan is allowed.

A full list of configuration options can be seen here: [ScottPlot/Control/Configuration.cs](https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot4/ScottPlot/Control/Configuration.cs) but the most common customizations include:

* Prevent the mouse from zooming or panning
* Disable left-click-drag panning
* Disable right-click-drag zooming
* Disable the middle-click-drag zoom window function
* Always draw anti-aliased plots to increase performance
* Adjust the middle-click auto-axis margins
* Lock the vertical or horizontal axes
* Use a non-UI-thread blocking render queue
* Change DPI scaling options