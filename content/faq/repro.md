---
title: Reproducible Code Examples
description: Recommendations for preparing executable code samples that can facilitate resolving issues or answering questions.
date: 2023-12-13
---

# How to Create Reproducible Code Examples

**Sharing a reproducible code example with an issue or question increases the likelihood that it will be addressed rapidly and accurately.** Questions with absent or incomplete code examples are unlikely to receive an accurate or timely responses, and may even be closed the labor required to reproduce the issue is high. This page describes strategies for creating code examples that are easy for others to run and evaluate.

## Static Plot

The preferred method for sharing ScottPlot code examples is to create a new .NET Console Application that demonstrates the topic and saves the result as an image.

**Step 1:** Create a new .NET console project

**Step 2:** Add the `ScottPlot` NuGet package

**Step 3:** Create a plot and save it as an image

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

ScottPlot.Plot myPlot = new();
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("quickstart.png", 400, 300);
```

## Interactive Plot from a Console Application

**If your topic relates to mouse interactivity, it may be necessary to demonstrate it using a GUI.** The preferred method is to create a .NET Console Application that launches Windows Form containing a ScottPlot.

**Step 1:** Create a new .NET console project 

**Step 2:** Add the `ScottPlot` and `ScottPlot.WinForms` NuGet packages

**Step 3:** Modify the csproj file's property group to support Windows Forms

```xml
<OutputType>Exe</OutputType>
<TargetFramework>net6.0-windows</TargetFramework>
<ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable>
<UseWindowsForms>true</UseWindowsForms>
```

**Step 4:** Create a plot and display it interactively

```cs
// create a plot
ScottPlot.Plot plt = new();
plt.Add.Signal(Generate.Sin());
plt.Add.Signal(Generate.Cos());

// display it in a Windows Form
Form form = new() { Width = 600, Height = 400 };
ScottPlot.WinForms.FormsPlot formsPlot1 = new() { Dock = DockStyle.Fill };
formsPlot1.Reset(plt);
formsPlot1.Refresh();
form.Controls.Add(formsPlot1);
form.ShowDialog();
```