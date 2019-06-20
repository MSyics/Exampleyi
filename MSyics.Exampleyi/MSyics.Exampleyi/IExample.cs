using System.Threading.Tasks;
/// <summary>
/// 実例を示します。
/// </summary>
public interface IExample
{
    /// <summary>
    /// 実例の名前を取得します。
    /// </summary>
    string Name { get; }

    /// <summary>
    /// 実例を示します。
    /// </summary>
    void Show();

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
