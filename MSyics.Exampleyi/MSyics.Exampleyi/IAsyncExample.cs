/// <summary>
/// 実例を示します。
/// </summary>
public interface IAsyncExample
{
    /// <summary>
    /// 実例の名前を取得します。
    /// </summary>
    string Name { get; }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    Task ShowAsync();

    /// <summary>
    /// 実例を示す前の処理を行います。
    /// </summary>
    void Setup();

    /// <summary>
    /// 実例を示した後の処理を行います。
    /// </summary>
    void Teardown();
}
