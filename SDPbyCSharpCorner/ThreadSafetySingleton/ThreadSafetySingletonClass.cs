using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.ThreadSafetySingleton;

public sealed class ThreadSafetySingletonClass
{

    /* This is a private constructor. It ensures that instance of the class cannot be created from outside.*/
    private ThreadSafetySingletonClass() { }


    /* This variable holds the single instance of the class. 
       The "volatile" keyword ensure that the variable is always read from and written to main memory,
       preventing petential caching issues accross Multi-Threads. */
    private static volatile ThreadSafetySingletonClass? instance;


    /* This objectt is used as a synchronization root for the double-checkedlocking pattern.
       It ensure that only one Thread enter the critical section of code at a time.*/
    private static readonly object syncRoot = new object();


    /* Instance property provides access to the singleton instance. Inside this property there is a double-checked locked machanism.
        
        * The first check ("if (instance is null)") is performed without locking to improve performance.
          If the instance is already initialized, this check unnecessary locking and object creation.
        * If the instance is null, the code enters a lock section ("lock (syncRoot)") to ensure that one thread can create  the instance.
        * Inside the locked section there is an another check to ensure that the instance hasn't been created by another thread while waiting for the lock.
          This is necessary because multiple threads might have passed first null check and one of them has acquired lock and initialized the instance.
          Therefore, it's important to check instance again to prevent duplicate instance creation.
    */
    public static ThreadSafetySingletonClass Instance
    {
        get
        {
            if (instance is null)
            {
                lock (syncRoot)
                {
                    if (instance is null)
                    {
                        instance = new ThreadSafetySingletonClass();
                    }
                }
            }

            return instance;
        }
    }
}
