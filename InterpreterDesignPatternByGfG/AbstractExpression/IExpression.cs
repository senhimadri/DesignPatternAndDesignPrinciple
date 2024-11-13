using InterpreterDesignPatternByGfG.Context;

namespace InterpreterDesignPatternByGfG.AbstractExpression;

public interface IExpression
{
    int Interprete(Context.GlobalContext context);
}
