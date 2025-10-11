---
Title: Multiple Sine Waves - ScottPlot 5 Cookbook
Description: This recipe demonstrates creation of a noisy waveform containing multiple sine waves with different frequencies.
URL: /cookbook/5/DataGen/MultipleSineWaves/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Sample Data", "Multiple Sine Waves"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/DataGen", "/cookbook/5/DataGen/MultipleSineWaves"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Sine Waves</h1>
</div>

This recipe demonstrates creation of a noisy waveform containing multiple sine waves with different frequencies.

[![](/cookbook/5/images/MultipleSineWaves.png?251011113742)](/cookbook/5/images/MultipleSineWaves.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/DataGen.cs" imageUrl="/cookbook/5/images/MultipleSineWaves.png?251011113742" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/DataGen'>Sample Data</a> category</div>


