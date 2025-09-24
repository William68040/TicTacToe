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
        public void ShowResult(State CurrentState, Player winner)
        {
            if (CurrentState == State.Won)
            {
                Console.WriteLine($"Player {winner.getName()} ({winner.getMarker()}) has won!");
            }


            else if (CurrentState == State.Draw)
            {
                Console.WriteLine("The game is a draw!");
            }

            else if (CurrentState == State.Undecided)
            {
                /// Spelet pågår, gör inget
            }
        }
    }
}

/// A) Skapa en enum som heter State. 

/// B) Lägg till tre olika tillstånd i denna enum:
///    - Undecided → när spelet fortfarande pågår.
///    - Won → när en spelare har vunnit.
///    - Draw → när spelplanen är full men ingen vinnare finns.

/// C) GameState har en metod ShowResult som tar emot:
///    - currentState (av typen State)
///    - winner (av typen Player, kan vara null om det blev oavgjort)

/// D) Om currentState är Won:
///    - Använd winner.getName() och winner.getMarker() för att skriva ut:
///      "Player [namn] ([marker]) has won!"

/// E) Om currentState är Draw:
///    - Skriv ut "The game is a draw!"

/// F) Om currentState är Undecided:
///    - Gör ingenting (spelet pågår fortfarande).
