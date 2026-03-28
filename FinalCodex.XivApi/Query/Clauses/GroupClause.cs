namespace FinalCodex.XivApi.Query.Clauses;

/// <summary>
/// Wraps multiple clauses in parentheses, separated by whitespace.
/// </summary>
/// <param name="clauses">Array of clauses to be grouped.</param>
internal sealed class GroupClause(XivApiClause[] clauses) : XivApiClause
{
    public override string ToString() =>
        $"({string.Join(" ", clauses.Select(clause => clause.ToString()))})";
}