using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkdownSharp;
using System.Net;
using System.Threading;
using System.Reflection;
using System.Resources;
using System.IO;

namespace Sesma.Application
{
    public static class HelpPageExtractor
    {
        public static string GetPage(string page)
        {
            return WikiPage.Wrap(new Markdown().Transform(GetMarkdown(page)));
        }

        private static string GetMarkdown(string page)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Sesma.Application.HelpPages." + page);
            using(var reader = new StreamReader(stream))        
                return reader.ReadToEnd();

        }
    }
}
