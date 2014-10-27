using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using ZillowDownloadConsole.DAL.dbo;
using ZillowDownloadConsole.DO.dbo;

namespace ZillowDownloadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Downloader prog = new Downloader();
            prog.Run();
        }
    }


    public class Downloader
    {
        string _urlFormat = "http://www.zillow.com/search/GetResults.htm?spt=homes&status=001000&lt=000000&ht=100000&pr=120587,163147&mp=451,611&bd=0%2C&ba=1.0%2C&sf=1315,1779&lot=,&yr=,&pho=0&pets=0&parking=0&laundry=0&pnd=0&red=0&zso=0&days=12m&ds=all&pmf=0&pf=0&zoom=12&rect=-81481218,28316471,-81258059,28376902&p={0}&sort=days&search=list&disp=1&listright=true&responsivemode=defaultList&isMapSearch=false&zoom=12";
        string _folder;
        int _page = 1;
        int _totalPages = 1;

        Regex esc = new Regex("&\\w+;|href=\"[^\"]+\"");
        Regex open = new Regex(@"<article");
        Regex close = new Regex(@"</article>");

        public Downloader()
        {

        }


        public void Run()
        {

            string url = string.Format(_urlFormat, _page);
            
            PageDO page = GetPageHtml(url);

            XmlDocument[] articleDocs = GetArticles(page.Html);

            foreach (XmlDocument doc in articleDocs)
            {
                Article article = new Article(doc, page.PageId);
                PropertyDO property = article.GetProperty();
                Property.Create(property);
            }

            _page += 1;
            if (_page <= _totalPages)
                Run();
        }





        /// <summary>
        /// Gets an array of articles formatted as xml
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        XmlDocument[] GetArticles(string html)
        {
            MatchCollection openers = open.Matches(html);
            MatchCollection closers = close.Matches(html);
            List<XmlDocument> articles = new List<XmlDocument>();
            for (int i = 0; i < openers.Count; i++)
            {
                Match o = openers[i];
                Match c = closers[i];
                string article = html.Substring(o.Index, c.Index - o.Index + 10);
                article = esc.Replace(article, "");
                article = article.Replace("&", "&amp;");
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(article);
                articles.Add(xml);
            }

            return articles.ToArray();
        }


        /// <summary>
        /// Returns the html for a page from the database or by downloading
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        PageDO GetPageHtml(string url)
        {
            PageDO[] allPages = Page.GetAll();
            PageDO page = allPages.Where(p => p.Url == url).FirstOrDefault();
            if (page != null)
                return page;

            using (WebClient client = new WebClient())
            {
                string content = client.DownloadString(url);
                JObject json = JObject.Parse(content);

                _totalPages = Convert.ToInt32(json["list"]["numPages"].ToString());

                JToken token = json["list"]["listHTML"];
                string html = token.ToString();

                // save the page to the database
                page = new PageDO() { DownloadDate = DateTime.Now, Html = html, Url = url };
                page.PageId = Page.Create(page);

                return page;
            }
        }
    }

    public class Article
    {
        XmlDocument article;
        PropertyDO property = new PropertyDO();

        public Article(XmlDocument Article, int PageId)
        {
            property.PageId = PageId;
            article = Article;
            property.ArticleHtml = article.OuterXml;
        }

        public PropertyDO GetProperty()
        {
            property.Lat = article.DocumentElement.Attributes["latitude"].InnerText;
            property.Long = article.DocumentElement.Attributes["longitude"].InnerText;
            property.PhotoUrl = article.SelectSingleNode("//figure").Attributes["data-photourl"].InnerText;
            property.PhotoCaption = article.SelectSingleNode("//figcaption") == null ? " " : article.SelectSingleNode("//figcaption").InnerText;
            XmlNodeList dts = article.SelectNodes("//dt");
            property.Price = article.SelectSingleNode("//dt[@class='type-recentlySold listing-type zsg-content_collapsed']") == null ? " " : article.SelectSingleNode("//dt[@class='type-recentlySold listing-type zsg-content_collapsed']").InnerText; // dts[0].InnerText;
            property.SoldDate = article.SelectSingleNode("//dt[@class='sold-date zsg-fineprint']") == null ? " " : article.SelectSingleNode("//dt[@class='sold-date zsg-fineprint']").InnerText;// dts[1].InnerText;
            property.Zestimate = article.SelectSingleNode("//dt[@class='zestimate zsg-fineprint']") == null ? " " : article.SelectSingleNode("//dt[@class='zestimate zsg-fineprint']").InnerText;// dts[2].InnerText;
            property.PriceSQFt = article.SelectSingleNode("//dt[@class='zsg-fineprint']") == null ? " " : article.SelectSingleNode("//dt[@class='zsg-fineprint']").InnerText; // dts[3].InnerText;
            property.Address = article.SelectSingleNode("//dt[@class='property-address']") == null ? " " : article.SelectSingleNode("//dt[@class='property-address']").InnerText; // dts[4].InnerText;
            property.PropertyData = article.SelectSingleNode("//dt[@class='property-data']") == null ? " " : article.SelectSingleNode("//dt[@class='property-data']").InnerText; //dts[5].InnerText;
            property.LotSize = article.SelectSingleNode("//dt[@class='property-lot zsg-fineprint']") == null ? " " : article.SelectSingleNode("//dt[@class='property-lot zsg-fineprint']").InnerText; //dts[6].InnerText;
            property.YearBuilt = article.SelectSingleNode("//dt[@class='property-year zsg-fineprint']") == null ? " " : article.SelectSingleNode("//dt[@class='property-year zsg-fineprint']").InnerText; // dts[7].InnerText;

            
            return property;

        }

        private void ParseFigure()
        {

        }

        private void ParseCol1()
        {

        }

        private void ParseCol2()
        {

        }

    }
}
