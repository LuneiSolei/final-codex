namespace FinalCodex.XivApi.Infrastructure.Requests.ClauseBuilder.Steps;

public interface IConditionStep
{
    IOperatorStep Is();
    IOperatorStep IsNot();
}