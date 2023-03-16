//Created by Tinsay
//Last Modified 3/16/2023


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlay_Interface
{
    public class Gamer: IPlay
    {
        //class variables 
        private string name = "n/a";
        private string favoriteGame = "n/a;";

        //gets and sets 
        public string Name 
        { 
            get { return this.name; }
            set { this.name = value; }
        }
        public string FavoriteGame
        {
            get { return this.favoriteGame; }
            set { this.favoriteGame = value; }
        }

        //constructors 

        public Gamer(string aName, string aFavoriteGame)
        {
            this.Name = aName;
            this.FavoriteGame = aFavoriteGame;
        }

        //methods 

        public override string ToString()
        {
            string msg = "";
            msg += "Name: "+ this.Name +"\n"+
                "Favorite Game: "+ this .FavoriteGame;
            return msg;
        }

        public string Play()
        {
            return "The Gamer Plays his favorite game"+"\n";
        }
    }
}
