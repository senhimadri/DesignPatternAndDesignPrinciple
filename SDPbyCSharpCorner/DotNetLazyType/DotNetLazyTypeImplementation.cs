using SDPbyCSharpCorner.NoThreadSafeSingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.DotNetLazyType;

internal class DotNetLazyTypeImplementation
{
    DotNetLazyTypeClass singleton = DotNetLazyTypeClass.Instance;
}

