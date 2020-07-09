using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AsyncApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            resultsWindow.Text = "";
            output.Add("WebA.com");
            output.Add("WebB.com");
        } 

        private void ButtonSynCro_Clicked(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            RunDownLoadSync();
            watch.Stop();
            var elaspedMs = watch.ElapsedMilliseconds;
            resultsWindow.Text += $"Execution Time:  {elaspedMs}";
        }

        private void ButtonAsync_Clicked(object sender, EventArgs e)
        {

        }

        private void RunDownLoadSync()
        {
            List<string> websites = PrepData();
            foreach(string site in websites)
            {
                WebSiteDataModel results = DownLoadWebsite(site);
                ReportWebSiteInfo(results);
            }
        }
        private WebSiteDataModel DownLoadWebSite(string websiteURL)
        {
            //do shit
        }
    }
}
 