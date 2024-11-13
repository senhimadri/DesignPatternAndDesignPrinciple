using InterpreterDesignPatternByGfG.Context;
using InterpreterDesignPatternByGfG.Interpreter;

namespace InterpreterDesignPatternByGfG.Client;

public class InterpreterClient
{
    public static void Main()
    {
        string expression = "2 + 3 * 4";

        GlobalContext context = new GlobalContext();

        GlobalInterpreter interpreter = new GlobalInterpreter(context);

        int result = interpreter.Interpret(expression);

        Console.WriteLine($"Result: { result }");
    }
}
