using System.Net.Http;
using System.Text.Json;

namespace webScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            ScrapeWebsite();
        }

        internal async void ScrapeWebsite()
        {
            string subreddit = txtSubreddit.Text.Trim();
            if (string.IsNullOrWhiteSpace(subreddit))
            {
                rtbDisplay.AppendText("Subreddit cannot be empty.\n");
                return;
            }

            string[] queryTerms = new string[]
            {
                txtSearchTerm1.Text.Trim(),
                txtSearchTerm2.Text.Trim(),
                txtSearchTerm3.Text.Trim()
            };

            int maxPages = 20;  // number of pages you want to scrape
            string after = null;
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");

            for (int i = 0; i < maxPages; i++)
            {
                string siteUrl = $"https://www.reddit.com/r/{subreddit}/.json?limit=100";
                if (!string.IsNullOrEmpty(after))
                    siteUrl += $"&after={after}";

                var response = await httpClient.GetAsync(siteUrl);
                if (!response.IsSuccessStatusCode)
                {
                    rtbDisplay.AppendText($"Failed to retrieve page {i + 1}\n");
                    break;
                }

                var json = await response.Content.ReadAsStringAsync();
                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    var data = doc.RootElement.GetProperty("data");
                    var posts = data.GetProperty("children").EnumerateArray();

                    foreach (var post in posts)
                    {
                        var postData = post.GetProperty("data");
                        string title = postData.GetProperty("title").GetString();
                        string permalink = postData.GetProperty("permalink").GetString();
                        string fullUrl = "https://www.reddit.com" + permalink;

                        if (queryTerms.Any(term => !string.IsNullOrWhiteSpace(term) && title.Contains(term, StringComparison.OrdinalIgnoreCase)))
                        {
                            rtbDisplay.AppendText($"{title} - {fullUrl}{Environment.NewLine}");
                        }
                    }

                    // Grab the after token for next page
                    after = data.GetProperty("after").GetString();

                    if (string.IsNullOrEmpty(after))
                    {
                        // No more pages
                        break;
                    }
                }
            }

            rtbDisplay.AppendText("Finished scraping.\n");
        }
    }



}

