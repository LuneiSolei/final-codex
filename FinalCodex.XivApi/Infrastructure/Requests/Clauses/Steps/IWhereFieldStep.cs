namespace FinalCodex.XivApi.Infrastructure.Requests.Clauses.Steps;

public interface IWhereFieldStep
{
    IConditionStep WhereField(string fieldName);
}