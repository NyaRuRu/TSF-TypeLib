using System.Globalization;
using System.Runtime.InteropServices;

namespace TSF.InteropTypes
{
  [StructLayout(LayoutKind.Sequential, Pack = 2)]
  public struct LangID
  {
    public LangID(ushort value)
    {
      PrimaryLanguageID = (byte)(0xff & value);
      SubLanguageID = (byte)(0xff & (value >> 8));
    }
    public LangID(byte primaryLanguageId, byte subLanguageId)
    {
      PrimaryLanguageID = primaryLanguageId;
      SubLanguageID = subLanguageId;
    }

    public byte PrimaryLanguageID;
    public byte SubLanguageID;

    public ushort LCID
    {
      get
      {
        return (ushort)(((ushort)SubLanguageID) << 8 | PrimaryLanguageID);
      }
      set
      {
        PrimaryLanguageID = (byte)(0xff & value);
        SubLanguageID = (byte)(0xff & (value >> 8));
      }
    }
  }
}
