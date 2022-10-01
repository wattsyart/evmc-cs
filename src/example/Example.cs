using evmc;
using System.Runtime.InteropServices;

namespace example
{
    public static class Example
    {
        // [MarshalAs(UnmanagedType.Struct)]
        // extern "C" evmc_vm* evmc_create_example_vm()

        [DllExport("evmc_create_example_vm", CallingConvention.Cdecl)]
        public static IntPtr evmc_create_example_vm()
        {
            evmc_vm instance = new evmc_vm
            {
                abi_version = 10,
                name = "example",
                version = "0.0.1"
            };

            IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(instance));

            try
            {
                Marshal.StructureToPtr(instance, ptr, false);
                return ptr;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}
