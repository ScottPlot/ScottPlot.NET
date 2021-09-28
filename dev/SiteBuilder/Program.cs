using CommandLine;
using System;
using System.IO;

namespace SiteBuilder
{
    class Program
    {
        private class CommandLineOptions
        {
            [Option(longName: "content", Required = true, HelpText = "path of the root website (containing markdown files)")]
            public string? Content { get; set; }

            [Option(longName: "theme", Required = true, HelpText = "path of the theme folder (containing HTML templates)")]
            public string? Theme { get; set; }

            [Option(longName: "cookbook", Required = false, HelpText = "path of the cookbook folder (containing recipes.json and images folder)")]
            public string? Cookbook { get; set; }

            [Option(longName: "urlSource", Required = true, HelpText = "URL of the content source code")]
            public string? SourceUrl { get; set; }

            [Option(longName: "urlSite", Required = true, HelpText = "URL of the content on the web")]
            public string? SiteUrl { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(RunOptions);
        }

        static void RunOptions(CommandLineOptions opts)
        {
            if (opts.Cookbook is not null)
            {
                var cbg = new CookbookGenerator(opts.Cookbook);
                cbg.Generate();
            }

            var ssg = new Statix.Generator(
                contentFolder: opts.Content,
                themeFolder: opts.Theme,
                sourceUrl: opts.SourceUrl,
                rootUrl: opts.SiteUrl);
                
            ssg.Generate();
        }
    }
}