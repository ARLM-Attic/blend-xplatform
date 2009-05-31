﻿using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.gdi32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumObjectsProc(
        [In] IntPtr lpLogObject,
        [In] IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumFontFamProc(
        [In] IntPtr lpelf,
        [In] IntPtr lpntm,
        [In] uint FontType,
        [In] IntPtr lParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumFontFamExProc(
        [In] IntPtr lpelfe,
        [In] IntPtr lpntme,
        [In] uint FontType,
        [In] IntPtr lParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumFontsProc(
        [Const, In] IntPtr lplf,
        [Const, In] IntPtr lptm,
        [In] uint dwType,
        [In] IntPtr lpData);
}

namespace xPlatform.x86.gdi32
{
    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMR
    {
        public uint iType;
        public uint nSize;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct CIEXYZ
    {
        public int ciexyzX;
        public int ciexyzY;
        public int ciexyzZ;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct CIEXYZTRIPLE
    {
        public CIEXYZ ciexyzRed;
        public CIEXYZ ciexyzGreen;
        public CIEXYZ ciexyzBlue;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPV4HEADER
    {
        public uint bV4Size;
        public int bV4Width;
        public int bV4Height;
        public ushort bV4Planes;
        public ushort bV4BitCount;
        public uint bV4V4Compression;
        public uint bV4SizeImage;
        public int bV4XPelsPerMeter;
        public int bV4YPelsPerMeter;
        public uint bV4ClrUsed;
        public uint bV4ClrImportant;
        public uint bV4RedMask;
        public uint bV4GreenMask;
        public uint bV4BlueMask;
        public uint bv4AlphaMask;
        public uint bV4CSType;
        public CIEXYZTRIPLE bV4Endpoints;
        public uint bV4GammaRed;
        public uint bV4GammaGreen;
        public uint bV4GammaBlue;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPV5HEADER
    {
        public uint bV5Size;
        public int bV5Width;
        public int bV5Height;
        public ushort bV5Planes;
        public ushort bV5BitCount;
        public uint bV5Compression;
        public uint bV5SizeImage;
        public int bV5XPelsPerMeter;
        public int bV5YPelsPerMeter;
        public uint bV5ClrUsed;
        public uint bV5ClrImportant;
        public uint bV5RedMask;
        public uint bV5GreenMask;
        public uint bV5BlueMask;
        public uint bV5AlphaMask;
        public uint bV5CSType;
        public CIEXYZTRIPLE bV5Endpoints;
        public uint bV5GammaRed;
        public uint bV5GammaGreen;
        public uint bV5GammaBlue;
        public uint bV5Intent;
        public uint bV5ProfileData;
        public uint bV5ProfileSize;
        public uint bV5Reserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RGBQUAD
    {
        public byte rgbBlue;
        public byte rgbGreen;
        public byte rgbRed;
        public byte rgbReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPINFO
    {
        public BITMAPINFOHEADER bmiHeader;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public RGBQUAD[] bmiColors;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RECTL
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct XFORM
    {
        public float eM11;
        public float eM12;
        public float eM21;
        public float eM22;
        public float eDx;
        public float eDy;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRALPHABLEND
    {
        public EMR emr;
        public RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int cxDest;
        public int cyDest;
        public uint dwRop;
        public int xSrc;
        public int ySrc;
        public XFORM xFormSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public int cxSrc;
        public int cySrc;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAP
    {
        public int bmType;
        public int bmWidth;
        public int bmHeight;
        public int bmWidthBytes;
        public ushort bmPlanes;
        public ushort bmBitsPixel;
        public IntPtr bmBits;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct SIZE
    {
        public int cx;
        public int cy;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct POINTL
    {
        public int x;
        public int y;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TRIVERTEX
    {
        public int x;
        public int y;
        public ushort Red;
        public ushort Green;
        public ushort Blue;
        public ushort Alpha;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GRADIENT_TRIANGLE
    {
        public uint Vertex1;
        public uint Vertex2;
        public uint Vertex3;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GRADIENT_RECT
    {
        public uint UpperLeft;
        public uint LowerRight;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct POINT
    {
        public int x;
        public int y;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPCOREHEADER
    {
        public uint bcSize;
        public ushort bcWidth;
        public ushort bcHeight;
        public ushort bcPlanes;
        public ushort bcBitCount;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RGBTRIPLE
    {
        public byte rgbtBlue;
        public byte rgbtGreen;
        public byte rgbtRed;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPCOREINFO
    {
        public BITMAPCOREHEADER bmciHeader;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public RGBTRIPLE[] bmciColors;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct BITMAPFILEHEADER
    {
        public ushort bfType;
        public uint bfSize;
        public ushort bfReserved1;
        public ushort bfReserved2;
        public uint bfOffBits;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct COLORADJUSTMENT
    {
        public ushort caSize;
        public ushort caFlags;
        public ushort caIlluminantIndex;
        public ushort caRedGamma;
        public ushort caGreenGamma;
        public ushort caBlueGamma;
        public ushort caReferenceBlack;
        public ushort caReferenceWhite;
        public short caContrast;
        public short caBrightness;
        public short caColorfulness;
        public short caRedGreenTint;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DIBSECTION
    {
        public BITMAP dsBm;
        public BITMAPINFOHEADER dsBmih;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public uint[] dsBitfields;

        public IntPtr dshSection;
        public uint dsOffset;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LOGBRUSH
    {
        public uint lbStyle;
        public uint lbColor;
        public int lbHatch;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LOGBRUSH32
    {
        public uint lbStyle;
        public uint lbColor;
        public uint lbHatch;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PALETTEENTRY
    {
        public byte peRed;
        public byte peGreen;
        public byte peBlue;
        public byte peFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LOGPALETTE
    {
        public ushort palVersion;
        public ushort palNumEntries;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public PALETTEENTRY[] palPalEntry;
    }

    [Serializable, StructLayout(LayoutKind.Explicit), CLSCompliant(false)]
    public struct DEVMODE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        [FieldOffset(4)]
        public ushort dmSpecVersion;

        [FieldOffset(6)]
        public ushort dmDriverVersion;

        [FieldOffset(8)]
        public ushort dmSize;

        [FieldOffset(10)]
        public ushort dmDriverExtra;

        [FieldOffset(12)]
        public uint dmFields;

        [FieldOffset(16)]
        public short dmOrientation;

        [FieldOffset(18)]
        public short dmPaperSize;

        [FieldOffset(20)]
        public short dmPaperLength;

        [FieldOffset(22)]
        public short dmPaperWidth;

        [FieldOffset(24)]
        public short dmScale;

        [FieldOffset(26)]
        public short dmCopies;

        [FieldOffset(28)]
        public short dmDefaultSource;

        [FieldOffset(30)]
        public short dmPrintQuality;

        [FieldOffset(16)]
        public POINTL dmPosition;

        [FieldOffset(16)]
        public uint dmDisplayOrientation;

        [FieldOffset(16)]
        public uint dmDisplayFixedOutput;

        [FieldOffset(32)]
        public short dmColor;

        [FieldOffset(34)]
        public short dmDuplex;

        [FieldOffset(36)]
        public short dmYResolution;

        [FieldOffset(38)]
        public short dmTTOption;

        [FieldOffset(40)]
        public short dmCollate;

        [FieldOffset(42)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        [FieldOffset(46)]
        public short dmLogPixels;

        [FieldOffset(48)]
        public uint dmBitsPerPel;

        [FieldOffset(52)]
        public uint dmPelsWidth;

        [FieldOffset(56)]
        public uint dmPelsHeight;

        [FieldOffset(60)]
        public uint dmDisplayFlags;

        [FieldOffset(60)]
        public uint dmNup;

        [FieldOffset(64)]
        public uint dmDisplayFrequency;

        [FieldOffset(68)]
        public uint dmICMMethod;

        [FieldOffset(72)]
        public uint dmICMIntent;

        [FieldOffset(76)]
        public uint dmMediaType;

        [FieldOffset(80)]
        public uint dmDitherType;

        [FieldOffset(84)]
        public uint dmReserved1;

        [FieldOffset(88)]
        public uint dmReserved2;

        [FieldOffset(92)]
        public uint dmPanningWidth;

        [FieldOffset(96)]
        public uint dmPanningHeight;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DISPLAY_DEVICE
    {
        public uint cb;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;

        public uint StateFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct VIDEOPARAMETERS
    {
        public Guid guid;
        public uint dwOffset;
        public uint dwCommand;
        public uint dwFlags;
        public uint dwMode;
        public uint dwTVStandard;
        public uint dwAvailableModes;
        public uint dwAvailableTVStandard;
        public uint dwFlickerFilter;
        public uint dwOverScanX;
        public uint dwOverScanY;
        public uint dwMaxUnscaledX;
        public uint dwMaxUnscaledY;
        public uint dwPositionX;
        public uint dwPositionY;
        public uint dwBrightness;
        public uint dwContrast;
        public uint dwCPType;
        public uint dwCPCommand;
        public uint dwCPStandard;
        public uint dwCPKey;
        public uint bCP_APSTriggerBits;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] bOEMCopyProtection;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct LOGFONT
    {
        public int lfHeight;
        public int lfWidth;
        public int lfEscapement;
        public int lfOrientation;
        public int lfWeight;
        public byte lfItalic;
        public byte lfUnderline;
        public byte lfStrikeOut;
        public byte lfCharSet;
        public byte lfOutPrecision;
        public byte lfClipPrecision;
        public byte lfQuality;
        public byte lfPitchAndFamily;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lfFaceName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct ENUMLOGFONTEX
    {
        public LOGFONT elfLogFont;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfScript;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DESIGNVECTOR
    {
        public uint dvReserved;
        public uint dvNumAxes;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public int[] dvValues;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENUMLOGFONTEXDV
    {
        public ENUMLOGFONTEX elfEnumLogfontEx;
        public DESIGNVECTOR elfDesignVector;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DRAWTEXTPARAMS
    {
        public uint cbSize;
        public int iTabLength;
        public int iLeftMargin;
        public int iRightMargin;
        public uint uiLengthDrawn;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct FONTSIGNATURE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public uint[] fsUsb;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public uint[] fsCsb;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct TEXTMETRICA
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public byte tmFirstChar;
        public byte tmLastChar;
        public byte tmDefaultChar;
        public byte tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct TEXTMETRICW
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public char tmFirstChar;
        public char tmLastChar;
        public char tmDefaultChar;
        public char tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NEWTEXTMETRICA
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public byte tmFirstChar;
        public byte tmLastChar;
        public byte tmDefaultChar;
        public byte tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
        public uint ntmFlags;
        public uint ntmSizeEM;
        public uint ntmCellHeight;
        public uint ntmAvgWidth;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NEWTEXTMETRICW
    {
        public int tmHeight;
        public int tmAscent;
        public int tmDescent;
        public int tmInternalLeading;
        public int tmExternalLeading;
        public int tmAveCharWidth;
        public int tmMaxCharWidth;
        public int tmWeight;
        public int tmOverhang;
        public int tmDigitizedAspectX;
        public int tmDigitizedAspectY;
        public char tmFirstChar;
        public char tmLastChar;
        public char tmDefaultChar;
        public char tmBreakChar;
        public byte tmItalic;
        public byte tmUnderlined;
        public byte tmStruckOut;
        public byte tmPitchAndFamily;
        public byte tmCharSet;
        public uint ntmFlags;
        public uint ntmSizeEM;
        public uint ntmCellHeight;
        public uint ntmAvgWidth;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NEWTEXTMETRICEXA
    {
        public NEWTEXTMETRICA ntmTm;
        public FONTSIGNATURE ntmFontSig;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct NEWTEXTMETRICEXW
    {
        public NEWTEXTMETRICW ntmTm;
        public FONTSIGNATURE ntmFontSig;
    }
}
