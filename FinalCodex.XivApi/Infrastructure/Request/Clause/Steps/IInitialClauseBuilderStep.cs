namespace FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

public interface IInitialClauseBuilderStep
{
    IConditionStep WhereField(string name);
}