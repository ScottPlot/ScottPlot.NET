---
Title: Windows Forms Quickstart
description: How to create an interactive plot in a C# Windows Forms application
date: 2021-09-26
---

{{< banner-sp5 >}}

# Windows Forms Quickstart

**Step 1:** Install the [`ScottPlot.WinForms`](https://www.nuget.org/packages/ScottPlot.WinForms) NuGet package

**Step 2:** Drag a `FormsPlot` from the Toolbox onto your Form

**Step 3:** Plot some data in your start-up sequence

{{< code-sp5 >}}

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

formsPlot1.Plot.Add.Scatter(dataX, dataY);
formsPlot1.Refresh();
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-quickstart-winforms.png)

### How to add a Plot Control Programmatically

If users are not using the visual designer (or are having trouble locating the plot control in the toolbox), a FormsPlot can be added to the Form programmatically. See the [FAQ: Add ScottPlot WinForms Control Programmatically](/faq/add-winforms-programmatically/) page for additional information.
