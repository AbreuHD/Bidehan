using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utils
{
    public class Search
    {
        public async Task<string> AutomaticSearchAsync(string uri)
        {
            if (uri.Contains("streamtape.") || uri.Contains("streamta.pe") || uri.Contains("tapecontent.net"))
            {
                Scrapers.Streamtape.StreamtapeScraper.GetDirectUri(uri);
            }
            if(uri.Contains("tiktok."))
            {
                await Scrapers.TikTok.TikTokScraper.GetDirectUriAsync(uri);
            }
            if (uri.Contains("gamovideo."))
            {
                //Scrapers.Twitter.TwitterScraper.GetDirectUri(uri);
            }
            return "This web is not added, please create a ticket in Github";
        }
    }
}
