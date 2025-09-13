namespace GameOffsets.Objects.Components
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct TargetableOffsets
    {
        // found this function by checking whats accessing 0x52.
        // 0: First check is on Entity -> IsValid offset (i.e greater than zero).
        // TODO: Make a pattern so we know before league start.
        [FieldOffset(0x00)] public ComponentHeader Header;
        [FieldOffset(0x49)] public bool IsTargetable; // 1 -> True
        [FieldOffset(0x4A)] public bool IsHighlightable; // Non-Highlightable things can be targetted.
        [FieldOffset(0x4B)] public bool IsTargettedByPlayer;
        [FieldOffset(0x4E)] public bool MeetsQuestState; // 4 -> true
        [FieldOffset(0x50)] public bool NeedsTrue; // 3 -> True
        [FieldOffset(0x51)] public bool HiddenfromPlayer; // 2 -> False
        [FieldOffset(0x52)] public bool NeedsFalse; // 5 -> False
    }
}
