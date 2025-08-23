---
Title: Dynamically Generated Functions - ScottPlot 5.0 Cookbook
Description: When a function cannot be represented as a static method (e.g., one that requires custom parameters) it can be represented as variable of type Func<double, double> and plotted accordingly.
URL: /cookbook/5.0/Function/FunctionDynamic/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Function", "Dynamically Generated Functions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Function", "/cookbook/5.0/Function/FunctionDynamic"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Dynamically Generated Functions</h1>
</div>

When a function cannot be represented as a static method (e.g., one that requires custom parameters) it can be represented as variable of type Func<double, double> and plotted accordingly.

[![](/cookbook/5.0/images/FunctionDynamic.png?250822231048)](/cookbook/5.0/images/FunctionDynamic.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Function.cs" imageUrl="/cookbook/5.0/images/FunctionDynamic.png?250822231048" >}}ScottPlot.Plot myPlot = new();

static double LogNormalDist(double x, double a, double b)
{
    double expNum = Math.Log(x / a);
    double exp = Math.Exp(-(expNum * expNum) / (2 * b * b));
    double y = Math.Sqrt(2 * Math.PI) * b * x * exp;
    return double.IsNaN(y) ? 0 : y;
}

double[] testValues = Generate.Range(0.8, 1.2, 0.05);
Color[] colors = new ScottPlot.Colormaps.MellowRainbow().GetColors(testValues.Length);
for (int i = 0; i &lt; testValues.Length; i++)
{
    double testValue = testValues[i];
    var myFunc = new Func&lt;double, double&gt;((x) =&gt; LogNormalDist(x, testValue, 0.5));
    var funcPlot = myPlot.Add.Function(myFunc);
    funcPlot.LegendText = $"{testValue:0.00}";
    funcPlot.LineWidth = 2;
    funcPlot.LineColor = colors[i];
}

myPlot.ShowLegend();
myPlot.Legend.Orientation = Orientation.Horizontal;

myPlot.Axes.SetLimitsX(-0.5, 4);
myPlot.Axes.SetLimitsY(-0.8, 2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Function'>Function</a> category</div>


