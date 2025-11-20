namespace Statystyka_liter
{
    internal class Program
    {
        private static string StatystykaZnaków(string s)
        {
            SortedDictionary<char, int> Litery = new SortedDictionary<char, int>();
            string wynik = string.Empty;

            foreach (char c in s)
                if (Litery.ContainsKey(c))
                    Litery[c] += 1;
                else
                    Litery.Add(c, 1);
            foreach (var e in Litery)
                wynik += $"{e.Key}: {e.Value} \n";
            return wynik;

        }   
        static void Main(string[] args)
        {
            string s = string.Empty;
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
                s += (char)r.Next('a', 'z' + 1);
            Console.WriteLine(s);
            Console.WriteLine(StatystykaZnaków(s));

        }
    }
}
