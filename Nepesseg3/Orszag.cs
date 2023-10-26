using System;
using System.Collections.Generic;
using System.Text;

namespace Nepesseg3
{
    internal class Orszag {

    public string Orszagnev { get; private set; }
    public int Terulet { get; private set; }
    public int Nepesseg { get; private set; }
    public string Fovaros { get; private set; }
    public int FovarosNepesseg { get; private set; }
    public int Nepsuruseg => Nepesseg / Terulet;

    public Orszag(string sor)
    {
        var darabok = sor.Split(';');
        Orszagnev = darabok[0];
        Terulet = int.Parse(darabok[1]);
        Nepesseg = int.Parse(darabok[2].Replace("g","0000"));
        Fovaros = darabok[3];
        FovarosNepesseg = int.Parse(darabok[4]);
    }

    public override string ToString()
    {
        return "";
    }

    }
}
