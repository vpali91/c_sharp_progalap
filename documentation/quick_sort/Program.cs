using System;

namespace QuickSort
{
    class Program
    {
        static void TombKiir(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                Console.Write("{0}, ", elem);
            }
            Console.WriteLine();
        }

        public static void Gyorsrendez(int[] tomb, int eleje, int vege)
        {
            if (eleje < vege)
            {
                int kozepe = Feloszt(tomb, eleje, vege);
                Gyorsrendez(tomb, eleje, kozepe - 1);
                Gyorsrendez(tomb, kozepe + 1, vege);
            }
        }

        private static int Feloszt(int[] tomb, int eleje, int vege)
        {
            int kozepe = tomb[vege-1];
            int kozepindex = eleje;

            for (int i = eleje; i < vege; i++)
            {
                if (tomb[i] <= kozepe)
                {
                    int temp = tomb[i];
                    tomb[i] = tomb[kozepindex];
                    tomb[kozepindex] = temp;
                    kozepindex++;
                }
            }

            int kozepindexErteke = tomb[kozepindex-1];
            tomb[kozepindex-1] = tomb[vege-1];
            tomb[vege-1] = kozepindexErteke;
            return kozepindex;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Gyors rendezés:");
            Gyorsrendez(tomb, 0, tomb.Length);
            TombKiir(tomb);

            Console.ReadKey();
        }
    }
}
