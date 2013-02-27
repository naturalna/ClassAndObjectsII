using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct Point
{
    // izpolzwat se za definirane na razni promenliwi cwetowe, to4ki i tem podobni .nqmat funkcionalnost, karti za igra
    //Zadyljitelno konstruktoryt e bez parametri
    //definirame to4ka
    //strukturata ne e clas
    public byte X { get; set; }
    public byte Y { get; set; }
    //prawim samo protyrtitata defoltniqt konstruktor se griji da inicializira poletata
    //defoltniqt konstruktor winagi e wyw strukturata dori i da ne go napi6em 
    //pri klasowete ako napi6em konstruktor s parametri ,konstruktoryt bez parametri se gubi
    // no pri strukturite prazniqt-default ne se trie
    //ako pi6em konstr s parametri zadyljitelno izwikwame : this() za6toto kato ne sme zadali poletata
    // a samo swoistawata ima gPre6ka, ne moje da si nameri na argumentite w () na konstruktora koi swoistawa otgowarqt 
    //a defalta 6te si gi zapi6e i nameri
    // polzwam awtomati4nite swoista kogato nqmam poleta
    //konstruktor
    public Point(byte h)
        : this()
    {
        this.X = h;
    }
    public Point(byte h, byte i)
        : this()
    {
        this.X = h;
        this.Y = i;
    }
    public override string ToString()
    {
        return this.X + ", "+ this.Y;
    }


}

