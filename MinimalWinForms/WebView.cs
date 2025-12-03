using Diga.WebView2.Wrapper;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinimalWinForms
{
    public partial class WebView : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Uri? Url { get; set; } = new Uri("https://www.itagnesmeyer.de");

        private WebView2Control? _WebViewControl;

        private bool _WasCreated = false;

        public WebView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            CreateWebViewControl(this.Handle);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (this._WebViewControl != null && this._WasCreated)
            {
                this._WebViewControl.DockToParent();
            }
        }
        private void CreateWebViewControl(nint parentHandle)
        {
            try
            {
                this._WebViewControl = new WebView2Control(parentHandle);
                WireEvents();
            }
            catch (Exception ex)
            {

                Debug.Print(ex.ToString());
            }

        }
        private void WireEvents()
        {
            if (this._WebViewControl != null)
            {
                this._WebViewControl.Created += OnCreated;
                this._WebViewControl.BeforeCreate += OnBeforeCreate;
            }
        }

        private void OnBeforeCreate(object? sender, BeforeCreateEventArgs e)
        {
            //Do something with e.Settings
            e.Settings.IsScriptEnabled = true;
            e.Settings.IsWebMessageEnabled = true;
            e.Settings.AreDefaultScriptDialogsEnabled = true;
            e.Settings.AreDevToolsEnabled = true;
        }

        private void OnCreated(object? sender, EventArgs e)
        {
            if (this._WebViewControl != null)
            {

                if (this.Url != null)
                {
                    this._WebViewControl.Navigate(this.Url.ToString());
                }
            }
            this._WasCreated = true;
        }
    }
}
