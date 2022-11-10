using System.Text.Json;
using GaragesDemo;

// Generics - array og List
// Kan vi gå igjennom legge til i lister fra console vindu?

var json = File.ReadAllText("verksteder.json");
var verksteder = JsonSerializer.Deserialize<Verksted[]>(json);
Console.WriteLine("kjhkjh");
