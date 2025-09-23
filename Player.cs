using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player
    {
        private string name;
        private char marker;    

        public Player(string name, char marker)
        {
            this.name = name;
            this.marker = marker;
        }

        public string GetName()
        {
            return name;
        }

        public char GetMarker()
        {
            return marker;
        }

        // metod för att göra sitt drag på brädan
        public void MakeMove()
        {
            //välj en rad och kolumn
            // om brädan har en ledig plats
            // placera ut marker på platsen
            //försök annars igen
        }


    }

}
