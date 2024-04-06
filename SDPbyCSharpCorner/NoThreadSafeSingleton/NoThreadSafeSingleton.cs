using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.NoThreadSafeSingleton;

public sealed class NoThreadSafeSingleton
{
    private NoThreadSafeSingleton() { }
    private static NoThreadSafeSingleton? instance = null;


    private static NoThreadSafeSingleton Instance { 
    
        get
        {
            if (instance is null)
            {
                instance = new NoThreadSafeSingleton();
            }
            return instance;
        }
    }
}

