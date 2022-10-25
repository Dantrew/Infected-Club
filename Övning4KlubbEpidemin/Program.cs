using System.Diagnostics.Metrics;

namespace Övning4KlubbEpidemin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> club = new List<Person>();
            for (int i = 0; i < 20; i++)
            {
                club.Add(new Person());
            }

            Person infected = new Person(true);
            club[0] = infected;

            int time = 0;
            int diseaseCounter = 2;
            int clubLength = club.Count;
            

            while (true)
            {
                int deadCount = 0;

                Console.WriteLine($"Name     |    Infekted    |   Hours  |  Immune |   Status  ");
                Console.WriteLine($"===========================================================");

                foreach (Person p in club)
                {    
                    p.InfectedClub();
                    Console.Write(p.Name.PadRight(9));

                    if (p.Infected == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\tSick" + " \t\t ");
                    }
                    else if (p.Infected == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\tHealthy" + " \t ");
                    }
                    Console.ResetColor();

                    Console.Write(p.InfectedWhen + "\t");

                    if (p.Immune == false)
                    { 
                        Console.Write(p.Immune); 
                    }
                    else if (p.Immune == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(p.Immune);
                    }
                    Console.ResetColor();
                    if (p.Dead == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t    Alive");
                    }
                    else if (p.Dead == true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\t    Dead");
                        deadCount++;
                    }
                    Console.ResetColor();
                }

                //Console.Write(p.Name + "\t" + p.Infected + " \t\t " + p.InfectedWhen + "\t" + p.Immune);  <<< För en kod utan färger


                if (diseaseCounter < clubLength)
                {
                    for (int j = 0; j < diseaseCounter; j++)
                    {
                        club[j].NewInfected();
                    }
                    diseaseCounter = diseaseCounter * 2;
                }
                else if (diseaseCounter > clubLength)
                {
                    for (int j = 0; j < clubLength; j++)
                    {
                        club[j].NewInfected();  
                    }
                }

                time++;
                Console.WriteLine($"===========================================================");
                Console.WriteLine($"Time elapsed in club is: {time} hours. People who died: {deadCount}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}



//◦ ◦ Skapa ett objekt: Person, med följande egenskaper
//◦ Smittad (bool)
//◦ SmittadNär(int, personen ska bli frisk igen efter 5 timmar.)
//◦ Immun(bool, en smittad person som blivit frisk kan inte bli sjuk igen)
//◦ Skapa en lista: club, där du stoppar in 20 personer. 
//◦ Ange att EN person är sjuk.
//◦ Loopa igenom listan och anta att varje sjuk person smittar 1(en) annan person per 
//timme.
//◦ Första timmen smittar alltså den enda sjuka personen en annan person. 
//◦ Andra timmen smittar dessa två personer ytterligare varsin person
//◦ Tredje timmen smittar alla fyra ytterligare fyra personer…osv
//◦ När 5 timmar gått blir första personen frisk, och smittar ingen längre (och är immun), 
//men de andra fortsätter smitta…
//◦ Stega fram timmarna med en tangenttryckning, en timme per tryck.
//◦ Visa I konsollen vilka som är smittade, och hur många som är immuna. 
//◦ Visa också hur många timmar som går.
//◦ Hur många timmar tar det innan alla är immuna?