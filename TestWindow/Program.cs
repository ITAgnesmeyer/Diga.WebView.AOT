using CoreWindowsWrapper;
using System.Resources;

namespace TestWindow
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string url = string.Empty;
            bool rel = false;
            if(args.Length > 0)
            {
                url = args[0];
            }
            if(args.Length > 1)
            {
                var rv = args[1];
                if(!string.IsNullOrEmpty(rv))
                {
                    if(rv == "r")
                    {
                        rel = true;
                    }
                }
            }
            BrowserWindow window = new BrowserWindow();
            window.WebViewCreate += (o, e) =>
            {
                if(!string.IsNullOrEmpty(url))
                {
                    if(!string.IsNullOrEmpty(e.MonitoringUrl))
                    {
                        if(rel)
                        {
                            url = e.MonitoringUrl + url;
                        }
                    }
                    e.Url = url;
                }
                
            };
            //Diga.Core.Api.Win32.ResourceLoader loader = new Diga.Core.Api.Win32.ResourceLoader();
            //var res =  loader.LoadResource("#1001", "RT_DATA");
            NativeApp.Run(window);
        }
    }
}
