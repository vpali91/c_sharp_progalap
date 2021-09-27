using System;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömbökben(Arrays) szintem bármilyen változót tudunk tárolni
            //Tömböknél létrehozáskor mindig vagy meg kell adnunk az elemeit, vagy azt hogy hány elemből fog állni. Ez nem is változtatható amíg a memóriában él.

            //üres tömb létrehozása(declaration), ilyenkor meg kell adnunk hány elemből álljon:
            int[] uresTomb = new int[5];

            //Tömb létrehozása értékekkel(minden értéket meg kell adni, vagy a helyére alapértelmezett null értékeket adni)
            int[] tomb1 = new int[]{ 1, 2, 3, 4, 5, 6, 7 };
            //tömböt így is létrehozhatunk:
            int[] tomb2 = new int[] { 3, 4, 7, 2, 9, 10 };

            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            //tomb kiíratása
            Console.WriteLine($"{weekDays[0]}, {weekDays[1]}, stb...");
            foreach (var item in weekDays)
            {
                Console.WriteLine($"Foreach: {item}");
            }

            //Tömb methódusok
            //tomb.Length: Megmondja hány tagú a tömb
            Console.WriteLine($"tomb1.Length: {tomb1.Length}");

            //Equals, összehasonlítása 2 tombnek. True/False értékkel tér vissza
            Console.WriteLine("tomb1.Equals(tomb2): "+tomb1.Equals(tomb2));

            //2D tömbök: Olyan tömb, ami 2 tagú tömböket tartalmaz
            int[,] tomb2D = new int[,] { {1,3},{5,7},{8,9} };
            int[,] btomb2D = new int[3,2] { { 1, 3 }, { 5, 7 }, { 8, 9 } };
            //Kiíratás:
            Console.WriteLine(tomb2D[1,0]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{tomb2D[i,j]}, ");
                }
                Console.WriteLine("");
            }

            //3D tömbök
            int[,,] tomb3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            int[,,] btomb3D = new int[2,2,3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            //Kiíratás:
            Console.WriteLine(tomb3D[1, 0, 0]);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write($"{tomb3D[i,j,k]},");
                    }
                    Console.WriteLine();
                }
            }

            //Jagged array (egyenetlen tömb), Olyan tömb, ami tömböket tartalmaz és a tartalmazott tömbök nem feltétlen egyforma hosszúságúak
            //Első körben meg kell adni hány tömböt tartalmaz a tömb
            int[][] jaggedArray = new int[3][];
            //Második körben meg kell adni, hány tagot tartalmaznak a belső tömbök
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            //Mehet az értékadás:
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            //Kiíratás
            Console.WriteLine($"Jagged: {jaggedArray[1][2]}");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}, ");
                }
                Console.WriteLine();
            }


        }
    }
}
