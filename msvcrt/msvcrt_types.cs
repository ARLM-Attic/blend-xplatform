using System;
using System.Runtime.InteropServices;

#region Type Conventions

[Flags, Serializable]
public enum unsigned : uint { }

[Flags, Serializable]
public enum size_t : uint { }

[Flags, Serializable]
public enum rsize_t : uint { }

[Flags, Serializable]
public enum intptr_t : int { }

[Flags, Serializable]
public enum uintptr_t : uint { }

[Flags, Serializable]
public enum ptrdiff_t : int { }

[Flags, Serializable]
public enum wchar_t : ushort { }

[Flags, Serializable]
public enum wint_t : ushort { }

[Flags, Serializable]
public enum wctype_t : ushort { }

[Flags, Serializable]
public enum errcode : int { }

[Flags, Serializable]
public enum errno_t : int { }

[Flags, Serializable]
public enum __time32_t : int { }

[Flags, Serializable]
public enum __time64_t : long { }

[Flags, Serializable]
public enum time_t : int { }

[Flags, Serializable]
public enum _locale_t : uint { }

[Flags, Serializable]
public enum _ctype_t : uint { }

#endregion // Type Conventions

#region Delegates

[Serializable]
public delegate void _CrtDoForAllClientObjects_pfn(IntPtr ptr1, IntPtr ptr2);

[Serializable]
public delegate void _se_translator_function(uint code, IntPtr exceptionPointers);

[Serializable]
public delegate void terminate_function();

[Serializable]
public delegate void unexpected_function();

#endregion // Delegates

#region Structures

[Serializable]
[StructLayout(LayoutKind.Sequential)]
public class _diskfree_t
{
    public uint total_clusters;
    public uint avail_clusters;
    public uint sectors_per_cluster;
    public uint bytes_per_sector;
}

#endregion // Structures