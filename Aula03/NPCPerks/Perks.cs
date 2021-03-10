using System;

namespace NPCPerks
{
    [Flags]
    public enum Perks
    {
        Nothing    = 0,
        Stealth    = 0b0001, // 1 // 1 << 0
        Combat     = 0b0010, // 2 // 1 << 1
        Lockpick   = 0b0100, // 4 // 1 << 2
        Luck       = 0b1000  // 8 // 1 << 3
    }
}
