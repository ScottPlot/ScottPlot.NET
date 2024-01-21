---
Title: ScottPlot Blazor Quickstart
description: How to display interactive plots in the browser using C# and Blazor
date: 2023-12-13
---

{{< banner-sp5 >}}

**Step 1:** Create a new Blazor project

**Step 2:** Add the `ScottPlot.Blazor` NuGet package

**Step 3:** Place a `BlazorPlot` on your `.razor` page

{{< code-sp5 >}}

```xml
@page "/"
@using ScottPlot
@using ScottPlot.Blazor

<h1>ScottPlot 5 in Blazor</h1>

<BlazorPlot @ref=BlazorPlot Style="width: 400px; height: 300px;" />
```

{{< /code-sp5 >}}

**Step 4:** Add code to place data onto the plot

{{< code-sp5 >}}

```cs
@code {

    BlazorPlot BlazorPlot { get; set; } = new();

    protected override void OnAfterRender(bool firstRender)
    {
        BlazorPlot.Plot.Add.Signal(Generate.Sin());
        BlazorPlot.Plot.Add.Signal(Generate.Cos());
    }
}
```

{{< /code-sp5 >}}

![](/images/quickstart/blazor.png)