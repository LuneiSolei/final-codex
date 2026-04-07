namespace FinalCodex.XivApi.Infrastructure.Requests.ClauseBuilder.Steps;

public interface IWhereFieldStep
{
    IConditionStep WhereField(string fieldName);
}