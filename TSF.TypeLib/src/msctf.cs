using System;
using System.Runtime.InteropServices;

namespace TSF.TypeLib
{
  public enum ManagerReturnValues : int
  {
    TF_E_ALREADY_EXISTS = unchecked((int)0x80040506),
    TF_E_COMPOSITION_REJECTED = unchecked((int)0x80040508),
    TF_E_DISCONNECTED = unchecked((int)0x80040504),
    TF_E_EMPTYCONTEXT = unchecked((int)0x80040509),
    TF_E_FORMAT = unchecked((int)0x8004020a),
    TF_E_INVALIDPOINT = unchecked((int)0x80040207),
    TF_E_INVALIDPOS = unchecked((int)0x80040200),
    TF_E_INVALIDVIEW = unchecked((int)0x80040505),
    TF_E_LOCKED = unchecked((int)0x80040500),
    TF_E_NOINTERFACE = unchecked((int)0x80040204),
    TF_E_NOLAYOUT = unchecked((int)0x80040206),
    TF_E_NOLOCK = unchecked((int)0x80040201),
    TF_E_NOOBJECT = unchecked((int)0x80040202),
    TF_E_NOPROVIDER = unchecked((int)0x80040503),
    TF_E_NOSELECTION = unchecked((int)0x80040205),
    TF_E_NOSERVICE = unchecked((int)0x80040203),
    TF_E_NOTOWNEDRANGE = unchecked((int)0x80040502),
    TF_E_RANGE_NOT_COVERED = unchecked((int)0x80040507),
    TF_E_READONLY = unchecked((int)0x80040209),
    TF_E_STACKFULL = unchecked((int)0x80040501),
    TF_E_SYNCHRONOUS = unchecked((int)0x80040208),
    TF_S_ASYNC = unchecked((int)0x00040300),
  }

  public enum TKB_ALTERNATES : uint
  {
    TKB_ALTERNATES_STANDARD = 0x00000001,
    TKB_ALTERNATES_FOR_AUTOCORRECTION = 0x00000002,
    TKB_ALTERNATES_FOR_PREDICTION = 0x00000003,
    TKB_ALTERNATES_AUTOCORRECTION_APPLIED = 0x00000004,
  }

  public static partial class Guids
  {
    public static readonly Guid GUID_PROP_ATTRIBUTE = new Guid("34b45670-7526-11d2-a147-00105a2799b5");
    public static readonly Guid GUID_PROP_TEXTOWNER = new Guid("f1e2d520-0969-11d3-8df0-00105a2799b5");
    public static readonly Guid GUID_PROP_LANGID = new Guid("3280ce20-8032-11d2-b603-00105a2799b5");
    public static readonly Guid GUID_PROP_READING = new Guid("5463f7c0-8e31-11d2-bf46-00105a2799b5");
    public static readonly Guid GUID_PROP_COMPOSING = new Guid("e12ac060-af15-11d2-afc5-00105a2799b5");
    public static readonly Guid GUID_PROP_MODEBIAS = new Guid("372e0716-974f-40ac-a088-08cdc92ebfbc");
    public static readonly Guid GUID_PROP_TKB_ALTERNATES = new Guid("70B2A803-968D-462E-B93B-2164C91517F7");

    public static readonly Guid GUID_SYSTEM_FUNCTIONPROVIDER = new Guid("9a698bb0-0f21-11d3-8df1-00105a2799b5");
    public static readonly Guid GUID_APP_FUNCTIONPROVIDER = new Guid("4caef01e-12af-4b0e-9db1-a6ec5b881208");

    public static readonly Guid GUID_INTEGRATIONSTYLE_SEARCHBOX = new Guid("E6D1BD11-82F7-4903-AE21-1A6397CDE2EB");

    public static readonly Guid GUID_COMPARTMENT_KEYBOARD_DISABLED = new Guid("71a5b253-1951-466b-9fbc-9c8808fa84f2");
    public static readonly Guid GUID_COMPARTMENT_KEYBOARD_OPENCLOSE = new Guid("58273aad-01bb-4164-95c6-755ba0b5162d");
    public static readonly Guid GUID_COMPARTMENT_HANDWRITING_OPENCLOSE = new Guid("f9ae2c6b-1866-4361-af72-7aa30948890e");
    public static readonly Guid GUID_COMPARTMENT_SPEECH_DISABLED = new Guid("56c5c607-0703-4e59-8e52-cbc84e8bbe35");
    public static readonly Guid GUID_COMPARTMENT_SPEECH_OPENCLOSE = new Guid("544d6a63-e2e8-4752-bbd1-000960bca083");
    public static readonly Guid GUID_COMPARTMENT_SPEECH_GLOBALSTATE = new Guid("2a54fe8e-0d08-460c-a75d-87035ff436c5");
    public static readonly Guid GUID_COMPARTMENT_PERSISTMENUENABLED = new Guid("575f3783-70c8-47c8-ae5d-91a01a1f7592");
    public static readonly Guid GUID_COMPARTMENT_EMPTYCONTEXT = new Guid("d7487dbf-804e-41c5-894d-ad96fd4eea13");
    public static readonly Guid GUID_COMPARTMENT_TIPUISTATUS = new Guid("148ca3ec-0366-401c-8d75-ed978d85fbc9");
    public static readonly Guid GUID_COMPARTMENT_KEYBOARD_INPUTMODE_CONVERSION = new Guid("ccf05dd8-4a87-11d7-a6e2-00065b84435c");
    public static readonly Guid GUID_COMPARTMENT_KEYBOARD_INPUTMODE_SENTENCE = new Guid("ccf05dd9-4a87-11d7-a6e2-00065b84435c");
    public static readonly Guid GUID_COMPARTMENT_TRANSITORYEXTENSION = new Guid("8be347f5-c7a0-11d7-b408-00065b84435c");
    public static readonly Guid GUID_COMPARTMENT_TRANSITORYEXTENSION_DOCUMENTMANAGER = new Guid("8be347f7-c7a0-11d7-b408-00065b84435c");
    public static readonly Guid GUID_COMPARTMENT_TRANSITORYEXTENSION_PARENT = new Guid("8be347f8-c7a0-11d7-b408-00065b84435c");

    public static readonly Guid GUID_MODEBIAS_NONE = Guid.Empty;
    public static readonly Guid GUID_MODEBIAS_URLHISTORY = new Guid("8b0e54d9-63f2-4c68-84d4-79aee7a59f09");
    public static readonly Guid GUID_MODEBIAS_FILENAME = new Guid("d7f707fe-44c6-4fca-8e76-86ab50c7931b");
    public static readonly Guid GUID_MODEBIAS_READING = new Guid("e31643a3-6466-4cbf-8d8b-0bd4d8545461");
    public static readonly Guid GUID_MODEBIAS_DATETIME = new Guid("f2bdb372-7f61-4039-92ef-1c35599f0222");
    public static readonly Guid GUID_MODEBIAS_NAME = new Guid("fddc10f0-d239-49bf-b8fc-5410caaa427e");
    public static readonly Guid GUID_MODEBIAS_CONVERSATION = new Guid("0f4ec104-1790-443b-95f1-e10f939d6546");
    public static readonly Guid GUID_MODEBIAS_NUMERIC = new Guid("4021766c-e872-48fd-9cee-4ec5c75e16c3");
    public static readonly Guid GUID_MODEBIAS_HIRAGANA = new Guid("d73d316e-9b91-46f1-a280-31597f52c694");
    public static readonly Guid GUID_MODEBIAS_KATAKANA = new Guid("2e0eeddd-3a1a-499e-8543-3c7ee7949811");
    public static readonly Guid GUID_MODEBIAS_HANGUL = new Guid("76ef0541-23b3-4d77-a074-691801ccea17");
    public static readonly Guid GUID_MODEBIAS_CHINESE = new Guid("7add26de-4328-489b-83ae-6493750cad5c");
    public static readonly Guid GUID_MODEBIAS_HALFWIDTHKATAKANA = new Guid("005f6b63-78d4-41cc-8859-485ca821a795");
    public static readonly Guid GUID_MODEBIAS_FULLWIDTHALPHANUMERIC = new Guid("81489fb8-b36a-473d-8146-e4a2258b24ae");
    public static readonly Guid GUID_MODEBIAS_HALFWIDTHALPHANUMERIC = new Guid("c6f24fc0-4479-46ed-938a-6052b1653d3b");
    public static readonly Guid GUID_MODEBIAS_FULLWIDTHHANGUL = new Guid("c01ae6c9-45b5-4fd0-9cb1-9f4cebc39fea");
    public static readonly Guid GUID_TFCAT_CATEGORY_OF_TIP = new Guid("534c48c1-0607-4098-a521-4fc899c73e90");
    public static readonly Guid GUID_TFCAT_TIP_KEYBOARD = new Guid("34745c63-b2f0-4784-8b67-5e12c8701a31");
    public static readonly Guid GUID_TFCAT_TIP_SPEECH = new Guid("b5a73cd1-8355-426b-a161-259808f26b14");
    public static readonly Guid GUID_TFCAT_TIP_HANDWRITING = new Guid("246ecb87-c2f2-4abe-905b-c8b38add2c43");
    public static readonly Guid GUID_TFCAT_TIPCAP_SECUREMODE = new Guid("49d2f9ce-1f5e-11d7-a6d3-00065b84435c");
    public static readonly Guid GUID_TFCAT_TIPCAP_UIELEMENTENABLED = new Guid("49d2f9cf-1f5e-11d7-a6d3-00065b84435c");
    public static readonly Guid GUID_TFCAT_TIPCAP_INPUTMODECOMPARTMENT = new Guid("ccf05dd7-4a87-11d7-a6e2-00065b84435c");
    public static readonly Guid GUID_TFCAT_TIPCAP_COMLESS = new Guid("364215d9-75bc-11d7-a6ef-00065b84435c");
    public static readonly Guid GUID_TFCAT_TIPCAP_WOW16 = new Guid("364215da-75bc-11d7-a6ef-00065b84435c");
    public static readonly Guid GUID_TFCAT_TIPCAP_IMMERSIVESUPPORT = new Guid("13A016DF-560B-46CD-947A-4C3AF1E0E35D");
    public static readonly Guid GUID_TFCAT_TIPCAP_SYSTRAYSUPPORT = new Guid("13A016DF-560B-46CD-947A-4C3AF1E0E35D");
    public static readonly Guid GUID_TFCAT_PROP_AUDIODATA = new Guid("9b7be3a9-e8ab-4d47-a8fe-254fa423436d");
    public static readonly Guid GUID_TFCAT_PROP_INKDATA = new Guid("7c6a82ae-b0d7-4f14-a745-14f28b009d61");
    public static readonly Guid GUID_TFCAT_PROPSTYLE_CUSTOM = new Guid("25504FB4-7BAB-4BC1-9C69-CF81890F0EF5");
    public static readonly Guid GUID_TFCAT_PROPSTYLE_STATIC = new Guid("565fb8d8-6bd4-4ca1-b223-0f2ccb8f4f96");
    public static readonly Guid GUID_TFCAT_PROPSTYLE_STATICCOMPACT = new Guid("85f9794b-4d19-40d8-8864-4e747371a66d");
    public static readonly Guid GUID_TFCAT_DISPLAYATTRIBUTEPROVIDER = new Guid("046b8c80-1647-40f7-9b21-b93b81aabc1b");
    public static readonly Guid GUID_TFCAT_DISPLAYATTRIBUTEPROPERTY = new Guid("b95f181b-ea4c-4af1-8056-7c321abbb091");
  }

  public static class TextFrameworkDeclarations
  {
    public static readonly uint TF_CLIENTID_NULL = 0;
    public static readonly uint TF_INVALID_GUIDATOM = 0;
    [Obsolete("Not used.")]
    public static readonly uint TF_US_HIDETIPUI = 0x00000001;
    public static readonly string TF_PROCESS_ATOM = "_CTF_PROCESS_ATOM_";
    public static readonly string TF_ENABLE_PROCESS_ATOM = "_CTF_ENABLE_PROCESS_ATOM_";
    public static readonly uint TF_INVALID_UIELEMENTID = unchecked((uint)-1);
    public static readonly uint TF_INVALID_COOKIE = unchecked((uint)-1);
  }

  [Flags]
  public enum TF_POPF : uint
  {
    TF_POPF_ALL = 0x1
  }

  [Flags]
  public enum TF_IPSINK_FLAG : uint
  {
    TF_IPSINK_FLAG_ACTIVE = 0x0001,
  }

  [Flags]
  public enum TF_PROFILETYPE : uint
  {
    TF_PROFILETYPE_INPUTPROCESSOR = 0x0001,
    TF_PROFILETYPE_KEYBOARDLAYOUT = 0x0002,
  }

  [Flags]
  public enum TF_URP : uint
  {
    TF_URP_ALLPROFILES = 0x00000002,
    TF_URP_LOCALPROCESS = 0x00000004,
    TF_URP_LOCALTHREAD = 0x00000008,
  }

  [Flags]
  public enum TF_RP : uint
  {
    TF_RP_HIDDENINSETTINGUI = 0x00000002,
    TF_RP_LOCALPROCESS = 0x00000004,
    TF_RP_LOCALTHREAD = 0x00000008,
    TF_RP_SUBITEMINSETTINGUI = 0x00000010,
  }

  [Flags]
  public enum TF_IPPMF : uint
  {
    TF_IPPMF_FORPROCESS = 0x10000000,
    TF_IPPMF_FORSESSION = 0x20000000,
    TF_IPPMF_FORSYSTEMALL = 0x40000000,
    TF_IPPMF_ENABLEPROFILE = 0x00000001,
    TF_IPPMF_DISABLEPROFILE = 0x00000002,
    TF_IPPMF_DONTCARECURRENTINPUTLANGUAGE = 0x00000004,
  }

  [Flags]
  public enum TF_IPP_CAPS : uint
  {
    TF_IPP_CAPS_DISABLEONTRANSITORY = 0x00000001,
    TF_IPP_CAPS_SECUREMODESUPPORT = 0x00000002,
    TF_IPP_CAPS_UIELEMENTENABLED = 0x00000004,
    TF_IPP_CAPS_COMLESSSUPPORT = 0x00000008,
    TF_IPP_CAPS_WOW16SUPPORT = 0x00000010,
    TF_IPP_CAPS_IMMERSIVESUPPORT = 0x00010000,
    TF_IPP_CAPS_SYSTRAYSUPPORT = 0x00020000,
  }

  [Flags]
  public enum TF_RCM : uint
  {
    TF_RCM_COMLESS = 0x00000001,
    TF_RCM_VKEY = 0x00000002,
    TF_RCM_HINT_READING_LENGTH = 0x00000004,
    TF_RCM_HINT_COLLISION = 0x00000008,
  }

  [Flags]
  public enum TF_RIP_FLAG : uint
  {
    TF_RIP_FLAG_FREEUNUSEDLIBRARIES = 0x00000001,
  }

  [Flags]
  public enum TF_IPP_FLAG : uint
  {
    TF_IPP_FLAG_ACTIVE = 0x00000001,
    TF_IPP_FLAG_ENABLED = 0x00000002,
    TF_IPP_FLAG_SUBSTITUTEDBYINPUTPROCESSOR = 0x00000004,
  }

  [Flags]
  public enum TF_TRANSITORYEXTENSION : uint
  {
    TF_TRANSITORYEXTENSION_NONE = 0x0000,
    TF_TRANSITORYEXTENSION_FLOATING = 0x0001,
    TF_TRANSITORYEXTENSION_ATSELECTION = 0x0002,
  }

  [Flags]
  public enum TF_CONVERSIONMODE : uint
  {
    TF_CONVERSIONMODE_ALPHANUMERIC = 0x0000,
    TF_CONVERSIONMODE_NATIVE = 0x0001,
    TF_CONVERSIONMODE_KATAKANA = 0x0002,
    TF_CONVERSIONMODE_FULLSHAPE = 0x0008,
    TF_CONVERSIONMODE_ROMAN = 0x0010,
    TF_CONVERSIONMODE_CHARCODE = 0x0020,
    TF_CONVERSIONMODE_SOFTKEYBOARD = 0x0080,
    TF_CONVERSIONMODE_NOCONVERSION = 0x0100,
    TF_CONVERSIONMODE_EUDC = 0x0200,
    TF_CONVERSIONMODE_SYMBOL = 0x0400,
    TF_CONVERSIONMODE_FIXED = 0x0800,
  }

  [Flags]
  public enum TF_SENTENCEMODE : uint
  {
    TF_SENTENCEMODE_NONE = 0x0000,
    TF_SENTENCEMODE_PLAURALCLAUSE = 0x0001,
    TF_SENTENCEMODE_SINGLECONVERT = 0x0002,
    TF_SENTENCEMODE_AUTOMATIC = 0x0004,
    TF_SENTENCEMODE_PHRASEPREDICT = 0x0008,
    TF_SENTENCEMODE_CONVERSATION = 0x0010,
  }

  [Flags]
  public enum TF_RIUIE : uint
  {
    TF_RIUIE_CONTEXT = 0x00000001,
    TF_RIUIE_STRING = 0x00000002,
    TF_RIUIE_MAXREADINGSTRINGLENGTH = 0x00000004,
    TF_RIUIE_ERRORINDEX = 0x00000008,
    TF_RIUIE_VERTICALORDER = 0x00000010,
  }

  [Flags]
  public enum TF_CLUIE
  {
    TF_CLUIE_DOCUMENTMGR = 0x00000001,
    TF_CLUIE_COUNT = 0x00000002,
    TF_CLUIE_SELECTION = 0x00000004,
    TF_CLUIE_STRING = 0x00000008,
    TF_CLUIE_PAGEINDEX = 0x00000010,
    TF_CLUIE_CURRENTPAGE = 0x00000020,
  }

  [Flags]
  public enum TF_DISABLE
  {
    TF_DISABLE_SPEECH = 0x00000001,
    TF_DISABLE_DICTATION = 0x00000002,
    TF_DISABLE_COMMANDING = 0x00000004,
  }

  [Flags]
  public enum TF_TMAE : uint
  {
    TF_TMAE_NOACTIVATETIP = 0x00000001,
    TF_TMAE_SECUREMODE = 0x00000002,
    TF_TMAE_UIELEMENTENABLEDONLY = 0x00000004,
    TF_TMAE_COMLESS = 0x00000008,
    TF_TMAE_WOW16 = 0x00000010,
    TF_TMAE_NOACTIVATEKEYBOARDLAYOUT = 0x00000020,
    TF_TMAE_CONSOLE = 0x00000040,
  }

  [Flags]
  public enum TF_TMF : uint
  {
    TF_TMF_NOACTIVATETIP = TF_TMAE.TF_TMAE_NOACTIVATETIP,
    TF_TMF_SECUREMODE = TF_TMAE.TF_TMAE_SECUREMODE,
    TF_TMF_UIELEMENTENABLEDONLY = TF_TMAE.TF_TMAE_UIELEMENTENABLEDONLY,
    TF_TMF_COMLESS = TF_TMAE.TF_TMAE_COMLESS,
    TF_TMF_WOW16 = TF_TMAE.TF_TMAE_WOW16,
    TF_TMF_CONSOLE = TF_TMAE.TF_TMAE_CONSOLE,
    TF_TMF_IMMERSIVEMODE = 0x40000000,
    TF_TMF_ACTIVATED = 0x80000000,
  }

  [Flags]
  public enum TF_MOD : uint
  {
    TF_MOD_ALT = 0x0001,
    TF_MOD_CONTROL = 0x0002,
    TF_MOD_SHIFT = 0x0004,
    TF_MOD_RALT = 0x0008,
    TF_MOD_RCONTROL = 0x0010,
    TF_MOD_RSHIFT = 0x0020,
    TF_MOD_LALT = 0x0040,
    TF_MOD_LCONTROL = 0x0080,
    TF_MOD_LSHIFT = 0x0100,
    TF_MOD_ON_KEYUP = 0x0200,
    TF_MOD_IGNORE_ALL_MODIFIER = 0x0400,
  }

  [Flags]
  public enum TF_ES : uint
  {
    TF_ES_ASYNCDONTCARE = 0x0,
    TF_ES_SYNC = 0x1,
    TF_ES_READ = 0x2,
    TF_ES_WRITE = 0x4,
    TF_ES_READWRITE = TF_ES_READ | TF_ES_WRITE,
    TF_ES_ASYNC = 0x8
  }

  [Flags]
  public enum TF_SD_DYNAMIC : uint
  {
    TF_SD_READONLY = TS_SD.TS_SD_READONLY,
    TF_SS_LOADING = TS_SD.TS_SD_LOADING,
    TF_SS_MASKALL = TS_SD.TS_SD_MASKALL,
  }

  [Flags]
  public enum TF_SD_STATIC : uint
  {
    TF_SS_DISJOINTSEL = TS_SS.TS_SS_DISJOINTSEL,
    TF_SS_REGIONS = TS_SS.TS_SS_REGIONS,
    TF_SS_TRANSITORY = TS_SS.TS_SS_TRANSITORY,
  }

  [Flags]
  public enum TF_IAS : uint
  {
    TF_IAS_NONE = 0,
    TF_IAS_NOQUERY = 0x1,
    TF_IAS_QUERYONLY = 0x2,
    TF_IAS_NO_DEFAULT_COMPOSITION = 0x80000000,
  }

  [Flags]
  public enum TF_TF : uint
  {
    TF_TF_MOVESTART = 1,
    TF_TF_IGNOREEND = 2,
  }

  [Flags]
  public enum TF_ST : uint
  {
    TF_ST_CORRECTION = 1,
  }

  [Flags]
  public enum TF_HF : uint
  {
    TF_HF_OBJECT = 1,
  }

  [Flags]
  public enum TF_IE : uint
  {
    TF_IE_CORRECTION = 1,
  }

  [Flags]
  public enum TF_GTP : uint
  {
    TF_GTP_INCL_TEXT = 1,
  }

  [Flags]
  public enum TF_TU : uint
  {
    TF_TU_CORRECTION = 0x1,
  }
}