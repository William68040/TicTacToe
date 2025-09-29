using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// En enkel mänsklig spelare med namn och symbol (X eller O).
    /// </summary>
    class Player
    {
        public string Name { get; }   // spelarens namn
        public char Symbol { get; }   // 'X' eller 'O'

        public Player(string name, char symbol)
        {
            // Om användaren inte skrev något namn -> sätt standardnamn
            Name = string.IsNullOrWhiteSpace(name) ? "Spelare" : name;
            Symbol = symbol;
        }
    }
}
