using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WebsiteDeadPageFinder
{
    public partial class Form1 : Form
    {
        string Title = "Website Dead Page Finder";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(URL.Text, UriKind.Absolute))
            {
                LogIt("======================================== URLS ============================================");
                List<string> urls = GetUrlsFromSiteMap(URL.Text);
                LogIt("==========================================================================================");
                int counter = 0;
                int pagecounter = 0;
                foreach (string page in urls)
                {
                    bool result = DoesSiteExist2(page);
                    if(result == true)
                    {
                        LogIt("Page " + page + " does exist!");
                    }
                    else
                    {
                        LogIt("Warning!!!");
                        LogIt(page + " DOES NOT EXIST OR HAS A SERIOUS ERROR!");
                        LogIt("Warning!!!");
                        counter++;
                    }
                    pagecounter++;
                }
                LogIt("=======================================================================================================");
                LogIt("I found " + counter.ToString() + " pages that did not exist (or had a significant error), but where in the sitemap.");
                LogIt("Total pages: " + pagecounter.ToString());
                LogIt("=======================================================================================================");
                if (counter > 0)
                {
                    LogIt("Pages that are listed in the sitemap but do not actually exist are bad. Google crawls these pages and finds zero content! It affects your search engine rank!");
                    LogIt("==============================================================================================================================================================");
                }
            }
            else
            {
                MessageBox.Show("You need to enter a sitemap address.", Title);
            }
        }



        bool DoesSiteExist(string url)
        {
            bool result = true;
            try
            {
                Uri uri = new Uri(url);
                WebRequest request = WebRequest.Create(uri);
                request.Timeout = (int)timeOut.Value * 1000;
                WebResponse response;
                try
                {
                    response = request.GetResponse();
                }
                catch (Exception ex)
                {
                    result = false;
                    LogIt("Error: " + ex.Message.ToString() + " for page: " + url);
                    //MessageBox.Show("The website entered doesn't exist.", Title);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to check if site exists.\nError Code: " + ex.Message.ToString(), Title);
                LogIt("Error: " + ex.Message.ToString());
            }
            return result;
        }


        bool DoesSiteExist2(string url)
        {
            bool result = true;
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = (int)timeOut.Value * 1000;
                request.AllowAutoRedirect = false;
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    result = true;
                }
            }
            catch(Exception ex)
            {
                result = false;
                LogIt("Error: " + ex.Message.ToString() + " for page: " + url);
            }
            return result;
        }


        List<string> GetUrlsFromSiteMap(string SitemapURL)
        {
            LogIt("Attempting to retrieve web pages and their urls from the website's sitemap...\n");
            List<string> urls = new List<string>();
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = System.Text.Encoding.UTF8;
                string reply = wc.DownloadString(SitemapURL);
                XmlDocument urldoc = new XmlDocument();
                urldoc.LoadXml(reply);
                XmlNodeList xnList = urldoc.GetElementsByTagName("url");

                foreach (XmlNode node in xnList)
                {
                    LogIt("url: " + node["loc"].InnerText);
                    urls.Add(node["loc"].InnerText);
                }
                Output.Text = Output.Text + "\n\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is not a valid sitemap address, the author of the website hasn't created it properly. You will need to manually visit each page.", Title);
                LogIt("This is not a valid sitemap address, the author of the website hasn't created it properly. You will need to manually visit each page.");
                LogIt("Error: " + ex.Message.ToString());
            }
            return urls;
        }



        void LogIt(string message)
        {
            Output.Text = Output.Text + DateTime.Now.ToString() + ":   " + message + "\n";
            Output.Focus();
            Output.SelectionStart = Output.Text.Length;
            Output.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }
    }
}
