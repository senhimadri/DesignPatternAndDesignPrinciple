namespace SDPbyCSharpCorner.NoThreadSafeSingleton;

public sealed class NoThreadSafeSingletonClass
{

    //This is a private constructor. It ensures that instances of this class cannot be created from the outside.
    private NoThreadSafeSingletonClass() { }


    // This is a private static variable that hold the single instance of a class. It's initially set to null.
    private static NoThreadSafeSingletonClass? instance = null;


    // This is a static property that provides access to the singleton access to the class.
    // If the instance is null it will create a new instance of the class; otherwise, it will return the existing instance.

    public static NoThreadSafeSingletonClass Instance { 
    
        get
        {
            if (instance is null)
            {
                instance = new NoThreadSafeSingletonClass();
            }
            return instance;
        }
    }
}

