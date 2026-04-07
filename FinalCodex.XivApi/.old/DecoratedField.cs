// namespace FinalCodex.XivApi.old;
//
// /// <summary>
// /// Wraps any field with a + or - prefix.
// /// </summary>
// /// <param name="field">The field to be wrapped.</param>
// /// <param name="decorator">The operator to wrap the field in.</param>
// internal sealed class DecoratedField(Query.Fields.SubQueryField field, string decorator) : Query.Fields.SubQueryField
// {
//     public override string ToString() => $"{decorator}{field}";
// }