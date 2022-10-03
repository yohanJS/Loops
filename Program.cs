using System;

namespace LoopsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomText = "amway to popular belief, aorem Ipsum is not simply andom text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered ahe undoubtable source. aorem Ipsum comes from aections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.";

            string[] randomTextArray = randomText.Split(' ');

            //string[] startsWithLetterA = new string[randomTextArray.Length];    


            string wordsWithA = startsWithA(randomTextArray);

            Console.WriteLine(wordsWithA);
        }
        static string startsWithA(string[] text)
        {
            string withA = "";
            foreach (var word in text)
            {
                if (word.StartsWith("a") && word.Length > 3)
                {
                    withA += $"{word}, ";
                }
            }
            return withA;
        }
    }
}
