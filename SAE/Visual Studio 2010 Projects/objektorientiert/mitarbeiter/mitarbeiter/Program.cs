using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mitarbeiter
{
    class Program
    {
        static void Main(string[] args)
        {
            mitarbeiter mitarbeiterA = new mitarbeiter();
            //double neustdlohn;


            Console.WriteLine("###################################");
            Console.Write("Der Stundenlohn ist auf einen Standart von ");
        
            Console.WriteLine(mitarbeiterA.stdlohn + " gesetzt.");
            Console.WriteLine("Für einen anderen Stundenlohn bitte eingeben, ansonsten 0: ");
            mitarbeiterA.setstdlohn(Convert.ToDouble(Console.ReadLine()));
            
            Console.Write("Personalnummer: ");
            mitarbeiterA.setnummer(Convert.ToInt32(Console.ReadLine()));
           
            Console.Write("Mitarbeitername: ");
            mitarbeiterA.setname(Console.ReadLine());
            ///mitarbeiterA.name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("#########  Menue  ###########");
                Console.WriteLine("Waehlen Sie einen Punkt:\n1. Stunden hinzufuegen\n2. Monatsbrutto ausrechnen\n3. Stundenlohn aendern");

                int switcher = Convert.ToInt32(Console.ReadLine());

                switch (switcher)
                {
                    case 1:
                        Console.WriteLine("Anzahl Stunden: ");

                        mitarbeiterA.addtime(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Bruttoentgelt: " + Convert.ToString(mitarbeiterA.getbrutto()));
                        break;
                    case 3:
                        Console.WriteLine("Prozentsatz eingeben: ");
                        mitarbeiterA.editstdlohn(Convert.ToDouble(Console.ReadLine()));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
