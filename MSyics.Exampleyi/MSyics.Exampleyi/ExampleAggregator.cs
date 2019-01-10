using MSyics.Traceyi;
using System.Collections.Generic;

/// <summary>
/// 登録した実例を実行します。
/// </summary>
public sealed class ExampleAggregator
{
    /// <summary>
    /// トレーサーオブジェクトを取得します。
    /// </summary>
    private Tracer Tracer { get; } = Traceable.Get();

    /// <summary>
    /// Example オブジェクトの一覧を取得します。
    /// </summary>
    private List<Example> Examples { get; } = new List<Example>();

    /// <summary>
    /// Example オブジェクトを登録します。
    /// </summary>
    /// <typeparam name="T">登録する Example オブジェクトの型</typeparam>
    public ExampleAggregator Add<T>() where T : Example, new()
    {
        Examples.Add(new T());
        return this;
    }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    public void Show()
    {
        try
        {
            using (Tracer.Scope())
            {
                foreach (var item in Examples)
                {
                    item.Show();
                }
            }
        }
        finally
        {
            Traceable.Shutdown();
        }
    }
}
