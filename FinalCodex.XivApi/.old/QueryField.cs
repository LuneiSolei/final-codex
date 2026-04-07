// using System.Text;
//
// namespace FinalCodex.XivApi.old;
//
// public class SubQueryField(string name)
// {
//     public override string ToString()
//     {
//         StringBuilder builder = new(name);
//         
//         return builder.ToString();
//     }
//
//     public Query.Fields.SubQueryField PartiallyMatches(string value) =>
//         new SimpleField(this, "~", $"\"{value}\"");
//
//     public Query.Fields.SubQueryField EqualTo(string value) =>
//         new SimpleField(this, "=", $"\"{value}\"");
//
//     public Query.Fields.SubQueryField EqualTo(double value) =>
//         new SimpleField(this, "=", value.ToString());
//     
//     public Query.Fields.SubQueryField EqualTo(bool value) =>
//         new SimpleField(this, "=", value ? "true" : "false");
//
//     public Query.Fields.SubQueryField GreaterThan(double value) =>
//         new SimpleField(this, ">", value.ToString());
//
//     public Query.Fields.SubQueryField GreaterThanOrEqualTo(double value) =>
//         new SimpleField(this, ">=", value.ToString());
//
//     public Query.Fields.SubQueryField LessThan(double value) =>
//         new SimpleField(this, "<", value.ToString());
//
//     public Query.Fields.SubQueryField LessThanOrEqualTo(double value) =>
//         new SimpleField(this, "<=", value.ToString());
// }