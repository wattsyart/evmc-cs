using System.Runtime.InteropServices;
using evmc;

namespace example
{
    public static class Example
    {
        // [DllExport(CallingConvention.Cdecl)]
        public static evmc_vm evmc_create_example_vm()
        {
            var evm = new evmc_vm();
            evm.abi_version = 10;
            evm.name = "example";
            evm.version = "0.0.1";
            return evm;
        }
    }
}
