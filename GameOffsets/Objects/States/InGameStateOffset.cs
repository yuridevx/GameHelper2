namespace GameOffsets.Objects.States
{
    using System;
    using System.Runtime.InteropServices;

    // Ghidra function ref: search for "Abnormal disconnect: "
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct InGameStateOffset
    {
        [FieldOffset(0x290)] public IntPtr AreaInstanceData; // contains area level
        [FieldOffset(0x2F8)] public IntPtr WorldData; // contains area name
        [FieldOffset(0x648)] public IntPtr UiRootPtr; // contains self pointer
        [FieldOffset(0xC40)] public IntPtr IngameUi; // contains self pointer
    }
}
