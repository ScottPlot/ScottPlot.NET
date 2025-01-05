---
Title: Sample Data - ScottPlot 5.0 Cookbook
Description: ScottPlot has many built-in utilities for generating sample data.
URL: /cookbook/5.0/DataGen/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Sample Data"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DataGen"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Sample Data</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Sine Waves</h1>
<a href='/cookbook/5.0/DataGen/MultipleSineWaves' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

This recipe demonstrates creation of a noisy waveform containing multiple sine waves with different frequencies.

[![](/cookbook/5.0/images/MultipleSineWaves.png?250105183901)](/cookbook/5.0/images/MultipleSineWaves.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/DataGen.cs" imageUrl="/cookbook/5.0/images/MultipleSineWaves.png?250105183901" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomNormal(500, stdDev: 0.2);

for (int i = 1; i &lt; 10; i++)
{
    var sig = myPlot.Add.Signal(values);
    sig.Data.YOffset = i * 3;
    sig.LineWidth = 1.5f;
    values = Generate.AddSin(values, oscillations: i);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


