using System.Text.Json;
using GaragesDemo;

var cd = new CounterDemo();
cd.Run();
return;
// CSV - JSON
// Generics - array og List
// Kan vi gå igjennom legge til i lister fra console vindu?
// Array vs List<>

var json = File.ReadAllText("verksteder.json");
var verksteder = JsonSerializer.Deserialize<Verksted[]>(json);

//var strings = new List<string>();
//strings.Add("a");
//strings.Add("b");

//var numbers = new List<int>();
//numbers.Add(1);
//numbers.Add(2);

var verkstedListe = new List<Verksted>(verksteder);
verkstedListe.RemoveAt(0);

// LINQ - filter() og map()

var postnumre1 = new List<string>();
foreach (var verksted in verkstedListe)
{
    postnumre1.Add(verksted.Postnummer.ToString());
}

var postnumre2 = verkstedListe.Select(v => v.Postnummer).ToList();
var postnumre3 = verkstedListe.Select(Mappings.Postnr).ToList();

// filtrere - ett kriterium

var postnumreSomStarterMed0a = new List<Verksted>();
foreach (var verksted in verkstedListe)
{
    if (verksted.Postnummer.ToString().StartsWith("0"))
    {
        postnumreSomStarterMed0a.Add(verksted);
    }
}

var postnumreSomStarterMed0b = verkstedListe.Where(v => v.Postnummer.ToString().StartsWith("0"));

// filtere - to kriterier

var p0AndA = verkstedListe.Where(
    v => v.Postnummer.ToString().StartsWith("0")
                && v.Bedriftsnavn.StartsWith("A"));

// Gi meg alle postnumre som starter med 0 og som hører til verksteder med navn som begynner på A
var x = verkstedListe
    .Where(v => v.Postnummer.ToString().StartsWith("0") && v.Bedriftsnavn.StartsWith("A"))
    .Select(v => v.Postnummer)
    .ToList();

// Finne første eller siste
var v = verkstedListe.FirstOrDefault(v => v.Bedriftsnavn.StartsWith("A"));

// Hoppe over, feks til paging
var pageSize = 10;
var pageIndex = 7;

var elements = verkstedListe
    .Skip(pageIndex * pageSize)
    .Take(pageIndex);

// Extension methods
var vw = verkstedListe.Last();
var vv = verkstedListe.First();
v.Terje();
Extensions.Terje(v);

var a = verkstedListe.Select(v => v.Postnummer);
var b = Enumerable.Select(verkstedListe, v => v.Postnummer);

Console.WriteLine();
