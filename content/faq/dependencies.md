---
title: ScottPlot dependencies - ScottPlot FAQ
description: ScottPlot's Dependencies and their Implications
date: 2023-12-13
---

# ScottPlot Dependencies

**Adding the ScottPlot NuGet package to a .NET project typically brings all the dependencies it needs to run.** In some cases additional steps need to be taken for apps that use ScottPlot to run smoothly.

## SkiaSharp Native Assets for Linux

Non-Windows users may need to add the [`SkiaSharp.NativeAssets.Linux.NoDependencies` NuGet package](https://www.nuget.org/packages/SkiaSharp.NativeAssets.Linux.NoDependencies/) to projects that use ScottPlot to resolve the following errors:

```
System.DllNotFoundException: Unable to load shared library 'libSkiaSharp' or one of its dependencies
```

```
libSkiaSharp.so: cannot open shared object file
```` 

## Font Rendering Issues

Non-Windows users may need to install system packages to fix font issues (e.g., characters are blank or appear as squares or rectangles):

```
apt-get update
apt-get install -y libfreetype6
apt-get install -y libfontconfig1
apt-get install -y fontconfig
```


## Using ScottPlot in Docker

ScottPlot can be used in Docker images. For additional information see:
* [#3504](https://github.com/ScottPlot/ScottPlot/issues/3504) (ScottPlot 5.0, 2025)
* [#2366](https://github.com/ScottPlot/ScottPlot/issues/2366) (ScottPlot 5.0, 2023)
* [#1677](https://github.com/ScottPlot/ScottPlot/issues/1677) (ScottPlot 4.1, 2023)

## ScottPlot 4 Warning	CA1416

ScottPlot 4 users may encounter warning CA1416 because cross-platform support for System.Drawing was dropped in .NET 6. To resolve this issue, edit your .csproj file to target `.net6.0-windows` so your app only attempts to build for Windows.

```
Warning	CA1416 This call site is reachable on all platforms. 
'FormsPlot.Plot' is only supported on: 'Windows' 7.0 and later.	
```

Users wishing to create cross-platform apps should use ScottPlot 5 which does not have this limitation.

## ScottPlot 4 on Linux or MacOS

Non-Windows users may need to install [libgdiplus](https://www.mono-project.com/docs/gui/libgdiplus/) using one of the following commands:

```
apt-get install -y libgdiplus
```

```
brew install mono-libgdiplus
````
