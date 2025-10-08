namespace Liczby_zespolone
{
        class Zespolona
        {
            public double liczba1 { get; }
        public double liczba2 { get; }

            public Zespolona(double a, double b)
            {
                this.liczba1 = a;
                this.liczba2 = b;
            }
            public override string ToString()
            {
                return liczba1 + " + " + liczba2 + "i";
            }
            public static Zespolona operator +(Zespolona l1, Zespolona l2)
            {
                return new Zespolona((l1.liczba1 + l2.liczba1), (l1.liczba2 + l2.liczba2));
            }
            public static Zespolona operator -(Zespolona l1, Zespolona l2)
            {
                return new Zespolona((l1.liczba1 - l2.liczba1), (l1.liczba2 - l2.liczba2));
            }
            public static Zespolona operator *(Zespolona l1, Zespolona l2)
            {
                return new Zespolona((l1.liczba1*l2.liczba1-l1.liczba2*l2.liczba2),(l1.liczba1*l2.liczba2+l1.liczba2*l2.liczba1)); // W notatce było ac=((AC-BD),(AD-BC)i) a w 2 powinien być plus zamiast minusa
        }                                                                                                                          // Czyli ac=((AC-BD),(AD+BC)i)
        public static Zespolona operator *(int liczba, Zespolona l1)
            {
                return new Zespolona(l1.liczba1*liczba,l1.liczba2*liczba);
            }
        public static Zespolona operator *(Zespolona l1 ,int liczba)
        {
            return new Zespolona(l1.liczba1 * liczba, l1.liczba2 * liczba);
        }
        public static Zespolona operator ~(Zespolona l1)
            {
                return new Zespolona(l1.liczba1,-l1.liczba2);
            }
    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            Zespolona a = new Zespolona(1, 4);
            Zespolona b = new Zespolona(2, 5);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(3 * b);
            Console.WriteLine(a * 4);
            Console.WriteLine(~b);
            Console.WriteLine(~a);
        }
    }
}
