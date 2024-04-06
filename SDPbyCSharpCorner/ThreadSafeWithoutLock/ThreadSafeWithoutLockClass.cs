namespace SDPbyCSharpCorner.ThreadSafeWithoutLock;
public sealed class ThreadSafeWithoutLockClass
{

    /* This is a private constructor. It ensures that instance of the class cannot be created from outside.*/
    private ThreadSafeWithoutLockClass() { }


    /* Here, the "instance" is created statically. The CLR ensures that the static initialization is thread-safe by default.
       This means, the instance will be created one time and only one thread can be executed the static constructor at a time. */
    private static readonly ThreadSafeWithoutLockClass instance = new ThreadSafeWithoutLockClass();

    /* This is an explicit static constructor. In this case this is empty. It is included here to prevent runtime from making 
       the type as "beforefieldinit", which could result in non-deterministic behavior during the initialization of the singleton instance.*/
    static ThreadSafeWithoutLockClass() { }

    /* This is a public property through which singleton instance is accessed. It return the statically initialized instance of the class.*/
    public static ThreadSafeWithoutLockClass Instance => instance;
}

