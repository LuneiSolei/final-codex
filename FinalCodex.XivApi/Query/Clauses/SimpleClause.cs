namespace FinalCodex.XivApi.Query.Clauses;

internal sealed class SimpleClause(XivApiQueryField field,
    string op, string value) : XivApiClause
{
    public override string ToString() => $"{field}{op}{value}";
}