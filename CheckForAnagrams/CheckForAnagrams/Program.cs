using System;

namespace CheckForAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("cristian", "Cristina")); ;
            Console.WriteLine(IsAnagram("Dave Barry", "Ray Adverb"));
            Console.WriteLine(IsAnagram("Nope", "Note"));
            Console.ReadKey();
        }

        private static bool IsAnagram(string A, string B)
        {
           var newA = A.ToLowerInvariant().Replace(" ", "");
           var newB = B.ToLowerInvariant().Replace(" ", "");

            int TrueLetters = 0;

            if (newA.Length != newB.Length)
            {
                return false;
            }
            
            for(int i = 0; i < newA.Length; i++)
            {
                for (int j = 0; j < newB.Length; j++)
                {
                    if (newA[i] == newB[j])
                    {
                        TrueLetters++;
                        break;
                    }
                                        
                }
            }

            if (TrueLetters == newA.Length)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return true;
            }       
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return false;
            }
           
        }
    }
    
}
