---
Title: Notebook Quickstart
description: How to plot data using ScottPlot in a Jupyter / .NET Interactive notebook
url: "quickstart/notebook"
---

[.NET Notebooks](https://github.com/dotnet/interactive) allow programmers to work with data in an interactive environment. To get started using ScottPlot in a .NET workbooks, install the [.NET Interactive Notebooks extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode), create a new `quickstart.ipynb` file, then add the following:


```cs
// Install the ScottPlot NuGet package
#r "nuget:ScottPlot"

// Plot some data
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);

// Display the plot as an image
display(HTML(plt.GetImageHTML()));
```

![](../console/scottplot-quickstart-console.png)
