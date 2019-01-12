using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCrowe
{
    public class DataPulls
    {
        //Demonstrating a code separation for data pulls.  For this exercise, just using string data, but could pull from
        //the App_Data folder and typed datasets contained within if connected to a SQL, or other, data source.
        public string GrabFact()
        {
            string[] facts = { "Newborn elephants suck their trunks for comfort.",
            "The first Macy's Thanksgiving Day Parade featured lions, camels, and elephants from the Central Park Zoo.",
            "Danny DeVito is an experienced hairdresser.",
            "A group of ferrets is called a business.",
            "On Scooby-Doo, Shaggy’s real name is Norville Rogers." };
            return facts[new Random().Next(0, facts.Length)];
        }
    }
}
