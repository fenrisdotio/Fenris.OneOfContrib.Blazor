namespace Fenris.OneOfContrib.Blazor.Components;

using Microsoft.AspNetCore.Components;

public partial class OneOfBaseSwitch7<T0, T1, T2, T3, T4, T5, T6>
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
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T2" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T2> T2Template { get; set; } = default!;

    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T3" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T3> T3Template { get; set; } = default!;

    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T4" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T4> T4Template { get; set; } = default!;

    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T5" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T5> T5Template { get; set; } = default!;

    /// <summary>
    ///     The <see cref="RenderFragment{TValue}" /> to use when the value is of type <typeparamref name="T6" />.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public RenderFragment<T6> T6Template { get; set; } = default!;

    /// <summary>
    ///     The value.
    /// </summary>
    [Parameter]
    [EditorRequired]
    public OneOfBase<T0, T1, T2, T3, T4, T5, T6> Value { get; set; } = default!;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        ArgumentNullException.ThrowIfNull(Value);
        ArgumentNullException.ThrowIfNull(T0Template);
        ArgumentNullException.ThrowIfNull(T1Template);
        ArgumentNullException.ThrowIfNull(T2Template);
        ArgumentNullException.ThrowIfNull(T3Template);
        ArgumentNullException.ThrowIfNull(T4Template);
        ArgumentNullException.ThrowIfNull(T5Template);
        ArgumentNullException.ThrowIfNull(T6Template);
    }
}
