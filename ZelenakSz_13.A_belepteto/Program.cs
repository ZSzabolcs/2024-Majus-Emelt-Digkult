namespace ZelenakSz_13.A_belepteto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:\\Users\\zelenaksz\\source\\repos\\ZelenakSz_13.A_belepteto\\ZelenakSz_13.A_belepteto\\bedat.txt");
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
        }
    }
}
