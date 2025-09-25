using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class CheckWinner
    {
        public GetWinner(Board board, Player1 p1, Player2 p2)

            int[][] winningCombinations = new int[][]
            {
                new int[] {1, 2, 3 },
                new int[] {4, 5, 6 },
                new int[] {7, 8, 9 },
                new int[] {1, 4, 7 },
                new int[] {2, 5, 8 },
                new int[] {3, 6, 9 },
                new int[] {1, 5, 9 },
                new int[] {3, 5, 7 }
            }

            if (Square[position1] == Square[position2] && Square[position2] == Square[position3])
            {
                
            }  

    }
}

/// A) Skapa en metod GetWinner(Board board, Player p1, Player p2).
///    Den ska returnera en Player (vinnaren) eller null om ingen vunnit ännu.

/// B) Definiera en lista med alla möjliga vinstkombinationer.
///    Exempel: varje kombination innehåller tre positioner på spelplanen:
///    [1,2,3], [4,5,6], [7,8,9]  (rader)
///    [1,4,7], [2,5,8], [3,6,9]  (kolumner)
///    [1,5,9], [3,5,7]           (diagonaler)

/// C) Gå igenom varje vinstkombination i en loop:
///    1. Kolla om symbolen på första rutan == symbolen på andra rutan
///       OCH symbolen på andra rutan == symbolen på tredje rutan.
///    2. Om detta stämmer har vi hittat en vinnare.

/// D) Hämta vinnarsymbolen (t.ex. 'X' eller 'O') från rutan.
///    - Om vinnarsymbolen == p1.getMarker() → returnera p1.
///    - Om vinnarsymbolen == p2.getMarker() → returnera p2.

/// E) Om loopen är klar och ingen vinnare hittats:
///    returnera null (spelet har inte avgjorts ännu).