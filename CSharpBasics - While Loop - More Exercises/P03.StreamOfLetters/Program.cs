using System;
using System.Linq;

namespace P03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = null;
            bool c = false;
            bool o = false;
            bool n = false;
            string input = null;
            while ((input = Console.ReadLine()) != "End")
            {
                bool isLetter = input.All(Char.IsLetter);
                if (isLetter)
                {
                    if (c == false || o == false || n == false)
                    {
                        if (input == "c")
                        {
                            switch (c)
                            {
                                case true:
                                    word += input;
                                    break;
                                case false:
                                    c = true;
                                    break;
                            }
                        }
                        else if (input == "o")
                        {
                            switch (o)
                            {
                                case true:
                                    word += input;
                                    break;
                                case false:
                                    o = true;
                                    break;
                            }
                        }
                        else if (input == "n")
                        {
                            switch (n)
                            {
                                case true:
                                    word += input;
                                    break;
                                case false:
                                    n = true;
                                    break;
                            }
                        }
                        else
                        {
                            word += input;
                        }
                        if (c == true && o == true && n == true)
                        {
                            word = word + " ";
                            Console.Write(word);
                            c = false;
                            o = false;
                            n = false;
                            word = null;
                        }

                    }
                }
            }
        }
    }
}
