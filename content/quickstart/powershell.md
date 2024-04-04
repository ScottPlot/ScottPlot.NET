---
Title: PowerShell Quickstart
description: How to plot data from PowerShell using ScottPlot
date: 2023-12-13
---

{{< banner-sp5 >}}

# PowerShell Quickstart

**Step 1: Get PowerShell Core** 

* Do not use Windows PowerShell
* PowerShell Core can run on Windows, Linux, and MacOS
* Download from https://github.com/PowerShell/PowerShell

**Step 2: Build an empty .NET app using ScottPlot**

* `dotnet new console`
* `dotnet add package scottplot`
* `dotnet build`

**Step 3: Create a PowerShell script**
* Enter the builder folder containing `ScottPlot.dll`
* Enter the runtimes folder, select your platform (ex. win-x64), copy `libSkiaSharp` and paste it in the folder containing `ScottPlot.dll`
* Create `myScript.ps1` and copy the following contents into it
* Run the script using PowerShell Core (not Windows PowerShell)

{{< code-sp5 >}}

```ps1
Add-Type -Path .\ScottPlot.dll
[double[]] $dataX = @( 1, 2, 3, 4, 5 )
[double[]] $dataY = @( 1, 4, 9, 16, 25 )
$plt = [ScottPlot.Plot]::new()
[Void] $plt.Add.Scatter($dataX, $dataY)
[Void] $plt.SavePng("$pwd\quickstart.png", 400, 300)
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-quickstart-console.png)

## PowerShell Interactive Notebooks

[Doug Finke](https://github.com/dfinke) prepared a [YouTube video](https://www.youtube.com/watch?v=nL0JRukCU4k) and [GitHub repository](https://github.com/dfinke/PowerShellScottPlot) demonstrating how to create data visualizations with PowerShell and ScottPlot in the a Polyglot Interactive Notebook.

* https://www.youtube.com/watch?v=nL0JRukCU4k
* https://github.com/dfinke/PowerShellScottPlot

<div class="w-75 mx-auto">
<div class='ratio ratio-16x9 w-100 my-5 shadow'>
<iframe src='https://www.youtube.com/embed/nL0JRukCU4k' frameborder='0'
width='1920' height='1080'
allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture'     allowfullscreen>
</iframe>
</div>
</div>
