using System;

namespace TSF.InteropTypes
{
  [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
  internal class NullAllowedAttribute : Attribute { }
}
