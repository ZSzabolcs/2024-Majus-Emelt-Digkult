namespace ZelenakSz_13.A_belepteto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("bedat.txt");
            List<Tanulo> diakok = new List<Tanulo>();
            while (!sr.EndOfStream)
            {
                var sor = sr.ReadLine().Split(" ");
                Tanulo diak = new Tanulo(sor[0], TimeOnly.Parse(sor[1]), int.Parse(sor[2]));
                diakok.Add(diak);
            }
            Console.WriteLine($"2. feladat");
            //Kihasználhatom, hogy az adatok időrendi sorrendben vannak.
            //Az első esemény belépés, az utolsó kilépés.
            //Az adatok helyességét nem kell ellenőriznem.
            TimeOnly elso = diakok[0].Ido;
            TimeOnly utolso = diakok[diakok.Count - 1].Ido;
            Console.WriteLine($"Az első tanuló belépésének ideje: {elso}\nAz utolsó tanuló kilépésének ideje: {utolso}");

            StreamWriter sw = new StreamWriter("kesok.txt");
            foreach ( var item in diakok)
            {
                if (item.Ido.Hour >= 7 && item.Ido.Minute > 50 && item.Ido.Hour <= 8 && item.Ido.Hour <= 15 && item.Szam == 1)
                {
                    sw.WriteLine($"{item.Kod} {item.Ido}");
                }
            }
            sw.Close();

            int ebedDb = 0;
            foreach (var item in diakok)
            {
                if (item.Szam == 3)
                {
                    ebedDb++;
                }
            }
            Console.WriteLine($"\n4. feladat\nA menzán aznap {ebedDb} tanuló ebédelt.");

            int kolcsonDb = 0;
            List<string> kodok = new List<string>();
            foreach (var item in diakok)
            {
                if (item.Szam == 4 && !kodok.Contains(item.Kod))
                {
                    kolcsonDb++;
                    kodok.Add(item.Kod.ToString());
                }
            }
            string message = "Ugyanannyian kölcsönöztek, ahányan ebédeltek.";
            if (ebedDb > kolcsonDb)
            {
                message = "Nem voltak többen, mint a menzán.";
            }
            if (ebedDb < kolcsonDb)
            {
                message = "Többen voltak, mint a menzán.";
            }
            Console.WriteLine($"\n5. feladat\nAznap {kolcsonDb} tanuló kölcsönzött a könyvtárban.\n{message}");

            Console.WriteLine("\n6. feladat\nAz érintett tanulók:");

            List<string> bejelentkezett = new List<string>();
            List<string> eredmeny = new List<string>();
            foreach (var item in diakok)
            {
                if (((item.Ido.Hour == 10 && item.Ido.Minute > 50) || (item.Ido.Hour == 11 && item.Ido.Minute == 0)) && item.Szam == 1)
                {
                    if (bejelentkezett.Contains(item.Kod))
                    {
                        if (!eredmeny.Contains(item.Kod))
                        {
                            eredmeny.Add(item.Kod);
                        }
                    }
                }
                if (!bejelentkezett.Contains(item.Kod) && item.Szam == 1)
                {
                    bejelentkezett.Add(item.Kod);
                }
                else if (item.Szam == 2)
                {
                    bejelentkezett.Remove(item.Kod);
                }
            }
            eredmeny.Sort();
            Console.WriteLine(string.Join(" ", eredmeny));

            Console.WriteLine("\n7. feladat\nKérem a tanuló azonosítóját: ");
            string? azonosito = "";
            bool helytelen = true;
            do
            {
                azonosito = Console.ReadLine();
                foreach (var item in diakok)
                {
                    if (item.Kod.ToString() == azonosito.ToString())
                    {
                        helytelen = false;
                        break;
                    }
                }
                if (helytelen)
                {
                    Console.WriteLine("Ilyen azonosítójú tanuló aznap nem volt az iskolában.\nKérem a tanuló azonosítóját: ");
                }
            } while (helytelen);

            Console.ReadKey();
        }
    }
}
