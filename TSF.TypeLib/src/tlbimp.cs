using System;
using System.Runtime.InteropServices;

namespace TSF.TypeLib
{
  using TSF.InteropTypes;
  using TSF.OleTypes;

  // TODO: Consider to define strong typedef
  using HICON = System.IntPtr;
  using HKL = System.IntPtr;
  using HWND = System.IntPtr;
  using HBITMAP = System.IntPtr;
  using LPARAM = System.IntPtr;
  using TfClientId = System.UInt32;
  using TfEditCookie = System.UInt32;
  using TfGuidAtom = System.UInt32;
  using TS_ATTRID = System.Guid;
  using TsViewCookie = System.UInt32;
  using WPARAM = System.UIntPtr;

  public static partial class CLSIDs
  {
    public const string CLSID_TF_ThreadMgr = "529a9e6b-6587-4f23-ab9e-9c7d683e3c50";
    public const string CLSID_TF_InputProcessorProfiles = "33c53a50-f456-4884-b049-85fd643ecfed";
    public const string CLSID_TF_LangBarMgr = "ebb08c45-6c4a-4fdc-ae53-4eb8c4c7db8e";
    public const string CLSID_TF_DisplayAttributeMgr = "3ce74de4-53d3-4d74-8b83-431b3828ba53";
    public const string CLSID_TF_CategoryMgr = "a4b544a1-438d-4b41-9325-869523e2d6c7";
    public const string CLSID_TF_LangBarItemMgr = "b9931692-a2b3-4fab-bf33-9ec6f9fb96ac";
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_ThreadMgr)]
  public class TF_ThreadMgr
  {
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_InputProcessorProfiles)]
  public class TF_InputProcessorProfiles
  {
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_LangBarMgr)]
  public class TF_LangBarMgr
  {
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_DisplayAttributeMgr)]
  public class TF_DisplayAttributeMgr
  {
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_CategoryMgr)]
  public class TF_CategoryMgr
  {
  }

  [ComImport, Guid(CLSIDs.CLSID_TF_LangBarItemMgr)]
  public class TF_LangBarItemMgr
  {
  }

  [ComImport, Guid("0002E000-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumGUID
  {
    [PreserveSig]
    HRESULT Next([In] uint celt, [Out] Guid[] rgelt, [NullAllowed] out uint pceltFetched);
    [PreserveSig]
    HRESULT Skip([In] uint celt);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
  }

  [ComImport, Guid("0FEB7E34-5A60-4356-8EF7-ABDEC2FF7CF8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IAnchor
  {
    [PreserveSig]
    HRESULT SetGravity([In] TsGravity gravity);
    [PreserveSig]
    HRESULT GetGravity([Out] out TsGravity pgravity);
    [PreserveSig]
    HRESULT IsEqual([In, MarshalAs(UnmanagedType.Interface)] IAnchor paWith, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
    [PreserveSig]
    HRESULT Compare([In, MarshalAs(UnmanagedType.Interface)] IAnchor paWith, [Out] out int plResult);
    [PreserveSig]
    HRESULT Shift([In] uint dwFlags, [In] int cchReq, [Out] out int pcch, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paHaltAnchor);
    [PreserveSig]
    HRESULT ShiftTo([In, MarshalAs(UnmanagedType.Interface)] IAnchor paSite);
    [PreserveSig]
    HRESULT ShiftRegion([In] uint dwFlags, [In] TsShiftDir dir, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfNoRegion);
    [PreserveSig]
    HRESULT SetChangeHistoryMask([In] uint dwMask);
    [PreserveSig]
    HRESULT GetChangeHistory([Out] out TS_CH pdwHistory);
    [PreserveSig]
    HRESULT ClearChangeHistory();
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaClone);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5EFD22BA-7838-46CB-88E2-CADB14124F8F")]
  public interface IEnumITfCompositionView
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumITfCompositionView ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfCompositionView[] rgCompositionView, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("8C5DAC4F-083C-4B85-A4C9-71746048ADCA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumSpeechCommands
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumSpeechCommands ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr)] string[] pSpCmds, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }


  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("DEFB1926-6C80-4CE8-87D4-D6B72B812BDE")]
  public interface IEnumTfCandidates
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfCandidates ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfCandidateString[] ppCand, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("8F1A7EA6-1654-4502-A86E-B2902344D507"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfContexts
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfContexts ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfContext[] rgContext, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("F0C0F8DD-CF38-44E1-BB0F-68CF0D551C78")]
  public interface IEnumTfContextViews
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfContextViews ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfContextView[] rgViews, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("7CEF04D7-CB75-4E80-A7AB-5F5BC7D332DE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfDisplayAttributeInfo
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDisplayAttributeInfo ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfDisplayAttributeInfo[] rgInfo, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("AA80E808-2021-11D2-93E0-0060B067B86E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfDocumentMgrs
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDocumentMgrs ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfDocumentMgr[] rgDocumentMgr, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("E4B24DB0-0990-11D3-8DF0-00105A2799B5")]
  public interface IEnumTfFunctionProviders
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfFunctionProviders ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfFunctionProvider[] ppCmdobj, IntPtr pcFetch);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("71C6E74D-0F28-11D8-A82A-00065B84435C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfInputProcessorProfiles
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfInputProcessorProfiles ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out] out TF_INPUTPROCESSORPROFILE pProfile, [Out] out uint pcFetch);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("583F34D0-DE25-11D2-AFDD-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfLangBarItems
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLangBarItems ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfLangBarItem[] ppItem, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("3D61BF11-AC5F-42C8-A4CB-931BCC28C744"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfLanguageProfiles
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLanguageProfiles ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out] TF_LANGUAGEPROFILE[] pProfile, IntPtr pcFetch);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("56988052-47DA-4A05-911A-E3D941F17145"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfLatticeElements
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLatticeElements ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out] TF_LMLATTELEMENT[] rgsElements, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("19188CB0-ACA9-11D2-AFC5-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfProperties
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfProperties ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfProperty[] ppProp, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("8ED8981B-7C10-4D7D-9FB3-AB72E9C75F72"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfPropertyValue
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfPropertyValue ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out] TF_PROPERTYVAL[] rgValues, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  [ComImport, Guid("F99D3F40-8E32-11D2-BF46-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfRanges
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfRanges ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfRange[] ppRange, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip(uint ulCount);
  }

  [ComImport, Guid("887AA91E-ACBA-4931-84DA-3C5208CF543F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface IEnumTfUIElements
  {
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfUIElements ppEnum);
    [PreserveSig]
    HRESULT Next([In] uint ulCount, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface)] ITfUIElement[] ppElement, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT Reset();
    [PreserveSig]
    HRESULT Skip([In] uint ulCount);
  }

  public enum InputScope : int
  {
    IS_DEFAULT = 0,
    IS_URL = 1,
    IS_FILE_FULLFILEPATH = 2,
    IS_FILE_FILENAME = 3,
    IS_EMAIL_USERNAME = 4,
    IS_EMAIL_SMTPEMAILADDRESS = 5,
    IS_LOGINNAME = 6,
    IS_PERSONALNAME_FULLNAME = 7,
    IS_PERSONALNAME_PREFIX = 8,
    IS_PERSONALNAME_GIVENNAME = 9,
    IS_PERSONALNAME_MIDDLENAME = 10,
    IS_PERSONALNAME_SURNAME = 11,
    IS_PERSONALNAME_SUFFIX = 12,
    IS_ADDRESS_FULLPOSTALADDRESS = 13,
    IS_ADDRESS_POSTALCODE = 14,
    IS_ADDRESS_STREET = 15,
    IS_ADDRESS_STATEORPROVINCE = 16,
    IS_ADDRESS_CITY = 17,
    IS_ADDRESS_COUNTRYNAME = 18,
    IS_ADDRESS_COUNTRYSHORTNAME = 19,
    IS_CURRENCY_AMOUNTANDSYMBOL = 20,
    IS_CURRENCY_AMOUNT = 21,
    IS_DATE_FULLDATE = 22,
    IS_DATE_MONTH = 23,
    IS_DATE_DAY = 24,
    IS_DATE_YEAR = 25,
    IS_DATE_MONTHNAME = 26,
    IS_DATE_DAYNAME = 27,
    IS_DIGITS = 28,
    IS_NUMBER = 29,
    IS_ONECHAR = 30,
    IS_PASSWORD = 31,
    IS_TELEPHONE_FULLTELEPHONENUMBER = 32,
    IS_TELEPHONE_COUNTRYCODE = 33,
    IS_TELEPHONE_AREACODE = 34,
    IS_TELEPHONE_LOCALNUMBER = 35,
    IS_TIME_FULLTIME = 36,
    IS_TIME_HOUR = 37,
    IS_TIME_MINORSEC = 38,
    IS_NUMBER_FULLWIDTH = 39,
    IS_ALPHANUMERIC_HALFWIDTH = 40,
    IS_ALPHANUMERIC_FULLWIDTH = 41,
    IS_CURRENCY_CHINESE = 42,
    IS_BOPOMOFO = 43,
    IS_HIRAGANA = 44,
    IS_KATAKANA_HALFWIDTH = 45,
    IS_KATAKANA_FULLWIDTH = 46,
    IS_HANJA = 47,
    IS_HANGUL_HALFWIDTH = 48,
    IS_HANGUL_FULLWIDTH = 49,
    IS_SEARCH = 50,
    IS_FORMULA = 51,
    IS_SEARCH_INCREMENTAL = 52,
    IS_CHINESE_HALFWIDTH = 53,
    IS_CHINESE_FULLWIDTH = 54,
    IS_NATIVE_SCRIPT = 55,
    IS_YOMI = 56,
    IS_TEXT = 57,
    IS_CHAT = 58,
    IS_NAME_OR_PHONENUMBER = 59,
    IS_EMAILNAME_OR_ADDRESS = 60,
    IS_PRIVATE = 61,
    IS_MAPS = 62,
    IS_NUMERIC_PASSWORD = 63,
    IS_NUMERIC_PIN = 64,
    IS_ALPHANUMERIC_PIN = 65,
    IS_ALPHANUMERIC_PIN_SET = 66,
    IS_PHRASELIST = -1,
    IS_REGULAREXPRESSION = -2,
    IS_SRGS = -3,
    IS_XML = -4,
    IS_ENUMSTRING = -5
  }

  [ComImport, Guid("38E09D4C-586D-435A-B592-C8A86691DEC6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ISpeechCommandProvider
  {
    [PreserveSig]
    HRESULT EnumSpeechCommands([In] LangID langid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumSpeechCommands ppEnum);
    [PreserveSig]
    HRESULT ProcessCommand([In] ref ushort pszCommand, [In] uint cch, [In] LangID langid);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("28888FE3-C2A0-483A-A3EA-8CB1CE51FF3D")]
  public interface ITextStoreACP
  {
    [PreserveSig]
    HRESULT AdviseSink([In] ref Guid riid, [In, MarshalAs(UnmanagedType.IUnknown)] object punk, [In] TS_AS dwMask);
    [PreserveSig]
    HRESULT UnadviseSink([In, MarshalAs(UnmanagedType.IUnknown)] object punk);
    [PreserveSig]
    HRESULT RequestLock([In] TS_LF dwLockFlags, [Out, MarshalAs(UnmanagedType.Error)] out TextStoreReturnValues phrSession);
    [PreserveSig]
    HRESULT GetStatus([Out] out TS_STATUS pdcs);
    [PreserveSig]
    HRESULT QueryInsert([In] int acpTestStart, [In] int acpTestEnd, [In] uint cch, [Out] out int pacpResultStart, [Out] out int pacpResultEnd);
    [PreserveSig]
    HRESULT GetSelection([In] uint ulIndex, [In] uint ulCount, [Out] TS_SELECTION_ACP[] pSelection, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT SetSelection([In] uint ulCount, [In] ref TS_SELECTION_ACP pSelection);
    [PreserveSig]
    HRESULT GetText([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchPlain, [In] uint cchPlainReq, [Out] out uint pcchPlainRet, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] TS_RUNINFO[] prgRunInfo, [In] uint cRunInfoReq, [Out] out uint pcRunInfoRet, [Out] out int pacpNext);
    [PreserveSig]
    HRESULT SetText([In] TS_ST dwFlags, [In] int acpStart, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] int acpEnd, [In] char[] pchText, [In] uint cch, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT GetFormattedText([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);
    [PreserveSig]
    HRESULT GetEmbedded([In] int acpPos, [In] ref Guid rguidService, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    HRESULT QueryInsertEmbedded([In] ref Guid pguidService, [In] ref FORMATETC pformatetc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertable);
    [PreserveSig]
    HRESULT InsertEmbedded([In] TS_IE dwFlags, [In] int acpStart, [In] int acpEnd, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT InsertTextAtSelection([In] TF_IAS dwFlags, [In] ref ushort pchText, [In] uint cch, [Out] out int pacpStart, [Out] out int pacpEnd, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT InsertEmbeddedAtSelection([In] TF_IAS dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out] out int pacpStart, [Out] out int pacpEnd, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT RequestSupportedAttrs([In] uint dwFlags, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs);
    [PreserveSig]
    HRESULT RequestAttrsAtPosition([In] int acpPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] uint dwFlags);
    [PreserveSig]
    HRESULT RequestAttrsTransitioningAtPosition([In] int acpPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] TS_ATTR_FIND dwFlags);
    [PreserveSig]
    HRESULT FindNextAttrTransition([In] int acpStart, [In] int acpHalt, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] TS_ATTR_FIND dwFlags, [Out] out int pacpNext, [Out] out int pfFound, [Out] out int plFoundOffset);
    [PreserveSig]
    HRESULT RetrieveRequestedAttrs([In] uint ulCount, [Out] TS_ATTRVAL[] paAttrVals, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT GetEndACP([Out] out int pacp);
    [PreserveSig]
    HRESULT GetActiveView([Out] out TsViewCookie pvcView);
    [PreserveSig]
    HRESULT GetACPFromPoint([In] TsViewCookie vcView, [In] ref POINT ptScreen, [In] uint dwFlags, [Out] out int pacp);
    [PreserveSig]
    HRESULT GetTextExt([In] TsViewCookie vcView, [In] int acpStart, [In] int acpEnd, [Out] out RECT prc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfClipped);
    [PreserveSig]
    HRESULT GetScreenExt([In] TsViewCookie vcView, [Out] out RECT prc);
    [PreserveSig]
    HRESULT GetWnd([In] TsViewCookie vcView, [Out] out HWND phwnd);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A2DE3BC2-3D8E-11d3-81A9-F753FBE61A00")]
  public interface ITextStoreACPEx
  {
    [PreserveSig]
    HRESULT ScrollToRect ([In] int acpStart, [In] int acpEnd, [In] ref RECT rc, [In] uint dwPosition);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("f86ad89f-5fe4-4b8d-bb9f-ef3797a84f1f")]
  public interface ITextStoreACP2
  {
    [PreserveSig]
    HRESULT AdviseSink([In] ref Guid riid, [In, MarshalAs(UnmanagedType.IUnknown)] object punk, [In] TS_AS dwMask);
    [PreserveSig]
    HRESULT UnadviseSink([In, MarshalAs(UnmanagedType.IUnknown)] object punk);
    [PreserveSig]
    HRESULT RequestLock([In] TS_LF dwLockFlags, [Out, MarshalAs(UnmanagedType.Error)] out TextStoreReturnValues phrSession);
    [PreserveSig]
    HRESULT GetStatus([Out] out TS_STATUS pdcs);
    [PreserveSig]
    HRESULT QueryInsert([In] int acpTestStart, [In] int acpTestEnd, [In] uint cch, [Out] out int pacpResultStart, [Out] out int pacpResultEnd);
    [PreserveSig]
    HRESULT GetSelection([In] uint ulIndex, [In] uint ulCount, [Out] TS_SELECTION_ACP[] pSelection, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT SetSelection([In] uint ulCount, [In] ref TS_SELECTION_ACP pSelection);
    [PreserveSig]
    HRESULT GetText([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchPlain, [In] uint cchPlainReq, [Out] out uint pcchPlainRet, [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 7)] TS_RUNINFO[] prgRunInfo, [In] uint cRunInfoReq, [Out] out uint pcRunInfoRet, [Out] out int pacpNext);
    [PreserveSig]
    HRESULT SetText([In] TS_ST dwFlags, [In] int acpStart, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] int acpEnd, [In] char[] pchText, [In] uint cch, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT GetFormattedText([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);
    [PreserveSig]
    HRESULT GetEmbedded([In] int acpPos, [In] ref Guid rguidService, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    HRESULT QueryInsertEmbedded([In] ref Guid pguidService, [In] ref FORMATETC pformatetc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertable);
    [PreserveSig]
    HRESULT InsertEmbedded([In] TS_IE dwFlags, [In] int acpStart, [In] int acpEnd, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT InsertTextAtSelection([In] TF_IAS dwFlags, [In] ref ushort pchText, [In] uint cch, [Out] out int pacpStart, [Out] out int pacpEnd, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT InsertEmbeddedAtSelection([In] TF_IAS dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out] out int pacpStart, [Out] out int pacpEnd, [Out] out TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT RequestSupportedAttrs([In] uint dwFlags, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs);
    [PreserveSig]
    HRESULT RequestAttrsAtPosition([In] int acpPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] uint dwFlags);
    [PreserveSig]
    HRESULT RequestAttrsTransitioningAtPosition([In] int acpPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] TS_ATTR_FIND dwFlags);
    [PreserveSig]
    HRESULT FindNextAttrTransition([In] int acpStart, [In] int acpHalt, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] TS_ATTR_FIND dwFlags, [Out] out int pacpNext, [Out] out int pfFound, [Out] out int plFoundOffset);
    [PreserveSig]
    HRESULT RetrieveRequestedAttrs([In] uint ulCount, [Out] TS_ATTRVAL[] paAttrVals, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT GetEndACP([Out] out int pacp);
    [PreserveSig]
    HRESULT GetActiveView([Out] out TsViewCookie pvcView);
    [PreserveSig]
    HRESULT GetACPFromPoint([In] TsViewCookie vcView, [In] ref POINT ptScreen, [In] uint dwFlags, [Out] out int pacp);
    [PreserveSig]
    HRESULT GetTextExt([In] TsViewCookie vcView, [In] int acpStart, [In] int acpEnd, [Out] out RECT prc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfClipped);
    [PreserveSig]
    HRESULT GetScreenExt([In] TsViewCookie vcView, [Out] out RECT prc);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E901-2021-11D2-93E0-0060B067B86E")]
  public interface ITextStoreACPServices
  {
    [PreserveSig]
    HRESULT Serialize([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out] out TF_PERSISTENT_PROPERTY_HEADER_ACP pHdr, [In, MarshalAs(UnmanagedType.Interface)] IStream pStream);
    [PreserveSig]
    HRESULT Unserialize([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp, [In] ref TF_PERSISTENT_PROPERTY_HEADER_ACP pHdr, [In, MarshalAs(UnmanagedType.Interface)] IStream pStream, [In, MarshalAs(UnmanagedType.Interface)] ITfPersistentPropertyLoaderACP pLoader);
    [PreserveSig]
    HRESULT ForceLoadProperty([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp);
    [PreserveSig]
    HRESULT CreateRange([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRangeACP ppRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("22D44C94-A419-4542-A272-AE26093ECECF")]
  public interface ITextStoreACPSink
  {
    [PreserveSig]
    HRESULT OnTextChange([In] TS_ST dwFlags, [In] ref TS_TEXTCHANGE pChange);
    [PreserveSig]
    HRESULT OnSelectionChange();
    [PreserveSig]
    HRESULT OnLayoutChange([In] TsLayoutCode lcode, [In] TsViewCookie vcView);
    [PreserveSig]
    HRESULT OnStatusChange([In] uint dwFlags);
    [PreserveSig]
    HRESULT OnAttrsChange([In] int acpStart, [In] int acpEnd, [In] uint cAttrs, [In] ref TS_ATTRID paAttrs);
    [PreserveSig]
    HRESULT OnLockGranted([In] uint dwLockFlags);
    [PreserveSig]
    HRESULT OnStartEditTransaction();
    [PreserveSig]
    HRESULT OnEndEditTransaction();
  }

  [ComImport, Guid("9B2077B0-5F18-4DEC-BEE9-3CC722F5DFE0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITextStoreAnchor
  {
    [PreserveSig]
    HRESULT AdviseSink([In] ref Guid riid, [In, MarshalAs(UnmanagedType.IUnknown)] object punk, [In] TS_AS dwMask);
    [PreserveSig]
    HRESULT UnadviseSink([In, MarshalAs(UnmanagedType.IUnknown)] object punk);
    [PreserveSig]
    HRESULT RequestLock([In] TS_LF dwLockFlags, [Out, MarshalAs(UnmanagedType.Error)] out TextStoreReturnValues phrSession);
    [PreserveSig]
    HRESULT GetStatus([Out] out TS_STATUS pdcs);
    [PreserveSig]
    HRESULT QueryInsert([In, MarshalAs(UnmanagedType.Interface)] IAnchor paTestStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paTestEnd, [In] uint cch, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaResultStart, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaResultEnd);
    [PreserveSig]
    HRESULT GetSelection([In] uint ulIndex, [In] uint ulCount, [Out] TS_SELECTION_ANCHOR[] pSelection, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT SetSelection([In] uint ulCount, [In] ref TS_SELECTION_ANCHOR pSelection);
    [PreserveSig]
    HRESULT GetText([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] uint cchReq, [Out] out uint pcch, [In, MarshalAs(UnmanagedType.Bool)] bool fUpdateAnchor);
    [PreserveSig]
    HRESULT SetText([In] TS_ST dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] uint cch);
    [PreserveSig]
    HRESULT GetFormattedText([In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [Out, MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);
    [PreserveSig]
    HRESULT GetEmbedded([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paPos, [In] ref Guid rguidService, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    HRESULT InsertEmbedded([In] TS_IE dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject);
    [PreserveSig]
    HRESULT RequestSupportedAttrs([In] uint dwFlags, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs);
    [PreserveSig]
    HRESULT RequestAttrsAtPosition([In, MarshalAs(UnmanagedType.Interface)] IAnchor paPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] uint dwFlags);
    [PreserveSig]
    HRESULT RequestAttrsTransitioningAtPosition([In, MarshalAs(UnmanagedType.Interface)] IAnchor paPos, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] TS_ATTR_FIND dwFlags);
    [PreserveSig]
    HRESULT FindNextAttrTransition([In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paHalt, [In] uint cFilterAttrs, [In] ref TS_ATTRID paFilterAttrs, [In] uint dwFlags, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfFound, [Out] out int plFoundOffset);
    [PreserveSig]
    HRESULT RetrieveRequestedAttrs([In] uint ulCount, [Out] TS_ATTRVAL[] paAttrVals, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT GetStart([Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaStart);
    [PreserveSig]
    HRESULT GetEnd([Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaEnd);
    [PreserveSig]
    HRESULT GetActiveView([Out] out TsViewCookie pvcView);
    [PreserveSig]
    HRESULT GetAnchorFromPoint([In] TsViewCookie vcView, [In] ref POINT ptScreen, [In] uint dwFlags, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaSite);
    [PreserveSig]
    HRESULT GetTextExt([In] TsViewCookie vcView, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [Out] out RECT prc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfClipped);
    [PreserveSig]
    HRESULT GetScreenExt([In] TsViewCookie vcView, [Out] out RECT prc);
    [PreserveSig]
    HRESULT GetWnd([In] TsViewCookie vcView, [Out] out IntPtr phwnd);
    [PreserveSig]
    HRESULT QueryInsertEmbedded([In] ref Guid pguidService, [In] ref FORMATETC pformatetc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertable);
    [PreserveSig]
    HRESULT InsertTextAtSelection([In] TF_IAS dwFlags, [In] ref ushort pchText, [In] uint cch, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaStart, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaEnd);
    [PreserveSig]
    HRESULT InsertEmbeddedAtSelection([In] TF_IAS dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaStart, [Out, MarshalAs(UnmanagedType.Interface)] out IAnchor ppaEnd);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A2DE3BC1-3D8E-11d3-81A9-F753FBE61A00")]
  public interface ITextStoreAnchorEx
  {
    [PreserveSig]
    HRESULT ScrollToRect([In, MarshalAs(UnmanagedType.Interface)] IAnchor pStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor pEnd, [In] ref RECT rc, [In] uint dwPosition);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E905-2021-11D2-93E0-0060B067B86E")]
  public interface ITextStoreAnchorSink
  {
    [PreserveSig]
    HRESULT OnTextChange([In] TS_TC dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd);
    [PreserveSig]
    HRESULT OnSelectionChange();
    [PreserveSig]
    HRESULT OnLayoutChange([In] TsLayoutCode lcode, [In] TsViewCookie vcView);
    [PreserveSig]
    HRESULT OnStatusChange([In] uint dwFlags);
    [PreserveSig]
    HRESULT OnAttrsChange([In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [In] uint cAttrs, [In] ref TS_ATTRID paAttrs);
    [PreserveSig]
    HRESULT OnLockGranted([In] uint dwLockFlags);
    [PreserveSig]
    HRESULT OnStartEditTransaction();
    [PreserveSig]
    HRESULT OnEndEditTransaction();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("25642426-028d-4474-977b-111bb114fe3e")]
  public interface ITextStoreAnchorSinkEx : ITextStoreAnchorSink
  {
    #region from base interface
    [PreserveSig]
    new HRESULT OnTextChange([In] TS_TC dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd);
    [PreserveSig]
    new HRESULT OnSelectionChange();
    [PreserveSig]
    new HRESULT OnLayoutChange([In] TsLayoutCode lcode, [In] TsViewCookie vcView);
    [PreserveSig]
    new HRESULT OnStatusChange([In] uint dwFlags);
    [PreserveSig]
    new HRESULT OnAttrsChange([In, MarshalAs(UnmanagedType.Interface)] IAnchor paStart, [In, MarshalAs(UnmanagedType.Interface)] IAnchor paEnd, [In] uint cAttrs, [In] ref TS_ATTRID paAttrs);
    [PreserveSig]
    new HRESULT OnLockGranted([In] uint dwLockFlags);
    [PreserveSig]
    new HRESULT OnStartEditTransaction();
    [PreserveSig]
    new HRESULT OnEndEditTransaction();
    #endregion
    [PreserveSig]
    HRESULT OnDisconnect();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("2bdf9464-41e2-43e3-950c-a6865ba25cd4")]
  public interface ITextStoreACPSinkEx : ITextStoreACPSink
  {
    #region from base interface
    [PreserveSig]
    new HRESULT OnTextChange([In] TS_ST dwFlags, [In] ref TS_TEXTCHANGE pChange);
    [PreserveSig]
    new HRESULT OnSelectionChange();
    [PreserveSig]
    new HRESULT OnLayoutChange([In] TsLayoutCode lcode, [In] TsViewCookie vcView);
    [PreserveSig]
    new HRESULT OnStatusChange([In] uint dwFlags);
    [PreserveSig]
    new HRESULT OnAttrsChange([In] int acpStart, [In] int acpEnd, [In] uint cAttrs, [In] ref TS_ATTRID paAttrs);
    [PreserveSig]
    new HRESULT OnLockGranted([In] uint dwLockFlags);
    [PreserveSig]
    new HRESULT OnStartEditTransaction();
    [PreserveSig]
    new HRESULT OnEndEditTransaction();
    #endregion
    [PreserveSig]
    HRESULT OnDisconnect();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("B246CB75-A93E-4652-BF8C-B3FE0CFD7E57")]
  public interface ITfActiveLanguageProfileNotifySink
  {
    [PreserveSig]
    HRESULT OnActivated([In] ref Guid clsid, [In] ref Guid guidProfile, [In] int fActivated);
  }

  [ComImport, Guid("A3AD50FB-9BDB-49E3-A843-6C76520FBF5D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCandidateList
  {
    [PreserveSig]
    HRESULT EnumCandidates([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfCandidates ppEnum);
    [PreserveSig]
    HRESULT GetCandidate([In] uint nIndex, [Out, MarshalAs(UnmanagedType.Interface)] out ITfCandidateString ppCand);
    [PreserveSig]
    HRESULT GetCandidateNum([Out] out uint pnCnt);
    [PreserveSig]
    HRESULT SetResult([In] uint nIndex, [In] TfCandidateResult imcr);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("EA1EA138-19DF-11D7-A6D2-00065B84435C")]
  public interface ITfCandidateListUIElement : ITfUIElement
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    new HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    new HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
    #endregion
    [PreserveSig]
    HRESULT GetUpdatedFlags([Out] out TF_CLUIE pdwFlags);
    [PreserveSig]
    HRESULT GetDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
    [PreserveSig]
    HRESULT GetCount([Out] out uint puCount);
    [PreserveSig]
    HRESULT GetSelection([Out] out uint puIndex);
    [PreserveSig]
    HRESULT GetString([In] uint uIndex, [Out, MarshalAs(UnmanagedType.BStr)] out string pstr);
    [PreserveSig]
    HRESULT GetPageIndex([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pIndex, [In] uint uSize, [Out] out uint puPageCnt);
    [PreserveSig]
    HRESULT SetPageIndex([In] ref uint pIndex, [In] uint uPageCnt);
    [PreserveSig]
    HRESULT GetCurrentPage([Out] out uint puPage);
  }

  [ComImport, Guid("85FAD185-58CE-497A-9460-355366B64B9A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCandidateListUIElementBehavior : ITfCandidateListUIElement
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    new HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    new HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
    [PreserveSig]
    new HRESULT GetUpdatedFlags([Out] out TF_CLUIE pdwFlags);
    [PreserveSig]
    new HRESULT GetDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
    [PreserveSig]
    new HRESULT GetCount([Out] out uint puCount);
    [PreserveSig]
    new HRESULT GetSelection([Out] out uint puIndex);
    [PreserveSig]
    new HRESULT GetString([In] uint uIndex, [Out, MarshalAs(UnmanagedType.BStr)] out string pstr);
    [PreserveSig]
    new HRESULT GetPageIndex([Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pIndex, [In] uint uSize, [Out] out uint puPageCnt);
    [PreserveSig]
    new HRESULT SetPageIndex([In] ref uint pIndex, [In] uint uPageCnt);
    [PreserveSig]
    new HRESULT GetCurrentPage([Out] out uint puPage);
    #endregion
    [PreserveSig]
    HRESULT SetSelection([In] uint nIndex);
    [PreserveSig]
    HRESULT Finalize();
    [PreserveSig]
    HRESULT Abort();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("581F317E-FD9D-443F-B972-ED00467C5D40")]
  public interface ITfCandidateString
  {
    [PreserveSig]
    HRESULT GetString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstr);
    [PreserveSig]
    HRESULT GetIndex([Out] out uint pnIndex);
  }

  [ComImport, Guid("C3ACEFB5-F69D-4905-938F-FCADCF4BE830"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_CategoryMgr))]
  public interface ITfCategoryMgr
  {
    [PreserveSig]
    HRESULT RegisterCategory([In] ref Guid rclsid, [In] ref Guid rcatid, [In] ref Guid rguid);
    [PreserveSig]
    HRESULT UnregisterCategory([In] ref Guid rclsid, [In] ref Guid rcatid, [In] ref Guid rguid);
    [PreserveSig]
    HRESULT EnumCategoriesInItem([In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
    [PreserveSig]
    HRESULT EnumItemsInCategory([In] ref Guid rcatid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
    [PreserveSig]
    HRESULT FindClosestCategory([In] ref Guid rguid, [Out] out Guid pcatid, [In] IntPtr ppcatidList, [In] uint ulCount);
    [PreserveSig]
    HRESULT RegisterGUIDDescription([In] ref Guid rclsid, [In] ref Guid rguid, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchDesc, [In] uint cch);
    [PreserveSig]
    HRESULT UnregisterGUIDDescription([In] ref Guid rclsid, [In] ref Guid rguid);
    [PreserveSig]
    HRESULT GetGUIDDescription([In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDesc);
    [PreserveSig]
    HRESULT RegisterGUIDDWORD([In] ref Guid rclsid, [In] ref Guid rguid, [In] uint dw);
    [PreserveSig]
    HRESULT UnregisterGUIDDWORD([In] ref Guid rclsid, [In] ref Guid rguid);
    [PreserveSig]
    HRESULT GetGUIDDWORD([In] ref Guid rguid, [Out] out uint pdw);
    [PreserveSig]
    HRESULT RegisterGUID([In] ref Guid rguid, [Out] out TfGuidAtom pguidatom);
    [PreserveSig]
    HRESULT GetGUID([In] TfGuidAtom guidatom, [Out] out Guid pguid);
    [PreserveSig]
    HRESULT IsEqualTfGuidAtom([In] TfGuidAtom guidatom, [In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
  }

  [ComImport, Guid("45C35144-154E-4797-BED8-D33AE7BF8794"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCleanupContextDurationSink
  {
    [PreserveSig]
    HRESULT OnStartCleanupContext();
    [PreserveSig]
    HRESULT OnEndCleanupContext();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("01689689-7ACB-4E9B-AB7C-7EA46B12B522")]
  public interface ITfCleanupContextSink
  {
    [PreserveSig]
    HRESULT OnCleanupContext([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
  }

  [ComImport, Guid("D60A7B49-1B9F-4BE2-B702-47E9DC05DEC3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfClientId
  {
    [PreserveSig]
    HRESULT GetClientId([In] ref Guid rclsid, [Out] out TfClientId ptid);
  }

  [ComImport, Guid("BB08F7A9-607A-4384-8623-056892B64371"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCompartment
  {
    [PreserveSig]
    HRESULT SetValue([In] TfClientId tid, [In, MarshalAs(UnmanagedType.Struct)] ref object pvarValue);
    [PreserveSig]
    HRESULT GetValue([Out, MarshalAs(UnmanagedType.Struct)] out object pvarValue);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("743ABD5F-F26D-48DF-8CC5-238492419B64")]
  public interface ITfCompartmentEventSink
  {
    [PreserveSig]
    HRESULT OnChange([In] ref Guid rguid);
  }

  [ComImport, Guid("7DCF57AC-18AD-438B-824D-979BFFB74B7C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCompartmentMgr
  {
    [PreserveSig]
    HRESULT GetCompartment([In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfCompartment ppcomp);
    [PreserveSig]
    HRESULT ClearCompartment([In] TfClientId tid, [In] ref Guid rguid);
    [PreserveSig]
    HRESULT EnumCompartments([Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("20168D64-5A8F-4A5A-B7BD-CFA29F4D0FD9")]
  public interface ITfComposition
  {
    [PreserveSig]
    HRESULT GetRange([Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange);
    [PreserveSig]
    HRESULT ShiftStart([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pNewStart);
    [PreserveSig]
    HRESULT ShiftEnd([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pNewEnd);
    [PreserveSig]
    HRESULT EndComposition([In] TfEditCookie ecWrite);
  }

  [ComImport, Guid("A781718C-579A-4B15-A280-32B8577ACC5E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCompositionSink
  {
    [PreserveSig]
    HRESULT OnCompositionTerminated([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfComposition pComposition);
  }

  [ComImport, Guid("D7540241-F9A1-4364-BEFC-DBCD2C4395B7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCompositionView
  {
    [PreserveSig]
    HRESULT GetOwnerClsid([Out] out Guid pclsid);
    [PreserveSig]
    HRESULT GetRange([Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0D2C969A-BC9C-437C-84EE-951C49B1A764")]
  public interface ITfConfigureSystemKeystrokeFeed
  {
    [PreserveSig]
    HRESULT DisableSystemKeystrokeFeed();
    [PreserveSig]
    HRESULT EnableSystemKeystrokeFeed();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E7FD-2021-11D2-93E0-0060B067B86E")]
  public interface ITfContext
  {
    [PreserveSig]
    HRESULT RequestEditSession([In] TfClientId tid, [In, MarshalAs(UnmanagedType.Interface)] ITfEditSession pes, [In] TF_ES dwFlags, [Out, MarshalAs(UnmanagedType.Error)] out int phrSession);
    [PreserveSig]
    HRESULT InWriteSession([In] TfClientId tid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfWriteSession);
    [PreserveSig]
    HRESULT GetSelection([In] TfEditCookie ec, [In] uint ulIndex, [In] uint ulCount, [Out] TF_SELECTION[] pSelection, [NullAllowed] out uint pcFetched);
    [PreserveSig]
    HRESULT SetSelection([In] TfEditCookie ec, [In] uint ulCount, [In] ref TF_SELECTION pSelection);
    [PreserveSig]
    HRESULT GetStart([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppStart);
    [PreserveSig]
    HRESULT GetEnd([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppEnd);
    [PreserveSig]
    HRESULT GetActiveView([Out, MarshalAs(UnmanagedType.Interface)] out ITfContextView ppView);
    [PreserveSig]
    HRESULT EnumViews([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfContextViews ppEnum);
    [PreserveSig]
    HRESULT GetStatus([Out] out TF_STATUS pdcs);
    [PreserveSig]
    HRESULT GetProperty([In] ref Guid guidProp, [Out, MarshalAs(UnmanagedType.Interface)] out ITfProperty ppProp);
    [PreserveSig]
    HRESULT GetAppProperty([In] ref Guid guidProp, [Out, MarshalAs(UnmanagedType.Interface)] out ITfReadOnlyProperty ppProp);
    [PreserveSig]
    HRESULT TrackProperties([In] IntPtr prgProp, [In] uint cProp, [In] IntPtr prgAppProp, [In] uint cAppProp, [Out, MarshalAs(UnmanagedType.Interface)] out ITfReadOnlyProperty ppProperty);
    [PreserveSig]
    HRESULT EnumProperties([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfProperties ppEnum);
    [PreserveSig]
    HRESULT GetDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppDm);
    [PreserveSig]
    HRESULT CreateRangeBackup([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRangeBackup ppBackup);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("D40C8AAE-AC92-4FC7-9A11-0EE0E23AA39B")]
  public interface ITfContextComposition
  {
    [PreserveSig]
    HRESULT StartComposition([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pCompositionRange, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionSink pSink, [Out, MarshalAs(UnmanagedType.Interface)] out ITfComposition ppComposition);
    [PreserveSig]
    HRESULT EnumCompositions([Out, MarshalAs(UnmanagedType.Interface)] out IEnumITfCompositionView ppEnum);
    [PreserveSig]
    HRESULT FindComposition([In] TfEditCookie ecRead, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pTestRange, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumITfCompositionView ppEnum);
    [PreserveSig]
    HRESULT TakeOwnership([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionSink pSink, [Out, MarshalAs(UnmanagedType.Interface)] out ITfComposition ppComposition);
  }

  [ComImport, Guid("0552BA5D-C835-4934-BF50-846AAA67432F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfContextKeyEventSink
  {
    [PreserveSig]
    HRESULT OnKeyDown([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnKeyUp([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnTestKeyDown([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnTestKeyUp([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E80C-2021-11D2-93E0-0060B067B86E")]
  public interface ITfContextOwner
  {
    [PreserveSig]
    HRESULT GetACPFromPoint([In] ref POINT ptScreen, [In] uint dwFlags, [Out] out int pacp);
    [PreserveSig]
    HRESULT GetTextExt([In] int acpStart, [In] int acpEnd, [Out] out RECT prc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfClipped);
    [PreserveSig]
    HRESULT GetScreenExt([Out] out RECT prc);
    [PreserveSig]
    HRESULT GetStatus([Out] out TF_STATUS pdcs);
    [PreserveSig]
    HRESULT GetWnd([Out] out HWND phwnd);
    [PreserveSig]
    HRESULT GetAttribute([In] ref Guid rguidAttribute, [Out, MarshalAs(UnmanagedType.Struct)] out object pvarValue);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("86462810-593B-4916-9764-19C08E9CE110")]
  public interface ITfContextOwnerCompositionServices : ITfContextComposition
  {
    #region from base interface
    [PreserveSig]
    new HRESULT StartComposition([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pCompositionRange, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionSink pSink, [Out, MarshalAs(UnmanagedType.Interface)] out ITfComposition ppComposition);
    [PreserveSig]
    new HRESULT EnumCompositions([Out, MarshalAs(UnmanagedType.Interface)] out IEnumITfCompositionView ppEnum);
    [PreserveSig]
    new HRESULT FindComposition([In] TfEditCookie ecRead, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pTestRange, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumITfCompositionView ppEnum);
    [PreserveSig]
    new HRESULT TakeOwnership([In] TfEditCookie ecWrite, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition, [In, MarshalAs(UnmanagedType.Interface)] ITfCompositionSink pSink, [Out, MarshalAs(UnmanagedType.Interface)] out ITfComposition ppComposition);
    #endregion
    [PreserveSig]
    HRESULT TerminateComposition([In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition);
  }

  [ComImport, Guid("5F20AA40-B57A-4F34-96AB-3576F377CC79"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfContextOwnerCompositionSink
  {
    [PreserveSig]
    HRESULT OnStartComposition([In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfOk);
    [PreserveSig]
    HRESULT OnUpdateComposition([In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRangeNew);
    [PreserveSig]
    HRESULT OnEndComposition([In, MarshalAs(UnmanagedType.Interface)] ITfCompositionView pComposition);
  }

  [ComImport, Guid("B23EB630-3E1C-11D3-A745-0050040AB407"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfContextOwnerServices
  {
    [PreserveSig]
    HRESULT OnLayoutChange();
    [PreserveSig]
    HRESULT OnStatusChange([In] uint dwFlags);
    [PreserveSig]
    HRESULT OnAttributeChange([In] ref Guid rguidAttribute);
    [PreserveSig]
    HRESULT Serialize([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out] out TF_PERSISTENT_PROPERTY_HEADER_ACP pHdr, [In, MarshalAs(UnmanagedType.Interface)] IStream pStream);
    [PreserveSig]
    HRESULT Unserialize([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp, [In] ref TF_PERSISTENT_PROPERTY_HEADER_ACP pHdr, [In, MarshalAs(UnmanagedType.Interface)] IStream pStream, [In, MarshalAs(UnmanagedType.Interface)] ITfPersistentPropertyLoaderACP pLoader);
    [PreserveSig]
    HRESULT ForceLoadProperty([In, MarshalAs(UnmanagedType.Interface)] ITfProperty pProp);
    [PreserveSig]
    HRESULT CreateRange([In] int acpStart, [In] int acpEnd, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRangeACP ppRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("2433BF8E-0F9B-435C-BA2C-180611978C30")]
  public interface ITfContextView
  {
    [PreserveSig]
    HRESULT GetRangeFromPoint([In] TfEditCookie ec, [In] ref POINT ppt, [In] uint dwFlags, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange);
    [PreserveSig]
    HRESULT GetTextExt([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out] out RECT prc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfClipped);
    [PreserveSig]
    HRESULT GetScreenExt([Out] out RECT prc);
    [PreserveSig]
    HRESULT GetWnd([Out] out HWND phwnd);
  }

  [ComImport, Guid("2463FBF0-B0AF-11D2-AFC5-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfCreatePropertyStore
  {
    [PreserveSig]
    HRESULT IsStoreSerializable([In] ref Guid guidProp, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, MarshalAs(UnmanagedType.Interface)] ITfPropertyStore pPropStore, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfSerializable);
    [PreserveSig]
    HRESULT CreatePropertyStore([In] ref Guid guidProp, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In] uint cb, [In, MarshalAs(UnmanagedType.Interface)] IStream pStream, [Out, MarshalAs(UnmanagedType.Interface)] out ITfPropertyStore ppStore);
  }

  [ComImport, Guid("70528852-2F26-4AEA-8C96-215150578932"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfDisplayAttributeInfo
  {
    [PreserveSig]
    HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDesc);
    [PreserveSig]
    HRESULT GetAttributeInfo([Out] out TF_DISPLAYATTRIBUTE pda);
    [PreserveSig]
    HRESULT SetAttributeInfo([In] ref TF_DISPLAYATTRIBUTE pda);
    [PreserveSig]
    HRESULT Reset();
  }

  [ComImport, Guid("8DED7393-5DB1-475C-9E71-A39111B0FF67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_DisplayAttributeMgr))]
  public interface ITfDisplayAttributeMgr
  {
    [PreserveSig]
    HRESULT OnUpdateInfo();
    [PreserveSig]
    HRESULT EnumDisplayAttributeInfo([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDisplayAttributeInfo ppEnum);
    [PreserveSig]
    HRESULT GetDisplayAttributeInfo([In] ref Guid guid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfDisplayAttributeInfo ppInfo, [Out] out Guid pclsidOwner);
  }

  [ComImport, Guid("AD56F402-E162-4F25-908F-7D577CF9BDA9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfDisplayAttributeNotifySink
  {
    [PreserveSig]
    HRESULT OnUpdateInfo();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("FEE47777-163C-4769-996A-6E9C50AD8F54")]
  public interface ITfDisplayAttributeProvider
  {
    [PreserveSig]
    HRESULT EnumDisplayAttributeInfo([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDisplayAttributeInfo ppEnum);
    [PreserveSig]
    HRESULT GetDisplayAttributeInfo([In] ref Guid guid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfDisplayAttributeInfo ppInfo);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E7F4-2021-11D2-93E0-0060B067B86E")]
  public interface ITfDocumentMgr
  {
    [PreserveSig]
    HRESULT CreateContext([In] TfClientId tidOwner, [In] uint dwFlags, [In, MarshalAs(UnmanagedType.IUnknown)] object punk, [Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppic, [Out] out TfEditCookie pecTextStore);
    [PreserveSig]
    HRESULT Push([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
    [PreserveSig]
    HRESULT Pop([In] TF_POPF dwFlags);
    [PreserveSig]
    HRESULT GetTop([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppic);
    [PreserveSig]
    HRESULT GetBase([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppic);
    [PreserveSig]
    HRESULT EnumContexts([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfContexts ppEnum);
  }

  [ComImport, Guid("42D4D099-7C1A-4A89-B836-6C6F22160DF0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfEditRecord
  {
    [PreserveSig]
    HRESULT GetSelectionStatus([Out, MarshalAs(UnmanagedType.Bool)] out bool pfChanged);
    [PreserveSig]
    HRESULT GetTextAndPropertyUpdates([In] TF_GTP dwFlags, [In] IntPtr prgProperties, [In] uint cProperties, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfRanges ppEnum);
  }

  [ComImport, Guid("AA80E803-2021-11D2-93E0-0060B067B86E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfEditSession
  {
    [PreserveSig]
    HRESULT DoEditSession([In] TfEditCookie ec);
  }

  [ComImport, Guid("708FBF70-B520-416B-B06C-2C41AB44F8BA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfEditTransactionSink
  {
    [PreserveSig]
    HRESULT OnStartEditTransaction([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
    [PreserveSig]
    HRESULT OnEndEditTransaction([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
  }

  [ComImport, Guid("3527268B-7D53-4DD9-92B7-7296AE461249"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnAdviseText : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT OnTextUpdate([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] int cch);
    [PreserveSig]
    HRESULT OnLatticeUpdate([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, MarshalAs(UnmanagedType.Interface)] ITfLMLattice pLattice);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("87a2ad8f-f27b-4920-8501-67602280175d")]
  public interface ITfFnSearchCandidateProvider : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT GetSearchCandidates([In][MarshalAs(UnmanagedType.BStr)] string bstrQuery, [In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationId, [Out] out ITfCandidateList pplist);

    [PreserveSig]
    HRESULT SetResult([In][MarshalAs(UnmanagedType.BStr)] string bstrQuery, [In][MarshalAs(UnmanagedType.BStr)] string bstrApplicationID, [In][MarshalAs(UnmanagedType.BStr)] string bstrResult);
  };

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C7A6F54F-B180-416F-B2BF-7BF2E4683D7B")]
  public interface ITfIntegratableCandidateListUIElement
  {
    [PreserveSig]
    HRESULT SetIntegrationStyle([In] ref Guid guidIntegrationStyle);
    [PreserveSig]
    HRESULT GetSelectionStyle([Out] out TfIntegratableCandidateListSelectionStyle ptfSelectionStyle);
    [PreserveSig]
    HRESULT OnKeyDown([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT ShowCandidateNumbers([Out, MarshalAs(UnmanagedType.Bool)] out bool pfShow);
    [PreserveSig]
    HRESULT FinalizeExactCompositionString();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5F309A41-590A-4ACC-A97F-D8EFFF13FDFC")]
  public interface ITfFnGetPreferredTouchKeyboardLayout
  {
    [PreserveSig]
    HRESULT GetLayout([Out] out TKBLayoutType pTKBLayoutType, [Out] out TKBLayoutId pwPreferredLayoutId);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("3BAB89E4-5FBE-45F4-A5BC-DCA36AD225A8")]
  public interface ITfFnBalloon
  {
    [PreserveSig]
    HRESULT UpdateBalloon([In] TfLBBalloonStyle style, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] char[] pch, [In] uint cch);
  }

  [ComImport, Guid("88F567C6-1757-49F8-A1B2-89234C1EEFF9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnConfigure : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT Show([In] HWND hwndParent, [In] LangID langid, [In] ref Guid rguidProfile);
  }

  [ComImport, Guid("B5E26FF5-D7AD-4304-913F-21A2ED95A1B0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnConfigureRegisterEudc : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT Show([In] HWND hwndParent, [In] LangID langid, [In] ref Guid rguidProfile, [In, MarshalAs(UnmanagedType.BStr)] string bstrRegistered);
  }

  [ComImport, Guid("BB95808A-6D8F-4BCA-8400-5390B586AEDF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnConfigureRegisterWord : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT Show([In] HWND hwndParent, [In] LangID langid, [In] ref Guid rguidProfile, [In, MarshalAs(UnmanagedType.BStr)] string bstrRegistered);
  }

  [ComImport, Guid("FCA6C349-A12F-43A3-8DD6-5A5A4282577B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnCustomSpeechCommand : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT SetSpeechCommandProvider([In, MarshalAs(UnmanagedType.IUnknown)] object pspcmdProvider);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5C0AB7EA-167D-4F59-BFB5-4693755E90CA")]
  public interface ITfFnGetSAPIObject : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT Get([In] TfSapiObject sObj, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A87A8574-A6C1-4E15-99F0-3D3965F548EB")]
  public interface ITfFnLangProfileUtil : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT RegisterActiveProfiles();
    [PreserveSig]
    HRESULT IsProfileAvailableForLang([In] LangID langid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAvailable);
  }

  [ComImport, Guid("04B825B1-AC9A-4F7B-B5AD-C7168F1EE445"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnLMInternal : ITfFnLMProcessor
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    [PreserveSig]
    new HRESULT QueryRange([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppNewRange, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccepted);
    [PreserveSig]
    new HRESULT QueryLangID([In] LangID langid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccepted);
    [PreserveSig]
    new HRESULT GetReconversion([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfCandidateList ppCandList);
    [PreserveSig]
    new HRESULT Reconvert([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
    [PreserveSig]
    new HRESULT QueryKey([In] int fUp, [In] WPARAM vKey, [In] LPARAM lparamKeydata, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInterested);
    [PreserveSig]
    new HRESULT InvokeKey([In] int fUp, [In] WPARAM vKey, [In] LPARAM lparamKeydata);
    [PreserveSig]
    new HRESULT InvokeFunc([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] ref Guid refguidFunc);
    #endregion
    [PreserveSig]
    HRESULT ProcessLattice([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("7AFBF8E7-AC4B-4082-B058-890899D3A010")]
  public interface ITfFnLMProcessor : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT QueryRange([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppNewRange, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccepted);
    [PreserveSig]
    HRESULT QueryLangID([In] LangID langid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccepted);
    [PreserveSig]
    HRESULT GetReconversion([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfCandidateList ppCandList);
    [PreserveSig]
    HRESULT Reconvert([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
    [PreserveSig]
    HRESULT QueryKey([In] int fUp, [In] WPARAM vKey, [In] LPARAM lparamKeydata, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInterested);
    [PreserveSig]
    HRESULT InvokeKey([In] int fUp, [In] WPARAM vKey, [In] LPARAM lparamKeydata);
    [PreserveSig]
    HRESULT InvokeFunc([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] ref Guid refguidFunc);
  }

  [ComImport, Guid("A3A416A4-0F64-11D3-B5B7-00C04FC324A1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnPlayBack : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT QueryRange([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppNewRange, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfPlayable);
    [PreserveSig]
    HRESULT Play([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("2338AC6E-2B9D-44C0-A75E-EE64F256B3BD")]
  public interface ITfFnPropertyUIStatus : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT GetStatus([In] ref Guid refguidProp, [Out] out uint pdw);
    [PreserveSig]
    HRESULT SetStatus([In] ref Guid refguidProp, [In] uint dw);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("4CEA93C0-0A58-11D3-8DF0-00105A2799B5")]
  public interface ITfFnReconversion : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT QueryRange([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, Out, MarshalAs(UnmanagedType.Interface)] ref ITfRange ppNewRange, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfConvertable);
    [PreserveSig]
    HRESULT GetReconversion([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfCandidateList ppCandList);
    [PreserveSig]
    HRESULT Reconvert([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
  }

  [ComImport, Guid("5AB1D30C-094D-4C29-8EA5-0BF59BE87BF3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfFnShowHelp : ITfFunction
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
    #endregion
    [PreserveSig]
    HRESULT Show([In] HWND hwndParent);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("DB593490-098F-11D3-8DF0-00105A2799B5")]
  public interface ITfFunction
  {
    [PreserveSig]
    HRESULT GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrName);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("101D6610-0990-11D3-8DF0-00105A2799B5")]
  public interface ITfFunctionProvider
  {
    [PreserveSig]
    HRESULT GetType([Out] out Guid pguid);
    [PreserveSig]
    HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDesc);
    [PreserveSig]
    HRESULT GetFunction([In] ref Guid rguid, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("71C6E74E-0F28-11D8-A82A-00065B84435C")]
  public interface ITfInputProcessorProfileActivationSink
  {
    [PreserveSig]
    HRESULT OnActivated([In] TF_PROFILETYPE dwProfileType, [In] LangID langid, [In] ref Guid clsid, [In] ref Guid catid, [In] ref Guid guidProfile, [In] HKL HKL, [In] TF_IPSINK_FLAG dwFlags);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("71C6E74C-0F28-11D8-A82A-00065B84435C"), CoClass(typeof(TF_InputProcessorProfiles))]
  public interface ITfInputProcessorProfileMgr
  {
    [PreserveSig]
    HRESULT ActivateProfile([In] TF_PROFILETYPE dwProfileType, [In] LangID langid, [In] ref Guid clsid, [In] ref Guid guidProfile, [In] HKL HKL, [In] TF_IPPMF dwFlags);
    [PreserveSig]
    HRESULT DeactivateProfile([In] TF_PROFILETYPE dwProfileType, [In] LangID langid, [In] ref Guid clsid, [In] ref Guid guidProfile, [In] HKL HKL, [In] TF_IPPMF dwFlags);
    [PreserveSig]
    HRESULT GetProfile([In] TF_PROFILETYPE dwProfileType, [In] LangID langid, [In] ref Guid clsid, [In] ref Guid guidProfile, [In] HKL HKL, [Out] out TF_INPUTPROCESSORPROFILE pProfile);
    [PreserveSig]
    HRESULT EnumProfiles([In] LangID langid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfInputProcessorProfiles ppEnum);
    [PreserveSig]
    HRESULT ReleaseInputProcessor([In] ref Guid rclsid, [In] TF_RIP_FLAG dwFlags);
    [PreserveSig]
    HRESULT RegisterProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.U2)] char[] pchDesc, [In] uint cchDesc, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6, ArraySubType = UnmanagedType.U2)] char[] pchIconFile, [In] uint cchFile, [In] uint uIconIndex, [In] HKL hklSubstitute, [In] uint dwPreferredLayout, [In, MarshalAs(UnmanagedType.Bool)] bool bEnabledByDefault, [In] TF_RP dwFlags);
    [PreserveSig]
    HRESULT UnregisterProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In] TF_URP dwFlags);
    [PreserveSig]
    HRESULT GetActiveProfile([In] ref Guid catid, [Out] out TF_INPUTPROCESSORPROFILE pProfile);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("1F02B6C5-7842-4EE6-8A0B-9A24183A95CA"), CoClass(typeof(TF_InputProcessorProfiles))]
  public interface ITfInputProcessorProfiles
  {
    [PreserveSig]
    HRESULT Register([In] ref Guid rclsid);
    [PreserveSig]
    HRESULT Unregister([In] ref Guid rclsid);
    [PreserveSig]
    HRESULT AddLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.U2)] char[] pchDesc, [In] uint cchDesc, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6, ArraySubType = UnmanagedType.U2)] char[] pchIconFile, [In] uint cchFile, [In] uint uIconIndex);
    [PreserveSig]
    HRESULT RemoveLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile);
    [PreserveSig]
    HRESULT EnumInputProcessorInfo([Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
    [PreserveSig]
    HRESULT GetDefaultLanguageProfile([In] LangID langid, [In] ref Guid catid, [Out] out Guid pclsid, [Out] out Guid pguidProfile);
    [PreserveSig]
    HRESULT SetDefaultLanguageProfile([In] LangID langid, [In] ref Guid rclsid, [In] ref Guid guidProfiles);
    [PreserveSig]
    HRESULT ActivateLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfiles);
    [PreserveSig]
    HRESULT GetActiveLanguageProfile([In] ref Guid rclsid, [Out] out LangID plangid, [Out] out Guid pguidProfile);
    [PreserveSig]
    HRESULT GetLanguageProfileDescription([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.BStr)] out string pbstrProfile);
    [PreserveSig]
    HRESULT GetCurrentLanguage([Out] out LangID plangid);
    [PreserveSig]
    HRESULT ChangeCurrentLanguage([In] LangID langid);
    [PreserveSig]
    HRESULT GetLanguageList([Out] IntPtr ppLangId, [Out] out uint pulCount);
    [PreserveSig]
    HRESULT EnumLanguageProfiles([In] LangID langid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLanguageProfiles ppEnum);
    [PreserveSig]
    HRESULT EnableLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In, MarshalAs(UnmanagedType.Bool)] bool fEnable);
    [PreserveSig]
    HRESULT IsEnabledLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEnable);
    [PreserveSig]
    HRESULT EnableLanguageProfileByDefault([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.Bool)] out bool fEnable);
    [PreserveSig]
    HRESULT SubstituteKeyboardLayout([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In] HKL HKL);
  }

  [ComImport, Guid("892F230F-FE00-4A41-A98E-FCD6DE0D35EF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_InputProcessorProfiles))]
  public interface ITfInputProcessorProfilesEx : ITfInputProcessorProfiles
  {
    #region from base interface
    [PreserveSig]
    new HRESULT Register([In] ref Guid rclsid);
    [PreserveSig]
    new HRESULT Unregister([In] ref Guid rclsid);
    [PreserveSig]
    new HRESULT AddLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.U2)] char[] pchDesc, [In] uint cchDesc, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6, ArraySubType = UnmanagedType.U2)] char[] pchIconFile, [In] uint cchFile, [In] uint uIconIndex);
    [PreserveSig]
    new HRESULT RemoveLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile);
    [PreserveSig]
    new HRESULT EnumInputProcessorInfo([Out, MarshalAs(UnmanagedType.Interface)] out IEnumGUID ppEnum);
    [PreserveSig]
    new HRESULT GetDefaultLanguageProfile([In] LangID langid, [In] ref Guid catid, [Out] out Guid pclsid, [Out] out Guid pguidProfile);
    [PreserveSig]
    new HRESULT SetDefaultLanguageProfile([In] LangID langid, [In] ref Guid rclsid, [In] ref Guid guidProfiles);
    [PreserveSig]
    new HRESULT ActivateLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfiles);
    [PreserveSig]
    new HRESULT GetActiveLanguageProfile([In] ref Guid rclsid, [Out] out LangID plangid, [Out] out Guid pguidProfile);
    [PreserveSig]
    new HRESULT GetLanguageProfileDescription([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.BStr)] out string pbstrProfile);
    [PreserveSig]
    new HRESULT GetCurrentLanguage([Out] out LangID plangid);
    [PreserveSig]
    new HRESULT ChangeCurrentLanguage([In] LangID langid);
    [PreserveSig]
    new HRESULT GetLanguageList([Out] IntPtr ppLangId, [Out] out uint pulCount);
    [PreserveSig]
    new HRESULT EnumLanguageProfiles([In] LangID langid, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLanguageProfiles ppEnum);
    [PreserveSig]
    new HRESULT EnableLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In, MarshalAs(UnmanagedType.Bool)] bool fEnable);
    [PreserveSig]
    new HRESULT IsEnabledLanguageProfile([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEnable);
    [PreserveSig]
    new HRESULT EnableLanguageProfileByDefault([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out, MarshalAs(UnmanagedType.Bool)] out bool fEnable);
    [PreserveSig]
    new HRESULT SubstituteKeyboardLayout([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In] HKL HKL);
    #endregion
    [PreserveSig]
    HRESULT SetLanguageProfileDisplayName([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4, ArraySubType = UnmanagedType.U2)] char[] pchFile, [In] uint cchFile, [In] uint uResId);
  }

  [ComImport, Guid("4FD67194-1002-4513-BFF2-C0DDF6258552"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfInputProcessorProfileSubstituteLayout
  {
    [PreserveSig]
    HRESULT GetSubstituteKeyboardLayout([In] ref Guid rclsid, [In] LangID langid, [In] ref Guid guidProfile, [Out] out HKL phKL);
  }

  [ComImport, Guid("FDE1EAEE-6924-4CDF-91E7-DA38CFF5559D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfInputScope
  {
    [PreserveSig]
    HRESULT GetInputScopes(IntPtr pprgInputScopes, [Out] out uint pcCount);
    [PreserveSig]
    HRESULT GetPhrase(IntPtr ppbstrPhrases, [Out] out uint pcCount);
    [PreserveSig]
    HRESULT GetRegularExpression([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrRegExp);
    [PreserveSig]
    HRESULT GetSRGS([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrSRGS);
    [PreserveSig]
    HRESULT GetXML([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrXML);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5731EAA0-6BC2-4681-A532-92FBB74D7C41")]
  public interface ITfInputScope2 : ITfInputScope
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetInputScopes(IntPtr pprgInputScopes, [Out] out uint pcCount);
    [PreserveSig]
    new HRESULT GetPhrase(IntPtr ppbstrPhrases, [Out] out uint pcCount);
    [PreserveSig]
    new HRESULT GetRegularExpression([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrRegExp);
    [PreserveSig]
    new HRESULT GetSRGS([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrSRGS);
    [PreserveSig]
    new HRESULT GetXML([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrXML);
    #endregion
    [PreserveSig]
    HRESULT EnumWordList([Out, MarshalAs(UnmanagedType.Interface)] out IEnumString ppEnumString);
  }

  [ComImport, Guid("55CE16BA-3014-41C1-9CEB-FADE1446AC6C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfInsertAtSelection
  {
    [PreserveSig]
    HRESULT InsertTextAtSelection([In] TfEditCookie ec, [In] TF_IAS dwFlags, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] int cch, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange);
    [PreserveSig]
    HRESULT InsertEmbeddedAtSelection([In] TfEditCookie ec, [In] TF_IAS dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E7F5-2021-11D2-93E0-0060B067B86E")]
  public interface ITfKeyEventSink
  {
    [PreserveSig]
    HRESULT OnSetFocus([In] int fForeground);
    [PreserveSig]
    HRESULT OnTestKeyDown([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnTestKeyUp([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnKeyDown([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnKeyUp([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT OnPreservedKey([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E7F0-2021-11D2-93E0-0060B067B86E")]
  public interface ITfKeystrokeMgr
  {
    [PreserveSig]
    HRESULT AdviseKeyEventSink([In] TfClientId tid, [In, MarshalAs(UnmanagedType.Interface)] ITfKeyEventSink pSink, [In] int fForeground);
    [PreserveSig]
    HRESULT UnadviseKeyEventSink([In] TfClientId tid);
    [PreserveSig]
    HRESULT GetForeground([Out] out Guid pclsid);
    [PreserveSig]
    HRESULT TestKeyDown([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT TestKeyUp([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT KeyDown([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT KeyUp([In] WPARAM wParam, [In] LPARAM lParam, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
    [PreserveSig]
    HRESULT GetPreservedKey([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] ref TF_PRESERVEDKEY pprekey, [Out] out Guid pguid);
    [PreserveSig]
    HRESULT IsPreservedKey([In] ref Guid rguid, [In] ref TF_PRESERVEDKEY pprekey, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfRegistered);
    [PreserveSig]
    HRESULT PreserveKey([In] TfClientId tid, [In] ref Guid rguid, [In] ref TF_PRESERVEDKEY prekey, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 4)] char[] pchDesc, [In] uint cchDesc);
    [PreserveSig]
    HRESULT UnpreserveKey([In] ref Guid rguid, [In] ref TF_PRESERVEDKEY pprekey);
    [PreserveSig]
    HRESULT SetPreservedKeyDescription([In] ref Guid rguid, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] char[] pchDesc, [In] uint cchDesc);
    [PreserveSig]
    HRESULT GetPreservedKeyDescription([In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDesc);
    [PreserveSig]
    HRESULT SimulatePreservedKey([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
  }

  [ComImport, Guid("1CD4C13B-1C36-4191-A70A-7F3E611F367D"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfKeyTraceEventSink
  {
    [PreserveSig]
    HRESULT OnKeyTraceDown([In] WPARAM wParam, [In] LPARAM lParam);
    [PreserveSig]
    HRESULT OnKeyTraceUp([In] WPARAM wParam, [In] LPARAM lParam);
  }

  [ComImport, Guid("18A4E900-E0AE-11D2-AFDD-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfLangBarEventSink
  {
    [PreserveSig]
    HRESULT OnSetFocus([In] uint dwThreadId);
    [Obsolete]
    [PreserveSig]
    HRESULT OnThreadTerminate([In] uint dwThreadId);
    [PreserveSig]
    HRESULT OnThreadItemChange([In] uint dwThreadId);
    [Obsolete]
    [PreserveSig]
    HRESULT OnModalInput([In] uint dwThreadId, [In] uint uMsg, [In] uint wParam, [In] LPARAM lParam);
    [PreserveSig]
    HRESULT ShowFloating([In] TF_SFT dwFlags);
    [Obsolete]
    [PreserveSig]
    HRESULT GetItemFloatingRect([In] uint dwThreadId, [In] ref Guid rguid, [Out] out RECT prc);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("73540D69-EDEB-4EE9-96C9-23AA30B25916")]
  public interface ITfLangBarItem
  {
    [PreserveSig]
    HRESULT GetInfo([Out] out TF_LANGBARITEMINFO pInfo);
    [PreserveSig]
    HRESULT GetStatus([Out] out TF_LBI_STATUS pdwStatus);
    [PreserveSig]
    HRESULT Show([In] int fShow);
    [PreserveSig]
    HRESULT GetTooltipString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrToolTip);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("01C2D285-D3C7-4B7B-B5B5-D97411D0C283")]
  public interface ITfLangBarItemBalloon : ITfLangBarItem
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetInfo([Out] out TF_LANGBARITEMINFO pInfo);
    [PreserveSig]
    new HRESULT GetStatus([Out] out TF_LBI_STATUS pdwStatus);
    [PreserveSig]
    new HRESULT Show([In] int fShow);
    [PreserveSig]
    new HRESULT GetTooltipString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrToolTip);
    #endregion
    [PreserveSig]
    HRESULT OnClick([In] TfLBIClick click, [In] POINT pt, [In] ref RECT prcArea);
    [PreserveSig]
    HRESULT GetPreferredSize([In] ref SIZE pszDefault, [Out] out SIZE psz);
    [PreserveSig]
    HRESULT GetBalloonInfo([Out] out TF_LBBALLOONINFO pInfo);
  }

  [ComImport, Guid("73830352-D722-4179-ADA5-F045C98DF355"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfLangBarItemBitmap : ITfLangBarItem
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetInfo([Out] out TF_LANGBARITEMINFO pInfo);
    [PreserveSig]
    new HRESULT GetStatus([Out] out TF_LBI_STATUS pdwStatus);
    [PreserveSig]
    new HRESULT Show([In] int fShow);
    [PreserveSig]
    new HRESULT GetTooltipString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrToolTip);
    #endregion
    [PreserveSig]
    HRESULT OnClick([In] TfLBIClick click, [In] POINT pt, [In] ref RECT prcArea);
    [PreserveSig]
    HRESULT GetPreferredSize([In] ref SIZE pszDefault, [Out] out SIZE psz);
    [PreserveSig]
    HRESULT DrawBitmap([In] int bmWidth, [In] int bmHeight, [In] uint dwFlags, [Out] out HBITMAP phbmp, [Out] out HBITMAP phbmpMask);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A26A0525-3FAE-4FA0-89EE-88A964F9F1B5")]
  public interface ITfLangBarItemBitmapButton : ITfLangBarItem
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetInfo([Out] out TF_LANGBARITEMINFO pInfo);
    [PreserveSig]
    new HRESULT GetStatus([Out] out TF_LBI_STATUS pdwStatus);
    [PreserveSig]
    new HRESULT Show([In] int fShow);
    [PreserveSig]
    new HRESULT GetTooltipString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrToolTip);
    #endregion
    [PreserveSig]
    HRESULT OnClick([In] TfLBIClick click, [In] POINT pt, [In] ref RECT prcArea);
    [PreserveSig]
    HRESULT InitMenu([In, MarshalAs(UnmanagedType.Interface)] ITfMenu pMenu);
    [PreserveSig]
    HRESULT OnMenuSelect([In] uint wID);
    [PreserveSig]
    HRESULT GetPreferredSize([In] ref SIZE pszDefault, [Out] out SIZE psz);
    [PreserveSig]
    HRESULT DrawBitmap([In] int bmWidth, [In] int bmHeight, [In] uint dwFlags, [Out] out HBITMAP phbmp, [Out] out HBITMAP phbmpMask);
    [PreserveSig]
    HRESULT GetText([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrText);
  }

  [ComImport, Guid("28C7F1D0-DE25-11D2-AFDD-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfLangBarItemButton : ITfLangBarItem
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetInfo([Out] out TF_LANGBARITEMINFO pInfo);
    [PreserveSig]
    new HRESULT GetStatus([Out] out TF_LBI_STATUS pdwStatus);
    [PreserveSig]
    new HRESULT Show([In] int fShow);
    [PreserveSig]
    new HRESULT GetTooltipString([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrToolTip);
    #endregion
    [PreserveSig]
    HRESULT OnClick([In] TfLBIClick click, [In] POINT pt, [In] ref RECT prcArea);
    [PreserveSig]
    HRESULT InitMenu([In, MarshalAs(UnmanagedType.Interface)] ITfMenu pMenu);
    [PreserveSig]
    HRESULT OnMenuSelect([In] uint wID);
    [PreserveSig]
    HRESULT GetIcon([Out] out HICON phIcon);
    [PreserveSig]
    HRESULT GetText([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrText);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("BA468C55-9956-4FB1-A59D-52A7DD7CC6AA"), CoClass(typeof(TF_LangBarItemMgr))]
  public interface ITfLangBarItemMgr
  {
    [PreserveSig]
    HRESULT EnumItems([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLangBarItems ppEnum);
    [PreserveSig]
    HRESULT GetItem([In] ref Guid rguid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfLangBarItem ppItem);
    [PreserveSig]
    HRESULT AddItem([In, MarshalAs(UnmanagedType.Interface)] ITfLangBarItem punk);
    [PreserveSig]
    HRESULT RemoveItem([In, MarshalAs(UnmanagedType.Interface)] ITfLangBarItem punk);
    [PreserveSig]
    HRESULT AdviseItemSink([In, MarshalAs(UnmanagedType.Interface)] ITfLangBarItemSink punk, [Out] out uint pdwCookie, [In] ref Guid rguidItem);
    [PreserveSig]
    HRESULT UnadviseItemSink([In] uint dwCookie);
    [PreserveSig]
    HRESULT GetItemFloatingRect([In] uint dwThreadId, [In] ref Guid rguid, [Out] out RECT prc);
    [PreserveSig]
    HRESULT GetItemsStatus([In] uint ulCount, [In] ref Guid prgguid, [Out] out uint pdwStatus);
    [PreserveSig]
    HRESULT GetItemNum([Out] out uint pulCount);
    [PreserveSig]
    HRESULT GetItems([In] uint ulCount, [Out, MarshalAs(UnmanagedType.Interface)] out ITfLangBarItem ppItem, [Out] out TF_LANGBARITEMINFO pInfo, [Out] out uint pdwStatus, [In, Out] ref uint pcFetched);
    [PreserveSig]
    HRESULT AdviseItemsSink([In] uint ulCount, [In, MarshalAs(UnmanagedType.Interface)] ref ITfLangBarItemSink ppunk, [In] ref Guid pguidItem, [Out] out uint pdwCookie);
    [PreserveSig]
    HRESULT UnadviseItemsSink([In] uint ulCount, [In] ref uint pdwCookie);
  }

  [ComImport, Guid("57DBE1A0-DE25-11D2-AFDD-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfLangBarItemSink
  {
    [PreserveSig]
    HRESULT OnUpdate([In] TF_LBI dwFlags);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("87955690-E627-11D2-8DDB-00105A2799B5"), CoClass(typeof(TF_LangBarMgr))]
  public interface ITfLangBarMgr
  {
    [PreserveSig]
    HRESULT AdviseEventSink([In, MarshalAs(UnmanagedType.Interface)] ITfLangBarEventSink pSink, [In] HWND hwnd, [In] uint dwFlags, [In] ref uint pdwCookie);
    [PreserveSig]
    HRESULT UnadviseEventSink([In] uint dwCookie);
    [PreserveSig]
    HRESULT GetThreadMarshalInterface([In] uint dwThreadId, [In] uint dwType, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    HRESULT GetThreadLangBarItemMgr([In] uint dwThreadId, [Out, MarshalAs(UnmanagedType.Interface)] out ITfLangBarItemMgr pplbi, [Out] out uint pdwThreadid);
    [PreserveSig]
    HRESULT GetInputProcessorProfiles([In] uint dwThreadId, [Out, MarshalAs(UnmanagedType.Interface)] out ITfInputProcessorProfiles ppaip, [Out] out uint pdwThreadid);
    [PreserveSig]
    HRESULT RestoreLastFocus([Out] out uint pdwThreadid, [In] int fPrev);
    [PreserveSig]
    HRESULT SetModalInput([In, MarshalAs(UnmanagedType.Interface)] ITfLangBarEventSink pSink, [In] uint dwThreadId, [In] uint dwFlags);
    [PreserveSig]
    HRESULT ShowFloating([In] TF_SFT dwFlags);
    [PreserveSig]
    HRESULT GetShowFloatingStatus([Out] out TF_SFT pdwFlags);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("43C9FE15-F494-4C17-9DE2-B8A4AC350AA8")]
  public interface ITfLanguageProfileNotifySink
  {
    [PreserveSig]
    HRESULT OnLanguageChange([In] LangID langid, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccept);
    [PreserveSig]
    HRESULT OnLanguageChanged();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("D4236675-A5BF-4570-9D42-5D6D7B02D59B")]
  public interface ITfLMLattice
  {
    [PreserveSig]
    HRESULT QueryType([In] ref Guid rguidType, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfSupported);
    [PreserveSig]
    HRESULT EnumLatticeElements([In] uint dwFrameStart, [In] ref Guid rguidType, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfLatticeElements ppEnum);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6F8A98E4-AAA0-4F15-8C5B-07E0DF0A3DD8")]
  public interface ITfMenu
  {
    [PreserveSig]
    HRESULT AddMenuItem([In] uint uId, [In] TF_LBMENUF dwFlags, [In] HBITMAP hbmp, [In] HBITMAP hbmpMask, [MarshalAs(UnmanagedType.LPWStr)] string pch, [In] uint cch, [In, Out, MarshalAs(UnmanagedType.Interface)] ref ITfMenu ppMenu);
  }

  [ComImport, Guid("8F1B8AD8-0B6B-4874-90C5-BD76011E8F7C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfMessagePump
  {
    [PreserveSig]
    HRESULT PeekMessageA([Out] out MSG pMsg, [In] HWND hwnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax, [In] uint wRemoveMsg, [Out] out int pfResult);
    [PreserveSig]
    HRESULT GetMessageA([Out] out MSG pMsg, [In] HWND hwnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax, [Out] out int pfResult);
    [PreserveSig]
    HRESULT PeekMessageW([Out] out MSG pMsg, [In] HWND hwnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax, [In] uint wRemoveMsg, [Out] out int pfResult);
    [PreserveSig]
    HRESULT GetMessageW([Out] out MSG pMsg, [In] HWND hwnd, [In] uint wMsgFilterMin, [In] uint wMsgFilterMax, [Out] out int pfResult);
  }

  [ComImport, Guid("A1ADAAA2-3A24-449D-AC96-5183E7F5C217"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfMouseSink
  {
    [PreserveSig]
    HRESULT OnMouseEvent([In] uint uEdge, [In] uint uQuadrant, [In] uint dwBtnStatus, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEaten);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("09D146CD-A544-4132-925B-7AFA8EF322D0")]
  public interface ITfMouseTracker
  {
    [PreserveSig]
    HRESULT AdviseMouseSink([In, MarshalAs(UnmanagedType.Interface)] ITfRange range, [In, MarshalAs(UnmanagedType.Interface)] ITfMouseSink pSink, [Out] out uint pdwCookie);
    [PreserveSig]
    HRESULT UnadviseMouseSink([In] uint dwCookie);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("3BDD78E2-C16E-47FD-B883-CE6FACC1A208")]
  public interface ITfMouseTrackerACP
  {
    [PreserveSig]
    HRESULT AdviseMouseSink([In, MarshalAs(UnmanagedType.Interface)] ITfRangeACP range, [In, MarshalAs(UnmanagedType.Interface)] ITfMouseSink pSink, [Out] out uint pdwCookie);
    [PreserveSig]
    HRESULT UnadviseMouseSink([In] uint dwCookie);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("4EF89150-0807-11D3-8DF0-00105A2799B5")]
  public interface ITfPersistentPropertyLoaderACP
  {
    [PreserveSig]
    HRESULT LoadProperty([In] ref TF_PERSISTENT_PROPERTY_HEADER_ACP pHdr, [Out, MarshalAs(UnmanagedType.Interface)] out IStream ppStream);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6F77C993-D2B1-446E-853E-5912EFC8A286")]
  public interface ITfPreservedKeyNotifySink
  {
    [PreserveSig]
    HRESULT OnUpdated([In] ref TF_PRESERVEDKEY pprekey);
  }

  [ComImport, Guid("E2449660-9542-11D2-BF46-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfProperty : ITfReadOnlyProperty
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetType([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT EnumRanges([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfRanges ppEnum, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pTargetRange);
    [PreserveSig]
    new HRESULT GetValue([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Struct)] out object pvarValue);
    [PreserveSig]
    new HRESULT GetContext([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppContext);
    #endregion
    [PreserveSig]
    HRESULT FindRange([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppRange, [In] TfAnchor aPos);
    [PreserveSig]
    HRESULT SetValueStore([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, MarshalAs(UnmanagedType.Interface)] ITfPropertyStore pPropStore);
    [PreserveSig]
    HRESULT SetValue([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In, MarshalAs(UnmanagedType.Struct)] ref object pvarValue);
    [PreserveSig]
    HRESULT Clear([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
  }

  [ComImport, Guid("6834B120-88CB-11D2-BF45-00105A2799B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfPropertyStore
  {
    [PreserveSig]
    HRESULT GetType([Out] out Guid pguid);
    [PreserveSig]
    HRESULT GetDataType([Out] out uint pdwReserved);
    [PreserveSig]
    HRESULT GetData([Out, MarshalAs(UnmanagedType.Struct)] out object pvarValue);
    [PreserveSig]
    HRESULT OnTextUpdated([In] uint dwFlags, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRangeNew, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfAccept);
    [PreserveSig]
    HRESULT Shrink([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRangeNew, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfFree);
    [PreserveSig]
    HRESULT Divide([In, MarshalAs(UnmanagedType.Interface)] ITfRange pRangeThis, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRangeNew, [Out, MarshalAs(UnmanagedType.Interface)] out ITfPropertyStore ppPropStore);
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out ITfPropertyStore pPropStore);
    [PreserveSig]
    HRESULT GetPropertyRangeCreator([Out] out Guid pclsid);
    [PreserveSig]
    HRESULT Serialize([In, MarshalAs(UnmanagedType.Interface)] IStream pStream, [Out] out uint pcb);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("0FAB9BDB-D250-4169-84E5-6BE118FDD7A8")]
  public interface ITfQueryEmbedded
  {
    [PreserveSig]
    HRESULT QueryInsertEmbedded([In] ref Guid pguidService, [In] ref FORMATETC pformatetc, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertable);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("AA80E7FF-2021-11D2-93E0-0060B067B86E")]
  public interface ITfRange
  {
    [PreserveSig]
    HRESULT GetText([In] TfEditCookie ec, [In] TF_TF dwFlags, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] out char[] pchText, [In] uint cchMax, [Out] out uint pcch);
    [PreserveSig]
    HRESULT SetText([In] TfEditCookie ec, [In] TF_ST dwFlags, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] int cch);
    [PreserveSig]
    HRESULT GetFormattedText([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);
    [PreserveSig]
    HRESULT GetEmbedded([In] TfEditCookie ec, [In] ref Guid rguidService, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    HRESULT InsertEmbedded([In] TfEditCookie ec, [In] TF_IE dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject);
    [PreserveSig]
    HRESULT ShiftStart([In] TfEditCookie ec, [In] int cchReq, [Out] out int pcch, [In] ref TF_HALTCOND pHalt);
    [PreserveSig]
    HRESULT ShiftEnd([In] TfEditCookie ec, [In] int cchReq, [Out] out int pcch, [In] ref TF_HALTCOND pHalt);
    [PreserveSig]
    HRESULT ShiftStartToRange([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In] TfAnchor aPos);
    [PreserveSig]
    HRESULT ShiftEndToRange([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In] TfAnchor aPos);
    [PreserveSig]
    HRESULT ShiftStartRegion([In] TfEditCookie ec, [In] TfShiftDir dir, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfNoRegion);
    [PreserveSig]
    HRESULT ShiftEndRegion([In] TfEditCookie ec, [In] TfShiftDir dir, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfNoRegion);
    [PreserveSig]
    HRESULT IsEmpty([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEmpty);
    [PreserveSig]
    HRESULT Collapse([In] TfEditCookie ec, [In] TfAnchor aPos);
    [PreserveSig]
    HRESULT IsEqualStart([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
    [PreserveSig]
    HRESULT IsEqualEnd([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
    [PreserveSig]
    HRESULT CompareStart([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out] out int plResult);
    [PreserveSig]
    HRESULT CompareEnd([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out] out int plResult);
    [PreserveSig]
    HRESULT AdjustForInsert([In] TfEditCookie ec, [In] uint cchInsert, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertOk);
    [PreserveSig]
    HRESULT GetGravity([Out] out TfGravity pgStart, [Out] out TfGravity pgEnd);
    [PreserveSig]
    HRESULT SetGravity([In] TfEditCookie ec, [In] TfGravity gStart, [In] TfGravity gEnd);
    [PreserveSig]
    HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppClone);
    [PreserveSig]
    HRESULT GetContext([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppContext);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("057A6296-029B-4154-B79A-0D461D4EA94C")]
  public interface ITfRangeACP : ITfRange
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetText([In] TfEditCookie ec, [In] TF_TF dwFlags, [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] out char[] pchText, [In] uint cchMax, [Out] out uint pcch);
    [PreserveSig]
    new HRESULT SetText([In] TfEditCookie ec, [In] TF_ST dwFlags, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 3)] char[] pchText, [In] int cch);
    [PreserveSig]
    new HRESULT GetFormattedText([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out IDataObject ppDataObject);
    [PreserveSig]
    new HRESULT GetEmbedded([In] TfEditCookie ec, [In] ref Guid rguidService, [In] ref Guid riid, [Out, MarshalAs(UnmanagedType.IUnknown)] out object ppunk);
    [PreserveSig]
    new HRESULT InsertEmbedded([In] TfEditCookie ec, [In] TF_IE dwFlags, [In, MarshalAs(UnmanagedType.Interface)] IDataObject pDataObject);
    [PreserveSig]
    new HRESULT ShiftStart([In] TfEditCookie ec, [In] int cchReq, [Out] out int pcch, [In] ref TF_HALTCOND pHalt);
    [PreserveSig]
    new HRESULT ShiftEnd([In] TfEditCookie ec, [In] int cchReq, [Out] out int pcch, [In] ref TF_HALTCOND pHalt);
    [PreserveSig]
    new HRESULT ShiftStartToRange([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In] TfAnchor aPos);
    [PreserveSig]
    new HRESULT ShiftEndToRange([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [In] TfAnchor aPos);
    [PreserveSig]
    new HRESULT ShiftStartRegion([In] TfEditCookie ec, [In] TfShiftDir dir, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfNoRegion);
    [PreserveSig]
    new HRESULT ShiftEndRegion([In] TfEditCookie ec, [In] TfShiftDir dir, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfNoRegion);
    [PreserveSig]
    new HRESULT IsEmpty([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEmpty);
    [PreserveSig]
    new HRESULT Collapse([In] TfEditCookie ec, [In] TfAnchor aPos);
    [PreserveSig]
    new HRESULT IsEqualStart([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
    [PreserveSig]
    new HRESULT IsEqualEnd([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfEqual);
    [PreserveSig]
    new HRESULT CompareStart([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out] out int plResult);
    [PreserveSig]
    new HRESULT CompareEnd([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pWith, [In] TfAnchor aPos, [Out] out int plResult);
    [PreserveSig]
    new HRESULT AdjustForInsert([In] TfEditCookie ec, [In] uint cchInsert, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfInsertOk);
    [PreserveSig]
    new HRESULT GetGravity([Out] out TfGravity pgStart, [Out] out TfGravity pgEnd);
    [PreserveSig]
    new HRESULT SetGravity([In] TfEditCookie ec, [In] TfGravity gStart, [In] TfGravity gEnd);
    [PreserveSig]
    new HRESULT Clone([Out, MarshalAs(UnmanagedType.Interface)] out ITfRange ppClone);
    [PreserveSig]
    new HRESULT GetContext([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppContext);
    #endregion
    [PreserveSig]
    HRESULT GetExtent([Out] out int pacpAnchor, [Out] out int pcch);
    [PreserveSig]
    HRESULT SetExtent([In] int acpAnchor, [In] int cch);
  }

  [ComImport, Guid("463A506D-6992-49D2-9B88-93D55E70BB16"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfRangeBackup
  {
    [PreserveSig]
    HRESULT Restore([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange);
  }

  [ComImport, Guid("EA1EA139-19DF-11D7-A6D2-00065B84435C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfReadingInformationUIElement : ITfUIElement
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    new HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    new HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
    #endregion
    [PreserveSig]
    HRESULT GetUpdatedFlags([Out] out TF_RIUIE pdwFlags);
    [PreserveSig]
    HRESULT GetContext([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppic);
    [PreserveSig]
    HRESULT GetString([Out, MarshalAs(UnmanagedType.BStr)] out string pstr);
    [PreserveSig]
    HRESULT GetMaxReadingStringLength([Out] out uint pcchMax);
    [PreserveSig]
    HRESULT GetErrorIndex([Out] out uint pErrorIndex);
    [PreserveSig]
    HRESULT IsVerticalOrderPreferred([Out, MarshalAs(UnmanagedType.Bool)] out bool pfVertical);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("17D49A3D-F8B8-4B2F-B254-52319DD64C53")]
  public interface ITfReadOnlyProperty
  {
    [PreserveSig]
    HRESULT GetType([Out] out Guid pguid);
    [PreserveSig]
    HRESULT EnumRanges([In] TfEditCookie ec, [Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfRanges ppEnum, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pTargetRange);
    [PreserveSig]
    HRESULT GetValue([In] TfEditCookie ec, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pRange, [Out, MarshalAs(UnmanagedType.Struct)] out object pvarValue);
    [PreserveSig]
    HRESULT GetContext([Out, MarshalAs(UnmanagedType.Interface)] out ITfContext ppContext);
  }

  [ComImport, Guid("4EA48A35-60AE-446F-8FD6-E6A8D82459F7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfSource
  {
    [PreserveSig]
    HRESULT AdviseSink([In] ref Guid riid, [In, MarshalAs(UnmanagedType.IUnknown)] object punk, [Out] out uint pdwCookie);
    [PreserveSig]
    HRESULT UnadviseSink([In] uint dwCookie);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("73131F9C-56A9-49DD-B0EE-D046633F7528")]
  public interface ITfSourceSingle
  {
    [PreserveSig]
    HRESULT AdviseSingleSink([In] TfClientId tid, [In] ref Guid riid, [In, MarshalAs(UnmanagedType.IUnknown)] object punk);
    [PreserveSig]
    HRESULT UnadviseSingleSink([In] TfClientId tid, [In] ref Guid riid);
  }

  [ComImport, Guid("90E9A944-9244-489F-A78F-DE67AFC013A7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfSpeechUIServer
  {
    [PreserveSig]
    HRESULT Initialize();
    [PreserveSig]
    HRESULT ShowUI([In] int fShow);
    [PreserveSig]
    HRESULT UpdateBalloon([In] TfLBBalloonStyle style, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 2)] char[] pch, [In] uint cch);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6B7D8D73-B267-4F69-B32E-1CA321CE4F45")]
  public interface ITfStatusSink
  {
    [PreserveSig]
    HRESULT OnStatusChange([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] uint dwFlags);
  }

  [ComImport, Guid("45672EB9-9059-46A2-838D-4530355F6A77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfSystemDeviceTypeLangBarItem
  {
    [PreserveSig]
    HRESULT SetIconMode([In] TF_DTLBI dwFlags);
    [PreserveSig]
    HRESULT GetIconMode([Out] out TF_DTLBI pdwFlags);
  }

  [ComImport, Guid("1E13E9EC-6B33-4D4A-B5EB-8A92F029F356"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfSystemLangBarItem
  {
    [PreserveSig]
    HRESULT SetIcon([In] ref HICON hIcon);
    [PreserveSig]
    HRESULT SetTooltipString([In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 1)] char[] pchToolTip, [In] uint cch);
  }

  [ComImport, Guid("1449D9AB-13CF-4687-AA3E-8D8B18574396"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfSystemLangBarItemSink
  {
    [PreserveSig]
    HRESULT InitMenu([In, MarshalAs(UnmanagedType.Interface)] ITfMenu pMenu);
    [PreserveSig]
    HRESULT OnMenuSelect([In] uint wID);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("5C4CE0E5-BA49-4B52-AC6B-3B397B4F701F")]
  public interface ITfSystemLangBarItemText
  {
    [PreserveSig]
    HRESULT SetItemText([In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U2, SizeParamIndex = 1)] char[] pch, [In] uint cch);
    [PreserveSig]
    HRESULT GetItemText([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrText);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("8127D409-CCD3-4683-967A-B43D5B482BF7")]
  public interface ITfTextEditSink
  {
    [PreserveSig]
    HRESULT OnEndEdit([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] TfEditCookie ecReadOnly, [In, MarshalAs(UnmanagedType.Interface)] ITfEditRecord pEditRecord);
  }

  [ComImport, Guid("AA80E7F7-2021-11D2-93E0-0060B067B86E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfTextInputProcessor
  {
    [PreserveSig]
    HRESULT Activate([In, MarshalAs(UnmanagedType.Interface)] ITfThreadMgr ptim, [In] TfClientId tid);
    [PreserveSig]
    HRESULT Deactivate();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("6E4E2102-F9CD-433D-B496-303CE03A6507")]
  public interface ITfTextInputProcessorEx : ITfTextInputProcessor
  {
    #region from base interface
    [PreserveSig]
    new HRESULT Activate([In, MarshalAs(UnmanagedType.Interface)] ITfThreadMgr ptim, [In] TfClientId tid);
    [PreserveSig]
    new HRESULT Deactivate();
    #endregion
    [PreserveSig]
    HRESULT ActivateEx([In, MarshalAs(UnmanagedType.Interface)] ITfThreadMgr ptim, [In] TfClientId tid, [In] TF_TMAE dwFlags);
  }

  [ComImport, Guid("2AF2D06A-DD5B-4927-A0B4-54F19C91FADE"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfTextLayoutSink
  {
    [PreserveSig]
    HRESULT OnLayoutChange([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] TfLayoutCode lcode, [In, MarshalAs(UnmanagedType.Interface)] ITfContextView pView);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("C0F1DB0C-3A20-405C-A303-96B6010A885F")]
  public interface ITfThreadFocusSink
  {
    [PreserveSig]
    HRESULT OnSetThreadFocus();
    [PreserveSig]
    HRESULT OnKillThreadFocus();
  }

  [ComImport, Guid("AA80E801-2021-11D2-93E0-0060B067B86E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_ThreadMgr))]
  public interface ITfThreadMgr
  {
    [PreserveSig]
    HRESULT Activate([Out] out TfClientId ptid);
    [PreserveSig]
    HRESULT Deactivate();
    [PreserveSig]
    HRESULT CreateDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
    [PreserveSig]
    HRESULT EnumDocumentMgrs([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDocumentMgrs ppEnum);
    [PreserveSig]
    HRESULT GetFocus([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdimFocus);
    [PreserveSig]
    HRESULT SetFocus([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimFocus);
    [PreserveSig]
    HRESULT AssociateFocus([In] HWND hwnd, [In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimNew, [Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdimPrev);
    [PreserveSig]
    HRESULT IsThreadFocus([Out, MarshalAs(UnmanagedType.Bool)] out bool pfThreadFocus);
    [PreserveSig]
    HRESULT GetFunctionProvider([In] ref Guid clsid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfFunctionProvider ppFuncProv);
    [PreserveSig]
    HRESULT EnumFunctionProviders([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfFunctionProviders ppEnum);
    [PreserveSig]
    HRESULT GetGlobalCompartment([Out, MarshalAs(UnmanagedType.Interface)] out ITfCompartmentMgr ppCompMgr);
  }

  [ComImport, Guid("AA80E80E-2021-11D2-93E0-0060B067B86E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfThreadMgrEventSink
  {
    [PreserveSig]
    HRESULT OnInitDocumentMgr([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdim);
    [PreserveSig]
    HRESULT OnUninitDocumentMgr([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdim);
    [PreserveSig]
    HRESULT OnSetFocus([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimFocus, [In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimPrevFocus);
    [PreserveSig]
    HRESULT OnPushContext([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
    [PreserveSig]
    HRESULT OnPopContext([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic);
  }

  [ComImport, Guid("3E90ADE3-7594-4CB0-BB58-69628F5F458C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_ThreadMgr))]
  public interface ITfThreadMgrEx : ITfThreadMgr
  {
    #region from base interface
    [PreserveSig]
    new HRESULT Activate([Out] out TfClientId ptid);
    [PreserveSig]
    new HRESULT Deactivate();
    [PreserveSig]
    new HRESULT CreateDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
    [PreserveSig]
    new HRESULT EnumDocumentMgrs([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDocumentMgrs ppEnum);
    [PreserveSig]
    new HRESULT GetFocus([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdimFocus);
    [PreserveSig]
    new HRESULT SetFocus([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimFocus);
    [PreserveSig]
    new HRESULT AssociateFocus([In] HWND hwnd, [In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimNew, [Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdimPrev);
    [PreserveSig]
    new HRESULT IsThreadFocus([Out, MarshalAs(UnmanagedType.Bool)] out bool pfThreadFocus);
    [PreserveSig]
    new HRESULT GetFunctionProvider([In] ref Guid clsid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfFunctionProvider ppFuncProv);
    [PreserveSig]
    new HRESULT EnumFunctionProviders([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfFunctionProviders ppEnum);
    [PreserveSig]
    new HRESULT GetGlobalCompartment([Out, MarshalAs(UnmanagedType.Interface)] out ITfCompartmentMgr ppCompMgr);
    #endregion
    [PreserveSig]
    HRESULT ActivateEx([Out] out TfClientId ptid, [In] TF_TMAE dwFlags);
    [PreserveSig]
    HRESULT GetActiveFlags([Out] out TF_TMF lpdwFlags);
  }

  [ComImport, Guid("0ab198ef-6477-4ee8-8812-6780edb82d5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), CoClass(typeof(TF_ThreadMgr))]
  public interface ITfThreadMgr2
  {
    [PreserveSig]
    HRESULT Activate([Out] out TfClientId ptid);
    [PreserveSig]
    HRESULT Deactivate();
    [PreserveSig]
    HRESULT CreateDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
    [PreserveSig]
    HRESULT EnumDocumentMgrs([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfDocumentMgrs ppEnum);
    [PreserveSig]
    HRESULT GetFocus([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdimFocus);
    [PreserveSig]
    HRESULT SetFocus([In, MarshalAs(UnmanagedType.Interface)] ITfDocumentMgr pdimFocus);
    [PreserveSig]
    HRESULT IsThreadFocus([Out, MarshalAs(UnmanagedType.Bool)] out bool pfThreadFocus);
    [PreserveSig]
    HRESULT GetFunctionProvider([In] ref Guid clsid, [Out, MarshalAs(UnmanagedType.Interface)] out ITfFunctionProvider ppFuncProv);
    [PreserveSig]
    HRESULT EnumFunctionProviders([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfFunctionProviders ppEnum);
    [PreserveSig]
    HRESULT GetGlobalCompartment([Out, MarshalAs(UnmanagedType.Interface)] out ITfCompartmentMgr ppCompMgr);
    [PreserveSig]
    HRESULT ActivateEx([Out] out TfClientId ptid, [In] TF_TMAE dwFlags);
    [PreserveSig]
    HRESULT GetActiveFlags([Out] out TF_TMF lpdwFlags);
    [PreserveSig]
    HRESULT SuspendKeystrokeHandling();
    [PreserveSig]
    HRESULT ResumeKeystrokeHandling();
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("52B18B5C-555D-46B2-B00A-FA680144FBDB")]
  public interface ITfToolTipUIElement : ITfUIElement
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    new HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    new HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
    #endregion
    [PreserveSig]
    HRESULT GetString([Out, MarshalAs(UnmanagedType.BStr)] out string pstr);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("A615096F-1C57-4813-8A15-55EE6E5A839C")]
  public interface ITfTransitoryExtensionSink
  {
    [PreserveSig]
    HRESULT OnTransitoryExtensionUpdated([In, MarshalAs(UnmanagedType.Interface)] ITfContext pic, [In] TfEditCookie ecReadOnly, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pResultRange, [In, MarshalAs(UnmanagedType.Interface)] ITfRange pCompositionRange, [Out, MarshalAs(UnmanagedType.Bool)] out bool pfDeleteResultRange);
  }

  [ComImport, Guid("858F956A-972F-42A2-A2F2-0321E1ABE209"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfTransitoryExtensionUIElement : ITfUIElement
  {
    #region from base interface
    [PreserveSig]
    new HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    new HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    new HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    new HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
    #endregion
    [PreserveSig]
    HRESULT GetDocumentMgr([Out, MarshalAs(UnmanagedType.Interface)] out ITfDocumentMgr ppdim);
  }

  [ComImport, Guid("EA1EA137-19DF-11D7-A6D2-00065B84435C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfUIElement
  {
    [PreserveSig]
    HRESULT GetDescription([Out, MarshalAs(UnmanagedType.BStr)] out string pbstrDescription);
    [PreserveSig]
    HRESULT GetGUID([Out] out Guid pguid);
    [PreserveSig]
    HRESULT Show([In, MarshalAs(UnmanagedType.Bool)] bool bShow);
    [PreserveSig]
    HRESULT IsShown([Out, MarshalAs(UnmanagedType.Bool)] out bool pbShow);
  }

  [ComImport, Guid("EA1EA135-19DF-11D7-A6D2-00065B84435C"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  public interface ITfUIElementMgr
  {
    [PreserveSig]
    HRESULT BeginUIElement([In, MarshalAs(UnmanagedType.Interface)] ITfUIElement pElement, [In, Out, MarshalAs(UnmanagedType.Bool)] ref bool pbShow, [Out] out uint pdwUIElementId);
    [PreserveSig]
    HRESULT UpdateUIElement([In] uint dwUIElementId);
    [PreserveSig]
    HRESULT EndUIElement([In] uint dwUIElementId);
    [PreserveSig]
    HRESULT GetUIElement([In] uint dwUIElementId, [Out, MarshalAs(UnmanagedType.Interface)] out ITfUIElement ppElement);
    [PreserveSig]
    HRESULT EnumUIElements([Out, MarshalAs(UnmanagedType.Interface)] out IEnumTfUIElements ppEnum);
  }

  [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("EA1EA136-19DF-11D7-A6D2-00065B84435C")]
  public interface ITfUIElementSink
  {
    [PreserveSig]
    HRESULT BeginUIElement([In] uint dwUIElementId, [In, Out, MarshalAs(UnmanagedType.Bool)] ref bool pbShow);
    [PreserveSig]
    HRESULT UpdateUIElement([In] uint dwUIElementId);
    [PreserveSig]
    HRESULT EndUIElement([In] uint dwUIElementId);
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct POINT
  {
    public int x;
    public int y;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct RECT
  {
    public int left;
    public int top;
    public int right;
    public int bottom;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct SIZE
  {
    public int cx;
    public int cy;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct MSG
  {
    public IntPtr hwnd;
    public int message;
    public IntPtr wParam;
    public IntPtr lParam;
    public int time;
    public POINT pt;
  }

  [Guid("33D2FE4B-6C24-4F67-8D75-3BC1819E4126")]
  public enum TF_DA_ATTR_INFO
  {
    // Fields
    TF_ATTR_CONVERTED = 2,
    TF_ATTR_FIXEDCONVERTED = 5,
    TF_ATTR_INPUT = 0,
    TF_ATTR_INPUT_ERROR = 4,
    TF_ATTR_OTHER = -1,
    TF_ATTR_TARGET_CONVERTED = 1,
    TF_ATTR_TARGET_NOTCONVERTED = 3
  }

  [StructLayout(LayoutKind.Explicit, Pack = 4), Guid("90D0CB5E-6520-4A0F-B47C-C39BD955F0D6")]
  public struct TF_DA_COLOR
  {
    // Fields
    [FieldOffset(0)]
    internal TF_DA_COLORTYPE type;
    [FieldOffset(4)]
    internal int nIndex;
    [FieldOffset(4)]
    internal uint cr;
  }

  [Guid("D9B92E21-084A-401B-9C64-1E6DAD91A1AB")]
  public enum TF_DA_COLORTYPE
  {
    TF_CT_NONE,
    TF_CT_SYSCOLOR,
    TF_CT_COLORREF
  }

  [Guid("C4CC07F1-80CC-4A7B-BC54-98512782CBE3")]
  public enum TF_DA_LINESTYLE
  {
    TF_LS_NONE,
    TF_LS_SOLID,
    TF_LS_DOT,
    TF_LS_DASH,
    TF_LS_SQUIGGLE
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("1BF1C305-419B-4182-A4D2-9BFADC3F021F")]
  public struct TF_DISPLAYATTRIBUTE
  {
    public TF_DA_COLOR crText;
    public TF_DA_COLOR crBk;
    public TF_DA_LINESTYLE lsStyle;
    public int fBoldLine;
    public TF_DA_COLOR crLine;
    public TF_DA_ATTR_INFO bAttr;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("49930D51-7D93-448C-A48C-FEA5DAC192B1")]
  public struct TF_HALTCOND
  {
    [MarshalAs(UnmanagedType.Interface)]
    public ITfRange pHaltRange;
    public TfAnchor aHaltPos;
    public TF_HF dwFlags;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("44D2825A-10E5-43B2-877F-6CB2F43B7E7E")]
  public struct TF_INPUTPROCESSORPROFILE
  {
    public TF_PROFILETYPE dwProfileType;
    public LangID langid;
    public Guid clsid;
    public Guid guidProfile;
    public Guid catid;
    public HKL hklSubstitute;
    public TF_IPP_CAPS dwCaps;
    public HKL HKL;
    public TF_IPP_FLAG dwFlags;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode), Guid("12A1D29F-A065-440C-9746-EB2002C8BD19")]
  public struct TF_LANGBARITEMINFO
  {
    public Guid clsidService;
    public Guid guidItem;
    public TF_LBI_STYLE dwStyle;
    public uint ulSort;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = LangBarDeclarations.TF_LBI_DESC_MAXLEN)]
    public string szDescription;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("E1B5808D-1E46-4C19-84DC-68C5F5978CC8")]
  public struct TF_LANGUAGEPROFILE
  {
    public Guid clsid;
    public LangID langid;
    public Guid catid;
    public int fActive;
    public Guid guidProfile;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("37574483-5C50-4092-A55C-922E3A67E5B8")]
  public struct TF_LBBALLOONINFO
  {
    public TfLBBalloonStyle style;
    [MarshalAs(UnmanagedType.BStr)]
    public string bstrText;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("1B646EFE-3CE3-4CE2-B41F-35B93FE5552F")]
  public struct TF_LMLATTELEMENT
  {
    // Fields
    internal uint dwFrameStart;
    internal uint dwFrameLen;
    internal uint dwFlags;
    internal int iCost;
    [MarshalAs(UnmanagedType.BStr)]
    internal string bstrText;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("E26D9E1D-691E-4F29-90D7-338DCF1F8CEF")]
  public struct TF_PERSISTENT_PROPERTY_HEADER_ACP
  {
    public Guid guidType;
    public int ichStart;
    public int cch;
    public uint cb;
    public uint dwPrivate;
    public Guid clsidTIP;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("77C12F95-B783-450D-879F-1CD2362C6521")]
  public struct TF_PRESERVEDKEY
  {
    public uint uVKey;
    public TF_MOD uModifiers;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 8), Guid("D678C645-EB6A-45C9-B4EE-0F3E3A991348")]
  public struct TF_PROPERTYVAL
  {
    public Guid guidId;
    [MarshalAs(UnmanagedType.Struct)]
    public object varValue;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("75EB22F2-B0BF-46A8-8006-975A3B6EFCF1")]
  public struct TF_SELECTION
  {
    [MarshalAs(UnmanagedType.Interface)]
    public ITfRange range;
    public TF_SELECTIONSTYLE style;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("36AE42A4-6989-4BDC-B48A-6137B7BF2E42")]
  public struct TF_SELECTIONSTYLE
  {
    public TfActiveSelEnd ase;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fInterimChar;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("BC7D979A-846A-444D-AFEF-0A9BFA82B961")]
  public struct TF_STATUS
  {
    public TF_SD_DYNAMIC dwDynamicFlags;
    public TF_SD_STATIC dwStaticFlags;
  }

  [Guid("1690BE9B-D3E9-49F6-8D8B-51B905AF4C43")]
  public enum TfActiveSelEnd : uint
  {
    TF_AE_NONE,
    TF_AE_START,
    TF_AE_END
  }

  [Guid("5A886226-AE9A-489B-B991-2B1E25EE59A9")]
  public enum TfAnchor : uint
  {
    TF_ANCHOR_START,
    TF_ANCHOR_END
  }

  [Guid("BAA898F2-0207-4643-92CA-F3F7B0CF6F80")]
  public enum TfCandidateResult : uint
  {
    CAND_FINALIZED,
    CAND_SELECTED,
    CAND_CANCELED
  }

  [Guid("CF610F06-2882-46F6-ABE5-298568B664C4")]
  public enum TfGravity : uint
  {
    TF_GRAVITY_BACKWARD,
    TF_GRAVITY_FORWARD
  }

  [Guid("603553CF-9EDD-4CC1-9ECC-069E4A427734")]
  public enum TfLayoutCode : uint
  {
    TF_LC_CREATE,
    TF_LC_CHANGE,
    TF_LC_DESTROY
  }

  [Guid("F399A969-9E97-4DDD-B974-2BFB934CFBC9")]
  public enum TfLBBalloonStyle : uint
  {
    TF_LB_BALLOON_RECO,
    TF_LB_BALLOON_SHOW,
    TF_LB_BALLOON_MISS
  }

  [Guid("8FB5F0CE-DFDD-4F0A-85B9-8988D8DD8FF2")]
  public enum TfLBIClick : uint
  {
    TF_LBI_CLK_LEFT = 2,
    TF_LBI_CLK_RIGHT = 1
  }

  [Guid("36ADB6D9-DA1F-45D8-A499-86167E0F936B")]
  public enum TfSapiObject : uint
  {
    GETIF_RESMGR,
    GETIF_RECOCONTEXT,
    GETIF_RECOGNIZER,
    GETIF_VOICE,
    GETIF_DICTGRAM,
    GETIF_RECOGNIZERNOINIT
  }

  [Guid("1E512533-BBDC-4530-9A8E-A1DC0AF67468")]
  public enum TfShiftDir : uint
  {
    TF_SD_BACKWARD,
    TF_SD_FORWARD
  }

  [StructLayout(LayoutKind.Sequential, Pack = 8), Guid("2CC2B33F-1174-4507-B8D9-5BC0EB37C197")]
  public struct TS_ATTRVAL
  {
    public TS_ATTRID idAttr;
    public uint dwOverlapId;
    [MarshalAs(UnmanagedType.Struct)]
    public object varValue;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("A6231949-37C5-4B74-A24E-2A26C327201D")]
  public struct TS_RUNINFO
  {
    public uint uCount;
    public TsRunType type;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("C4B9C33B-8A0D-4426-BEBE-D444A4701FE9")]
  public struct TS_SELECTION_ACP
  {
    public int acpStart;
    public int acpEnd;
    public TS_SELECTIONSTYLE style;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("B03413D2-0723-4C4E-9E08-2E9C1FF3772B")]
  public struct TS_SELECTION_ANCHOR
  {
    [MarshalAs(UnmanagedType.Interface)]
    public IAnchor paStart;
    [MarshalAs(UnmanagedType.Interface)]
    public IAnchor paEnd;
    public TS_SELECTIONSTYLE style;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("7ECC3FFA-8F73-4D91-98ED-76F8AC5B1600")]
  public struct TS_SELECTIONSTYLE
  {
    public TsActiveSelEnd ase;
    [MarshalAs(UnmanagedType.Bool)]
    public bool fInterimChar;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("FEC4F516-C503-45B1-A5FD-7A3D8AB07049")]
  public struct TS_STATUS
  {
    public TS_SD dwDynamicFlags;
    public TS_SS dwStaticFlags;
  }

  [StructLayout(LayoutKind.Sequential, Pack = 4), Guid("F3181BD6-BCF0-41D3-A81C-474B17EC38FB")]
  public struct TS_TEXTCHANGE
  {
    public int acpStart;
    public int acpOldEnd;
    public int acpNewEnd;
  }

  [Guid("05FCF85B-5E9C-4C3E-AB71-29471D4F38E7")]
  public enum TsActiveSelEnd : uint
  {
    TS_AE_NONE,
    TS_AE_START,
    TS_AE_END
  }

  [Guid("DAA8601E-7695-426F-9BB7-498A6AA64B68")]
  public enum TsGravity : uint
  {
    TS_GR_BACKWARD,
    TS_GR_FORWARD
  }

  [Guid("7899D7C4-5F07-493C-A89A-FAC8E777F476")]
  public enum TsLayoutCode : uint
  {
    TS_LC_CREATE,
    TS_LC_CHANGE,
    TS_LC_DESTROY
  }

  [Guid("033B0DF0-F193-4170-B47B-141AFC247878")]
  public enum TsRunType : uint
  {
    TS_RT_PLAIN,
    TS_RT_HIDDEN,
    TS_RT_OPAQUE
  }

  [Guid("898E19DF-4FB4-4AF3-8DAF-9B3C1145C79D")]
  public enum TsShiftDir : uint
  {
    TS_SD_BACKWARD,
    TS_SD_FORWARD
  }

  [Guid("AF8F5D86-0615-4af3-90FA-5DCBB407A5D4")]
  public enum TfIntegratableCandidateListSelectionStyle : uint 
  { 
      STYLE_ACTIVE_SELECTION = 0x0, 
      STYLE_IMPLIED_SELECTION = 0x1 
  }

  [Guid("5F309A41-590A-4ACC-A97F-D8EFFF13FDFC")]
  public enum TKBLayoutType : uint
  {
    TKBLT_UNDEFINED = 0,
    TKBLT_CLASSIC = 1,
    TKBLT_OPTIMIZED = 2,
  }

  public enum TKBLayoutId : ushort
  {
    TKBLT_UNDEFINED = 0,
    TKBL_CLASSIC_TRADITIONAL_CHINESE_PHONETIC = 0x0404,
    TKBL_CLASSIC_TRADITIONAL_CHINESE_CHANGJIE = 0xF042,
    TKBL_CLASSIC_TRADITIONAL_CHINESE_DAYI = 0xF043,
    TKBL_OPT_JAPANESE_ABC = 0x0411,
    TKBL_OPT_KOREAN_HANGUL_2_BULSIK = 0x0412,
    TKBL_OPT_SIMPLIFIED_CHINESE_PINYIN = 0x0804,
    TKBL_OPT_TRADITIONAL_CHINESE_PHONETIC = 0x0404,
  }
}
