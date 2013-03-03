using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// dobawqme metodi kym we4e sy6testwuwa6tite klasowe
// pri onasledqwaneto na klasowe imame bazow klas koito ima nqkakwa funkcionalnost i druk klas koito go nasledqwa i 
// priema funkcionalnostta na bazowiqt klasi + swoi sobstwenni metodi konstruktoryt moje da e i na bazowiqt klas
// a extation metodi sa samo metodi koito se dobawqt kym we4e sy6testwuwa6tiqt klas
 class Program
{
     // ne 4e ne moje i s nasledqwane da stane prosto e po slojno za malki promeni e po dobre s exten methods da se raboti 
     // za da byde edin metod extension to toi trqbwa das e namira w stati4en class i da e stati4en toi samiqt
     // polzwame dumata this predi pytriqt argument w exten metoda ina4e si e obiknowen metod
     // normalno da e stati4n klasyt nali samo metod sysdyrja,nqma da mu prawim instanciq q za da go polzwame samo kato metod 
    static void Main(string[] args)
    {
        SameClass a = new SameClass(4);
        int ans=a.Power(2);
        Console.WriteLine("The ext method returns : " + ans);
        // polzwane na ext metod za string
        string text = "hgcjh, hgfjhcjg.hg hhb?";
        int res=text.WordsCount();
        Console.WriteLine( "Ext method returns words count for same string : " + res);
        Console.WriteLine("Expected : 4");
        // moje da imamme ext metod i kym interfeisi, to i e normalno 
        // za listowete masiwite i tem e logi4no da se dobawqt kym interfeisa naprawo metodite
        // 
        List<int> list = new List<int>();
        list.ListCount();
    }
}

