// Build: 85d92444ee4d6ad81e3ea0ba126a739b
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
