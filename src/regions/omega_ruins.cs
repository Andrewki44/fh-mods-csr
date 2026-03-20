// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR; 

internal unsafe static partial class Removers {
    private static class OmegaRuins {
        public static void remove_intro(byte* code_ptr)
        {
            remove(code_ptr, 0x66D5, 0x68DB); // w1Ee02 - Still sets the OmegaRuinsProgressionFlags as normal after removal
        }
    }
}
