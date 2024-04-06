using SDPbyCSharpCorner.ThreadSafetySingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.ThreadSafeWithoutLock;

internal class ThreadSafeWithoutLockImplementation
{
    ThreadSafeWithoutLockClass singleton = ThreadSafeWithoutLockClass.Instance;
}

