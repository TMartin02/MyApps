using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ///Program: Kő papír olló játék leprogramozása
            ///Irta: Tomek Martin / 2019.03.06
            ///Adott: számítógép - véletlenszerű válasz

            ///Megoldandó feladat 1:
            ///Citlus programfutatás, amíg a felhasználó szeretne játszani

            bool moreGame = true;
            Random r = new Random();

            ///Feladat változók létrehozása
            
            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int playerScore = 0;
        
            Console.WriteLine("**********Kő/Papír/Olló játék**********");

            do
            {
                ///Feladat 3:
                ///Player választásának megkérdezése és tárolása
                
                Console.WriteLine("Te mitválasztasz?(k/p/o)");

                switch (Console.ReadKey(true).KeyChar)
                    {
                    case 'k':
                    playerChoice = "kő";
                    break;
                    case'p':
                    playerChoice = "papír";
                    break;
                    case 'o':
                    playerChoice = "olló";
                    break;
                    }
                ///Feladat 4:
                ///Számítógép választásának kérdése: Random()
                ///
                switch (r.Next(0, 3))
                    {
                    case 0:
                    compChoice = "kő";
                    break;
                    case 1:
                    compChoice = "papír";
                    break;
                    case 2:
                    compChoice = "olló";
                    break;
                    }
                ///Feladat 5: Értékeljük ki a compChoice és a playerChoice
                ///változókat
                ///

                if(
                    (playerChoice == "kő" && compChoice == "papír") ||
                    (playerChoice == "papír" && compChoice == "olló") ||
                    (playerChoice == "olló" && compChoice == "kő") 
                  )
                    {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Számítógép:["  + compChoice + "] Te:[" + playerChoice + "]");
                    Console.ResetColor();
                    Console.WriteLine("Veszítettél! \nÁllás : Szg: {0} Játékos: {1}", ++compScore, playerScore);
                    }
                else if(playerChoice == compChoice)
                    {
                    
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Számítógép:[" + compChoice + "] Te:[" + playerChoice + "]");
                    Console.ResetColor();
                    Console.WriteLine("Döntetlen!\n Állás : Szg: {0} Játékos: {1}", compScore, playerScore);
                    }
                else
                    {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Számítógép:[" + compChoice + "] Te:[" + playerChoice + "]");
                    Console.ResetColor();
                    Console.WriteLine("Nyertél!\n Állás : Szg: {0} Játékos: {1}", compScore, ++playerScore);
                    }

                    

                Console.WriteLine("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }
            } while (moreGame);
            

            Console.ReadKey();

           
        }
    }
}
