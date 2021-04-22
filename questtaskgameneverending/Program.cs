using System;

namespace questtaskgameneverending
{
    
    class Program
    {
        public static Spiller currentPlayer = new Spiller();

        static void Main(string[] args)
        {
            Start();
            Fiende.firstmotstand();
        }


        static void Start()
        {
            Console.WriteLine("Hennings spill!");
            Console.WriteLine("Navnet ditt er?");
            currentPlayer.navn = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Du våkner fyllesyk altfor tidlig naken på ett iskaldt baderomsgulv");
            //Console.WriteLine("Husker ingen ting fra igår");

            if (currentPlayer.navn == "")
                Console.WriteLine("Husker du ikke? Gi deg selv ett navn jeg kan kalle deg da!");
            else
            Console.WriteLine("Hei på deg " + currentPlayer.navn + " hygglig å møtes");
            Console.WriteLine("Hva har skjedd?"+"\n trykk en knapp ");
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("mer hitorie, finner en dør");
            //Console.WriteLine("den går istykker, og ser en fyr");
            //Console.WriteLine("du ser fyren");
        }
    }
}
