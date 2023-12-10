---
title: Multi-Threaded/Async - ScottPlot FAQ
description: How to use ScottPlot to display data in multi-threaded/async environments
---

# Async and Multithreading Considerations

Some applications are multi-threaded (e.g., WPF) allowing rendering to occur separately from data manipulation routines. While this allows for faster and more responsive applications, it raises potential problems if data inside plottable objects are manipulated mid-render. For example, replacing the `xs` and `ys` array in a scatter plot _while_ it is rendering may result in an exception.

The `Plot` module has a render locking system to allow data manipulation in multi-threaded environments. Calling `Plot.RenderLock()` will hang until the current render is complete, and it will prevent future renders from occurring. This allows the user to modify the plot however they desire. Later the user can call `Plot.RenderUnlock()` to permit renders to continue.

```cs
// hang until the current render is complete and prevent future renders
wpfPlot1.Plot.RenderLock();

/* plottables and data may be freely manipulated now */

// resume automatic rendering
wpfPlot1.Plot.RenderUnlock();
```