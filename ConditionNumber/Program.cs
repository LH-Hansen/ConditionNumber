using ConditionNumber.Model;

namespace ConditionNumber;

class Program
{
    static void Main()
    {
        Kondital myKondital = new Kondital();

        while (true) 
        {
            Console.Write("Angiv køn\n0. Mand\n1. Kvinde\nVælg køn: ");
            bool isFemale = Convert.ToBoolean(Convert.ToByte(Console.ReadLine()));

            Console.Clear();

            Console.Write("Indtast alder: ");
            byte alder = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            Console.Write("Indtast vægt i kg: ");
            double vægt = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Indtast maxpuls: ");
            double maxPuls = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Indtast hvilepuls: ");
            double hvilePuls = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Dit kondital er:        \t{0}\tml/kg/min", myKondital.BeregnKondital(maxPuls, hvilePuls));
            Console.WriteLine("Din max iltoptagelse er:\t{0}\tl/ml", myKondital.BeregnIltOptagelse(myKondital.BeregnKondital(maxPuls, hvilePuls), vægt));
        }
    }
}