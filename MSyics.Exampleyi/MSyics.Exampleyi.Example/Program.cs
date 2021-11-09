namespace MSyics.Exampleyi.Example;

class Program : ExampleAggregator
{
    static async Task Main()
    {
        await new Program().
            Add<AsyncExample>().
            ShowAsync();
    }
}

class AsyncExample : IExample
{
    public string Name => nameof(AsyncExample);

    public void Setup()
    {
        Console.WriteLine("Setup!");
    }

    public void Show()
    {
        Console.WriteLine("Show!");
    }

    public Task ShowAsync()
    {
        return Task.Run(() => Console.WriteLine("ShowAsync!"));
    }

    public void Teardown()
    {
        Console.WriteLine("Teardown!");
    }
}
