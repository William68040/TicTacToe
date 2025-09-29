using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Kollar om någon har vunnit på spelplanen.
    /// </summary>
    static class Checkwinner
    {
        // Alla vinstlinjer (3 rader, 3 kolumner, 2 diagonaler)
        private static readonly int[][] Lines = new int[][]
        {
            // rader
            new[]{0,1,2}, new[]{3,4,5}, new[]{6,7,8},
            // kolumner
            new[]{0,3,6}, new[]{1,4,7}, new[]{2,5,8},
            // diagonaler
            new[]{0,4,8}, new[]{2,4,6}
        };

        /// <summary>
        /// Returnerar 'X' eller 'O' om någon har vunnit, annars ' ' (ingen).
        /// </summary>
        public static char GetWinner(Board board)
        {
            foreach (var line in Lines)
            {
                char a = board.GetCell(line[0]);
                char b = board.GetCell(line[1]);
                char c = board.GetCell(line[2]);

                // Om alla tre är lika och inte tomma => vinnare
                if (a != ' ' && a == b && b == c)
                    return a;
            }
            return ' '; // ingen vinnare ännu
        }
    }
}
