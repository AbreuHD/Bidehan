using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Scrapers.TikTok
{
    public static class TikTokScraper
    {
        public static async Task<string> GetDirectUriAsync(string url)
        {
            HtmlWeb web = new HtmlWeb();
            var pageResult = await web.LoadFromWebAsync(url);
            var responseNode = pageResult.DocumentNode.SelectSingleNode("//video/source[2]");
            //var cutNode = responseNode.Split("'norobotlink').innerHTML = '")[1];
            //var link = cutNode.Replace("' + ('xcd", "").Replace("').substring(1).substring(2);", "");
            return "";
        }
    }
}
