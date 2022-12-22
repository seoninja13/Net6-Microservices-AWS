

       
        
Console.WriteLine("Scrape books!");
    

static HtmlDocument GetDocument(string url)
{
    Html web = new HtmlWeb();
    HtmlDocument doc = web.Load(url);
    console.WriteLine("Url is: " + url);
    return doc;
}

public HtmlNodeCollection SelectNodes(string xpath);

public HtmlNode SelectSingleNode(string xpath);