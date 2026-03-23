// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class BaajTemple {
        public static void second_visit_dive(byte* code_ptr) {
            // bjyt0200 (Ruins - Underwater Hall)

            remove(code_ptr, 0x9D17, 0x9D26); // W1Fcross - skip fadeout
            remove(code_ptr, 0x9D38, 0x9D57);

            // w1Be08
            remove(code_ptr, 0x92A1, 0x92B2); // w0Ce45

            //// w00e1C- Common.warpToPoint and sets swimming movement etc
            remove(code_ptr, 0x0303, 0x035A);

            //// w10e18 - Common.playSfxWithParams 
            remove(code_ptr, 0x92BD, 0x92F7); // await w00e1C

            remove(code_ptr, 0x92FE, 0x95AD); // "Payback time" 
            // Set saveData0381[0] = saveData0381[0] | 1 [01h];
            
            remove(code_ptr, 0x95BB, 0x9608); // Camera stuff

            // Next functions setup swimming party
            remove(code_ptr, 0x9683, 0x9689); // Don't need to fade in cause we never faded out
        }
    }
}
