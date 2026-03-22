// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class OmegaRuins {
        public static void remove_intro(byte* code_ptr) {
            // ffx_ps2\ffx\master\new_uspc\event\obj_ps3\om\omeg0000\omeg0000.bin
            // omeg0000 (Omega Ruins)
            remove(code_ptr, 0x66D5, 0x68DC); // w1Ee02 - Still sets the OmegaRuinsProgressionFlags as normal after removal
        }
    }
}
