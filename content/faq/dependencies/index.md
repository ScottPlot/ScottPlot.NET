---
title: ScottPlot dependencies - ScottPlot FAQ
description: ScottPlot's Dependencies and their Implications
---

**ScottPlot 4 depends on the [System.Drawing.Common package](https://www.nuget.org/packages/System.Drawing.Common/) to render plots.** This has special considerations for modern .NET projects depending on which operating system is being targeted.

## Windows

Applications targeting .NET 6 and newer may produce the following message:

```
Warning	CA1416	This call site is reachable on all platforms. 
'FormsPlot.Plot' is only supported on: 'Windows' 7.0 and later.	
```

**To fix this warning:** edit your .csproj file to target `.net6.0-windows`

## Linux & MacOS

Non-Windows users must take the following steps to enable System.Drawing.Common rendering support:

**Step 1:** Install [libgdiplus](https://www.mono-project.com/docs/gui/libgdiplus/)

* **Linux:** `apt-get install -y libgdiplus`

* **MacOS:** `brew install mono-libgdiplus`

**Step 2:** Manually add the `System.Drawing.Common` package to your project:

* `dotnet add package System.Drawing.Common`

**Step 3:** Follow Microsoft's [recommended action](https://docs.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only#recommended-action) and edit `runtimeconfig.json` to `EnableUnixSupport`.

## ScottPlot 5

* ScottPlot 5 is not yet released, but it is expected to release before .NET 7 in November, 2022.

* ScottPlot 5 does not depend on `System.Drawing.Common`, so the concerns above concerns do not apply.

* The rendering technology underlying ScottPlot 5 is still not fully decided. See the [ScottPlot Roadmap](https://github.com/ScottPlot/ScottPlot/blob/main/dev/roadmap.md) for details.