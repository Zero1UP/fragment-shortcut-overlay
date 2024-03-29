﻿using System;
using System.Runtime.InteropServices;

namespace fragment_shortcut_overlay.Helpers;

public static class NativeMethods
{
    [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsWow64Process([In] Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid hProcess,
        [Out, MarshalAs(UnmanagedType.Bool)] out bool wow64Process);
}