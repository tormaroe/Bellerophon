using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarkdownSharp;
using System.Net;
using System.Threading;

namespace Sesma.Application
{
    public static class HelpPages
    {
        public static string GetPage(string page)
        {
            return new Markdown().Transform(GetMarkdown(page));
        }

        private static string GetMarkdown(string page)
        {
            throw new NotImplementedException();
        }
    }
}
