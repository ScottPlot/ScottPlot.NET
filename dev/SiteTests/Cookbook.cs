using System;
using NUnit.Framework;
using System.IO;

namespace SiteTests
{
    public class Cookbook
    {
        //[Test]
        public void Test_Cookbook_Build()
        {
            string cookbookFolder = Path.Combine(
                path1: TestContext.CurrentContext.TestDirectory,
                path2: "../../../../../content/cookbook/4.1/");

            var cbg = new SiteBuilder.CookbookGenerator(cookbookFolder);
            cbg.Generate();
        }
    }
}