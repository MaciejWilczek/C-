namespace Konstruktory
{
    class Tablica
    {
        public int[] tablica = new int[3];

        public Tablica(int[] tablica)
        {
            this.tablica = tablica;
        }
        public Tablica()
        {
            tablica = [0,0,0];
        }
        public Tablica(Tablica tab)
        {
            //this.tablica = tab.tablica;
            for (int i = 0; i < tab.tablica.Length; i++)
            {
                tablica[i] = tab.tablica[i];
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int i in tablica) 
                s += i.ToString();
            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tablica t1 = new Tablica([1,2,3]);
            Console.WriteLine(t1);
            Tablica t2 = new Tablica();
            Console.WriteLine(t2);
            Tablica t3 = new Tablica(t1);
            Console.WriteLine(t3);
        }
    }
}
