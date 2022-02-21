using System.Text.Json;

public class JsonMenuLoader : IMenuLoader
{
    public List<Product> LoadMenu()
    {
        string text = File.ReadAllText(@"./menu.json");
        return JsonSerializer.Deserialize<List<Product>>(text);
    }
}