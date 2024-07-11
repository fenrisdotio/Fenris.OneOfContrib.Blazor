namespace Fenris.OneOfContrib.Blazor.Components;

using Microsoft.AspNetCore.Components;

public partial class OneOfBaseSwitch2<T0, T1>
{
    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T0" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T0> T0Template { get; set; } = default!;

    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T1" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T1> T1Template { get; set; } = default!;

    /// <summary>
    ///     The value.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public OneOfBase<T0, T1> Value { get; set; } = default!;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        ArgumentNullException.ThrowIfNull(Value);
        ArgumentNullException.ThrowIfNull(T0Template);
        ArgumentNullException.ThrowIfNull(T1Template);
    }
}
