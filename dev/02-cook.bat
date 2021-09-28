:: building the cookbook requires a copy of ScottPlot repository in the root of this repo

:: build must occur INSIDE the cookbook folder due to how local images are imported.
cd %~dp0\..\ScottPlot\src\cookbook\ScottPlot.Cookbook

dotnet run ^
  --project %~dp0\..\ScottPlot\src\cookbook\CookbookGenerator ^
  --cookbook %~dp0\..\ScottPlot\src\cookbook\ScottPlot.Cookbook ^
  --imageFolder %~dp0\..\content\cookbook\4.1\images ^
  --sourceFile %~dp0\..\content\cookbook\4.1\recipes.json

:: move to the repo root folder
cd %~dp0\..\