using InterpreterDesignPatternByGfG.AbstractExpression;
using InterpreterDesignPatternByGfG.Context;
using InterpreterDesignPatternByGfG.NonterminalExpression;
using InterpreterDesignPatternByGfG.TerminalExpression;

namespace InterpreterDesignPatternByGfG.Interpreter;

public class GlobalInterpreter(GlobalContext context)
{
    private GlobalContext context = context;

    public int Interpret(string expression)
    {
        IExpression expressionTree = BuildExpressionTree(expression);
        return expressionTree.Interprete(context);
    }

    private IExpression BuildExpressionTree(string expression)
    {
        var numEx1 =new NumberExpression(2);
        var numEx2 =new NumberExpression(3);
        var numEx3 =new NumberExpression(5);

        var MultiEx2NEx3 = new MultiplicationExpression(numEx2, numEx3);

        var AdditionEx = new AdditionExpression(numEx1, MultiEx2NEx3);

        return AdditionEx;
    }

}
