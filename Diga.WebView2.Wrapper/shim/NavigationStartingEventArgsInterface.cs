using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.shim
{
    public class NavigationStartingEventArgsInterface3: NavigationStartingEventArgsInterface2//, ICoreWebView2NavigationStartingEventArgs3
    {
        private ComObjectHolder<ICoreWebView2NavigationStartingEventArgs3> _args;

        public NavigationStartingEventArgsInterface3(ICoreWebView2NavigationStartingEventArgs3 args) : base(args)
        {
            Args = args;
        }

        private ICoreWebView2NavigationStartingEventArgs3 Args
        {
            get
            {
                if (_args == null)
                {
                    Debug.Print(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }

                return _args.Interface;
            }
            set => _args = new ComObjectHolder<ICoreWebView2NavigationStartingEventArgs3>(value);
        }

        public COREWEBVIEW2_NAVIGATION_KIND GetNavigationKind()
        {
            return Args.GetNavigationKind();
        }
    }
    public class NavigationStartingEventArgsInterface2: NavigationStartingEventArgsInterface//, ICoreWebView2NavigationStartingEventArgs2
    {
        private ComObjectHolder<ICoreWebView2NavigationStartingEventArgs2> _args;

        public NavigationStartingEventArgsInterface2(ICoreWebView2NavigationStartingEventArgs2 args) : base(args)
        {
            Args = args;
        }

        private ICoreWebView2NavigationStartingEventArgs2 Args
        {
            get
            {
                if (_args == null)
                {
                    Debug.Print(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }

                return _args.Interface;
            }
            set => _args = new ComObjectHolder<ICoreWebView2NavigationStartingEventArgs2>(value);
        }

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string GetAdditionalAllowedFrameAncestors()
        {
            return Args.GetAdditionalAllowedFrameAncestors();
        }

        public void SetAdditionalAllowedFrameAncestors([MarshalAs(UnmanagedType.LPWStr)] string value)
        {
            Args.SetAdditionalAllowedFrameAncestors(value);
        }
    }
    public class NavigationStartingEventArgsInterface : EventArgs//, ICoreWebView2NavigationStartingEventArgs
    {
        private ComObjectHolder<ICoreWebView2NavigationStartingEventArgs> _args;
        public NavigationStartingEventArgsInterface(ICoreWebView2NavigationStartingEventArgs args)
        {
            Args = args;
        }

        private ICoreWebView2NavigationStartingEventArgs Args
        {
            get
            {
                if (_args == null)
                {
                    Debug.Print(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");

                    throw new InvalidOperationException(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(Args) + " is null");
                }

                return _args.Interface;
            }
            set => _args = new ComObjectHolder<ICoreWebView2NavigationStartingEventArgs>(value);
        }
        public string uri => Args.Geturi();

        public int IsUserInitiated => Args.GetIsUserInitiated();

        public int IsRedirected => Args.GetIsRedirected();

        public ICoreWebView2HttpRequestHeaders RequestHeaders => Args.GetRequestHeaders();

        public int Cancel { get => Args.GetCancel(); set => Args.SetCancel(value); }

        public ulong NavigationId => Args.GetNavigationId();

        [return: MarshalAs(UnmanagedType.LPWStr)]
        public string Geturi()
        {
            return Args.Geturi();
        }

        public int GetIsUserInitiated()
        {
            return Args.GetIsUserInitiated();
        }

        public int GetIsRedirected()
        {
            return Args.GetIsRedirected();
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2HttpRequestHeaders GetRequestHeaders()
        {
            return Args.GetRequestHeaders();
        }

        public int GetCancel()
        {
            return Args.GetCancel();
        }

        public void SetCancel(int value)
        {
            Args.SetCancel(value);
        }

        public ulong GetNavigationId()
        {
            return Args.GetNavigationId();
        }
    }
}
