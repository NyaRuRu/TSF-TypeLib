using System;

namespace TSF.TypeLib
{
  public enum TextStoreReturnValues : int
  {
    TS_E_FORMAT = unchecked((int)0x8004020a),
    TS_E_INVALIDPOINT = unchecked((int)0x80040207),
    TS_E_INVALIDPOS = unchecked((int)0x80040200),
    TS_E_NOINTERFACE = unchecked((int)0x80040204),
    TS_E_NOLAYOUT = unchecked((int)0x80040206),
    TS_E_NOLOCK = unchecked((int)0x80040201),
    TS_E_NOOBJECT = unchecked((int)0x80040202),
    TS_E_NOSELECTION = unchecked((int)0x80040205),
    TS_E_NOSERVICE = unchecked((int)0x80040203),
    TS_E_READONLY = unchecked((int)0x80040209),
    TS_E_SYNCHRONOUS = unchecked((int)0x00040208),
    TS_S_ASYNC = 0x01,
  }

  [Flags]
  public enum TS_LF : uint
  {
    TS_LF_SYNC = 0x1,
    TS_LF_READ = 0x2,
    TS_LF_READWRITE = 0x6,
  }

  [Flags]
  public enum TS_AS : uint
  {
    TS_AS_TEXT_CHANGE = 0x01,
    TS_AS_SEL_CHANGE = 0x02,
    TS_AS_LAYOUT_CHANGE = 0x04,
    TS_AS_ATTR_CHANGE = 0x08,
    TS_AS_STATUS_CHANGE = 0x10,
    TS_AS_ALL_SINKS = (TS_AS_TEXT_CHANGE | TS_AS_SEL_CHANGE | TS_AS_LAYOUT_CHANGE | TS_AS_ATTR_CHANGE | TS_AS_STATUS_CHANGE),
  }

  [Flags]
  public enum TS_SD : uint
  {
    TS_SD_READONLY = 0x001,
    TS_SD_LOADING = 0x002,
    TS_SD_MASKALL = (TS_SD_READONLY | TS_SD_LOADING),
  }

  [Flags]
  public enum TS_SS : uint
  {
    TS_SS_DISJOINTSEL = 0x001,
    TS_SS_REGIONS = 0x002,
    TS_SS_TRANSITORY = 0x004,
    TS_SS_NOHIDDENTEXT = 0x008,
  }

  [Flags]
  public enum TS_ST : uint
  {
    TS_ST_NONE = 0x0,
    TS_ST_CORRECTION = 0x1,
  }

  [Flags]
  public enum TS_TC : uint
  {
    TS_TC_NONE = 0x0,
    TS_TC_CORRECTION = 0x1,
  }

  [Flags]
  public enum TS_IAS : uint
  {
    TS_IAS_NOQUERY = 0x1,
    TS_IAS_QUERYONLY = 0x2,
  }

  [Flags]
  public enum GXFPF : uint
  {
    GXFPF_ROUND_NEAREST = 0x1,
    GXFPF_NEAREST = 0x2,
  }

  [Flags]
  public enum TS_ATTR_FIND : uint
  {
    TS_ATTR_FIND_BACKWARDS = 0x0001,
    TS_ATTR_FIND_WANT_OFFSET = 0x0002,
    TS_ATTR_FIND_UPDATESTART = 0x0004,
    TS_ATTR_FIND_WANT_VALUE = 0x0008,
    TS_ATTR_FIND_WANT_END = 0x0010,
    TS_ATTR_FIND_HIDDEN = 0x0020,
  }

  [Flags]
  public enum TS_CH : uint
  {
    TS_CH_PRECEDING_DEL = 1,
    TS_CH_FOLLOWING_DEL = 2,
  }

  [Flags]
  public enum TS_SHIFT : uint
  {
    TS_SHIFT_COUNT_HIDDEN = 0x1,
    [Obsolete("Not used.")]
    TS_SHIFT_HALT_HIDDEN = 0x2,
    TS_SHIFT_HALT_VISIBLE = 0x4,
    TS_SHIFT_COUNT_ONLY = 0x8,
  }

  public enum TS_IE : uint
  {
    TS_IE_CORRECTION = 0x1,
    [Obsolete("Not used.")]
    TS_IE_COMPOSITION = 0x2,
  }

  public static class TextStoreDeclarations
  {
    public static readonly int TS_GTA_HIDDEN = 0x1;
    public static readonly int TS_GEA_HIDDEN = 0x1;
  }
}