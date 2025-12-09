using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2View21Interface : WebView2View20Interface //, ICoreWebView2_21
    {
        private ComObjectHolder<ICoreWebView2_21> _Iface;
        private ICoreWebView2_21 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View21Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View21Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_21>(value);
        }
        public WebView2View21Interface(ICoreWebView2_21 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }

        public void ExecuteScriptWithResult([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptWithResultCompletedHandler handler)
        {
            Iface.ExecuteScriptWithResult(javaScript, handler);
        }

        
    }

    public class WebView2View20Interface : WebView2View19Interface//, ICoreWebView2_20
    {
        private ComObjectHolder<ICoreWebView2_20> _Iface;
        private ICoreWebView2_20 Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(WebView2View20Interface) + "=>" + nameof(Iface) + " is null");

                    throw new InvalidOperationException(nameof(WebView2View20Interface) + "=>" + nameof(Iface) + " is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<ICoreWebView2_20>(value);
        }
        public WebView2View20Interface(ICoreWebView2_20 iface) : base(iface)
        {
            Iface = iface ?? throw new ArgumentNullException(nameof(iface));
        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                _Iface = null;
                _IsDisposed = true;
            }
            base.Dispose(disposing);
        }

        public uint FrameId => this.Iface.GetFrameId();
    }

    public class WebView2View19Interface : WebView2View18Interface//, ICoreWebView2_19
    {
        private ComObjectHolder<ICoreWebView2_19> _WebView;
        private ICoreWebView2_19 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View19Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View19Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_19>(value);
        }

        public WebView2View19Interface(ICoreWebView2_19 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public COREWEBVIEW2_MEMORY_USAGE_TARGET_LEVEL MemoryUsageTargetLevel { get => this.WebView.GetMemoryUsageTargetLevel(); set => this.WebView.SetMemoryUsageTargetLevel(value); }
    }
    public class WebView2View18Interface : WebView2View17Interface//, ICoreWebView2_18
    {
        private ComObjectHolder<ICoreWebView2_18> _WebView;

        private ICoreWebView2_18 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View18Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View18Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_18>(value);
        }

        public WebView2View18Interface(ICoreWebView2_18 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_LaunchingExternalUriScheme([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2LaunchingExternalUriSchemeEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_LaunchingExternalUriScheme(eventHandler, out token);
        }

        public void remove_LaunchingExternalUriScheme([In] EventRegistrationToken token)
        {
            this.WebView.remove_LaunchingExternalUriScheme(token);
        }
    }
    public class WebView2View17Interface : WebView2View16Interface //, ICoreWebView2_17
    {
        private ComObjectHolder<ICoreWebView2_17> _WebView;

        private ICoreWebView2_17 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View17Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View17Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_17>(value);
        }

        public WebView2View17Interface(ICoreWebView2_17 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void PostSharedBufferToScript([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In, MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson)
        {
            this.WebView.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJson);
        }
    }
    public class WebView2View16Interface : WebView2View15Interface //, ICoreWebView2_16
    {
        private ComObjectHolder<ICoreWebView2_16> _WebView;

        private ICoreWebView2_16 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View16Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View16Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_16>(value);
        }

        public WebView2View16Interface(ICoreWebView2_16 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void Print([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintCompletedHandler handler)
        {
            this.WebView.Print(printSettings, handler);
        }

        public void ShowPrintUI([In] COREWEBVIEW2_PRINT_DIALOG_KIND printDialogKind)
        {
            this.WebView.ShowPrintUI(printDialogKind);
        }

        public void PrintToPdfStream([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfStreamCompletedHandler handler)
        {
            this.WebView.PrintToPdfStream(printSettings, handler);
        }
    }
    public class WebView2View15Interface : WebView2View14Interface
    {
        private ComObjectHolder<ICoreWebView2_15> _WebView;
        private ICoreWebView2_15 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View15Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View15Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_15>(value);
        }

        public ICoreWebView2_15 GetInterface()
        {
            return this.WebView;
        }
        public WebView2View15Interface(ICoreWebView2_15 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_FaviconChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FaviconChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_FaviconChanged(eventHandler, out token);
        }

        public void remove_FaviconChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_FaviconChanged(token);
        }

        public string FaviconUri => this.WebView.GetFaviconUri();

        public void GetFavicon([In] COREWEBVIEW2_FAVICON_IMAGE_FORMAT format, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetFaviconCompletedHandler completedHandler)
        {
            this.WebView.GetFavicon(format, completedHandler);
        }
    }
    public class WebView2View14Interface : WebView2View13Interface
    {
        private ComObjectHolder<ICoreWebView2_14> _WebView;
        private ICoreWebView2_14 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View14Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View14Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_14>(value);
        }
        public WebView2View14Interface(ICoreWebView2_14 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_ServerCertificateErrorDetected([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ServerCertificateErrorDetectedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ServerCertificateErrorDetected(eventHandler, out token);
        }

        public void remove_ServerCertificateErrorDetected([In] EventRegistrationToken token)
        {
            this.WebView.remove_ServerCertificateErrorDetected(token);
        }

        public void ClearServerCertificateErrorActions([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClearServerCertificateErrorActionsCompletedHandler handler)
        {
            this.WebView.ClearServerCertificateErrorActions(handler);
        }
    }
    public class WebView2View13Interface : WebView2View12Interface
    {
        private ComObjectHolder<ICoreWebView2_13> _WebView;
        private ICoreWebView2_13 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View13Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View13Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_13>(value);
        }

        public WebView2View13Interface(ICoreWebView2_13 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public ICoreWebView2Profile Profile => this.WebView.GetProfile();
    }
    public class WebView2View12Interface : WebView2View11Interface
    {
        private ComObjectHolder<ICoreWebView2_12> _WebView;
        private ICoreWebView2_12 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View12Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View12Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_12>(value);
        }

        public WebView2View12Interface(ICoreWebView2_12 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }



        public void add_StatusBarTextChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2StatusBarTextChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_StatusBarTextChanged(eventHandler, out token);
        }

        public void remove_StatusBarTextChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_StatusBarTextChanged(token);
        }

        public string StatusBarText => this.WebView.GetStatusBarText();
    }


    public class WebView2View11Interface : WebView2View10Interface
    {
        private ComObjectHolder<ICoreWebView2_11> _WebView;
        private ICoreWebView2_11 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View11Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View11Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_11>(value);
        }

        public WebView2View11Interface(ICoreWebView2_11 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void CallDevToolsProtocolMethodForSession([In, MarshalAs(UnmanagedType.LPWStr)] string sessionId, [In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
        }

        public void add_ContextMenuRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ContextMenuRequested(eventHandler, out token);
        }

        public void remove_ContextMenuRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_ContextMenuRequested(token);
        }
    }
    public class WebView2View10Interface : WebView2View9Interface
    {
        private ComObjectHolder<ICoreWebView2_10> _WebView;
        private ICoreWebView2_10 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View10Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View10Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_10>(value);
        }

        public WebView2View10Interface(ICoreWebView2_10 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        public void add_BasicAuthenticationRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BasicAuthenticationRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_BasicAuthenticationRequested(eventHandler, out token);
        }

        public void remove_BasicAuthenticationRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_BasicAuthenticationRequested(token);
        }
    }


    public class WebView2View9Interface : WebView2View8Interface
    {
        private ComObjectHolder<ICoreWebView2_9> _WebView;
        private ICoreWebView2_9 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_9>(value);
        }
        public WebView2View9Interface(ICoreWebView2_9 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_IsDefaultDownloadDialogOpenChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDefaultDownloadDialogOpenChangedEventHandler handler, out EventRegistrationToken token)
        {
            this.WebView.add_IsDefaultDownloadDialogOpenChanged(handler, out token);
        }

        public void remove_IsDefaultDownloadDialogOpenChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsDefaultDownloadDialogOpenChanged(token);
        }

        public int IsDefaultDownloadDialogOpen => this.WebView.GetIsDefaultDownloadDialogOpen();

        public void OpenDefaultDownloadDialog()
        {
            this.WebView.OpenDefaultDownloadDialog();
        }

        public void CloseDefaultDownloadDialog()
        {
            this.WebView.CloseDefaultDownloadDialog();
        }

        public COREWEBVIEW2_DEFAULT_DOWNLOAD_DIALOG_CORNER_ALIGNMENT DefaultDownloadDialogCornerAlignment { get => this.WebView.GetDefaultDownloadDialogCornerAlignment(); set => this.WebView.SetDefaultDownloadDialogCornerAlignment(value); }
        public POINT DefaultDownloadDialogMargin { get => this.WebView.GetDefaultDownloadDialogMargin(); set => this.WebView.SetDefaultDownloadDialogMargin(value); }
    }

    public class WebView2View8Interface : WebView2View7Interface
    {
        private ComObjectHolder<ICoreWebView2_8> _WebView;
        private ICoreWebView2_8 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View8Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_8>(value);
        }
        public WebView2View8Interface(ICoreWebView2_8 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void add_IsMutedChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsMutedChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_IsMutedChanged(eventHandler, out token);
        }

        public void remove_IsMutedChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsMutedChanged(token);
        }

        public int IsMuted { get => this.WebView.GetIsMuted(); set => this.WebView.SetIsMuted(value); }

        public void add_IsDocumentPlayingAudioChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2IsDocumentPlayingAudioChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_IsDocumentPlayingAudioChanged(eventHandler, out token);
        }

        public void remove_IsDocumentPlayingAudioChanged([In] EventRegistrationToken token)
        {
            this.WebView.remove_IsDocumentPlayingAudioChanged(token);
        }

        public int IsDocumentPlayingAudio => this.WebView.GetIsDocumentPlayingAudio();

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }


    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View7Interface : WebView2View6Interface
    {
        private ComObjectHolder<ICoreWebView2_7> _WebView;
        private ICoreWebView2_7 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View7Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View7Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2_7>(value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View7Interface(ICoreWebView2_7 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PrintToPdf([In, MarshalAs(UnmanagedType.LPWStr)] string ResultFilePath, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintSettings printSettings, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PrintToPdfCompletedHandler handler)
        {
            try
            {

                this.WebView.PrintToPdf(ResultFilePath, printSettings, handler);
            }
            catch (Exception e)
            {
                var ex = Marshal.GetExceptionForHR(e.HResult);
                Debug.Print(ex.Message);
            }

        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }

    }


    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View6Interface : WebView2View5Interface
    {
        private ComObjectHolder<ICoreWebView2_6> _WebView;

        private ICoreWebView2_6 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View6Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View6Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_6>(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View6Interface(ICoreWebView2_6 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenTaskManagerWindow()
        {
            this.WebView.OpenTaskManagerWindow();
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View5Interface : WebView2View4Interface
    {
        private ComObjectHolder<ICoreWebView2_5> _WebView;
        private ICoreWebView2_5 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View5Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View5Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_5>(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View5Interface(ICoreWebView2_5 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ClientCertificateRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ClientCertificateRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ClientCertificateRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ClientCertificateRequested([In] EventRegistrationToken token)
        {
            try
            {
                this.WebView.remove_ClientCertificateRequested(token);
            }
            catch (AccessViolationException accessViolation)
            {

                Debug.Print("AccessViolation Exception:" + accessViolation.ToString());
            }

        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }


    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2View4Interface : WebView2View3Interface
    {
        private ComObjectHolder<ICoreWebView2_4> _WebView;

        private ICoreWebView2_4 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View4Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View4Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set => this._WebView = new ComObjectHolder<ICoreWebView2_4>(value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View4Interface(ICoreWebView2_4 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameCreated([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameCreatedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_FrameCreated(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameCreated([In] EventRegistrationToken token)
        {
            this.WebView.remove_FrameCreated(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DownloadStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DownloadStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_DownloadStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DownloadStarting([In] EventRegistrationToken token)
        {
            try
            {
                this.WebView.remove_DownloadStarting(token);
            }
            catch (COMException comEx)
            {
                Debug.Print(nameof(remove_DownloadStarting) + " Exception" + comEx);

            }

        }

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View3Interface : WebView2View2Interface
    {
        private ComObjectHolder<ICoreWebView2_3> _WebView;

        private ICoreWebView2_3 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View3Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View3Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2_3>(value);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View3Interface(ICoreWebView2_3 webView) : base(webView)
        {
            this.WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void TrySuspend([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler)
        {
            this.WebView.TrySuspend(handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Resume()
        {
            this.WebView.Resume();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int IsSuspended => this.WebView.GetIsSuspended();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void SetVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName, [In, MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind)
        {
            this.WebView.SetVirtualHostNameToFolderMapping(hostName, folderPath, accessKind);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ClearVirtualHostNameToFolderMapping([In, MarshalAs(UnmanagedType.LPWStr)] string hostName)
        {
            this.WebView.ClearVirtualHostNameToFolderMapping(hostName);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WebView2View2Interface : WebView2ViewInterface
    {
        private ComObjectHolder<ICoreWebView2_2> _WebView;

        private ICoreWebView2_2 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View2Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View2Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView.Interface;
            }
            set
            {
                this._WebView = new ComObjectHolder<ICoreWebView2_2>(value);
            }
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2View2Interface(ICoreWebView2_2 webView) : base(webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            this.WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceResponseReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceResponseReceivedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_WebResourceResponseReceived(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceResponseReceived([In] EventRegistrationToken token)
        {
            this.WebView.remove_WebResourceResponseReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateWithWebResourceRequest([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequest Request)
        {
            this.WebView.NavigateWithWebResourceRequest(Request);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_DOMContentLoaded(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            this.WebView.remove_DOMContentLoaded(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2CookieManager CookieManager => this.WebView.GetCookieManager();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Environment Environment => this.WebView.GetEnvironment();

        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._WebView = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class WebView2ViewInterface : IDisposable
    {
        private ComObjectHolder<ICoreWebView2> _WebView;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private ICoreWebView2 WebView
        {
            get
            {
                if (_WebView == null)
                {
                    Debug.Print(nameof(WebView2ViewInterface) + "." + nameof(WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2ViewInterface) + "." + nameof(WebView) + " is null");

                }
                return _WebView.Interface;
            }
            set
            {
                _WebView = new ComObjectHolder<ICoreWebView2>(value);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebView2ViewInterface(ICoreWebView2 webView)
        {
            if (webView == null)
                throw new ArgumentNullException(nameof(webView));

            WebView = webView;
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ICoreWebView2Settings Settings => WebView.GetSettings();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Source => WebView.GetSource();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Navigate([In, MarshalAs(UnmanagedType.LPWStr)] string uri)
        {
            WebView.Navigate(uri);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void NavigateToString([In, MarshalAs(UnmanagedType.LPWStr)] string htmlContent)
        {
            WebView.NavigateToString(htmlContent);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_NavigationStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NavigationStarting([In] EventRegistrationToken token)
        {
            WebView.remove_NavigationStarting(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ContentLoading([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_ContentLoading(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ContentLoading([In] EventRegistrationToken token)
        {
            WebView.remove_ContentLoading(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_SourceChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SourceChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_SourceChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_SourceChanged([In] EventRegistrationToken token)
        {
            WebView.remove_SourceChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_HistoryChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2HistoryChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_HistoryChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_HistoryChanged([In] EventRegistrationToken token)
        {
            WebView.remove_HistoryChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_NavigationCompleted(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NavigationCompleted([In] EventRegistrationToken token)
        {
            WebView.remove_NavigationCompleted(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameNavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_FrameNavigationStarting(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameNavigationStarting([In] EventRegistrationToken token)
        {
            WebView.remove_FrameNavigationStarting(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_FrameNavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_FrameNavigationCompleted(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_FrameNavigationCompleted([In] EventRegistrationToken token)
        {
            WebView.remove_FrameNavigationCompleted(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ScriptDialogOpening([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ScriptDialogOpeningEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_ScriptDialogOpening(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ScriptDialogOpening([In] EventRegistrationToken token)
        {
            WebView.remove_ScriptDialogOpening(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2PermissionRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_PermissionRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            WebView.remove_PermissionRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ProcessFailed([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessFailedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_ProcessFailed(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ProcessFailed([In] EventRegistrationToken token)
        {
            WebView.remove_ProcessFailed(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler handler)
        {
            WebView.AddScriptToExecuteOnDocumentCreated(javaScript, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveScriptToExecuteOnDocumentCreated([In, MarshalAs(UnmanagedType.LPWStr)] string id)
        {
            WebView.RemoveScriptToExecuteOnDocumentCreated(id);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            WebView.ExecuteScript(javaScript, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void CapturePreview([In] COREWEBVIEW2_CAPTURE_PREVIEW_IMAGE_FORMAT imageFormat, [In, MarshalAs(UnmanagedType.Interface)] IStream imageStream, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CapturePreviewCompletedHandler handler)
        {
            WebView.CapturePreview(imageFormat, imageStream, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Reload()
        {
            WebView.Reload();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson)
        {
            WebView.PostWebMessageAsJson(webMessageAsJson);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString)
        {
            WebView.PostWebMessageAsString(webMessageAsString);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebMessageReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            WebView.add_WebMessageReceived(handler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebMessageReceived([In] EventRegistrationToken token)
        {
            WebView.remove_WebMessageReceived(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void CallDevToolsProtocolMethod([In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            WebView.CallDevToolsProtocolMethod(methodName, parametersAsJson, handler);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public uint BrowserProcessId => WebView.GetBrowserProcessId();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int CanGoBack => WebView.GetCanGoBack();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int CanGoForward => WebView.GetCanGoForward();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void GoBack()
        {
            WebView.GoBack();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void GoForward()
        {
            WebView.GoForward();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2DevToolsProtocolEventReceiver GetDevToolsProtocolEventReceiver([In, MarshalAs(UnmanagedType.LPWStr)] string eventName)
        {
            return WebView.GetDevToolsProtocolEventReceiver(eventName);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Stop()
        {
            WebView.Stop();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_NewWindowRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewWindowRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_NewWindowRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_NewWindowRequested([In] EventRegistrationToken token)
        {
            WebView.remove_NewWindowRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_DocumentTitleChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2DocumentTitleChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_DocumentTitleChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_DocumentTitleChanged([In] EventRegistrationToken token)
        {
            WebView.remove_DocumentTitleChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string DocumentTitle => WebView.GetDocumentTitle();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddHostObjectToScript([In, MarshalAs(UnmanagedType.LPWStr)] string name,nint @object)
        {
            WebView.AddHostObjectToScript(name, @object);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveHostObjectFromScript([In, MarshalAs(UnmanagedType.LPWStr)] string name)
        {
            WebView.RemoveHostObjectFromScript(name);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void OpenDevToolsWindow()
        {
            WebView.OpenDevToolsWindow();
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_ContainsFullScreenElementChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContainsFullScreenElementChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_ContainsFullScreenElementChanged(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_ContainsFullScreenElementChanged([In] EventRegistrationToken token)
        {
            WebView.remove_ContainsFullScreenElementChanged(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int ContainsFullScreenElement => WebView.GetContainsFullScreenElement();
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WebResourceRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WebResourceRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_WebResourceRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WebResourceRequested([In] EventRegistrationToken token)
        {
            WebView.remove_WebResourceRequested(token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            WebView.AddWebResourceRequestedFilter(uri, ResourceContext);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void RemoveWebResourceRequestedFilter([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In] COREWEBVIEW2_WEB_RESOURCE_CONTEXT ResourceContext)
        {
            WebView.RemoveWebResourceRequestedFilter(uri, ResourceContext);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void add_WindowCloseRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2WindowCloseRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            WebView.add_WindowCloseRequested(eventHandler, out token);
        }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void remove_WindowCloseRequested([In] EventRegistrationToken token)
        {
            WebView.remove_WindowCloseRequested(token);
        }

       
        private bool _IsDesposed;
        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDesposed)
            {
                if (disposing)
                {
                    handle.Dispose();
                    _WebView = null;
                }

                _IsDesposed = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
