 class Program
    //program zawiera
    //dictionary
    //try-catch-finally
    {
        static void Main(string[] args)
        {

            // Tworzymy słownik z kluczami i wartościami
            Dictionary<string, int> slownik = new Dictionary<string, int>();

            // Dodajemy elementy do słownika
            slownik.Add("Jeden", 1);
            slownik.Add("Trzy", 3);
            slownik.Add("Pięć", 5);

            try // Próba wypisania liczby "Sześć", której nie ma w słowniku
            {
                Console.WriteLine(slownik["Sześć"]);

            }
            catch (KeyNotFoundException) // Wynik po złapaniu wyjątku
            {
                Console.WriteLine("Wartość nie istnieje w słowniku");
            }
            finally // Wynik końcowy, bez znaczenia czy wystąpił wyjątek
            {
                Console.WriteLine("Końcowa wiadomość :)");
            }
        }
    }

