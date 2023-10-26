using Nepesseg3;
using System.Text;

var orszagok = new List<Orszag>();
using StreamReader sr = new(@"..\..\..\src\adatok-utf8.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    orszagok.Add(new Orszag(sr.ReadLine()));
}

Console.WriteLine($"3.Feladat:{orszagok.Count}");