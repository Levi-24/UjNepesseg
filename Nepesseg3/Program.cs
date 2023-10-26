using Nepesseg3;
using System.Text;

List<Orszag> orszagok = new();
using StreamReader sr = new(@"..\..\..\src\adatok-utf8.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
    orszagok.Add(new(sr.ReadLine()));

Console.WriteLine($"3.Feladat: Beolvasott országok száma: {orszagok.Count}");
