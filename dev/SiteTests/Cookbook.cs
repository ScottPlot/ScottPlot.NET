using System;
using NUnit.Framework;
using System.IO;

namespace SiteTests
{
    public class Cookbook
    {
        SiteBuilder.CookbookGenerator CBG;

        [SetUp]
        public void Setup()
        {
            string cookbookCsprojFile = Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory, 
                path2: "../../../../../ScottPlot/src/cookbook/ScottPlot.Cookbook/ScottPlot.Cookbook.csproj");
            Console.WriteLine(Path.GetFullPath(cookbookCsprojFile));
            CBG = new SiteBuilder.CookbookGenerator(cookbookCsprojFile);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}