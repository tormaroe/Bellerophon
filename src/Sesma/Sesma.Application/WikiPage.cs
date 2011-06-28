using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace Sesma.Application
{
    public class WikiPage
    {
        static string top = @"
<style>
body
{
    font-family: Verdana;
    font-size:12px;
    margin:2px;
    padding:0px;
}
h1
{
    font-size:18px;
}
</style>
";
        static string bottom = @"";

        public static string Wrap(string content)
        {
            return string.Concat(top, content, bottom);
        }

    }
}
