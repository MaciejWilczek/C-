namespace Pralka
{
    class Pralka {
        private int program = 1;
        private int wirowanie = 0;

        
        public void Start()
        {

        }
        public void UstawProgram(string akcja)
        {
            if (akcja == "p+")
            {
                this.program += 1;
                if (this.program >= 6)
                    this.program = 1;
            }
            else
            {
                this.program -= 1;
                if (this.program <= 0)
                    this.program = 5;
            }
            Console.WriteLine("Ustawiono program nr: " + this.program);
        }
        public void UstawWirowanie(string akcja)
        {

        }
        private void Pranie()
        {

        }
        private void Plukanie()
        {

        }
        private void Wirowanie()
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pralka p = new Pralka();
            p.UstawProgram("p+");
        }
    }
}
