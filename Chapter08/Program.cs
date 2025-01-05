public class Program
{
    private static async void Main(string[] args)
    {
        //var greet = await Greetings().Wait();
        WriteToFileAsync("Hello World").Wait();
    }

    public static async Task WriteToFileAsync(string fileName)
    {
        using (StreamWriter writer = File.CreateText(fileName))
            await writer.WriteAsync("This is a test.");
    }

    public async Task<String> Greetings()
    {
        await Task.Delay(1000);
        return "Hello World";
    }
}