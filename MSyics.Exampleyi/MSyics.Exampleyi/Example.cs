using MSyics.Traceyi;

/// <summary>
/// 実例を示します。
/// </summary>
public abstract class Example
{
    /// <summary>
    /// トレーサーオブジェクトを取得します。
    /// </summary>
    protected Tracer Tracer { get; } = Traceable.Get();

    /// <summary>
    /// 実例の名前を取得します。
    /// </summary>
    public abstract string Name { get; }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    public void Show()
    {
        using (Tracer.Scope(Name))
        {
            try
            {
                Setup();
                ShowCore();
            }
            finally
            {
                Teardown();
            }
        }
    }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    protected abstract void ShowCore();

    /// <summary>
    /// 実例を示す前の処理を行います。
    /// </summary>
    protected abstract void Setup();

    /// <summary>
    /// 実例を示した後の処理を行います。
    /// </summary>
    protected abstract void Teardown();
}
