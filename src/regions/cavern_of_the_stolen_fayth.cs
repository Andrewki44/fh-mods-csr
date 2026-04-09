// SPDX-License-Identifier: MIT

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    private static class CavernOfTheStolenFayth {
        public static void remove_stolen_fayth(byte* code_ptr) {
            //remove(code_ptr, 0x6355, 0x68D2);
            //Globals.save_data->progression_flags_calm_lands_quest.set_bit(0, true);
        }

        public static void cavern_backstory(byte* code_ptr) {
            // nagi0500 (Cavern of the Stolen Fayth)

            // w25cross --> w19e06
            remove(code_ptr, 0x6355, 0x6813);
            // Set CalmLandsQuestProgressionFlags[0] = CalmLandsQuestProgressionFlags[0] | 1 [01h];
            remove(code_ptr, 0x6821, 0x68D2);
        }
    }
}
