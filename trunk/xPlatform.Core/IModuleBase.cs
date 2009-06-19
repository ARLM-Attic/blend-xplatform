using System;
using System.Collections.Generic;
using System.Text;

namespace xPlatform
{
    public interface IModuleBase
    {
        Type BaseType { get; }
        Type CurrentType { get; }
    }
}
