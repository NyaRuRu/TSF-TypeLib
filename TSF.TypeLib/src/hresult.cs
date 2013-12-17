using System.Runtime.InteropServices;
using TSF.TypeLib;

namespace TSF.InteropTypes
{
  [StructLayout(LayoutKind.Sequential)]
  public struct HRESULT
  {
    public int Code;
    public bool Succeeded
    {
      get
      {
        return Code >= 0;
      }
    }
    public static implicit operator bool(HRESULT hresult)
    {
      return hresult.Succeeded;
    }
    public override string ToString()
    {
      if (Code == 0)
      {
        return "S_OK";
      }
      var e = Marshal.GetExceptionForHR(Code);
      if (e != null)
      {
        return e.ToString();
      }
      switch ((ManagerReturnValues)Code)
      {
        case ManagerReturnValues.TF_E_ALREADY_EXISTS:
          return "TF_E_ALREADY_EXISTS";
        case ManagerReturnValues.TF_E_COMPOSITION_REJECTED:
          return "TF_E_COMPOSITION_REJECTED";
        case ManagerReturnValues.TF_E_DISCONNECTED:
          return "TF_E_COMPOSITION_REJECTED";
        case ManagerReturnValues.TF_E_EMPTYCONTEXT:
          return "TF_E_COMPOSITION_REJECTED";
        case ManagerReturnValues.TF_E_FORMAT:
          return "TF_E_FORMAT";
        case ManagerReturnValues.TF_E_INVALIDPOINT:
          return "TF_E_INVALIDPOINT";
        case ManagerReturnValues.TF_E_INVALIDPOS:
          return "TF_E_INVALIDPOS";
        case ManagerReturnValues.TF_E_INVALIDVIEW:
          return "TF_E_INVALIDVIEW";
        case ManagerReturnValues.TF_E_LOCKED:
          return "TF_E_LOCKED";
        case ManagerReturnValues.TF_E_NOINTERFACE:
          return "TF_E_NOINTERFACE";
        case ManagerReturnValues.TF_E_NOLAYOUT:
          return "TF_E_NOLAYOUT";
        case ManagerReturnValues.TF_E_NOLOCK:
          return "TF_E_NOLOCK";
        case ManagerReturnValues.TF_E_NOOBJECT:
          return "TF_E_NOOBJECT";
        case ManagerReturnValues.TF_E_NOPROVIDER:
          return "TF_E_NOPROVIDER";
        case ManagerReturnValues.TF_E_NOSELECTION:
          return "TF_E_NOSELECTION";
        case ManagerReturnValues.TF_E_NOSERVICE:
          return "TF_E_NOSERVICE";
        case ManagerReturnValues.TF_E_NOTOWNEDRANGE:
          return "TF_E_NOTOWNEDRANGE";
        case ManagerReturnValues.TF_E_RANGE_NOT_COVERED:
          return "TF_E_RANGE_NOT_COVERED";
        case ManagerReturnValues.TF_E_READONLY:
          return "TF_E_READONLY";
        case ManagerReturnValues.TF_E_STACKFULL:
          return "TF_E_STACKFULL";
        case ManagerReturnValues.TF_E_SYNCHRONOUS:
          return "TF_E_SYNCHRONOUS";
        case ManagerReturnValues.TF_S_ASYNC:
          return "TF_S_ASYNC";
        default:
          return "Unknown Error";
      }
    }
  }
}