---
Title: Plot Data in .NET Interactive Notebooks
description: How to use ScottPlot to visualize data in .NET Polyglot notebooks
date: 2023-12-13
---

# .NET Interactive Notebook Quickstart

.NET Interactive Notebooks (polyglot notebooks) allow programmers to work with data in an interactive environment. To get started using ScottPlot to display data in a .NET notebook, 

### Create a new .NET Notebook

* Install [VS Code](https://code.visualstudio.com/)
* Install the VS Code [Polyglot Notebooks extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.dotnet-interactive-vscode)
* Press `CTRL + SHIFT + P` to open the command dialogue
* Select _Polyglot Notebook: Create Default Notebook_
* Choose the `.ipynb` extension and select the C# language

### Setup ScottPlot

Add this to the top of your notebook to use the ScottPlot NuGet package and make it easy to display plots inline:

```cs
// Install the ScottPlot NuGet package
#r "nuget:ScottPlot, 5.0.*"

// Setup a custom formatter to display plots as images
using Microsoft.DotNet.Interactive.Formatting;
Formatter.Register(typeof(ScottPlot.Plot), (p, w) => 
    w.Write(((ScottPlot.Plot)p).GetImageHtml(400, 300)), HtmlFormatter.MimeType);
```

Linux users require an additional package as well
```cs
#r "nuget:SkiaSharp.NativeAssets.Linux.NoDependencies"
```

### Plot Data

```cs
// create sample data
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };

// plot the data
ScottPlot.Plot plt = new();
plt.Add.Scatter(dataX, dataY);

// display the plot
plt
```

![](/images/quickstart/scottplot-quickstart-console.png)
