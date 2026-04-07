using FinalCodex.XivApi.Core.Enums;

namespace FinalCodex.XivApi.Core.Options;

public class ClauseGroup
{
    public List<Clause> Clauses { get; } = [];
    public ClauseGroupOperator Operator { get; }
    
    public ClauseGroup(ClauseGroupOperator? groupOperator)
    {
        Operator = groupOperator ?? ClauseGroupOperator.Or;
    }
    
    public override string ToString()
    {
        return $"{GenerateOperator()}({string.Join(' ', Clauses)})";
    }

    private string GenerateOperator()
    {
        return Operator switch
        {
            ClauseGroupOperator.Or => string.Empty,
            ClauseGroupOperator.Must => "+",
            ClauseGroupOperator.MustNot => "-",
            _ => string.Empty
        };
    }
}