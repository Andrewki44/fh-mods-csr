// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class BaajTemple {
        public static void second_visit_dive(byte* code_ptr) {
            // bjyt0200 (Ruins - Underwater Hall)

            remove(code_ptr, 0x9D17, 0x9D1D); // W1Fcross - skip fadeout
            remove(code_ptr, 0x9D23, 0x9D26);
            remove(code_ptr, 0x9D38, 0x9D41);

            // w1Be08
            remove(code_ptr, 0x92A1, 0x92A7); // call Common.wait [0000h](frames=5 [05h]);

            //// w00e1C- Common.warpToPoint and sets swimming movement etc
            remove(code_ptr, 0x0303, 0x035A);

            //// w10e18 - Common.playSfxWithParams 
            remove(code_ptr, 0x92BD, 0x92F7); // await w00e1C

            remove(code_ptr, 0x92FE, 0x95AD); // "Payback time" 
            // Set saveData0381[0] = saveData0381[0] | 1 [01h];

            // Next functions setup swimming party
            remove(code_ptr, 0x9683, 0x9689); // Don't need to fade in cause we never faded out
        }
    }
}
