using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
namespace DotNetBenchmarks;

public class JsonBenchmark
{
    private readonly Pessoa _pessoa = new()
    {
        Nome = "Camilla",
        Idade = 29,
        Emails = new List<string> {"camilla@gmail.com","batista@gmail.com"}
    };

    private const string Json = "{\"Nome\":\"Camilla\",\"Idade\":29,\"Emails\":[\"camilla@gmail.com\",\"batista@gmail.com\"]}";

    [Benchmark]
    public void NewtonsoftJson_SerializeObject()
    {
        _ = JsonConvert.SerializeObject(_pessoa);
    }
    
    [Benchmark]
    public static void NewtonsoftJson_DeserializeObject()
    {
        _ = JsonConvert.DeserializeObject(Json);
    }
    
    [Benchmark]
    public void SystemTextJson_SerializeObject()
    {
        _ = JsonSerializer.Serialize(_pessoa);
    }
    
    [Benchmark]
    public static void SystemTextJson_DeserializeObject()
    {
        _ = JsonSerializer.Deserialize<Pessoa>(Json);
    }
    
    [Benchmark]
    public void NetJson_Serialize()
    {
        _ = NetJSON.NetJSON.Serialize(_pessoa);
    }
    
    [Benchmark]
    public static void NetJson_Deserialize()
    {
       _ = NetJSON.NetJSON.Deserialize<Pessoa>(Json);
    }
}

public class Pessoa
{
    public string Nome { get; init; }
    public int Idade { get; init; }
    public IList<string> Emails { get; init; }
}