using System;
using System.Collections.Generic;
using System.Text;

namespace questtaskgameneverending
{
    class Fiende
    {
        static Random rand = new Random();
        public static void firstmotstand()
        {
            Console.WriteLine("Du opner baderoms døra og løper berskerkt mot døra og charger finden med et sverd");
            Console.WriteLine("Han snur seg mot deg!!!"+"\nEr det her det er party?ATTACK!!!");
            Console.ReadKey();
            Console.WriteLine("trykk knapp for vidre!");
            Console.Clear();
            Kamp(false, "human rough", 1, 4);
        }
        public static void Kamp(bool random, string navn, int power, int helse)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
            }
            else
            {
                n = navn;
                p = power;
                h = helse;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("===================");
                Console.WriteLine("|(A)ttack (D)efend|");
                Console.WriteLine("|(R)un    (H)eal) |");
                Console.WriteLine("===================");
                Console.WriteLine(" Drikke: " + Program.currentPlayer.drikke + "Helse: " + Program.currentPlayer.helse);
                string input = Console.ReadLine();

                //////////////////////////////////
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    Console.WriteLine("Med full styrke slår du til, " + n + " slår deg tilbake");
                    int damage = p - Program.currentPlayer.beskyttelse;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.beskyttelse) + rand.Next(1, 4);
                    Console.WriteLine("Du tar" + damage + "helse og skader tar" + attack + "damage");
                    Program.currentPlayer.helse -= damage;
                    h -= attack;
                }

                ////////////////////////////////
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    Console.WriteLine(""+ n + "slår deg, men du forsvarer deg");
                    int damage = (p / 4) - Program.currentPlayer.beskyttelse;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.beskyttelse) / 2;
                    Console.WriteLine("Du tar" + damage + "helse og skader tar" + attack + "damage");
                    Program.currentPlayer.helse -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "ruun")
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("runn away from" + n + "");
                        int damage = p - Program.currentPlayer.beskyttelse;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("you lose" + damage + "takeing dmg");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.WriteLine("you use crayzy ninja moves to escape from " + n + "");


                        Console.ReadKey();
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "hiiil")
                {

                    if (Program.currentPlayer.drikke == 0)
                    {
                        Console.WriteLine("Drink up hiik oh they all emptey Nooo");
                        int damage = p - Program.currentPlayer.beskyttelse;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine(""+n + "is hiting you while drinking! thats not fair is it woot you been hit for " + damage + "healthleft");
                    }
                    else
                    {
                        Console.WriteLine("you take a drink");
                        int potionV = 5;
                        Console.WriteLine("your feeel alot better" + potionV + "");
                        Program.currentPlayer.helse += potionV;
                    }
                    Console.ReadKey();

                }
                Console.ReadKey();
            }
        }
    }
}
