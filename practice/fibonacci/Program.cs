namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci sorozat, mindig az előző két szám összege adja az új szám értékét
            int a = 1;
            int b = 2;
            int c;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
