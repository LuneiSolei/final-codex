namespace FinalCodex.XivApi.Infrastructure.Requests.ClauseBuilder.Steps;

public interface IInitialClauseBuilderStep
{
    IConditionStep WhereField(string name);
}