namespace OneOf.Extensions.Blazor.Examples.Models;

[GenerateOneOf]
public partial class StringOrInt : OneOfBase<int, string?>
{
}