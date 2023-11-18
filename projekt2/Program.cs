using System.Drawing;

namespace projekt2
{
    internal class Program
    {

        static List<Alkatresz> alkatreszek;

        static void Szin(ConsoleColor szin) { Console.ForegroundColor = szin; }

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
            Beolvasas(@"..\..\..\fajl.txt");
            for (int l = 0; l < l+1; l++)
            {
                Console.Write("Idáig bevitt alkatrészek törlése(i/n): ");
                string valasz1 = Console.ReadLine();
                if (valasz1 == "i")
                {
                    File.WriteAllText(fajlNev, "");
                    Szin(ConsoleColor.Green);
                    Console.WriteLine("Alkatrészek törölve.");
                    Szin(ConsoleColor.White);
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
                        bool van = false;
                        foreach (var a in alkatreszek)
                        {
                            if (a.Tipus == tipus && a.Nev == nev)
                            {
                                van = true;
                                Szin(ConsoleColor.Red);
                                Console.WriteLine("Ilyen alkatrész már létezik.");
                                Szin(ConsoleColor.White);
                                Console.Write("Másik alkatrész bevitele (i/n): ");
                                string valasz = Console.ReadLine();
                                if (valasz == "n")
                                {
                                    break;
                                }
                            }
                        }
                        if (van == false)
                        {
                            File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                            Console.Write("Új alkatrész bevitele (i/n): ");
                            string valasz2 = Console.ReadLine();
                            if (valasz2 == "n")
                            {
                                break;
                            }
                        }
                        break;
                    }
                    break;
                }
                else if (valasz1 == "n")
                {
                    for (int k = 0; k < k+1; k++)
                    {
                        Console.Write("Új alkatrész bevitele (i/n): ");
                        string valasz3 = Console.ReadLine();
                        if (valasz3 == "i")
                        {
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
                                bool van = false;
                                foreach (var a in alkatreszek)
                                {
                                    if (a.Tipus == tipus && a.Nev == nev)
                                    {
                                        van = true;
                                        Szin(ConsoleColor.Red);
                                        Console.WriteLine("Ilyen alkatrész már létezik.");
                                        Szin(ConsoleColor.White);
                                        Console.Write("Másik alkatrész bevitele (i/n): ");
                                        string valasz = Console.ReadLine();
                                        if (valasz == "n")
                                        {
                                            break;
                                        }
                                    }
                                }
                                if (van == false)
                                {
                                    File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                                    Console.Write("Új alkatrész bevitele (i/n): ");
                                    string valasz2 = Console.ReadLine();
                                    if (valasz2 == "n")
                                    {
                                        break;
                                    }
                                }
                                break;
                            }
                            break;
                        }
                        else if (valasz3 == "n")
                        {
                            break;
                        }
                        else { Console.WriteLine("i/n"); }
                    }
                    break;
                }
                else { Console.WriteLine("i/n"); }
            }
            
            
        }

        static void Kereses1()
        {
            Console.Write("\nAlkatrész típusa vagy neve: ");
            string tipusnev = Console.ReadLine();
            int db = 0;
            foreach (var a in alkatreszek)
            {
                if (a.Tipus.ToLower() == tipusnev.ToLower() || a.Nev.ToLower().Contains(tipusnev.ToLower()))
                {
                    Console.WriteLine($"\nTípus: {a.Tipus}\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr: {a.Ar} Ft");
                    db++;
                }
            }
            if (db == 0)
            {
                Szin(ConsoleColor.Red);
                Console.WriteLine("\nNem található ilyen alkatrész");
                Szin(ConsoleColor.White);
            }
        }

        static void Kereses2()
        {
            Console.Write("\nMinimum ár: ");
            int minAr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum ár: ");
            int maxAr = Convert.ToInt32(Console.ReadLine());
            int db = 0;
            foreach (var a in alkatreszek)
            {
                if (a.Ar >= minAr && a.Ar <= maxAr)
                {
                    Console.WriteLine($"\nTípus: {a.Tipus}\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr: {a.Ar} Ft");
                    db++;
                }
            }
            if(db == 0)
            {
                Szin(ConsoleColor.Red);
                Console.WriteLine("\nNem található ilyen alkatrész");
                Szin(ConsoleColor.White);
            }
        }

        static void Statisztika()
        {
            int intelCPU = 0;
            int amdCPU = 0;
            int nvidia = 0;
            int amdvideo = 0;
            foreach (var a in alkatreszek)
            {
                if (a.Tipus == "CPU" && a.Nev.StartsWith("Intel"))
                {
                    intelCPU++;
                }
                else if (a.Tipus == "CPU" && a.Nev.StartsWith("AMD"))
                {
                    amdCPU++;
                }
                else if (a.Tipus == "Videókártya" && a.Nev.StartsWith("Nvidia"))
                {
                    nvidia++;
                }
                else if (a.Tipus == "Videókártya" && a.Nev.StartsWith("AMD"))
                {
                    amdvideo++;
                }
            }

            Console.WriteLine("\nPROCESSZOROK\n");
            Console.WriteLine($"  {intelCPU} Intel processzor");
            Console.WriteLine($"  {amdCPU} AMD processzor");
            Console.WriteLine("\nVIDEÓKÁRTYÁK\n");
            Console.WriteLine($"  {nvidia} Nvidia kártya");
            Console.WriteLine($"  {amdvideo} AMD kártya");

        }

        static void Akcio()
        {
            Console.Write("\nHány százalékos akció legyen (1-100): ");
            int szazalek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Melyik termék típusra legyen akció: ");
            string tipus = Console.ReadLine();
            int db = 0;
            if (tipus == "minden")
            {
                foreach(var a in alkatreszek)
                {
                    a.Akcio(szazalek);
                    db++;
                }
            }
            else
            {
                foreach (var a in alkatreszek)
                {
                    if (a.Tipus.ToLower() == tipus.ToLower() || a.Nev.ToLower().Contains(tipus.ToLower()))
                    {
                        a.Akcio(szazalek);
                        db++;
                    }
                }
            }                      
            if (db == 0) { Szin(ConsoleColor.Red); Console.WriteLine("\nNem található ilyen alkatrész típus"); Szin(ConsoleColor.White); }
            else
            {
                Szin(ConsoleColor.Green);
                Console.WriteLine($"\n  {db} alkatrész {szazalek}% akciós");
                Szin(ConsoleColor.White);
            }
            
        }

        static void Modositas()
        {
            Console.Write("\nAlkatrész neve: ");
            string nev = Console.ReadLine();
            int db = 0;
            foreach (var a in alkatreszek)
            {
                if (a.Nev.ToLower() == nev.ToLower())
                {
                    db++;
                    Console.WriteLine($"Jelenlegi paraméterek: {a.Parameter}");
                }
            }
            if (db == 0)
            {
                Szin(ConsoleColor.Red);
                Console.WriteLine("Nem található ilyen alkatrész név");
                Szin(ConsoleColor.White);
            }
            else
            {
                Console.Write("Új paraméterek: ");
                string parameter = Console.ReadLine();
                foreach (var a in alkatreszek)
                {
                    if (a.Nev.ToLower() == nev.ToLower())
                    {
                        a.Param(parameter);
                    }
                }
                Szin(ConsoleColor.Green);
                Console.WriteLine("Paraméterek módosítva");
                Szin(ConsoleColor.White);
            }
            
        }

        static void Main(string[] args)
        {
            Kiirat(@"..\..\..\fajl.txt");
            Beolvasas(@"..\..\..\fajl.txt");

            for (int l = 0; l<l+1; l++)
            {
                Console.WriteLine("\n1. Keresés alkatrész típusára vagy nevére");
                Console.WriteLine("2. Keresés adott árak között");
                Console.WriteLine("3. Statisztika megtekintése");
                Console.WriteLine("4. Akciós árak");
                Console.WriteLine("5. Paraméter módosítás");
                Console.Write("\nMelyik legyen (1/2/3/4/5): ");
                string valasz = Console.ReadLine();
                for (int i = 0; i < i + 1; i++)
                {
                    if (valasz == "1")
                    {
                        Kereses1();
                        break;
                    }
                    else if (valasz == "2")
                    {
                        Kereses2();
                        break;
                    }
                    else if (valasz == "3")
                    {
                        Statisztika();
                        break;
                    }
                    else if (valasz == "4")
                    {
                        Akcio();
                        break;
                    }
                    else if (valasz == "5")
                    {
                        Modositas();
                        break;
                    }
                    else
                    {
                        Szin(ConsoleColor.Red);
                        Console.WriteLine("1/2/3/4/5");
                        Szin(ConsoleColor.White);
                        break;
                    }
                }
                
            }
        }
    }
}