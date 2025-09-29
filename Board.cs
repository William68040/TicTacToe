using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// 3x3-bräde. Rutor numreras som ett numeriskt tangentbord:
    /// 7 8 9
    /// 4 5 6
    /// 1 2 3
    /// </summary>
    class Board
    {
        // index 0..8 motsvarar ordningen [7,8,9,4,5,6,1,2,3]
        private readonly char[] cells = new char[9];

        // inmatning (1..9) -> index
        private static readonly Dictionary<int, int> inputToIndex = new Dictionary<int, int>
        {
            {7,0},{8,1},{9,2},
            {4,3},{5,4},{6,5},
            {1,6},{2,7},{3,8}
        };

        public Board()
        {
            for (int i = 0; i < cells.Length; i++)
                cells[i] = ' ';
        }

        // Ritar brädet. Tom ruta visar sin siffra som hjälp.
        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("TicTacToe – rutor som på numpaden (7-8-9 / 4-5-6 / 1-2-3)\n");

            char Show(int idx, int number) => cells[idx] == ' ' ? number.ToString()[0] : cells[idx];

            Console.WriteLine($" {Show(0, 7)} | {Show(1, 8)} | {Show(2, 9)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Show(3, 4)} | {Show(4, 5)} | {Show(5, 6)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Show(6, 1)} | {Show(7, 2)} | {Show(8, 3)} ");
            Console.WriteLine();
        }

        public bool IsFull()
        {
            foreach (var c in cells)
                if (c == ' ') return false;
            return true;
        }

        /// <summary>
        /// Försök placera symbol i vald knapp (1..9). Returnerar false om otillåtet.
        /// </summary>
        public bool PlaceMark(int keypadNumber, char symbol)
        {
            if (!inputToIndex.ContainsKey(keypadNumber)) return false;
            int idx = inputToIndex[keypadNumber];
            if (cells[idx] != ' ') return false; // redan upptagen
            cells[idx] = symbol;
            return true;
        }

        /// <summary>Hämta tecknet i given cell (0..8).</summary>
        public char GetCell(int index) => cells[index];
    }
}
