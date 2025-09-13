namespace GameOffsets.Objects.States.InGameState
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     All offsets over here are UiElements.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ImportantUiElementsOffsets
    {
        [FieldOffset(0x588)] public IntPtr ChatParentPtr;
        [FieldOffset(0x6A8)] public IntPtr PassiveSkillTreePanel;
        [FieldOffset(0x750)] public IntPtr MapParentPtr;
        [FieldOffset(0xA38)] public IntPtr ControllerModeMapParentPtr;
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapParentStruct
    {
        [FieldOffset(0x50)] public IntPtr LargeMapPtr; // 1st child ~ reading from cache location
        [FieldOffset(0x58)] public IntPtr MiniMapPtr; // 2nd child ~ reading from cache location
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapParentStructController
    {
        [FieldOffset(0x58)] public IntPtr LargeMapPtr; // 2st child ~ reading from cache location
        [FieldOffset(0x60)] public IntPtr MiniMapPtr; // 3nd child ~ reading from cache location
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct PassiveSkillTreeStruct
    {
        // TODO/Update: cache location isn't working, wait for EA to be over to see if cache location start
        // working again...updated to use NonCache location.
        // [FieldOffset(0x5B0)] public IntPtr SkillTreeNodeUiElements; // 3nd child ~ reading from cache location
        public static int ChildNumber = (3 - 1) * 0x08;
    }
}
