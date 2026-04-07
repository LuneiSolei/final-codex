namespace FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

public interface IWhereFieldStep
{
    IConditionStep WhereField(string fieldName);
}