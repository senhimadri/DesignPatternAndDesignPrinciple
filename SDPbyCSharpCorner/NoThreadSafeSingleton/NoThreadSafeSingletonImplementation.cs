using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.NoThreadSafeSingleton;
internal class NoThreadSafeSingletonImplementation
{
    NoThreadSafeSingletonClass singleton = NoThreadSafeSingletonClass.Instance;
    //Why it is not safe?

    // In a multi-threaded environment, if two or more threads simultaneously access the "Instance" property when "instance" is null,
    // they may end up creating multiple instances of the class. This is a violation of the SDP principle.




}

