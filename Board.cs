using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        public char[] Square { get; private set; }

        public Board()
        {
            Square = new char[10];
            for (int i = 1; i <= 9; i++)
            {
                Square[i] = (char)('0' + i);
            }
        }
        public void _Board()
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
