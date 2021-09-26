dotnet run ^
  --project %~dp0\SiteBuilder ^
  --content %~dp0\..\content ^
  --theme %~dp0\theme ^
  --cookbook %~dp0\..\ScottPlot\src\cookbook\ScottPlot.Cookbook ^
  --urlSource https://github.com/ScottPlot/ScottPlot.NET/blob/main/content ^
  --urlSite http://localhost:8080 ^