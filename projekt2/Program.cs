using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Text;

namespace projekt2
{
    internal class Program
    {

        static List<Alkatresz> alkatreszek;

        static void Szin(ConsoleColor szin, string szoveg) 
        {
            Console.ForegroundColor = szin;
            Console.WriteLine(szoveg);
            Console.ForegroundColor = ConsoleColor.White;
        }
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
            Beolvasas(fajlNev);
            for (int l = 0; l < l+1; l++)
            {
                Console.Write("Idáig bevitt alkatrészek törlése(i/n): ");
                string valasz1 = Console.ReadLine();
                if (valasz1 == "i")
                {
                    Console.Write($"Biztos törölni szeretnéd mind a {alkatreszek.Count()} alkatrészt(i/n): ");
                    string valasz2 = Console.ReadLine();
                    if (valasz2 == "i")
                    {
                        File.WriteAllText(fajlNev, "");
                        Szin(ConsoleColor.Green, "Alkatrészek törölve.");
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
                                    Szin(ConsoleColor.Red, "Ilyen alkatrész már létezik.");
                                    Console.Write("Másik alkatrész bevitele (i/n): ");
                                    string valasz = Console.ReadLine();
                                    if (valasz == "n")
                                    {
                                        break;
                                    }
                                }
                            }
                            Console.Clear();
                            if (van == false)
                            {
                                File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                                Szin(ConsoleColor.Green, "Új alkatrész hozzáadva\n");
                                Console.Write("Új alkatrész bevitele (i/n): ");
                                string valasz3 = Console.ReadLine();
                                if (valasz3 == "n")
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                            break;
                        }
                        break;
                    }
                    else if (valasz2 == "n")
                    {
                        for (int k = 0; k < k + 1; k++)
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
                                            Szin(ConsoleColor.Red, "Ilyen alkatrész már létezik.");
                                            Console.Write("Másik alkatrész bevitele (i/n): ");
                                            string valasz = Console.ReadLine();
                                            if (valasz == "n")
                                            {
                                                break;
                                            }
                                        }
                                    }
                                    Console.Clear();
                                    if (van == false)
                                    {
                                        File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                                        Szin(ConsoleColor.Green, "Új alkatrész hozzáadva\n");
                                        Console.Write("Új alkatrész bevitele (i/n): ");
                                        string valasz4 = Console.ReadLine();
                                        if (valasz4 == "n")
                                        {
                                            Console.Clear();
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
                                        Szin(ConsoleColor.Red, "Ilyen alkatrész már létezik.");
                                        Console.Write("Másik alkatrész bevitele (i/n): ");
                                        string valasz = Console.ReadLine();
                                        if (valasz == "n")
                                        {
                                            break;
                                        }
                                    }
                                }
                                Console.Clear();
                                if (van == false)
                                {
                                    File.AppendAllText(fajlNev, $"{tipus};{nev};{parameter};{ar}" + Environment.NewLine);
                                    Szin(ConsoleColor.Green, "Új alkatrész hozzáadva\n");
                                    Console.Write("Új alkatrész bevitele (i/n): ");
                                    string valasz2 = Console.ReadLine();
                                    if (valasz2 == "n")
                                    {
                                        Console.Clear();
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
            Console.Clear();

        }

        static void Kereses1()
        {
            Console.Clear();
            Console.Write("Alkatrész típusa vagy neve: ");
            string tipusnev = Console.ReadLine();
            int db = 0;
            Console.Clear();
            foreach (var a in alkatreszek)
            {
                if (a.Tipus.ToLower() == tipusnev.ToLower() || a.Nev.ToLower().Contains(tipusnev.ToLower()))
                {
                    Console.WriteLine($"Típus: {a.Tipus}\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr: {a.Ar} Ft\n");
                    db++;
                }
            }
            if (db == 0)
            {
                Szin(ConsoleColor.Red, "Nem található ilyen alkatrész\n");
            }
        }

        static void Kereses2()
        {
            Console.Clear();
            Console.Write("Minimum ár: ");
            int minAr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum ár: ");
            int maxAr = Convert.ToInt32(Console.ReadLine());
            int db = 0;
            Console.Clear();
            foreach (var a in alkatreszek)
            {
                if (a.Ar >= minAr && a.Ar <= maxAr)
                {
                    Console.WriteLine($"Típus: {a.Tipus}\nNév: {a.Nev}\nParaméterek: {a.Parameter}\nÁr: {a.Ar} Ft\n");
                    db++;
                }
            }
            if(db == 0)
            {
                Szin(ConsoleColor.Red, "Nem található ilyen alkatrész\n");
            }
        }


        static void StatSzamol(List<string> lista, string tipus, List<int> listaSzam)
        {
            foreach (var elem in lista)
            {
                int szam = 0;
                foreach (var a in alkatreszek)
                {
                    if (a.Tipus == tipus && a.Nev.Contains(elem))
                    {
                        szam++;
                    }
                }
                listaSzam.Add(szam);
            }
        }

        static void StatKiirat(string tipus, List<string> lista, List<int> listaSzam)
        {
            Console.WriteLine($"{tipus.ToUpper()}\n");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{listaSzam[i]} féle {lista[i]} {tipus}");
            }
            Console.WriteLine("");
        }

        static void Statisztika()
        {
            Console.Clear();
            List<string> cpu = new List<string>();
            List<int> cpuSzam = new List<int>();
            List<string> vkartya = new List<string>();
            List<int> vkartyaSzam = new List<int>();
            List<string> alaplap = new List<string>();
            List<int> alaplapSzam = new List<int>();
            List<string> memoria = new List<string>();
            List<int> memoriaSzam = new List<int>();
            List<string> hdd = new List<string>();
            List<int> hddSzam = new List<int>();
            List<string> ssd = new List<string>();
            List<int> ssdSzam = new List<int>();
            List<string> monitor = new List<string>();
            List<int> monitorSzam = new List<int>();
            List<string> eger = new List<string>();
            List<int> egerSzam = new List<int>();
            List<string> bill = new List<string>();
            List<int> billSzam = new List<int>();
            foreach (var a in alkatreszek)
            {
                if(a.Tipus == "CPU")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!cpu.Contains(nevElemek[0])) { cpu.Add(nevElemek[0]); }
                }
                else if(a.Tipus == "Videókártya")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!vkartya.Contains(nevElemek[0])) { vkartya.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "Alaplap")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!alaplap.Contains(nevElemek[0])) { alaplap.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "Memória")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!memoria.Contains(nevElemek[0])) { memoria.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "HDD")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!hdd.Contains(nevElemek[0])) { hdd.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "SSD")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!ssd.Contains(nevElemek[0])) { ssd.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "Monitor")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!monitor.Contains(nevElemek[0])) { monitor.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "Egér")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!eger.Contains(nevElemek[0])) { eger.Add(nevElemek[0]); }
                }
                else if (a.Tipus == "Billentyűzet")
                {
                    string[] nevElemek = a.Nev.Split(" ");
                    if (!bill.Contains(nevElemek[0])) { bill.Add(nevElemek[0]); }
                }


            }
            StatSzamol(cpu, "CPU", cpuSzam);
            StatSzamol(vkartya, "Videókártya", vkartyaSzam);
            StatSzamol(alaplap, "Alaplap", alaplapSzam);
            StatSzamol(memoria, "Memória", memoriaSzam);
            StatSzamol(hdd, "HDD", hddSzam);
            StatSzamol(ssd, "SSD", ssdSzam);
            StatSzamol(monitor, "Monitor", monitorSzam);
            StatSzamol(eger, "Egér", egerSzam);
            StatSzamol(bill, "Billentyűzet", billSzam);

            StatKiirat("processzor", cpu, cpuSzam);
            StatKiirat("videókártya", vkartya, vkartyaSzam);
            StatKiirat("alaplap", alaplap, alaplapSzam);
            StatKiirat("memória", memoria, memoriaSzam);
            StatKiirat("HDD", hdd, hddSzam);
            StatKiirat("SSD", ssd, ssdSzam);
            StatKiirat("monitor", monitor, monitorSzam);
            StatKiirat("egér", eger, egerSzam);
            StatKiirat("billentyűzet", bill, billSzam);

        }

        static void Akcio()
        {
            Console.Clear();
            Console.Write("Hány százalékos akció legyen (1-100): ");
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
            if (db == 0) { Szin(ConsoleColor.Red, "\nNem található ilyen alkatrész típus"); }
            else
            {
                Szin(ConsoleColor.Green, $"\n  {db} alkatrész {szazalek}% akciós\n");
            }
            
        }

        static void Modositas()
        {
            Console.Clear();
            Console.Write("Alkatrész teljes neve: ");
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
                Szin(ConsoleColor.Red, "Nem található ilyen alkatrész név\n");
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
                Szin(ConsoleColor.Green, "Paraméterek módosítva\n");
            }
            
        }

        static StringBuilder html = new StringBuilder();

        static void Divek(string tipus)
        {
            
            html.AppendLine("<div style=\"display: flex; flex-wrap: wrap; background-color: black;\">");
            html.AppendLine($"  <div style=\"width: 100%; background-color: gray; font-size: 5em; padding: 10px\">{tipus}</div>");
            foreach (var a in alkatreszek)
            {
                if (a.Tipus == $"{tipus}")
                {
                    html.AppendLine($"  <div style=\"border: 1px solid #ddd; padding: 10px; margin: 10px; background-color: white;\">");
                    html.AppendLine($"    <strong>{a.Tipus}</strong><br>");
                    html.AppendLine($"    <span>{a.Nev}</span><br>");
                    html.AppendLine($"    <span>{a.Parameter}</span><br>");
                    html.AppendLine($"    <span>Ár: {a.Ar} Ft</span><br>");
                    html.AppendLine($"  </div>");
                }
            }
        }

        static void HTMLGeneral()
        {
            Console.Clear();

            Divek("CPU");
            Divek("Videókártya");
            Divek("Alaplap");
            Divek("Memória");
            Divek("HDD");
            Divek("SSD");
            Divek("Monitor");
            Divek("Egér");
            Divek("Billentyűzet");

            html.AppendLine("</div>");

            string htmlKod = html.ToString();

            Szin(ConsoleColor.Green, "HTML kód legenerálva");
            File.WriteAllText(@"..\..\..\alkatreszek.html", htmlKod);
        }

        static void Main(string[] args)
        {
            Kiirat(@"..\..\..\fajl.txt");
            Beolvasas(@"..\..\..\fajl.txt");

            for (int l = 0; l<l+1; l++)
            {
                Console.WriteLine("1. Keresés alkatrész típusára vagy nevére");
                Console.WriteLine("2. Keresés adott árak között");
                Console.WriteLine("3. Statisztika megtekintése");
                Console.WriteLine("4. Akciós árak");
                Console.WriteLine("5. Paraméter módosítás");
                Console.WriteLine("6. HTML kód generálás");
                Console.Write("\nMelyik legyen (1/2/3/4/5/6): ");
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
                    else if (valasz == "6")
                    {
                        HTMLGeneral();
                        break;
                    }
                    else
                    {
                        Szin(ConsoleColor.Red, "1/2/3/4/5");
                        break;
                    }
                }
                
            }
        }
    }
}