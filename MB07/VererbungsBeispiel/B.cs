namespace MB07.VererbungsBeispiel
{
    internal class B : A
    {

        public B(string n) : base(n)
        {
            Console.WriteLine("B");
        }

        public void Methode1()
        {
            base.Methode1();
            Console.WriteLine("Methode B");
        }
    }
}
