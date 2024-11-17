---
Title: Multiple Sine Waves - ScottPlot 5.0 Cookbook
Description: This recipe demonstrates creation of a noisy waveform containing multiple sine waves with different frequencies.
URL: /cookbook/5.0/DataGen/MultipleSineWaves/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Sample Data", "Multiple Sine Waves"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DataGen", "/cookbook/5.0/DataGen/MultipleSineWaves"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Sine Waves</h1>
</div>

This recipe demonstrates creation of a noisy waveform containing multiple sine waves with different frequencies.

[![](/cookbook/5.0/images/MultipleSineWaves.png?241117162641)](/cookbook/5.0/images/MultipleSineWaves.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/DataGen.cs" imageUrl="/cookbook/5.0/images/MultipleSineWaves.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/DataGen'>Sample Data</a> category</div>


