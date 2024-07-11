namespace Fenris.OneOfContrib.Blazor.Components;

using Microsoft.AspNetCore.Components;

public partial class OneOfSwitch3<T0, T1, T2>
{
    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public OneOf<T0, T1, T2> Value { get; set; }

    /// <summary>
    /// The <see cref="RenderFragment{TValue}"/> to use when the value is of type <typeparamref name="T0"/>.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T0> T0Template { get; set; } = default!;

    /// <summary>
    /// The <see cref="RenderFragment{TValue}"/> to use when the value is of type <typeparamref name="T1"/>.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T1> T1Template { get; set; } = default!;

    /// <summary>
    /// The <see cref="RenderFragment{TValue}"/> to use when the value is of type <typeparamref name="T2"/>.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T2> T2Template { get; set; } = default!;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        ArgumentNullException.ThrowIfNull(T0Template);
        ArgumentNullException.ThrowIfNull(T1Template);
        ArgumentNullException.ThrowIfNull(T2Template);
    }
}
