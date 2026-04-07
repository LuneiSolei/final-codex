namespace FinalCodex.XivApi.Infrastructure.Requests.Clauses.Steps;

public interface IInitialClauseBuilderStep
{
    IConditionStep WhereField(string name);
}