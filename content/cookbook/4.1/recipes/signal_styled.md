---
Title: "Styled Signal Plot - ScottPlot 4.1 Cookbook"
Description: "Signal plots can be styled using public fields. Signal plots can also be offset by a defined X or Y amount."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/signal_styled/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Signal Plot", "Styled Signal Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-signal-plot", "/cookbook/4.1/recipes/signal_styled/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/signal_styled.png"
---

<h2><a id='styled-signal-plot' href='/cookbook/4.1/recipes/signal_styled/'>Styled Signal Plot</a></h2>

Signal plots can be styled using public fields. Signal plots can also be offset by a defined X or Y amount.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.RandomWalk(null, 500);
int sampleRate = 10;

var sp2 = plt.AddSignal(ys, sampleRate, Color.Magenta);
sp2.OffsetY = 1000;
sp2.OffsetX = 300;
sp2.LineStyle = LineStyle.Dash;
sp2.LineWidth = 2;

plt.SaveFig("signal_styled.png");
```

<img src='../../images/signal_styled.png' class='d-block mx-auto my-5' />


