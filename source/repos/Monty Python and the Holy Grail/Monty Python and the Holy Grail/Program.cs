using System;

namespace Monty_Python_and_the_Holy_Grail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIR LANCELOT AND THE HOLY GRAIL\n");
            string ending;
            string reply;
            Console.Write("You are Sir Lancelot of Camelot!\nYou need to cross The Bridge of Death while an old man, from Scene 24,\n" +
                "stands and guards it. Sir Lancelot is an educated knight.\n" +
                "When speaking, he must always use the appropriate capital letters\n" +
                "and punctuation,else he shall die!\n\n" +
                "Bridgekeeper: (cackling nastily)\n" +
                "              STOP!\n              " +
                "Who would cross the Bridge of Death\n" +
                "              Must answer me\n" +
                "              These questions three\n" +
                "              Ere the other side he see.\n" +
                "Lancelot:    (stoically) Ask me your questions, Bridgekeeper. I am not afraid!\n" +
                "Bridgekeeper: (cackling all the while) What...is your name?\n" +
                "Lancelot:     ");
            reply = Console.ReadLine();

            if (reply == "My name is Sir Lancelot of Camelot.")
            {
                Console.WriteLine("Bridgekeeper: What...is your quest?");
                Console.Write("Lancelot:     ");
                reply = Console.ReadLine();

                if (reply == "To seek the Holy Grail.")
                {
                    Console.Write("Bridgekeeper: What...is your favorite color?\r\nLancelot:     ");
                    reply = Console.ReadLine();

                    if (reply =="Blue.")
                    {
                        Console.Write("Bridgekeeper: Right, off you go.\n");
                        ending = "Lancelot:     (realizing that was it)  Oh, thank you. Thank you very much!\n\nTHE END!";
                    }
                }
            }
            ending = "Boom! Thus ends Sir Lancelot of Camelot and the quest of the Holy Grail fails.";
            Console.WriteLine(ending);
        }
    }
}
