using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
/*
 SELLING POINTS
-fire and forget
-run all tasks at once and report as soon as each finished
-run all tasks at once adn report when all are done as a group
-ADVANCE
 *cancel midway threw a task
 *status updates on a individual tasks mid-tasks
 */
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

        private async void ButtonAsync_Clicked(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await RunDownloadAsync();
            watch.Stop();
            var elaspsedTime = watch.ElapsedMilliseconds;
            resultsWindow.Text += $"Execution Time: {elaspsedTime}";
                
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
        /*FIRE AND FORGET
         * poin to ASYNC is that caller can CONTINUE after call even though RunDwonloadAsync is still doing the TASK on ITS OWN
          AT VERY LEAST GUI can return control to USER while RUNDOWNLOADASYNC runs int he back
         
         */
        private async Task RunDownloadAsync() /* void bad, TASK GOOD for RETURN type*/
        {//run all task at once but report individually whichever is done first then continue
            List<string> websites = PrepData();
            foreach(string site in websites)
            {
                WebsiteDataModel results = await /*will wait till this is done*/ Task.Run(()=>DownloadWebsite(site)); //will return a TAASK<WEBSITEDATMODEL>
                ReportWebSiteInfo(results); /*need "results"*/

            }
            
        }
        private async Task RunDownloadParallelAsync() //run all tasks at once but report when all all done
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();
            foreach (string site in websites)
            {
                tasks.Add(Task.Run(() => DownloadWebsite(site))); /*list of tasks*/
                
                 
            }
            var results = await Task.WhenAll(tasks); 
            foreach(Task t in tasks)
            {
                ReportWebSiteInfo(t);
            }

        }
        private WebSiteDataModel DownLoadWebSite(string websiteURL)
        {
            //do shit
        }
        private void executeAsync_Click(Object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            /* run ASYNC FUNCTION function*/
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;

            resultsWindow.Text += $"Total time is:{elapsedTime} ";

        }
    }
}
 