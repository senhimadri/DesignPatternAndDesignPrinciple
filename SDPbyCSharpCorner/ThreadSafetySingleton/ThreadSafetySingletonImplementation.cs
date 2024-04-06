using SDPbyCSharpCorner.NoThreadSafeSingleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.ThreadSafetySingleton;

public class ThreadSafetySingletonImplementation
{
    ThreadSafetySingletonClass singleton = ThreadSafetySingletonClass.Instance;
}

