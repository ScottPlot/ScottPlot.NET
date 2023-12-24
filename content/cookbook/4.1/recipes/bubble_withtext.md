---
Title: "Bubbles with Labels - ScottPlot 4.1 Cookbook"
Description: "Bubble plots can be combined with other plot types to create more advanced charts. In this example each bubble is accompanied by a text object. Bubbles are also colored according to their size such that smaller bubbles are bluer."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bubble_withtext/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bubble Plot", "Bubbles with Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bubble", "/cookbook/4.1/recipes/bubble_withtext/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bubble_withtext.png"
---

<h2><a id='bubbles-with-labels' href='/cookbook/4.1/recipes/bubble_withtext/'>Bubbles with Labels</a></h2>

Bubble plots can be combined with other plot types to create more advanced charts. In this example each bubble is accompanied by a text object. Bubbles are also colored according to their size such that smaller bubbles are bluer.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
int pointCount = 30;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount, 10);
string[] labels = ys.Select(x => x.ToString("N2")).ToArray();
var labelFont = new Drawing.Font
{
    Bold = true,
    Color = Color.Black,
    Alignment = Alignment.MiddleCenter
};

var myBubblePlot = plt.AddBubblePlot();
for (int i = 0; i < xs.Length; i++)
{
    // give each bubble a random size and make smaller ones bluer
    double randomValue = rand.NextDouble();
    double bubbleSize = randomValue * 30 + 10;
    Color bubbleColor = Drawing.Colormap.Jet.GetColor(randomValue, .5);

    myBubblePlot.Add(
        x: xs[i],
        y: ys[i],
        radius: bubbleSize,
        fillColor: bubbleColor,
        edgeColor: Color.Transparent,
        edgeWidth: 1
    );

    plt.AddText(labels[i], xs[i], ys[i], labelFont);
}

plt.Title("Bubble Plot with Labels");
plt.AxisAuto(.2, .25); // zoom out to accommodate large bubbles

plt.SaveFig("bubble_withText.png");
```

<img src='../../images/bubble_withtext.png' class='d-block mx-auto my-5' />


