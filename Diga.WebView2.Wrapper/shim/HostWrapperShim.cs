using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.shim
{
    public class HostWrapperShim: IDisposable
    {
        // Implementation of HostWrapperShim
        private ComObjectHolder<IHostWrapper> _Iface;
        private bool disposedValue;
        private SafeHandle handle = new SafeFileHandle(nint.Zero, true);
        private IHostWrapper Iface
        {
            get
            {
                if (_Iface == null)
                {
                    Debug.Print(nameof(HostWrapperShim) + " Iface is null");
                    throw new InvalidOperationException(nameof(HostWrapperShim) + " Iface is null");
                }
                return _Iface.Interface;
            }
            set => _Iface = new ComObjectHolder<IHostWrapper>(value);
        }

        public HostWrapperShim(IHostWrapper iface)
        {
            Iface = iface;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    handle?.Dispose();
                    _Iface = null;
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public int add_HostInvokeTarget(IHostInvokeTarget target, out EventRegistrationToken token)
        {
            return Iface.add_HostInvokeTarget(target, out token);
        }

        public int remove_HostInvokeTarget(EventRegistrationToken token)
        {
            return Iface.remove_HostInvokeTarget(token);
        }

        public IHostWrapper ToInterface() => _Iface.Interface;
    }
}
