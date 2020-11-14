using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Villain ozymandias = new Villain("Adrian Veidt", 60);
            Villain joker = new Villain("Mr. J", 70);
            Person robin = new Hero("Jason Todd", joker, 30);
            Hero batman = new Hero("Bruce Wayne", joker, robin, 40);
            batman.AddStrength("Intelligence");
            batman.AddStrength("Wealth");
            Person rorschach = new Hero("Walter Joseph Kovacs", ozymandias, 50);
            Villain gru = new Villain("Gru", 90);
            Minion bob = new Minion("Bob", "Dumb");
            Minion kevin = new Minion("Kevin", "Dumb");
            Minion stuart = new Minion("Stuart", "Dumb");
            gru.AddMinion(bob);
            gru.AddMinion(kevin);
            gru.AddMinion(stuart);

            Console.WriteLine("BATMAN");
            Console.WriteLine(batman.GetName());
            foreach(string strenght in batman.GetStrengths())
            {
                Console.WriteLine(strenght);
            }
            Console.WriteLine(batman.GetArchnemesis().GetName());
            Console.WriteLine(batman.GetArchnemesis().GetEvilness());

            Console.WriteLine("GRU");
            Console.WriteLine(gru.GetName());
            foreach (Minion minion in gru.GetMinions())
            {
                Console.WriteLine(minion.GetName());
                Console.WriteLine(minion.GetEvilness());
                Console.WriteLine(minion.GetWeakness());
            }
            Console.ReadKey();
        }
    }
}
