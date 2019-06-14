using System.Collections.Generic;

/// <summary>
/// 登録した実例を実行します。
/// </summary>
public sealed class ExampleAggregator
{
    /// <summary>
    /// Example オブジェクトの一覧を取得します。
    /// </summary>
    private List<IExample> Examples { get; } = new List<IExample>();

    /// <summary>
    /// Example オブジェクトを登録します。
    /// </summary>
    /// <typeparam name="T">登録する Example オブジェクトの型</typeparam>
    public ExampleAggregator Add<T>() where T : IExample, new()
    {
        Examples.Add(new T());
        return this;
    }

    /// <summary>
    /// Example オブジェクトを登録します。
    /// </summary>
    public ExampleAggregator Add(IExample examle)
    {
        Examples.Add(examle);
        return this;
    }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    public void Show()
    {
        foreach (var item in Examples)
        {
            item.Show();
        }
    }
}
