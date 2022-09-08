---
title: Development Environment Setup - ScottPlot FAQ
description: How to Build ScottPlot from Source Code using Visual Studio
---

## Build ScottPlot from Source

_Building from source lets developers modify the ScottPlot code to customize behavior, fix bugs, and add new features. These steps are the easiest way for new contributors to get up and running with ScottPlot._

**Step 1:** Install the latest version of [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) (free). During installation indicate you wish to install the ".NET desktop development" workload.

**Step 2:** Download ScottPlot code from https://github.com/scottplot/scottplot

**Step 3:** Open the `.sln` file in the `src` folder in Visual Studio

**Step 4:** Right-click one of the demo projects and "Set as Startup Project"

**Step 5:** Press F5 to Build and Run 🚀

> 💡 If the build fails with an error message, read it carefully. It may indicate you need a particular version of the [.NET SDK SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) or [.NET Framework Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) installed on your system. You may need to restart Visual Studio after installing these tools.

## Building with Older Tools

**ScottPlot uses modern C# language features** like [file-scoped namespaces](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/file-scoped-namespaces) and [lambda expressions](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions) which simplify the code but are not supported by older versions of Visual Studio. ScottPlot developers typically work with the latest major version of [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/), but it is possible to build ScottPlot using older tools with some modifications.

### Visual Studio 2019

> ⚠️ **WARNING: These steps are not required** for users who can use the latest free version of Visual Studio Community. Visual Studio 2019 is no longer the latest major version, but is officially supported until 2029 (see [Visual Studio 2019 Product Lifecycle](https://docs.microsoft.com/en-us/visualstudio/releases/2019/servicing-vs2019) for details).

> 🚀 **Special thanks to Lennox808** from the [ScottPlot Discord](/discord) for sharing these notes after successfully building ScottPlot 4 in Visual Studio 2019 (version 16.11) in September, 2022

Try to build the solution one project at a time, starting with `ScottPlot`. The following lists the build errors you will encounter and how to solve them. After fixing a build error, rebuild and repeat, until no errors remain.

* Edit the .csproj file to update target framework(s) to a single version known to be on your system (e.g., `net462`)

* Revert file-scoped namespaces. Lines starting with `namespace` should be modified such that the `;` is replaced with a `{` and a `}` must be added to the bottom of the file. Repeatedly attempting to build the solution will identify files requiring this modification by the errors it produces.

* Comment-out `Obsolete` lines that produce build errors

* Resolve the lambda errors (in `Crosshair` and `Heatmap`) by replacing the expression with explicit logic

### Automated Conversion with Python

The processes above may be automated using [this python script](convert-vs2017.py) contributed by Lennox808 from the [ScottPlot Discord](/discord). It is not officially supported, but still seems quite useful.
