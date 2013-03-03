using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// anonimni typowe sa wremenni i sa bez imena polzwame gi wednyj i posle iz4ezwa
// iskam nowa promenliwa kato tip danni bez zna4enie imeto s propyrtita x y ....
// i si gi polzwam .Ne6to kato sykraten zapis na struktura
//bez funkcionalnost sa kato strukturite 
// C# si izmislq ime ,prawi si clasyt i taka natatyk .Ne prawi struktura a klas 
// samo se dostypwat set nqmat sled towa
// overridwa se ToString {....} .Equals ni dawa -awtomati4no ot kompilatoryt
// dawa mi .HashCode sy6to imat 
// referentni typowe sa
//mojem da imame masiw ot anonimni tipowe no trqbwa da sa ednakwi 
class Program
{
    static void Main(string[] args)
    {
        var anonimenTip = new{X=4 , Y=3};//anonimen tip
        var masiwOtAnType = new[] { new { X = 4, Y = 4 }, new { X = 4, Y = 5 },anonimenTip };// imenata na X i Y trqbwa da sa ednakwi 
        Console.WriteLine(masiwOtAnType[0]);
        //masiwOtAnType[0] = 5; - nqma set 
    }
}

