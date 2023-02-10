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

## Docker

Docker users can find additional information in [#2366](https://github.com/ScottPlot/ScottPlot/issues/2366) and [#1677](https://github.com/ScottPlot/ScottPlot/issues/1677)

## ScottPlot 5

ScottPlot 5 does not depend on `System.Drawing.Common`, so the concerns above concerns do not apply.

However, the following packages may be useful for non-Windows systems:

```
apt-get update
apt-get install -y libfreetype6
apt-get install -y libfontconfig1
apt-get install -y fontconfig
```
