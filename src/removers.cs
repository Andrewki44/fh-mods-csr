using Fahrenheit.Core.FFX;
using Fahrenheit.Core.Atel;
using System.Runtime.InteropServices;

namespace Fahrenheit.Mods.CSR;

internal unsafe static partial class Removers {
    public static void init() {
        CutsceneRemoverModule.removers.Add("znkd0600", DreamZanarkand.remove_intro);
        CutsceneRemoverModule.removers.Add("znkd1000", DreamZanarkand.remove_prelude);
        CutsceneRemoverModule.removers.Add("znkd1400", DreamZanarkand.remove_overpass);
        CutsceneRemoverModule.removers.Add("znkd1300", DreamZanarkand.remove_stadium);
        CutsceneRemoverModule.removers.Add("znkd1200", DreamZanarkand.remove_stadium_attacked);

        CutsceneRemoverModule.removers.Add("cdsp0700", AlBhedShip.remove_underwater_ruins);

        CutsceneRemoverModule.removers.Add("bsil0300", Besaid.remove_valley);
        CutsceneRemoverModule.removers.Add("bsil0600", Besaid.remove_promontory);
        CutsceneRemoverModule.removers.Add("bsil0700", Besaid.remove_village_slope);
    }

    private static void remove(byte* code_ptr, int from, int to) {
        NativeMemory.Fill(code_ptr, (nuint)(to - from), 0);
    }

    private static void set(byte* code_ptr, int offset, byte value) {
        *(code_ptr + offset) = value;
    }

    private static byte* set(byte* code_ptr, int offset, params AtelInst[] opcodes) {
        byte* ptr = code_ptr + offset;

        foreach (AtelInst opcode in opcodes) {
            foreach (byte b in opcode.to_bytes()) {
                *ptr = b;
                ptr++;
            }
        }

        return ptr;
    }

    private static void set_tp(byte* code_ptr, int offset, ushort x_idx, ushort y_idx, ushort z_idx) {
        byte* ptr = code_ptr + offset;
        set(ptr, 0x0, AtelOp.PUSHF.build(x_idx));
        set(ptr, 0x3, AtelOp.PUSHF.build(y_idx));
        set(ptr, 0x6, AtelOp.PUSHF.build(z_idx));
        set(ptr, 0x9, AtelOp.CALLPOPA.build(0x126));
    }
}
