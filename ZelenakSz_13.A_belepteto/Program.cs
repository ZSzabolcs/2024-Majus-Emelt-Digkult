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
            for (int i = 0;  i < diakok.Count; i++)
            {
                Console.WriteLine(diakok[i].Ido);
            }
        }
    }
}
