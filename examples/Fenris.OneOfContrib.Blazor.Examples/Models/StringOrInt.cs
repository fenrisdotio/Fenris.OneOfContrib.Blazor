namespace Fenris.OneOfContrib.Blazor.Examples.Models;

using OneOf;

[GenerateOneOf]
public partial class StringOrInt : OneOfBase<int, string?>
{
}