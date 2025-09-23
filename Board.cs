using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTacToe
{
    internal class Board
    {
        public char[] Square { get; private set; }

        public Board() // Körs när vi skappar ett nytt bräde 
        {
            Square = new char[10]; // för att index 0 inte används "9"
            for (int i = 1; i <= 9; i++)
            {
                Square[i] = (char)('0' + i); // Fyll rutorna med "1" - "9" 
            }
        }
        public void _Board() // visar brädet i konsolen
        {
            Console.Clear();
            Console.WriteLine(" {0} | {1} | {2} ", Square[1], Square[2], Square[3]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", Square[4], Square[5], Square[6]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", Square[7], Square[8], Square[9]);
        }

        
        public bool IfSquareEmpty(int pos)
        {
            return Square[pos] != 'X' && Square[pos] != 'O';    // Om en ruta är ledig
        }
        
        // Måste lägga in position, Spelarens symbol fyller ruta
        // Om man lägger in fel värde
        

        
        
        public bool IfBoardIsFull()
        {
            for (int i = 1; i <= 9; i++)
            { 
                if (Square[i] != 'X' && Square[i] != 'O')    // Om alla rutor är upptagna 
                    return false;   
            }
        return true;    
        }
        

    }

}

        // klass Board
        //variabel: Ruta[1..9]   // array med 9 rutor
        //    konstruktor:
      // en array Ruta med 10 element (ignorera index 0)
      // för i från 1 till 9:
      //  sätt Ruta[i] till tecknet motsvarande siffran i
      // t.ex. i=3 ger Ruta[3] = '3'
      // metod Display():
    //   rensa skärmen
      //   skriv ut spelplanen i format:
  //         Ruta[7] | Ruta[8] | Ruta[9]
 //        -- - +---+---
 //        Ruta[4] | Ruta[5] | Ruta[6]
 //       -- - +---+---
//       Ruta[1] | Ruta[2] | Ruta[3]
  // metod IsCellEmpty(pos):
 //   returnera true om Ruta[pos] inte är 'X' och inte är 'O'
 //    annars returnera false
//  metod PlaceSymbol(pos, symbol):
 //   om IsCellEmpty(pos) är true:
//        sätt Ruta[pos] = symbol
//  metod IsFull():
//   för varje position från 1 till 9:
 //      om Ruta[i] inte är 'X' och inte är 'O':
//       returnera false
//  returnera true