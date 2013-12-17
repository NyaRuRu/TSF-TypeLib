using System;
using System.Runtime.InteropServices;
using TSF.InteropTypes;

namespace TSF.OleTypes
{
  using CLSID = System.Guid;

  public struct STGMEDIUM
  {
    [MarshalAs(UnmanagedType.U4)]
    public TYMED tymed;
    public IntPtr unionmember;
    [MarshalAs(UnmanagedType.IUnknown)]
    public object pUnkForRelease;
  }
  public enum DATADIR
  {
    DATADIR_GET = 1,
    DATADIR_SET
  }

  [ComImport, Guid("00000103-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumFORMATETC
  {
    [PreserveSig]
    HRESULT Next(uint celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] FORMATETC[] rgelt, [NullAllowed] out uint pceltFetched);
    [PreserveSig]
    HRESULT Skip(uint celt);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Clone(out IEnumFORMATETC newEnum);
  }

  [Flags]
  public enum ADVF : uint
  {
    ADVF_NODATA = 1,
    ADVF_PRIMEFIRST = 2,
    ADVF_ONLYONCE = 4,
    ADVF_DATAONSTOP = 64,
    ADVFCACHE_NOHANDLER = 8,
    ADVFCACHE_FORCEBUILTIN = 16,
    ADVFCACHE_ONSAVE = 32
  }

  public struct FILETIME
  {
    public uint dwLowDateTime;
    public uint dwHighDateTime;
  }

  public struct STATSTG
  {
    [MarshalAs(UnmanagedType.LPWStr)]
    public string pwcsName;
    public uint type;
    public ulong cbSize;
    public FILETIME mtime;
    public FILETIME ctime;
    public FILETIME atime;
    public uint grfMode;
    public uint grfLocksSupported;
    public CLSID clsid;
    public uint grfStateBits;
    public uint reserved;
  }

  [ComImport, Guid("0000000c-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IStream
  {
    [PreserveSig]
    HRESULT Read([Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, uint cb, out uint pcbRead);
    [PreserveSig]
    HRESULT Write([In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv, uint cb, out uint pcbWritten);
    [PreserveSig]
    HRESULT Seek(long dlibMove, uint dwOrigin, [NullAllowed] out ulong plibNewPosition);
    [PreserveSig]
    HRESULT SetSize(ulong libNewSize);
    [PreserveSig]
    HRESULT CopyTo(IStream pstm, ulong cb, [NullAllowed] out ulong pcbRead, [NullAllowed] out ulong pcbWritten);
    [PreserveSig]
    HRESULT Commit(uint grfCommitFlags);
    [PreserveSig]
    HRESULT Revert();
    [PreserveSig]
    HRESULT LockRegion(ulong libOffset, ulong cb, uint dwLockType);
    [PreserveSig]
    HRESULT UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);
    [PreserveSig]
    HRESULT Stat(out STATSTG pstatstg, uint grfStatFlag);
    [PreserveSig]
    HRESULT Clone(out IStream ppstm);
  }

  [ComImport, Guid("00000010-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IRunningObjectTable
  {
    [PreserveSig]
    HRESULT Register(uint grfFlags, [In, MarshalAs(UnmanagedType.Interface)] object punkObject, IMoniker pmkObjectName, out uint pdwRegister);
    [PreserveSig]
    HRESULT Revoke(uint dwRegister);
    [PreserveSig]
    HRESULT IsRunning(IMoniker pmkObjectName);
    [PreserveSig]
    HRESULT GetObject(IMoniker pmkObjectName, [MarshalAs(UnmanagedType.Interface)] out object ppunkObject);
    [PreserveSig]
    HRESULT NoteChangeTime(uint dwRegister, [In] ref FILETIME pfiletime);
    [PreserveSig]
    HRESULT GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);
    [PreserveSig]
    HRESULT EnumRunning(out IEnumMoniker ppenumMoniker);
  }

  [Guid("00000102-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IEnumMoniker
  {
    [PreserveSig]
    HRESULT Next(uint celt, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IMoniker[] rgelt, [NullAllowed] out uint pceltFetched);
    [PreserveSig]
    HRESULT Skip(uint celt);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Clone(out IEnumMoniker ppenum);
  }

  public struct BIND_OPTS
  {
    public uint cbStruct;
    public uint grfFlags;
    public uint grfMode;
    public uint dwTickCountDeadline;
  }

  [ComImport, Guid("00000101-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumString
  {
    [PreserveSig]
    HRESULT Next(uint celt, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] string[] rgelt, [NullAllowed] out uint pceltFetched);
    [PreserveSig]
    HRESULT Skip(uint celt);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Clone(out IEnumString ppenum);
  }

  [ComImport, Guid("0000000e-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IBindCtx
  {
    [PreserveSig]
    HRESULT RegisterObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);
    [PreserveSig]
    HRESULT RevokeObjectBound([MarshalAs(UnmanagedType.Interface)] object punk);
    [PreserveSig]
    HRESULT ReleaseBoundObjects();
    [PreserveSig]
    HRESULT SetBindOptions([In] ref BIND_OPTS pbindopts);
    [PreserveSig]
    HRESULT GetBindOptions([In, Out] ref BIND_OPTS pbindopts);
    [PreserveSig]
    HRESULT GetRunningObjectTable(out IRunningObjectTable pprot);
    [PreserveSig]
    HRESULT RegisterObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [MarshalAs(UnmanagedType.Interface)] object punk);
    [PreserveSig]
    HRESULT GetObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey, [Out, MarshalAs(UnmanagedType.Interface)] out object ppunk);
    [PreserveSig]
    HRESULT EnumObjectParam(out IEnumString ppenum);
    [PreserveSig]
    HRESULT RevokeObjectParam([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
  }

  [ComImport, Guid("0000000f-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IMoniker
  {
    [PreserveSig]
    HRESULT GetClassID(out CLSID pClassID);
    [PreserveSig]
    HRESULT IsDirty();
    [PreserveSig]
    HRESULT Load(IStream pStm);
    [PreserveSig]
    HRESULT Save(IStream pStm, [MarshalAs(UnmanagedType.Bool)] bool fClearDirty);
    [PreserveSig]
    HRESULT GetSizeMax(out ulong pcbSize);
    [PreserveSig]
    HRESULT BindToObject(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riidResult, [MarshalAs(UnmanagedType.Interface)] out object ppvResult);
    [PreserveSig]
    HRESULT BindToStorage(IBindCtx pbc, IMoniker pmkToLeft, [In] ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out object ppvObj);
    [PreserveSig]
    HRESULT Reduce(IBindCtx pbc, uint dwReduceHowFar, ref IMoniker ppmkToLeft, out IMoniker ppmkReduced);
    [PreserveSig]
    HRESULT ComposeWith(IMoniker pmkRight, [MarshalAs(UnmanagedType.Bool)] bool fOnlyIfNotGeneric, out IMoniker ppmkComposite);
    [PreserveSig]
    HRESULT Enum([MarshalAs(UnmanagedType.Bool)] bool fForward, out IEnumMoniker ppenumMoniker);
    [PreserveSig]
    HRESULT IsEqual(IMoniker pmkOtherMoniker);
    [PreserveSig]
    HRESULT Hash(out uint pdwHash);
    [PreserveSig]
    HRESULT IsRunning(IBindCtx pbc, IMoniker pmkToLeft, IMoniker pmkNewlyRunning);
    [PreserveSig]
    HRESULT GetTimeOfLastChange(IBindCtx pbc, IMoniker pmkToLeft, out FILETIME pFileTime);
    [PreserveSig]
    HRESULT Inverse(out IMoniker ppmk);
    [PreserveSig]
    HRESULT CommonPrefixWith(IMoniker pmkOther, out IMoniker ppmkPrefix);
    [PreserveSig]
    HRESULT RelativePathTo(IMoniker pmkOther, out IMoniker ppmkRelPath);
    [PreserveSig]
    HRESULT GetDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] out string ppszDisplayName);
    [PreserveSig]
    HRESULT ParseDisplayName(IBindCtx pbc, IMoniker pmkToLeft, [MarshalAs(UnmanagedType.LPWStr)] string pszDisplayName, out uint pchEaten, out IMoniker ppmkOut);
    [PreserveSig]
    HRESULT IsSystemMoniker(out uint pdwMksys);
  }

  [ComImport, Guid("0000010F-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IAdviseSink
  {
    [PreserveSig]
    void OnDataChange([In] ref FORMATETC format, [In] ref STGMEDIUM stgmedium);
    [PreserveSig]
    void OnViewChange(uint aspect, int index);
    [PreserveSig]
    void OnRename([In] IMoniker moniker);
    [PreserveSig]
    void OnSave();
    [PreserveSig]
    void OnClose();
  }
  public struct STATDATA
  {
    public FORMATETC formatetc;
    public ADVF advf;
    public IAdviseSink advSink;
    public uint connection;
  }

  [ComImport, Guid("00000103-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumSTATDATA
  {
    [PreserveSig]
    HRESULT Next(uint celt, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] STATDATA[] rgelt, [NullAllowed] out uint pceltFetched);
    [PreserveSig]
    HRESULT Skip(uint celt);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Clone(out IEnumSTATDATA newEnum);
  }

  [ComImport, Guid("0000010E-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IDataObject
  {
    [PreserveSig]
    HRESULT GetData([In] ref FORMATETC format, out STGMEDIUM medium);
    [PreserveSig]
    HRESULT GetDataHere([In] ref FORMATETC format, ref STGMEDIUM medium);
    [PreserveSig]
    HRESULT QueryGetData([In] ref FORMATETC format);
    [PreserveSig]
    HRESULT GetCanonicalFormatEtc([In] ref FORMATETC formatIn, out FORMATETC formatOut);
    [PreserveSig]
    HRESULT SetData([In] ref FORMATETC formatIn, [In] ref STGMEDIUM medium, [MarshalAs(UnmanagedType.Bool)] bool release);
    [PreserveSig]
    HRESULT EnumFormatEtc(DATADIR direction, out IEnumFORMATETC ppenumFormatEtc);
    [PreserveSig]
    HRESULT DAdvise([In] ref FORMATETC pFormatetc, ADVF advf, [In] IAdviseSink adviseSink, out uint connection);
    [PreserveSig]
    HRESULT DUnadvise(uint connection);
    [PreserveSig]
    HRESULT EnumDAdvise(out IEnumSTATDATA enumAdvise);
  }

  [Flags]
  public enum DVASPECT : uint
  {
    DVASPECT_CONTENT = 1,
    DVASPECT_THUMBNAIL = 2,
    DVASPECT_ICON = 4,
    DVASPECT_DOCPRINT = 8,
  }

  [Flags]
  public enum TYMED : uint
  {
    TYMED_NULL = 0,
    TYMED_HGLOBAL = 1,
    TYMED_FILE = 2,
    TYMED_ISTREAM = 4,
    TYMED_ISTORAGE = 8,
    TYMED_GDI = 16,
    TYMED_MFPICT = 32,
    TYMED_ENHMF = 64,
  }

  public struct FORMATETC
  {
    [MarshalAs(UnmanagedType.U2)]
    public short cfFormat;
    public IntPtr ptd;
    [MarshalAs(UnmanagedType.U4)]
    public DVASPECT dwAspect;
    public int lindex;
    [MarshalAs(UnmanagedType.U4)]
    public TYMED tymed;
  }
}
