using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary
            dictionary segítségével adatokat tárolhatunk kulcs: érték párosításban, hasonlóképp mint ahogy egy szótár is felépül
            a dictionary egy olyan collection, ami rendezve van, módosítható és nem enged duplikációt. 
            C# programozási nyelvben a kulcs értékpáros szigorúan típusos, tehát a létrehozáskor meg kell adni az kulcs és az érték típusát is.
            Nem lehetséges eltérő típusú változót tárolni az értékek közt, mint például pythonban. 
            Ezt meg lehet kerülni, ha stringben vannak tárolva az eltérő értékek és később alakítod át feldolgozás során.

            így épül fel: var név = new Dictionary<kulcs típusa, érték típusa>() {{"kulcs1" : "érték1", "kulcs2" : "érték2"}}
            */
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //Üres dictionary-hez így adunk értéket
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var capitalCities = new Dictionary<string, string>(){
                {"UK", "London"},
                {"USA", "Washington"},
                {"India", "New-Delhi"}
                };

            foreach (var kvp in capitalCities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //Egy érték kiíratása:
            Console.WriteLine(capitalCities["UK"]);

            //Ha nem ismered a kulcsokat és megtippelnéd van-e olyan kulcs a dictionaryben
            if (capitalCities.ContainsKey("France"))
            {
                Console.WriteLine(capitalCities["France"]);
            }

            //Másik megoldás ugyanerre a problémára
            string result;

            if (capitalCities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //ElementAt(): visszatér az kulcs-érték párossal indexet használva
            for (int i = 0; i < capitalCities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    capitalCities.ElementAt(i).Key,
                    capitalCities.ElementAt(i).Value);
            }

            //Érték felülírása új értékkel meglévő kulcs esetén
            capitalCities["UK"] = "Liverpool, Bristol"; // update value of UK key
            capitalCities["USA"] = "Los Angeles, Boston"; // update value of USA key

            //Ha új kulcsot is szeretnél hozzáadni az új értékkel:
            capitalCities.Add("France", "Paris");
            Console.WriteLine(capitalCities["France"]);

            //Eltávolítás
            capitalCities.Remove("UK"); // eltávolítja: "UK" kulcsot és az értéket

            foreach (var item in capitalCities)
            {
                Console.WriteLine(item);
            }

            //Dictionary teljes kiürítése. Minden kulcs és érték törlődik 
            //capitalCities.Clear();
        }
    }
}
