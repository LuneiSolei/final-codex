namespace FinalCodex.XivApi.Core.Options;

public class ClauseGroup
{
    public List<Clause> Clauses { get; } = [];
    public string Operator = string.Empty;

    public override string ToString()
    {
        return $"{Operator}({string.Join(' ', Clauses)})";
    }
}