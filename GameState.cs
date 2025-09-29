using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Håller koll på vems tur det är, om spelet är slut och vem som vann.
    /// </summary>
    class GameState
    {
        public Player CurrentPlayer { get; private set; } // vems tur just nu
        public bool IsOver { get; private set; }          // om spelet är slut
        public Player Winner { get; private set; }        // vinnaren (null om oavgjort)
        public bool IsDraw => IsOver && Winner == null;   // sant om oavgjort

        // Konstruktor – spelet startar med en viss spelare
        public GameState(Player first)
        {
            CurrentPlayer = first;
            IsOver = false;
            Winner = null;
        }

        // Byt tur till den andra spelaren
        public void NextTurn(Player a, Player b)
        {
            CurrentPlayer = CurrentPlayer == a ? b : a;
        }

        // Markera att någon har vunnit
        public void SetWinner(Player p)
        {
            IsOver = true;
            Winner = p;
        }

        // Markera oavgjort
        public void SetDraw()
        {
            IsOver = true;
            Winner = null;
        }
    }
}
