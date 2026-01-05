using Diga.WebView2.Interop;


namespace Diga.WebView2.Wrapper
{
    public class WebView2ControlCreateParams
    {
        //public IntPtr ParentHandle { get; }
        public string BrowserExecutableFolder { get; set; } = string.Empty;
        public string UserDataFolder { get; set; } = string.Empty;
        public string AdditionalBrowserArguments { get; set; } = string.Empty;
        public string Language { get; set; } = null;
        //protected string TargetCompatibleBrowserVersion { get; set; } = "119.0.2151.40";
        public bool AllowSingleSignOnUsingOSPrimaryAccount { get; set; } = true;
        public bool ExclusiveUserDataFolderAccess { get; set; } = false;
        public bool IsCustomCrashReportingEnabled { get; set; } = false;
        public bool EnableTrackingPrevention { get; set; } = false;

        public bool AreBrowserExtensionsEnabled { get; set; } = false;

        public COREWEBVIEW2_CHANNEL_SEARCH_KIND ChannelSearchKind { get; set; }= COREWEBVIEW2_CHANNEL_SEARCH_KIND.COREWEBVIEW2_CHANNEL_SEARCH_KIND_MOST_STABLE;

        public COREWEBVIEW2_RELEASE_CHANNELS ReleaseChannels { get; set; }= COREWEBVIEW2_RELEASE_CHANNELS.COREWEBVIEW2_RELEASE_CHANNELS_NONE;

        public COREWEBVIEW2_SCROLLBAR_STYLE ScrollBarStyle { get; set; } = COREWEBVIEW2_SCROLLBAR_STYLE.COREWEBVIEW2_SCROLLBAR_STYLE_DEFAULT;
        public List<SchemeRegistration> SchemeRegistrations { get; set; } = new List<SchemeRegistration>();
        
    }
}
