namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            // Ställ in konsolen för UTF-8 (för att kunna visa t.ex. svenska tecken)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Fråga efter spelare 1:s namn
            Console.Write("Spelare 1 namn (X): ");
            string n1 = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(n1)) n1 = "Spelare 1"; // fallback om inget skrivs
            
            var p1 = new Player(n1, 'X'); // spelare 1 använder symbol X

            // Fråga efter spelare 2:s namn
            Console.Write("Spelare 2 namn (O): ");
            string n2 = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(n2)) n2 = "Spelare 2"; // fallback
            
            var p2 = new Player(n2, 'O'); // spelare 2 använder symbol O

            var board = new Board();          // spelplan
            var state = new GameState(p1);    // startar med spelare 1

            // Spelloop – kör tills spelet är över (vinst eller oavgjort)
            while (!state.IsOver) // '!' betyder "inte", alltså "så länge spelet inte är över"
            {
                board.Draw(); // rita brädet
                
                Console.Write($"{state.CurrentPlayer.Name} ({state.CurrentPlayer.Symbol}), välj ruta (1–9): ");

                // Läs in användarens drag
                string input = Console.ReadLine();
                
                bool ok = int.TryParse(input, out int number) &&
                          board.PlaceMark(number, state.CurrentPlayer.Symbol);

                if (!ok)
                {
                    // Olagligt drag – spelplan oförändrad och samma spelare får försöka igen
                    Console.WriteLine("Olagligt drag. Försök igen (valfri tangent)...");
                    Console.ReadKey(true);
                    continue;
                }

                // Kolla om någon vann efter draget
                char win = Checkwinner.GetWinner(board); // 'char' betyder ett enda tecken, X eller O

                if (win == 'X' || win == 'O')
                {
                    // Sätt vinnare i GameState
                    state.SetWinner(win == p1.Symbol ? p1 : p2); // '?' är en kort if-sats, väljer p1 om symbolen matchar, annars p2
                    break;
                }

                // Om hela brädet är fullt utan vinnare -> oavgjort
                if (board.IsFull())
                {
                    state.SetDraw(); // Sätter spelet till oavgjort
                    break;
                }

                // Annars går turen till den andra spelaren
                state.NextTurn(p1, p2); // Växlar turen till nästa spelare
            }

            // Visa slutresultatet
            board.Draw();
            
            if (state.IsDraw)
                Console.WriteLine("Oavgjort! Spelplanen är full.");
            
            else
                Console.WriteLine($"Vinnare: {state.Winner.Name} ({state.Winner.Symbol})");

            Console.WriteLine("\nTack för att du spelade! Tryck valfri tangent för att avsluta.");
            Console.ReadKey(true);
        }
    }
}
