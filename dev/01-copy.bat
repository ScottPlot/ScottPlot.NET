:: GitHub Actions checks-out the latest ScottPlot from the web and uses it to generate the cookbook.
:: Instead of cloning the repo over HTTP this script copies the useful folders over from a local source.
rmdir %~dp0\..\ScottPlot\src\ /s /q
xcopy %~dp0\..\..\ScottPlot\src\ %~dp0\..\ScottPlot\src\ /E/H
xcopy %~dp0\..\..\ScottPlot\dev\ %~dp0\..\ScottPlot\dev\ /E/H