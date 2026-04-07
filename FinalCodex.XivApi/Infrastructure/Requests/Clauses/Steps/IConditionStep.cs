namespace FinalCodex.XivApi.Infrastructure.Requests.Clauses.Steps;

public interface IConditionStep
{
    IOperatorStep Is();
    IOperatorStep IsNot();
}