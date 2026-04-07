// using FinalCodex.XivApi.Query.Fields;
//
// namespace FinalCodex.XivApi.old;
//
// /// <summary>
// /// Wraps multiple clauses in parentheses, separated by whitespace.
// /// </summary>
// /// <param name="clauses">Array of clauses to be grouped.</param>
// internal sealed class GroupField(SubQueryField[] clauses) : SubQueryField
// {
//     public override string ToString() =>
//         $"({string.Join(" ", clauses.Select(clause => clause.ToString()))})";
// }