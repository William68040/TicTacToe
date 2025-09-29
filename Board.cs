using System;
using System.Collections.Generic;
using System.Linq;
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
        // 9 celler (3x3). Index 0..8 motsvarar knapparna i ordningen: 7,8,9,4,5,6,1,2,3
        private readonly char[] cells = new char[9];

        // Översättning från knapp (1–9) till index i cells
        private static readonly Dictionary<int, int> inputToIndex = new Dictionary<int, int>
        {
            {7,0},{8,1},{9,2},
            {4,3},{5,4},{6,5},
            {1,6},{2,7},{3,8}
        };

        // Konstruktor – fyller alla rutor med blank (tomma)
        public Board()
        {
            for (int i = 0; i < cells.Length; i++)
                cells[i] = ' ';
        }

        // Ritar brädet på konsolen
        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("TicTacToe – rutor som på numpaden (7-8-9 / 4-5-6 / 1-2-3)\n");

            // Om rutan är tom: visa sitt nummer, annars visa X eller O
            char Show(int idx, int number) => cells[idx] == ' ' ? number.ToString()[0] : cells[idx];

            Console.WriteLine($" {Show(0, 7)} | {Show(1, 8)} | {Show(2, 9)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Show(3, 4)} | {Show(4, 5)} | {Show(5, 6)} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {Show(6, 1)} | {Show(7, 2)} | {Show(8, 3)} ");
            Console.WriteLine();
        }

        // Returnerar true om alla rutor är fyllda
        public bool IsFull()
        {
            foreach (var c in cells)
                if (c == ' ') return false;
            return true;
        }

        /// <summary>
        /// Försök placera symbol i vald ruta (1..9). Returnerar false om draget är ogiltigt.
        /// </summary>
        public bool PlaceMark(int keypadNumber, char symbol)
        {
            if (!inputToIndex.ContainsKey(keypadNumber)) return false; // ogiltigt nummer
            int idx = inputToIndex[keypadNumber];
            if (cells[idx] != ' ') return false; // rutan redan upptagen
            cells[idx] = symbol;
            return true;
        }

        // Hämtar symbolen i en cell (för att kunna kontrollera vinst)
        public char GetCell(int index) => cells[index];
    }
}
