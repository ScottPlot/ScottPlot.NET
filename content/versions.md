---
Title: ScottPlot Versions
Description: Information about the major ScottPlot versions
date: 2023-12-13
---

## Major Versions

### ScottPlot 5.0
* First released January, 2024
* Used SkiaSharp for improved performance and cross-platform support
* [ScottPlot 4.1 to 5.0 migration guide](https://scottplot.net/faq/version-5.0/)
* Source Code: https://github.com/ScottPlot/ScottPlot

### ScottPlot 4.1 (No longer supported)
* First released May, 2021 
* Added multi-axis support and a stateless rendering system
* [ScottPlot 4.0 to 4.1 migration guide](https://scottplot.net/faq/version-4.1/)
* Source Code: https://github.com/ScottPlot/ScottPlot4-obsolete

### ScottPlot 4.0 (Obsolete)
* First released Nov, 2019
* Ths version targeted .NET Standard enabling cross-platform support
* Source Code: https://github.com/ScottPlot/ScottPlot/tags

### ScottPlot 3.0 (Obsolete)
* First released May, 2019
* First version deployed via NuGet (WinForms and WPF only)
* Source Code: https://github.com/ScottPlot/ScottPlot/tags

### ScottPlot 2.0 (Obsolete)
* First released Jan, 2019
* ScottPlot was adapted to a standalone project with its own repository
* Source Code: https://github.com/ScottPlot/ScottPlot/tags

### ScottPlot 1.0 (Obsolete)
* First source code committed to GitHub in June, 2017
* `ScottPlot.cs` was a 150 line file demonstrating how to create a line plot with C#
* Source code: [Form1.cs](https://github.com/swharden/Csharp-Data-Visualization/commit/0c8b5dbbaf093633be4bfe1c2bc6388742774f33)

## Versioning Strategy

**ScottPlot does not use [semantic versioning](semver.org).** Instead, version numbers are thoughtfully incremented to signal the likelihood that effort will be required to upgrade. Efforts are made to maximize backward compatibility, but **development prioritizes moving toward a high quality and intuitive API** over preventing existing users from having to modify code to upgrade.

**Naming:** ScottPlot x.y.z (major.minor.build)

* **Build version bump:** The overwhelming majority of users will be able to upgrade effortlessly without requiring code modification. A **small subset of users** who use advanced ScottPlot features to achieve extreme customization of appearance or interactive behavior may be required to modify source code after upgrading.

* **Minor version bump:** Significant changes to the API will require **many users** to modify source code files. However, many users will be able to upgrade effortlessly without requiring code modification.

* **Major version bump:** Significant changes the API require **all users** to modify most source code files and refer to new documentation. Unless the SkiaSharp is replaced with a different rendering system it unlikely ScottPlot will experience a major version bump.