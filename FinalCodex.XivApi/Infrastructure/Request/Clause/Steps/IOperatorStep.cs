namespace FinalCodex.XivApi.Infrastructure.Request.Clause.Steps;

public interface IOperatorStep
{
    IValueStep PartiallyEqualTo();
    IValueStep EqualTo();
    IValueStep GreaterThan();
    IValueStep GreaterThanOrEqualTo();
    IValueStep LessThan();
    IValueStep LessThanOrEqualTo();
}