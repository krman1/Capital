using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capitals
{
    class Game
    {
        Data data = new Data();
        int score = 0;
        int live = 5;
        int attempt = 1;



        public Game()
        {
            data.getData();
        }
        public void play()
        {
            
            Console.WriteLine($"Masz {live} pkt życia");
            Console.WriteLine($"Twój wynik {score} pkt");
            Random rnd = new Random();
            int itemInCollection = rnd.Next(data.getCountries().Count);
            Country selectedCoutry = data.getCountries()[itemInCollection];
            data.deleteItem(itemInCollection);
            Console.WriteLine($"Podaj stolicę państawa:{selectedCoutry.name}");
            String wordCollection = selectedCoutry.capital;
            int charNumber = wordCollection.Length;
            Console.WriteLine(" ");
            for (int i = 0; i < charNumber; i++)
            {
                Console.Write("_ ");
            }
            
            Comparator comparator = new Comparator();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Chcesz odgadnąć całą nazwę stolicy - naciśnij 1, czy jedną literę - naciśnij 2");
            String choice = Console.ReadLine();
            int cholceInt = int.Parse(choice);

            while (cholceInt > 2)
            {
                Console.WriteLine("Nieprawidłowy wybór");
                choice = Console.ReadLine();
                cholceInt = int.Parse(choice);
            }
            if (choice.Equals("1"))
            {
                if (comparator.compareTheWords(wordCollection, live, score))
                {
                    score = score + 2;
                }
                else
                {
                    live = live - 2;
                }
            }
            else
            {
                if (comparator.compareTheLetter(wordCollection, charNumber,live,score))
                {
                    score ++;
                }
                else
                {
                    live--;
                }

                if (comparator.compareTheWords(wordCollection, live, score))
                {
                    score ++;
                }
                else
                {
                    live = live - 2;
                }
            }

            if (live > 0)
            {
                attempt++;
                play();
                
            }
            
            else {
                Console.WriteLine("Koniec gry");
                Console.WriteLine($"Twój wynik {score} pkt");
                Console.WriteLine("Podaj swoje imie aby zapisać wynik");
                String name = Console.ReadLine();
                DateTime thisDay = DateTime.Now;


                if (!File.Exists("Score.txt"))
                {
                    StreamWriter sw = File.CreateText("Score.txt");
                    {
                        sw.WriteLine("Cracow");
                        sw.WriteLine (thisDay); 
                        sw.WriteLine($"Gratulacja {name} twój wynik to {score} w {attempt} próbach");
                        sw.Close();
                    }
                }
            }
        }

    }
}
