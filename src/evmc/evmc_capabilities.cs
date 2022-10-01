// ReSharper disable InconsistentNaming

namespace evmc;

public enum evmc_capabilities : uint
{
    /// <summary>
    /// The VM is capable of executing EVM1 bytecode.
    /// </summary>
    EVMC_CAPABILITY_EVM1 = (1u << 0),

    /// <summary>
    /// The VM is capable of executing ewasm bytecode.
    /// </summary>
    EVMC_CAPABILITY_EWASM = (1u << 1),

    /// <summary>
    ///      * The VM is capable of executing the precompiled contracts
    /// defined for the range of code addresses.
    ///
    /// The EIP-1352 (https://eips.ethereum.org/EIPS/eip-1352) specifies
    /// the range 0x000...0000 - 0x000...ffff of addresses
    /// reserved for precompiled and system contracts.
    ///
    /// This capability is **experimental** and MAY be removed without notice.
    /// </summary>
    EVMC_CAPABILITY_PRECOMPILES = (1u << 2)
}