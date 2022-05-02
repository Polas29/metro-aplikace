// See https://aka.ms/new-console-template for more information
using metro_aplikace;

Console.WriteLine(@"  __  __ ______ _______ _____   ____  
 |  \/  |  ____|__   __|  __ \ / __ \ 
 | \  / | |__     | |  | |__) | |  | |
 | |\/| |  __|    | |  |  _  /| |  | |
 | |  | | |____   | |  | | \ \| |__| |
 |_|  |_|______|  |_|  |_|  \_\\____/ ");
List<string> LinkaA = new List<string>
{
    "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská",
    "Malostranská" , "Staroměstská", "Muzeum", "Můstek", "Náměstí Míru", "Jiřího z Poděbrad",
    "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"
};

LinkaMetra linkaMetraA = new LinkaMetra(LinkaA);
linkaMetraA.VypisStanice();
linkaMetraA.PrvniPosledníStanice();
Console.WriteLine("Zadej stanici odjezdu");
string staniceA = Console.ReadLine();
Console.WriteLine("Zadej stanici příjezdu");
string staniceB = Console.ReadLine();

int casCesty = linkaMetraA.ZjistiCas(staniceA, staniceB);
Console.WriteLine(casCesty);