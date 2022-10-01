// ReSharper disable InconsistentNaming

using System.Runtime.InteropServices;

namespace evmc
{
    [StructLayout(LayoutKind.Sequential)]
    public struct evmc_vm
    {
        public int abi_version;
        public string name;
        public string version;
        public IntPtr destroy;
        public IntPtr execute;
        public IntPtr get_capabilities;
        public IntPtr set_option;
    }
}