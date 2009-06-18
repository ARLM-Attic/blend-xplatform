using System;
using xPlatform.Flags;
using System.Runtime.InteropServices;

namespace xPlatform.x86.gdi32
{
    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumObjectsProc(
        [In] IntPtr lpLogObject,
        [In] IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int EnumFontFamProc(
        [In] IntPtr lpelf,
        [In] IntPtr lpntm,
        [In] uint FontType,
        [In] IntPtr lParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int EnumFontFamExProc(
        [In] IntPtr lpelfe,
        [In] IntPtr lpntme,
        [In] uint FontType,
        [In] IntPtr lParam);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi), CLSCompliant(false)]
    public delegate int EnumFontsProc(
        [Const, In] IntPtr lplf,
        [Const, In] IntPtr lptm,
        [In] uint dwType,
        [In] IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate void LineDDAProc(
        [In] int X,
        [In] int Y,
        [In] IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnhMetaFileProc(
        [In] IntPtr hDC,
        [In] IntPtr lpHTable,
        [In, Const] IntPtr lpEMFR,
        [In] int nObj,
        [In] IntPtr lpData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumMetaFileProc(
        [In] IntPtr hDC,
        [In] IntPtr lpHTable,
        [In] IntPtr lpMFR,
        [In] int nObj,
        [In] IntPtr lpClientData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int MonitorEnumProc(
        [In] IntPtr hMonitor,
        [In] IntPtr hdcMonitor,
        [In] IntPtr lprcMonitor,
        [In] IntPtr dwData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int DrawStateProc(
        [In] IntPtr hdc,
        [In] IntPtr lData,
        [In] IntPtr wData,
        [In] int cx,
        [In] int cy);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int OutputProc(
        [In] IntPtr hdc,
        [In] IntPtr lpData,
        [In] int cchData);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int AbortProc(
        [In] IntPtr hdc,
        [In] int iError);

    [Serializable, UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public delegate int EnumICMProfilesProcCallback(
        [In] IntPtr lpszFilename,
        [In] IntPtr lParam);
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
    public struct SIZEL
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

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct DEVMODE
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        public ushort dmSpecVersion;
        public ushort dmDriverVersion;
        public ushort dmSize;
        public ushort dmDriverExtra;
        public uint dmFields;
        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;
        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        public uint dmPosition;
        public uint dmDisplayOrientation;
        public uint dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        
        public short dmLogPixels;
        public uint dmBitsPerPel;
        public uint dmPelsWidth;
        public uint dmPelsHeight;
        public uint dmDisplayFlags;
        public uint dmNup;
        public uint dmDisplayFrequency;
        public uint dmICMMethod;
        public uint dmICMIntent;
        public uint dmMediaType;
        public uint dmDitherType;
        public uint dmReserved1;
        public uint dmReserved2;
        public uint dmPanningWidth;
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

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
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

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ABC
    {
        public int abcA;
        public uint abcB;
        public int abcC;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct ABCFLOAT
    {
        public float abcfA;
        public float abcfB;
        public float abcfC;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GCP_RESULTS
    {
        public uint lStructSize;

        [MarshalAs(UnmanagedType.LPTStr)]
        public string lpOutString;

        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U4)]
        public uint[] lpOrder;

        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
        public int[] lpDx;

        [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)]
        public int[] lpCaretPos;

        [MarshalAs(UnmanagedType.LPStr)]
        public string lpClass;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpGlyphs;

        public uint nGlyphs;
        public int nMaxFit;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct WCRANGE
    {
        public ushort wcLow;
        public ushort cGlyphs;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GLYPHSET
    {
        public uint cbThis;
        public uint flAccel;
        public uint cGlyphsSupported;
        public uint cRanges;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public WCRANGE[] ranges;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct GLYPHMETRICS
    {
        public uint gmBlackBoxX;
        public uint gmBlackBoxY;
        public POINT gmptGlyphOrigin;
        public short gmCellIncX;
        public short gmCellIncY;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct FIXED
    {
        public ushort fract;
        public short value;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MAT2
    {
        public FIXED eM11;
        public FIXED eM12;
        public FIXED eM21;
        public FIXED eM22;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PANOSE
    {
        public byte bFamilyType;
        public byte bSerifStyle;
        public byte bWeight;
        public byte bProportion;
        public byte bContrast;
        public byte bStrokeVariation;
        public byte bArmStyle;
        public byte bLetterform;
        public byte bMidline;
        public byte bXHeight;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OUTLINETEXTMETRICA
    {
        public uint otmSize;
        public TEXTMETRICA otmTextMetrics;
        public byte otmFiller;
        public PANOSE otmPanoseNumber;
        public uint otmfsSelection;
        public uint otmfsType;
        public int otmsCharSlopeRise;
        public int otmsCharSlopeRun;
        public int otmItalicAngle;
        public uint otmEMSquare;
        public int otmAscent;
        public int otmDescent;
        public uint otmLineGap;
        public uint otmsCapEmHeight;
        public uint otmsXHeight;
        public RECT otmrcFontBox;
        public int otmMacAscent;
        public int otmMacDescent;
        public uint otmMacLineGap;
        public uint otmusMinimumPPEM;
        public POINT otmptSubscriptSize;
        public POINT otmptSubscriptOffset;
        public POINT otmptSuperscriptSize;
        public POINT otmptSuperscriptOffset;
        public uint otmsStrikeoutSize;
        public int otmsStrikeoutPosition;
        public int otmUnderscoreSize;
        public int otmUnderscorePosition;
        public IntPtr otmpFamilyName;
        public IntPtr otmpFaceName;
        public IntPtr otmpStyleName;
        public IntPtr otmpFullName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct OUTLINETEXTMETRICW
    {
        public uint otmSize;
        public TEXTMETRICW otmTextMetrics;
        public byte otmFiller;
        public PANOSE otmPanoseNumber;
        public uint otmfsSelection;
        public uint otmfsType;
        public int otmsCharSlopeRise;
        public int otmsCharSlopeRun;
        public int otmItalicAngle;
        public uint otmEMSquare;
        public int otmAscent;
        public int otmDescent;
        public uint otmLineGap;
        public uint otmsCapEmHeight;
        public uint otmsXHeight;
        public RECT otmrcFontBox;
        public int otmMacAscent;
        public int otmMacDescent;
        public uint otmMacLineGap;
        public uint otmusMinimumPPEM;
        public POINT otmptSubscriptSize;
        public POINT otmptSubscriptOffset;
        public POINT otmptSuperscriptSize;
        public POINT otmptSuperscriptOffset;
        public uint otmsStrikeoutSize;
        public int otmsStrikeoutPosition;
        public int otmUnderscoreSize;
        public int otmUnderscorePosition;
        public IntPtr otmpFamilyName;
        public IntPtr otmpFaceName;
        public IntPtr otmpStyleName;
        public IntPtr otmpFullName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct KERNINGPAIR
    {
        public ushort wFirst;
        public ushort wSecond;
        public int iKernAmount;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct RASTERIZER_STATUS
    {
        public short nSize;
        public short wFlags;
        public short nLanguageID;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct POLYTEXT
    {
        public int x;
        public int y;
        public uint n;
        public IntPtr lpstr;
        public uint uiFlags;
        public RECT rcl;
        public IntPtr pdx;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct POINTFX
    {
        public FIXED x;
        public FIXED y;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct AXISINFO
    {
        public int axMinValue;
        public int axMaxValue;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string axAxisName;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct AXESLIST
    {
        public uint axlReserved;
        public uint axlNumAxes;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public AXISINFO[] axlAxisInfo;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct EXTLOGFONT
    {
        public LOGFONT elfLogFont;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        public uint elfVersion;
        public uint elfStyleSize;
        public uint elfMatch;
        public uint elfReserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] elfVendorId;

        public uint elfCulture;
        public PANOSE elfPanose;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct EXTLOGFONTW
    {
        public LOGFONT elfLogFont;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string elfFullName;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string elfStyle;

        public uint elfVersion;
        public uint elfStyleSize;
        public uint elfMatch;
        public uint elfReserved;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] elfVendorId;

        public uint elfCulture;
        public PANOSE elfPanose;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TTPOLYCURVE
    {
        public ushort wType;
        public ushort cpfx;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTFX[] apfx;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct TTPOLYGONHEADER
    {
        public uint cb;
        public uint dwType;
        public POINTFX pfxStart;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct HANDLETABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] objectHandle;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENHMETAHEADER
    {
        public uint iType;
        public uint nSize;
        public RECTL rclBounds;
        public RECTL rclFrame;
        public uint dSignature;
        public uint nVersion;
        public uint nBytes;
        public uint nRecords;
        public ushort nHandles;
        public ushort sReserved;
        public uint nDescription;
        public uint offDescription;
        public uint nPalEntries;
        public SIZEL szlDevice;
        public SIZEL szlMillimeters;
        public uint cbPixelFormat;
        public uint offPixelFormat;
        public uint bOpenGL;
        public SIZEL szlMicrometers;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct ENHMETARECORD
    {
        public uint iType;
        public uint nSize;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] dParm;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct METAFILEPICT
    {
        public int mm;
        public int xExt;
        public int yExt;
        public IntPtr hMF;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct METARECORD
    {
        public uint rdSize;
        public ushort rdFunction;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ushort[] rdParm;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRTEXT
    {
        public POINTL ptlReference;
        public uint nChars;
        public uint offString;
        public uint fOptions;
        public RECTL rcl;
        public uint offDx;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRTRANSPARENTBLT
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
        public XFORM xformSrc;
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
    public struct EMRABORTPATH
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRBEGINPATH
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRENDPATH
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCLOSEFIGURE
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRFLATTENPATH
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRWIDENPATH
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETMETARGN
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSAVEDC
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRREALIZEPALETTE
    {
        public EMR emr;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRARC
    {
        public EMR emr;
        public RECTL rclBox;
        public POINTL ptlStart;
        public POINTL ptlEnd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRARCTO
    {
        public EMR emr;
        public RECTL rclBox;
        public POINTL ptlStart;
        public POINTL ptlEnd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCHORD
    {
        public EMR emr;
        public RECTL rclBox;
        public POINTL ptlStart;
        public POINTL ptlEnd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPIE
    {
        public EMR emr;
        public RECTL rclBox;
        public POINTL ptlStart;
        public POINTL ptlEnd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRBITBLT
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
        public XFORM xformSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCOLORCORRECTPALETTE
    {
        public EMR emr;
        public uint ihPalette;
        public uint nFirstEntry;
        public uint nPalEntries;
        public uint nReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCOLORMATCHTOTARGET
    {
        public EMR emr;
        public uint dwAction;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCREATEBRUSHINDIRECT
    {
        public EMR emr;
        public uint ihBrush;
        public LOGBRUSH32 lb;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct LOGCOLORSPACE
    {
        public uint lcsSignature;
        public uint lcsVersion;
        public uint lcsSize;
        public uint lcsCSType;
        public uint lcsIntent;
        public CIEXYZTRIPLE lcsEndpoints;
        public uint lcsGammaRed;
        public uint lcsGammaGreen;
        public uint lcsGammaBlue;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string lcsFilename;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct LOGCOLORSPACEW
    {
        public uint lcsSignature;
        public uint lcsVersion;
        public uint lcsSize;
        public uint lcsCSType;
        public uint lcsIntent;
        public CIEXYZTRIPLE lcsEndpoints;
        public uint lcsGammaRed;
        public uint lcsGammaGreen;
        public uint lcsGammaBlue;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string lcsFilename;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct EMRCREATECOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
        public LOGCOLORSPACE lcs;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct EMRCREATECOLORSPACEW
    {
        public EMR emr;
        public uint ihCS;
        public LOGCOLORSPACE lcs;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCREATEDIBPATTERNBRUSHPT
    {
        public EMR emr;
        public uint ihBrush;
        public uint iUsage;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCREATEMONOBRUSH
    {
        public EMR emr;
        public uint ihBrush;
        public uint iUsage;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCREATEPALETTE
    {
        public EMR emr;
        public uint ihPal;
        public LOGPALETTE lgpl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct LOGPEN
    {
        public uint lopnStyle;
        public POINT lopnWidth;
        public uint lopnColor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRCREATEPEN
    {
        public EMR emr;
        public uint ihPen;
        public LOGPEN lopn;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETCOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSELECTCOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRDELETECOLORSPACE
    {
        public EMR emr;
        public uint ihCS;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSELECTOBJECT
    {
        public EMR emr;
        public uint ihObject;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRDELETEOBJECT
    {
        public EMR emr;
        public uint ihObject;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRELLIPSE
    {
        public EMR emr;
        public RECTL rclBox;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRRECTANGLE
    {
        public EMR emr;
        public RECTL rclBox;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMREOF
    {
        public EMR emr;
        public uint nPalEntries;
        public uint offPalEntries;
        public uint nSizeLast;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMREXCLUDECLIPRECT
    {
        public EMR emr;
        public RECTL rclClip;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRINTERSECTCLIPRECT
    {
        public EMR emr;
        public RECTL rclClip;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct EMREXTCREATEFONTINDIRECT
    {
        public EMR emr;
        public uint ihFont;
        public EXTLOGFONT elfw;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct EMREXTCREATEFONTINDIRECTW
    {
        public EMR emr;
        public uint ihFont;
        public EXTLOGFONTW elfw;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EXTLOGPEN
    {
        public uint elpPenStyle;
        public uint elpWidth;
        public uint elpBrushStyle;
        public uint elpColor;
        public uint elpHatch;
        public uint elpNumEntries;
        public uint elpStyleEntry;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMREXTCREATEPEN
    {
        public EMR emr;
        public uint ihPen;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
        public EXTLOGPEN elp;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMREXTFLOODFILL
    {
        public EMR emr;
        public POINTL ptlStart;
        public uint crColor;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMREXTSELECTCLIPRGN
    {
        public EMR emr;
        public uint cbRgnData;
        public uint iMode;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] RgnData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct EMREXTTEXTOUTA
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public EMRTEXT emrtext;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct EMREXTTEXTOUTW
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint iGraphicsMode;
        public float exScale;
        public float eyScale;
        public EMRTEXT emrtext;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRFILLPATH
    {
        public EMR emr;
        public RECTL rclBounds;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSTROKEANDFILLPATH
    {
        public EMR emr;
        public RECTL rclBounds;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSTROKEPATH
    {
        public EMR emr;
        public RECTL rclBounds;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRFILLRGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] RgnData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRFORMAT
    {
        public uint dSignature;
        public uint nVersion;
        public uint cbData;
        public uint offData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRFRAMERGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;
        public uint ihBrush;
        public SIZEL szlStroke;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] RgnData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRGDICOMMENT
    {
        public EMR emr;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRGLSBOUNDEDRECORD
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRGLSRECORD
    {
        public EMR emr;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRGRADIENTFILL
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint nVer;
        public uint nTri;
        public uint ulMode;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public TRIVERTEX[] Ver;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRINVERTRGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] RgnData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPAINTRGN
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cbRgnData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] RgnData;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct RGNDATAHEADER
    {
        public uint dwSize;
        public uint iType;
        public uint nCount;
        public uint nRgnSize;
        public RECT rcBound;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct RGNDATA
    {
        public RGNDATAHEADER rdh;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Buffer;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRLINETO
    {
        public EMR emr;
        public POINTL ptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRMOVETOEX
    {
        public EMR emr;
        public POINTL ptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRMASKBLT
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
        public XFORM xformSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public int xMask;
        public int yMask;
        public uint iUsageMask;
        public uint offBmiMask;
        public uint cbBmiMask;
        public uint offBitsMask;
        public uint cbBitsMask;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRMODIFYWORLDTRANSFORM
    {
        public EMR emr;
        public XFORM xform;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMROFFSETCLIPRGN
    {
        public EMR emr;
        public POINTL ptlOffset;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct PIXELFORMATDESCRIPTOR
    {
        public ushort nSize;
        public ushort nVersion;
        public uint dwFlags;
        public byte iPixelType;
        public byte cColorBits;
        public byte cRedBits;
        public byte cRedShift;
        public byte cGreenBits;
        public byte cGreenShift;
        public byte cBlueBits;
        public byte cBlueShift;
        public byte cAlphaBits;
        public byte cAlphaShift;
        public byte cAccumBits;
        public byte cAccumRedBits;
        public byte cAccumGreenBits;
        public byte cAccumBlueBuits;
        public byte cAccumAlphaBits;
        public byte cDepthBits;
        public byte cStencilBits;
        public byte cAuxBuffers;
        public byte iLayerType;
        public byte bReserved;
        public uint dwLayerMask;
        public uint dwVisibleMask;
        public uint dwDamageMask;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPIXELFORMAT
    {
        public EMR emr;
        public PIXELFORMATDESCRIPTOR pfd;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPLGBLT
    {
        public EMR emr;
        public RECTL rclBounds;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public POINTL[] aptlDest;

        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public XFORM xformSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public int xMask;
        public int yMask;
        public uint iUsageMask;
        public uint offBmiMask;
        public uint cbBmiMask;
        public uint offBitsMask;
        public uint cbBitsMask;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYLINE
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYBEZIER
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYGON
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYBEZIERTO
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYLINETO
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYLINE16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYBEZIER16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYGON16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYBEZIERTO16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYLINETO16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYDRAW
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] aptl;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] abTypes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRPOLYDRAW16
    {
        public EMR emr;
        public RECTL rclBounds;
        public uint cpts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public POINTL[] apts;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] abTypes;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRRESIZEPALETTE
    {
        public EMR emr;
        public uint ihPal;
        public uint cEntries;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRRESTOREDC
    {
        public EMR emr;
        public int iRelative;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRROUNDRECT
    {
        public EMR emr;
        public RECTL rclBox;
        public SIZEL szlCorner;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSCALEVIEWPORTEXTEX
    {
        public EMR emr;
        public int xNum;
        public int xDenom;
        public int yNum;
        public int yDenom;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSCALEWINDOWEXTEX
    {
        public EMR emr;
        public int xNum;
        public int xDenom;
        public int yNum;
        public int yDenom;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSELECTPALETTE
    {
        public EMR emr;
        public uint ihPal;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETARCDIRECTION
    {
        public EMR emr;
        public uint iArcDirection;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETBKCOLOR
    {
        public EMR emr;
        public uint crColor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETTEXTCOLOR
    {
        public EMR emr;
        public uint crColor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETCOLORADJUSTMENT
    {
        public EMR emr;
        public COLORADJUSTMENT ColorAdjustment;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETDIBITSTODEVICE
    {
        public EMR emr;
        public RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public uint iUsageSrc;
        public uint iStartScan;
        public uint cScan;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETICMPROFILE
    {
        public EMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi), CLSCompliant(false)]
    public struct EMRSETICMPROFILEA
    {
        public EMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode), CLSCompliant(false)]
    public struct EMRSETICMPROFILEW
    {
        public EMR emr;
        public uint dwFlags;
        public uint cbName;
        public uint cbData;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Data;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETMAPPERFLAGS
    {
        public EMR emr;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct SETMITERLIMIT
    {
        public EMR emr;
        public float eMiterLimit;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETPALETTEENTRIES
    {
        public EMR emr;
        public uint ihPal;
        public uint iStart;
        public uint cEntries;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public PALETTEENTRY[] aPalEntries;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETPIXELV
    {
        public EMR emr;
        public POINTL ptlPixel;
        public uint crColor;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETVIEWPORTORGEX
    {
        public EMR emr;
        public POINTL ptlOrigin;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETWINDOWORGEX
    {
        public EMR emr;
        public POINTL ptlOrigin;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETBRUSHORGEX
    {
        public EMR emr;
        public POINTL ptlOrigin;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETWORLDTRANSFORM
    {
        public EMR emr;
        public XFORM xform;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSTRETCHBLT
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
        public XFORM xformSrc;
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
    public struct EMRSTRETCHDIBITS
    {
        public EMR emr;
        public RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public uint iUsageSrc;
        public uint dwRop;
        public int cxDest;
        public int cyDest;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSELECTCLIPPATH
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETBKMODE
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETMAPMODE
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETPOLYFILLMODE
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETROP2
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETSTRETCHBLTMODE
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETTEXTALIGN
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct EMRSETICMMODE
    {
        public EMR emr;
        public uint iMode;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MONITORINFO
    {
        public uint cbSize;
        public RECT rcMonitor;
        public RECT rcWork;
        public uint dwFlags;
    }

    [Serializable, StructLayout(LayoutKind.Sequential), CLSCompliant(false)]
    public struct MONITORINFOEX
    {
        public uint cbSize;
        public RECT rcMonitor;
        public RECT rcWork;
        public uint dwFlags;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szDevice;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct PAINTSTRUCT
    {
        public IntPtr hdc;
        public int fErase;
        public RECT rcPaint;
        public int fRestore;
        public int fIncUpdate;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] rgbReserved;
    }

    [Serializable, StructLayout(LayoutKind.Sequential)]
    public struct POINTS
    {
        public short x;
        public short y;
    }
}
