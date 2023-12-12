---
Title: "Images as Axis Labels - ScottPlot 4.1 Cookbook"
Description: "Images can be used as axis labels to allow for things like LaTeX axis labels."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/asis_image/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Images as Axis Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_image/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_image.png"
---

<h2><a href='/cookbook/4.1/recipes/asis_image/'>Images as Axis Labels</a></h2>

Images can be used as axis labels to allow for things like LaTeX axis labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create an interesting plot
double[] xs = DataGen.Range(-5, 5, .5);
double[] ys = DataGen.Range(-5, 5, .5);
Vector2[,] vectors = new Vector2[xs.Length, ys.Length];
for (int i = 0; i < xs.Length; i++)
    for (int j = 0; j < ys.Length; j++)
        vectors[i, j] = new Vector2(ys[j], -15 * Math.Sin(xs[i]));
plt.AddVectorField(vectors, xs, ys, colormap: Drawing.Colormap.Turbo);

// use images as axis labels
plt.XAxis.ImageLabel(new Bitmap("Images/theta.png"));
plt.YAxis.ImageLabel(new Bitmap("Images/d_theta_dt.png"));

plt.SaveFig("asis_image.png");
```

<img src='../../images/asis_image.png' class='d-block mx-auto my-5' />


