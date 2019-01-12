using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe
{
    public class HelloExercise
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console and greet Crowe reviewers.
            Console.WriteLine("Hello World, specifically Crowe!  I'm J.J.");
            TalkToMe();
        }

        public static void TalkToMe()
        {
            //Ask the user if they're interested in a random fact.
            Console.WriteLine("Would you like to know a random fact? Y or N");
            string wantsToChat = Console.ReadLine();

            if (wantsToChat.ToUpper() == "Y")
            {
                //Get their name and then provide fact randomly from string array in separate class representing data.
                Console.WriteLine("Splendid! But first, tell me your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Hello {0}!  Here is your random fact.", userName);
                DataPulls dataPulls = new DataPulls();               
                Console.WriteLine(dataPulls.GrabFact());
                Console.ReadLine();
            }
            else if (wantsToChat.ToUpper() == "N")
            {
                //Respect their choice and wish them well.
                Console.WriteLine("Well, that's a shame. Enjoy your day.");
                Console.ReadLine();
            }
            else
            {
                //Assume a no response.
                Console.WriteLine("That was not a Y or N, but I'll take it as a N.  Enjoy your day.");
                Console.ReadLine();
            }
        }
    }
}
