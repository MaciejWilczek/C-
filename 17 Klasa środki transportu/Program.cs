namespace _17_Klasa_środki_transportu
{
    internal class Program
    {
        interface IJedz
        {
            void jedz();
        }
        interface ILec
        {
            void lec();
        }
        interface IPlyn
        {
            void plyn();
        }

        abstract class SrodkiTransportu
        {
            public abstract string nazwa { get; protected set; }
        }
        abstract class Ladowe : SrodkiTransportu , IJedz
        { 
            public abstract void jedz();
        }
        abstract class Powietrzne : SrodkiTransportu, ILec
        {
            public abstract void lec();
        }
        abstract class Wodne : SrodkiTransportu, IPlyn
        {
            public abstract void plyn();
        }
        class Samolot : Powietrzne
        {
            public override string nazwa { get; protected set; }
        }

        class Auto : Ladowe
        {
            public override string nazwa { get; protected set; }
            public override void jedz()
            {
                Console.WriteLine("Ruszyłem się o ileś");
            }
            public Auto(string nazwa) => this.nazwa = nazwa;

            public override string ToString()
            {
                return "Auto o nazwie: "+nazwa;
            }
        }
        

        static void Main(string[] args)
        {
            Auto a = new Auto("BMW");
            Console.WriteLine(a);
        }
    }
}
