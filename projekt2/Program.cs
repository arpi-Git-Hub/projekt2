namespace projekt2
{
    internal class Program
    {

        static List<Alkatresz> alkatreszek;

        static void Beolvasas(string fajlNev)
        {
            alkatreszek = new List<Alkatresz>();
            foreach (var sor in File.ReadAllLines(fajlNev))
            {
                var sorElemei = sor.Split(';');
                string t = sorElemei[0];
                string n = sorElemei[1];
                string p = sorElemei[2];
                int a = int.Parse(sorElemei[3]);             
                alkatreszek.Add(new Alkatresz(t, n, p, a));
            }
        }

        static void Kiirat(string fajlNev)
        {
            Console.Write("Idáig bevitt alkatrészek törlése(i/n): ");
            string valasz1 = Console.ReadLine();
            if (valasz1 == "i")
            {
                File.WriteAllText(fajlNev, "");
                Console.WriteLine("Alkatrészek törölve.");
            }
            else if (valasz1 == "n")
            {
                Console.Write("Új alkatrész bevitele (i/n): ");
            }

            for (int i = 0; i < i + 1; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("ÚJ ALKATRÉSZ");
                Console.Write("Alkatrész típusa: ");
                string tipus = Console.ReadLine();
                Console.Write("Alkatrész neve: ");
                string nev = Console.ReadLine();
                Console.Write("Alkatrész paraméter: ");
                string parameter = Console.ReadLine();
                Console.Write("Alkatrész ára: ");
                string ar = Console.ReadLine();
                File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                Console.Write("Új alkatrész bevitele (i/n): ");
                string valasz2 = Console.ReadLine();
                if (valasz2 == "n")
                {
                    break;
                }
            }

            
        }

        static void Main(string[] args)
        {
            
            Kiirat("fajl.txt");

            Beolvasas("fajl.txt");

            Console.WriteLine("\n");
            Console.WriteLine("KERESÉS");
            Console.WriteLine("1. Keresés alkatrész típusára");
            Console.Write("Alkatrész típusa vagy neve: ");
            string tipusnevBe = Console.ReadLine();
            foreach(var a in alkatreszek)
            {
                if(a.Tipus == tipusnevBe)
                {
                    Console.WriteLine($"\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr:{a.Ar}");
                }
                else if(a.Nev == tipusnevBe)
                {
                    Console.WriteLine($"\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr:{a.Ar}");
                }
            }
        }
    }
}