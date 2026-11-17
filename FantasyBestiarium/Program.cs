using FantasyBestiarium;

SzornyAdatbazis adatbazis = new SzornyAdatbazis("server=localhost;uid=root;pwd=;database=fantasybestiarum");
List<Szorny> szornyek = adatbazis.Fetolt();
Szornyelemzo szE = new Szornyelemzo(szornyek);

Console.WriteLine($"Az összes szörny száma: {szE.OsszesSzornySzama()} db");
Console.WriteLine("------------------------");

List<string> veszelyesSZ = szE.VeszelyesSzornyekNeve();
Console.WriteLine("\nVeszélyes szörnyek neve:");
Console.WriteLine("------------------------");
foreach (string s in veszelyesSZ)
{
    Console.WriteLine($"\t{s}");
}

List<string> egyediE = szE.EgyediElohelyek();
Console.WriteLine("\nEgyedi Élőhelyek neve: ");
Console.WriteLine("------------------------");
foreach ( string s in egyediE )
{
    Console.WriteLine($"\t{s}");
}

Console.WriteLine($"\nAz szornyek átlagos veszélyessége: {szE.AtlagosVeszelyesseg()}");
Console.WriteLine("------------------------");

List<Szorny> legveszelyessebb = szE.LegveszelyesebbSzornyek();
Console.WriteLine("\nA legveszélyesebb szörnyek: ");
Console.WriteLine("------------------------");
foreach (Szorny sz in legveszelyessebb)
{
    Console.WriteLine($"\t{sz.ToString()}");
}

List<Szorny> mocsar = szE.MocsariVeszelyesSzornyek();
Console.WriteLine("\nA Fekete Mocsár veszélyes szörnyei: ");
Console.WriteLine("------------------------");
foreach (Szorny sz in mocsar)
{
    Console.WriteLine($"\t{sz.ToString()}");
}

Console.WriteLine($"\nVan tűzre gyenge szörny?: {szE.VanExtremTuzGyengeSzorny()}");
Console.WriteLine("------------------------");

Dictionary<string, int> elohelyek = szE.SzornyekSzamaElohelyenkent();
Console.WriteLine("\nSzörnyek száma élőhelyenként:");
Console.WriteLine("------------------------");
foreach (  KeyValuePair<string,int> e in elohelyek )
{
    Console.WriteLine($"\t{e.Key}: {e.Value}");
}
