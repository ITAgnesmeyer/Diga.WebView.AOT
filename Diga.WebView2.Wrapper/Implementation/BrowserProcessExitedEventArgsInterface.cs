using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Diagnostics;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class BrowserProcessExitedEventArgsInterface //: ICoreWebView2BrowserProcessExitedEventArgs
    {
        private ComObjectHolder<ICoreWebView2BrowserProcessExitedEventArgs> _Args;
        private ICoreWebView2BrowserProcessExitedEventArgs Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(BrowserProcessExitedEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(BrowserProcessExitedEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }
                return _Args.Interface;
            }
            set { _Args = new ComObjectHolder<ICoreWebView2BrowserProcessExitedEventArgs>(value); }
        }
        public BrowserProcessExitedEventArgsInterface(ICoreWebView2BrowserProcessExitedEventArgs args)
        {
            this.Args = args ?? throw new ArgumentNullException(nameof(args));
        }

        public COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind => this.Args.GetBrowserProcessExitKind();

        public uint BrowserProcessId => this.Args.GetBrowserProcessId();
    }
}
