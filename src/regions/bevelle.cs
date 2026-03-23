// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class Bevelle {
        public static void remove_intro(byte* code_ptr) {
            // ffx_ps2\ffx\master\new_uspc\event\obj_ps3\bv\bvyt0000\bvyt0000.bin
            // bvyt0000 (Bevelle - Tower of Light)
            remove(code_ptr, 0x64ED, 0x665E);   // Set GameMoment = 2010 [07DAh];
            remove(code_ptr, 0x6664, 0x673C);   // Set GameMoment = 2060 [080Ch];
            remove(code_ptr, 0x6742, 0x694C);   // Set GameMoment = 2070 [0816h];
            remove(code_ptr, 0x6959, 0x6A45);   // Set GameMoment = 2075 [081Bh];
            remove(code_ptr, 0x6A4B, 0x6D24);   // Set GameMoment = 2080 [0820h];
        }
    }
}
