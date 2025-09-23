using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class GameState
    {
        public enum State
        {
            Undecided,
            Won,
            Draw
        }
        public void ShowResult(State CurrentState)
        {
            if (CurrentState == State.Undecided)
            {
                /// Spelet pågår, gör inget
            }


            else if (CurrentState == State.Won)
            {
                Console.WriteLine("Player X has won!");
            }

            else
            {
                Console.WriteLine("The game is a draw!");
            }
        }
    }
}

/// A) Skapa en enum som heter State.

/// B) Lägg till tre olika tillstånd i denna enum:
/// Undecided → när spelet fortfarande pågår.
/// Won → när en spelare har vunnit.
/// Draw → när spelplanen är full men ingen vinnare finns.

///C) I början av spelet ska en variabel state sättas till GameState.Undecided.

///D) Efter varje drag ska programmet kontrollera:
/// Om en spelare har vunnit → ändra state till GameState.Won.
/// Om spelplanen är full och ingen vinnare finns → ändra state till GameState.Draw.
/// Annars låt state vara kvar som GameState.Undecided.

/// E) Spelets huvudloop ska fortsätta köra så länge state är Undecided.

/// F) När loopen avslutas:
/// Om state är Won → skriv ut vem som vann.
/// Om state är Draw → skriv ut att det blev oavgjort.