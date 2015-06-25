//Problem 15. Replace tags

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;

class ReplaceTags
{
    static void Main()
    {
        string site = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

        string html1 = "<a href=\"";
        string html2 = @""">";
        string html3 = "</a>";
        string url1 = "[URL=";
        string url2 = "]";
        string url3 = "[/URL]";

        while (site.Contains(html1))
        {
            site = site.Replace(html1, url1);
        }
        while (site.Contains(html2))
        {
            site = site.Replace(html2, url2);
        }
        while (site.Contains(html3))
        {
            site = site.Replace(html3, url3);
        }

        Console.WriteLine(site);
    }
}
