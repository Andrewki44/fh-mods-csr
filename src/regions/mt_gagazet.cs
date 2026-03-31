// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class MtGagazet {
        public static void spectral_keeper(byte* code_ptr) {
            // mtgz0800 (Gagazet - Summit Region)
            remove(code_ptr, 0x357E, 0x3590); // "It comes!"
            
            // Camera for "It comes!"
            remove(code_ptr, 0x35AC, 0x35B7);
            remove(code_ptr, 0x3616, 0x3623);

            remove(code_ptr, 0x36BA, 0x36CF); // Death Camera

            remove(code_ptr, 0x3749, 0x38B0); // Post-kill Cutscene

            // Battle Rewards Menu
            // GameMoment = 2625
            // run w0Be03

            remove(code_ptr, 0x38E0, 0x3B7C); // Post Rewards Cutscene
            // GameMoment = 2635
            remove(code_ptr, 0x3B82, 0x3B8B);
        }
    }
}
