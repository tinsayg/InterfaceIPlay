//Created by Tinsay
//Last Modified 3/16/2023


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlay_Interface
{
    public class Athlete : IPlay
    {
        //class variables 
        private string name = "n/a";
        private string favoriteSport = "n/a;";

        //gets and sets 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string FavoriteSport
        {
            get { return this.favoriteSport; }
            set { this.favoriteSport = value; }
        }

        //constructors 

        public Athlete(string aName, string aFavoriteSport)
        {
            this.Name = aName;
            this.FavoriteSport = aFavoriteSport;
        }

        //methods 

        public override string ToString()
        {
            string msg = "";
            msg += "Name: " + this.Name + "\n" +
                "Favorite Sport: " + this.FavoriteSport;
            return msg;
        }

        public string Play()
        {
            return "The Athlete Plays his favorite sport" + "\n";
        }
    }
}
