using InterpreterDesignPatternByGfG.AbstractExpression;
using InterpreterDesignPatternByGfG.Context;

namespace InterpreterDesignPatternByGfG.NonterminalExpression;

public class MultiplicationExpression(IExpression left, IExpression right) : IExpression
{
    private IExpression left = left, right = right;
    public int Interprete(GlobalContext context) 
                                    => left.Interprete(context) * right.Interprete(context);
}
