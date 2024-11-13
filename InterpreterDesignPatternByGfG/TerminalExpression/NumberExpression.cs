using InterpreterDesignPatternByGfG.AbstractExpression;
using InterpreterDesignPatternByGfG.Context;

namespace InterpreterDesignPatternByGfG.TerminalExpression;

public class NumberExpression(int number) : IExpression
{
    private int number = number;

    public int Interprete(GlobalContext context) => number;
}
