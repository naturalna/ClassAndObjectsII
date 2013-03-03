using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// delegatite sa promenliwi koito imat stoinost funkciq(metod)(adres na funkciq)
// poinyri kym funkcii w C
//delegatyt kazwa : az sym funkciq koqto wry6ta int i priema string primerno 
//multikast deleati - zaka4ame mngo funkcii stawa s += dori i main mojem da si zaka4im
// publish suscribal
public delegate void MyFirstDelegat(string parametri);
// izwyn clasyt sa 
public delegate void DelegatT<T>(T something);
class DelegateExample
{
    // stati4en metod
    static void Print(string text)
    {
        Console.WriteLine(text);
    }
    static void Main()
    {
        MyFirstDelegat d = new MyFirstDelegat(Print);//slagame referenciqta na metodyt kato stoinost na delegatyt d
        d("string4e nqkakwo");//slagame strigyt s koito trqbwa da raboti
        // mojem da naprawim delegatyt i bez konstruktor
        MyFirstDelegat dd = Print;
        dd("wtori delegat bez konstr");
        // metod ot klas dali moje da se zaka4i ???
        //ako ne syzdam obekt ot wyn6niqt klas 
        MyFirstDelegat delegatIKlas;
        delegatIKlas = new DelegatInNewClass().TestPrint;
        //ako syzdam obekt
        DelegatInNewClass klas = new DelegatInNewClass();
        // raboti samo 4e pyrwo trqbwa da imame obekt ot tozi klas i na obektyt mu izwikwame metodyt kato stoinost na delegatyt ili 
        // moje kakto e po dolu to e po4ti sy6toto no sykrateno kato kod
        MyFirstDelegat ddd = klas.TestPrint;
        ddd("string4e kym metod w klasyt");
        // edin delegat + wtori delegat 
        //ddd += dd;
        //edin delegat + zaka4ame funkciq 
        ddd += Print;
        ddd("Datame edin i sy6t string i na dwata metoda");

        // ako klasyt e stati4en dostypwaneto e klas.metod a delgatyt e :
        ddd += StatClas.Result;// prika4ih go kym ddd
        Console.WriteLine("Anonimni metodi---------------------------------------");
        MyFirstDelegat anonimenMetod = delegate(string text)
        {
            Console.WriteLine(text);
        };
        anonimenMetod("I am anonimous method");
        // taka ne iznasqme metodyt otwyn no e bez ime i ne moje da se izwikwa po drug na4in oswen 4rez delegatyt
        // ako delegatyt wika dwa metoda koito wry6tat int primerno wsy6tnost nakraq se wry6ta na posledniqt prika4en metod rezultatyt
    }
}

