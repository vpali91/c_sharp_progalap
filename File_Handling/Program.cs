using System;
using System.Collections.Generic;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írás
            // Ez létrehoz egy file-t sample.txt néven
            // a megadott helyen 
            StreamWriter sw = new StreamWriter("D://sample.txt");

            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor \n incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, \n sunt in culpa qui officia deserunt mollit anim id est laborum.";

            sw.WriteLine(str);
            sw.Flush();
            // Zárni is kell
            sw.Close();

            List<string> szoveg = new List<string>();
            //beolvasás
            //itt most éppen relatív útvonalat adtam meg, fontos hogy legyen a file a debug mappában
            StreamReader sr = new StreamReader("npcs.txt");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // beolvassa az első sort a szövegből
            string str2 = sr.ReadLine();
            szoveg.Add(str2);
            // Végigolvassa a teljes szöveget soronként, itt nem menti el
            while (str2 != null)
            {
                //Console.WriteLine(str2);
                str2 = sr.ReadLine();
                //ha nem adjuk hozzá listához vagy tömbhöz, akkor ez az adat törlődik a close()után
                szoveg.Add(str2);
            }
            Console.ReadLine();

            // to close the stream
            sr.Close();

            foreach (var item in szoveg)
            {
                Console.WriteLine(item);
            }

            //Beolvasás másképp:
            List<NPC> npc_list = new List<NPC>();
            string[] lines = File.ReadAllLines("npcs.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(',');
                NPC npc_object = new NPC(values[0], values[1], int.Parse(values[2]), bool.Parse(values[3]));
                npc_list.Add(npc_object);
            }

            foreach (var item in npc_list)
            {
                Console.WriteLine($"{item.name} {item.race} hp: {item.hp} immortal: {item.immortal}");
            }

        }
    }
}
