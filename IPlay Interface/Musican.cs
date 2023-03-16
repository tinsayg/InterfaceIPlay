//Created by Tinsay
//Last Modified 3/16/2023


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlay_Interface
{
    public class Musician : IPlay
    {
        //class variables 
        private string name = "n/a";
        private string favoriteInstrument = "n/a;";

        //gets and sets 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string FavoriteInstrument
        {
            get { return this.favoriteInstrument; }
            set { this.favoriteInstrument= value; }
        }

        //constructors 

        public Musician(string aName, string aFavoriteInstrument)
        {
            this.Name = aName;
            this.FavoriteInstrument = aFavoriteInstrument;
        }

        //methods 

        public override string ToString()
        {
            string msg = "";
            msg += "Name: " + this.Name + "\n" +
                "Favorite Instrument: " + this.FavoriteInstrument;
            return msg;
        }

        public string Play()
        {
            return "The Musician Plays his favorite instrument" + "\n";
        }
    }
}
