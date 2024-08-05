using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
namespace DotNetBenchmarks;

public class JSON
{
    private readonly Pessoa _pessoa;
    private readonly string _json;
    public JSON()
    {
        _pessoa = new Pessoa
        {
            Nome = "Camilla",
            Idade = 29,
            Emails = new List<string> {"camilla@gmail.com","batista@gmail.com"}
        }; 
        
        _json = "{\"Nome\":\"Camilla\",\"Idade\":29,\"Emails\":[\"camilla@gmail.com\",\"batista@gmail.com\"]}";
    }
    
    [Benchmark]
    public void NewtonsoftJson_SerializeObject()
    {
        var json = JsonConvert.SerializeObject(_pessoa);
    }
    
    [Benchmark]
    public void NewtonsoftJson_DeserializeObject()
    {
        var pessoa = JsonConvert.DeserializeObject(_json);
    }
    
    [Benchmark]
    public void SystemTextJson_SerializeObject()
    {
        var json = JsonSerializer.Serialize(_pessoa);
    }
    
    [Benchmark]
    public void SystemTextJson_DeserializeObject()
    {
        var pessoa = JsonSerializer.Deserialize<Pessoa>(_json);
    }
    
    [Benchmark]
    public void NetJson_Serialize()
    {
        var json = NetJSON.NetJSON.Serialize(_pessoa);
    }
    
    [Benchmark]
    public void NetJson_Deserialize()
    {
        var pessoa = NetJSON.NetJSON.Deserialize<Pessoa>(_json);
    }
}

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public IList<string> Emails { get; set; }
}