using System;
using System.Collections.Generic;
using System.Text;

namespace Capitals
{
    class Comparator
    {
        int k = 0;
        public Boolean compareTheWords(String wordCollection,int live, int score)
        {
            Console.Write("Wpisz stolicę i naciśnij ENTER: ");
            String typedWord = Console.ReadLine();
            if (wordCollection.Equals(typedWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Brawo dobra odpowiedź");
                return true;
            }
            else
            {
                Console.WriteLine("Niestety nieprawidłowa odpowiedź");
                return false;
            }
             
        }

        public Boolean compareTheLetter(String wordCollection, int charNumber, int live, int score)
        {
            Console.Write("Wpisz literę i naciśnij ENTER: ");
            String typedLetter = Console.ReadLine();
            Char[] capitalsLetters = wordCollection.ToCharArray(0, charNumber);
            for (int i = 0; i < charNumber; i++)
                if (capitalsLetters[i].ToString().Equals(typedLetter, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write($"  { typedLetter}");
                    k = k + 1;
                }
                else
                {
                    Console.Write(" _");
                }
            if (k > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Brawo podałeś prawidłową literę");
                return true;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Niestey nie ma takiej liery w słowie");
                return false;
            }
        }
       
        
    }
}
