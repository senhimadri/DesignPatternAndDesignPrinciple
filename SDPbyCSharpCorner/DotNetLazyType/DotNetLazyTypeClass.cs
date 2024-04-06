using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDPbyCSharpCorner.DotNetLazyType;

public sealed class DotNetLazyTypeClass
{

    /* This is the private constructor of the class, ensuring that instances cannot be created from outside the class.*/
    private DotNetLazyTypeClass() { }


    /* This line declare a private static fields of type Lazy<DotNetLazyTypeClass>. It initilized with a lamda expression 
       that create a new instance of "DotNetLazyTypeClass" when accessed for the first time. */
    private static readonly Lazy<DotNetLazyTypeClass> instance = 
                        new Lazy<DotNetLazyTypeClass>(() => new DotNetLazyTypeClass());

    /* This is a private static property through which the singleton instance is accessed. It returns the "value" property of 'instance',
       which triggers the creation of the singleton instance if it hasn't been created yet or return the existing instance. */
    public static DotNetLazyTypeClass Instance = instance.Value;

}