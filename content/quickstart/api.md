---
Title: ScottPlot .NET API Quickstart
description: How to serve dynamically generated plots from a .NET Core API project
date: 2023-12-13
---

# ScottPlot .NET API Quickstart

**Step 1:** Create a new .NET Core API project

**Step 2:** Add the `ScottPlot.Blazor` NuGet package

**Step 3:** Edit `Program.cs` to serve plots as image files

```cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    string html = "<html><body><img src='random.png'></body></html>";
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(html);
});

app.MapGet("/random.png", async context =>
{
    ScottPlot.Plot myPlot = new();
    double[] dataX = ScottPlot.Generate.Consecutive(100);
    double[] dataY = ScottPlot.Generate.RandomWalk(100);
    myPlot.Add.Scatter(dataX, dataY);

    byte[] imageBytes = myPlot.GetImageBytes(400, 300, ScottPlot.ImageFormat.Png);
    context.Response.ContentType = "image/png";
    await context.Response.Body.WriteAsync(imageBytes, 0, imageBytes.Length);
});

app.Run();
```

![](/images/quickstart/api.gif)


## Embedding Images in HTML

Embedding images in HTML prevents the need to create image file endpoints and also allows web pages to with images to be saved as single file documents.

### Inline SVG

```cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    ScottPlot.Plot myPlot = new();
    double[] dataX = ScottPlot.Generate.Consecutive(100);
    double[] dataY = ScottPlot.Generate.RandomWalk(100);
    myPlot.Add.Scatter(dataX, dataY);

    string svg = myPlot.GetSvgXml(600, 400);
    string html = $"<html><body>{svg}</body></html>";
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(html);
});

app.Run();
```

### Inline PNG

```cs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    // create a plot and fill it with sample data
    ScottPlot.Plot myPlot = new();
    double[] dataX = ScottPlot.Generate.Consecutive(100);
    double[] dataY = ScottPlot.Generate.RandomWalk(100);
    myPlot.Add.Scatter(dataX, dataY);

    // render the plot as a PNG and encode its bytes in HTML
    byte[] imgBytes = myPlot.GetImageBytes(600, 400, ScottPlot.ImageFormat.Png);
    string b64 = Convert.ToBase64String(imgBytes);
    string png = $"<img src='data:image/png;base64,{b64}'>";
    string html = $"<html><body>{png}</body></html>";
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(html);
});

app.Run();
```
