namespace FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

public interface IConditionStep
{
    IOperatorStep Is();
    IOperatorStep IsNot();
}