---
title: Multi-Threaded/Async - ScottPlot FAQ
description: How to use ScottPlot to display data in multi-threaded/async environments
date: 2023-12-13
---

{{< banner-sp5 >}}

# Async and Multithreading Considerations

Some applications are multi-threaded (e.g., WPF) allowing rendering to occur separately from data manipulation routines. While this allows for faster and more responsive applications, it raises potential problems if data inside plottable objects are manipulated mid-render. For example, reducing the size of the `List` holding data in a scatter plot while it is rendering may result in an index exception as the graphics code attempts to iterate over all of the original points.

### ScottPlot 5

This example shows how to perform a "dangerous" operation (reducing the size of a `List` containing plotted data) which could cause an index error if it is performed mid-render while the code that draws graphics is iterating over that data. When `EnableRendering` is `false` all render requests are skipped, so a render must be manually requested after re-enabling it.

{{< code-sp5 >}}

```cs
void MyDangerousOperation(){

    // disable new renders
    formsPlot1.Plot.RenderManager.EnableRendering = false;

    // wait for the current render to finish
    while (formsPlot1.Plot.RenderManager.IsRendering) {}

    // perform your dangerous operation
    myScatterPlot.DataSource.Clear();

    // permit new renders
    formsPlot1.Plot.RenderManager.EnableRendering = true;

    // force the plot to redraw
    formsPlot1.Refresh();
}
```

Advanced users may not wish to _skip_ render requests, but instead _hang_ render requests while an important data operation occurs. This may be achieved by adding custom code to the `PreRenderLock` event handler. Code here is executed before each frame is rendered and must complete before the render proceeds. Because it is called frequently users should be careful about placing long-running tasks inside this event.

{{< code-sp5 >}}

```cs
formsPlot1.Plot.RenderManager.PreRenderLock += (s, e) =>
{
    // perform your dangerous operation
};
```

{{< /code-sp5 >}}


{{< /code-sp5 >}}

### ScottPlot 4

In ScottPlot 4 the `Plot` module has a render locking system to allow data manipulation in multi-threaded environments. Calling `Plot.RenderLock()` will hang until the current render is complete, and it will prevent future renders from occurring. This allows the user to modify the plot however they desire. Later the user can call `Plot.RenderUnlock()` to permit renders to continue.

{{< code-sp4 >}}

```cs
// hang until the current render is complete and prevent future renders
wpfPlot1.Plot.RenderLock();

/* plottables and data may be freely manipulated now */

// resume automatic rendering
wpfPlot1.Plot.RenderUnlock();
```

{{< /code-sp4 >}}