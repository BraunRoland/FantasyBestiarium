using FantasyBestiarium;

SzornyAdatbazis adatbazis = new SzornyAdatbazis("asd");
List<Szorny> szornyek = adatbazis.Fetolt();
Szornyelemzo szE = new Szornyelemzo(szornyek);

Console.WriteLine($" Az összes szörny száma: {szE.OsszesSzornySzama()} db");
List<string> veszelyesSZ = szE.VeszelyesSzornyekNeve();
Console.WriteLine("Veszélyes szörnyek neve");
foreach (string s in veszelyesSZ)
{
    Console.WriteLine($"\t{s}");
}
List<string> egyediE = szE.EgyediElohelyek();
Console.WriteLine("Egyedi Élőhelyek neve: ");
foreach ( string s in egyediE )
{
    Console.WriteLine($"\t{s}");
}
Console.WriteLine($"Az szornyek átlagos veszélyessége: {szE.AtlagosVeszelyesseg()}");
List<Szorny> legveszelyessebb = szE.LegveszelyesebbSzornyek();
Console.WriteLine("A legveszélyesebb szörnyek: ");
foreach (Szorny sz in legveszelyessebb)
{
    Console.WriteLine($"\t{sz.ToString()}");
}
List<Szorny> mocsar = szE.MocsariVeszelyesSzornyek();
Console.WriteLine("A Fekete Mocsár veszélyes szörnyei: ");
foreach (Szorny sz in mocsar)
{
    Console.WriteLine($"\t{sz.ToString()}");
}
Console.WriteLine($"Van tűzre gyenge szörny?: {szE.VanExtremTuzGyengeSzorny()}");
Dictionary<string, int> elohelyek = szE.SzornyekSzamaElohelyenkent();
Console.WriteLine("SZörnyek száma élőhelyenként: ");
foreach(  KeyValuePair<string,int> e in elohelyek )
{
    Console.WriteLine($"\t{e}");
}
