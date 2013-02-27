using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// izwikwame list ot dwa elementa
public class GenericListD<T1, T2>
{
    private List<T1> list1 = new List<T1>();
    private List<T2> list2 = new List<T2>();
    //constructor s parametri
    public GenericListD(int count)
    {
        Console.WriteLine("Konstruktor raboti!");
    }
    //constructor bez parametri
    public GenericListD()
    {
        Console.WriteLine("Konstructor bez parametri !");
    }
    //methods
    public void Add(T1 List1Value, T2 list2Value)
    {
        list1.Add(List1Value);
        list2.Add(list2Value);
    }
    // nasledwane
    // ako imame daden klas i drug klas koito go nasledqwa,to swoistwata metodite i t.n na 
    //bazowiqt klas stawat swoistwa i poleta i t.n. i na negowiqt naslednik
    // class naslednik : roditel

    //INTERFACE
    //Towa e dogowor 4e na6iqt klas 6te ima opredeleni metodi
    // naprimer Add,Remove ...Dispolse()
    //sy6to se izpolzwat za ograni4enie na genericite po nqkakwi pokazateli
    //IComparable me zadyljawa da imam CompareTo(object item) me zadyljawa da 
    //imam nqkakyw obect koito  preobry6tam w int byte ili tam kakwoto mi trqbwa 
    // a IComparable<int> zadyljawa me da imam CompareTo(int item)
 
}