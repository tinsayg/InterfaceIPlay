using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlay_Interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //creating new objects
            Gamer aGamer = new Gamer("John", "Mortal Combat");
            Athlete anAthlete = new Athlete("Ronaldo", "Football");
            Musician aMusician = new Musician("Weekend", "FreeStyle");

            //Creating and adding them to a list
            List<IPlay> aListOfPlayers = new List<IPlay> { aGamer,anAthlete,aMusician };

            //Printing them out
            foreach(var a in aListOfPlayers)
            {
                Console.WriteLine (a.ToString());
                Console.WriteLine(a.Play());
            }

            Console.ReadLine();
        }
    }
}
