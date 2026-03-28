namespace FinalCodex.XivApi.Query.Clauses;

/// <summary>
/// Wraps any clause with a + or - prefix.
/// </summary>
/// <param name="clause">The clause to be wrapped.</param>
/// <param name="decorator">The operator to wrap the clause in.</param>
internal sealed class DecoratedClause(XivApiClause clause, string decorator) : XivApiClause
{
    public override string ToString() => $"{decorator}{clause}";
}