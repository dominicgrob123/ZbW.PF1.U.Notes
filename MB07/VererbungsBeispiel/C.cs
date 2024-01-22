namespace MB07.VererbungsBeispiel
{
    internal class C : B
    {

        public C(string n) : base(n)
        {
            Console.WriteLine("C");
        }

        public void Methode1()
        {
            Console.WriteLine("Methode C");
            base.Methode1();
        }
    }
}