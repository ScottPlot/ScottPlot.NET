---
Title: "Using a DateTime Axis - ScottPlot 4.1 Cookbook"
Description: "You probably never want to do this... but OHLCs have an X value you can customize to be a DateTime (converted to a double using DateTime.ToOATime()). The advantage is that you can use the native DateTime axis support on the horizontal axis. The disadvantage is that gaps in time appear as gaps in the candlesticks. Weekends without trading will appear as gaps. The alternative to this method is to plot a series of OHLCs using sequential numbers, then manually define the axis tick labels."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/finance_datetimeaxis/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Finance", "Using a DateTime Axis"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-finance", "/cookbook/4.1/recipes/finance_datetimeaxis/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/finance_datetimeaxis.png"
---

<h2><a href='/cookbook/4.1/recipes/finance_datetimeaxis/'>Using a DateTime Axis</a></h2>

You probably never want to do this... but OHLCs have an X value you can customize to be a DateTime (converted to a double using DateTime.ToOATime()). The advantage is that you can use the native DateTime axis support on the horizontal axis. The disadvantage is that gaps in time appear as gaps in the candlesticks. Weekends without trading will appear as gaps. The alternative to this method is to plot a series of OHLCs using sequential numbers, then manually define the axis tick labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 60, TimeSpan.FromDays(1));

// add the OHLCs to the plot and the horizontal axis to display DateTime tick labels
plt.AddCandlesticks(prices);
plt.XAxis.DateTimeFormat(true);

plt.SaveFig("finance_dateTimeAxis.png");
```

<img src='../../images/finance_datetimeaxis.png' class='d-block mx-auto my-5' />


