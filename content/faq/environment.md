---
title: Development Environment Setup - ScottPlot FAQ
description: How to Build ScottPlot from Source Code using Visual Studio
date: 2023-12-13
---

# Build ScottPlot from Source

_Building from source lets developers modify the ScottPlot code to customize behavior, fix bugs, and add new features. These steps are the easiest way for new contributors to get up and running with ScottPlot._

**Step 1:** Install the latest [.NET SDK](https://dotnet.microsoft.com/en-us/download). Even if you're building projects targeting older .NET platforms, building from source still requires the latest SDK on your system because it uses the latest C# language features. You can run `dotnet --list-sdks` to determine which SDKs are installed on your system.

**Step 2:** Install the latest version of [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) (free). During installation indicate you wish to install the ".NET desktop development" workload.

**Step 3:** Download ScottPlot code from https://github.com/scottplot/scottplot

**Step 4:** Open the `.sln` file in the `src` folder in Visual Studio

_Tip: Building the full solution is slow and requires software development kits for many platforms (Windows, Android, iOS, etc.) so consider unloading all projects then selectively loading the ones you wish to build._

**Step 5:** Right-click one of the demo projects and "Set as Startup Project"

**Step 6:** Press F5 to Build and Run 🚀

_If the build fails with an error message, read it carefully. It may indicate you need a particular version of the [.NET SDK](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks) or [.NET Framework Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48) installed on your system._