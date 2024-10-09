---
title: Multi-Threaded/Async - ScottPlot FAQ
description: How to use ScottPlot to display data in multi-threaded/async environments
date: 2023-12-13
---

# Async and Multithreading Considerations

**Exceptions may be thrown if plots are modified in one thread while another thread is performing a render.** To prevent race conditions like this, lock the `Plot.Sync` object to prevent rendering while potentially dangerous operations are performed.

```cs
System.Timers.Timer Timer = new() { Interval = 10; Enabled = true; };

Timer.Elapsed += (s, e) =>
{
    lock (plotControl.Plot.Sync)
    {
        // Operations inside this block will not start
        // until the previous render is finished, and the next
        // render will not start until these operations complete.
        ChangeDataLength();
    }

    // Request a redraw (which may occur in another thread)
    WpfPlot1.Refresh();
};
```

**WPF Demo:** A sample application demonstrating multi-threaded plot updates in WPF 
is available in the [WPF demo project](https://github.com/ScottPlot/ScottPlot/tree/main/src/ScottPlot5/ScottPlot5%20Demos/ScottPlot5%20WPF%20Demo).