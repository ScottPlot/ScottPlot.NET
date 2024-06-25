---
Title: ScottPlot Blazor Quickstart
description: How to display interactive plots in the browser using C# and Blazor WebAssembly
date: 2023-12-13
---

# Blazor WASM Quickstart

**Step 1:** Create a new Blazor WebAssembly project

**Step 2:** Add the `ScottPlot.Blazor` NuGet package

**Step 3:** Place a `BlazorPlot` on your `.razor` page and plot some data

```cs
@page "/"
@using ScottPlot
@using ScottPlot.Blazor

<h1>ScottPlot 5 in Blazor</h1>

<BlazorPlot @ref=BlazorPlot Style="width: 400px; height: 300px;" />

@code {

    BlazorPlot BlazorPlot { get; set; } = new();

    protected override void OnAfterRender(bool firstRender)
    {
        BlazorPlot.Plot.Add.Signal(Generate.Sin());
        BlazorPlot.Plot.Add.Signal(Generate.Cos());
    }
}
```

![](/images/quickstart/blazor.gif)
