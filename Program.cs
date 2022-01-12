using System;
using vismaUzduotis.Models;
using Newtonsoft.Json;

namespace MetodasRegistracijosSistema
{
    class Program
    {
        static string VARTOTOJAS;
        //static string SLAPTAZODIS;
        static bool PRISIJUNGIMO_STATUSAS = false;
        

        static void Main(string[] args)
        {
            DB.LoadData();
            DB.LoadMeetingData();
            Console.WriteLine("VISMA INTERNAL MEETINGS: \n");

            while (true)
            {
                Console.WriteLine(" 1 - Registruotis \n 2 - Prisijungti \n 3 - Susitikimu sistema \n 4 - Profilis \n 5 - Atsijungti");
                Console.Write("Jusu pasirinkimas: ");
                int pasirinkimas = int.Parse(Console.ReadLine());

                if (pasirinkimas == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Iveskite nauja prisijungimo varda: ");
                    string vardas = Console.ReadLine();
                    Console.WriteLine("Iveskite nauja slaptazodi: ");
                    string slaptazodis = Console.ReadLine();
                    Console.WriteLine("Pakartokite ivesta slaptazodi: ");
                    string pakartotasSlaptazodis = Console.ReadLine();

                    bool registruotas = arSutampaSlaptazodis(slaptazodis, pakartotasSlaptazodis);

                    if (registruotas)
                    {
                        //VARTOTOJAS = vardas;
                        //SLAPTAZODIS = slaptazodis;

                        PersonClass naujasVartotojas = new PersonClass();
                        naujasVartotojas.vardas = vardas;
                        naujasVartotojas.slaptazodis = slaptazodis;

                        DB.vartotojai.Add(naujasVartotojas);
                        DB.SaveChanges();
                         
                    }
                }
                if (pasirinkimas == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Iveskite prisijungimo varda: ");
                    string PrisijungimoVardas = Console.ReadLine();
                    Console.WriteLine("Iveskite slaptazodi: ");
                    string PrisijungimoSlaptazodis = Console.ReadLine();

                    Prisijungti(PrisijungimoVardas, PrisijungimoSlaptazodis);

                }
                if (pasirinkimas == 3)
                {
                    susitikimuSistema();
                }
                if (pasirinkimas == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Jusu profilio informacija: ");
                    if (PRISIJUNGIMO_STATUSAS)
                    {
                        Console.WriteLine("Vartotojas '{0}' prisijunges", VARTOTOJAS);
                    }
                    else
                    {
                        Console.WriteLine("Vartotojas nera prisijunges \n");
                    }
                }
                if (pasirinkimas == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Sėkmingai atsijungėte nuo sistemos \n");
                    break;
                }
            }
        }
        static bool arSutampaSlaptazodis(string slaptazodis, string pakartotasSlaptazodis)
        {
            Console.Clear();
            Console.WriteLine("VISMA SUSITIKIMŲ VALDYMO SISTEMA \n");
            
            if (slaptazodis == pakartotasSlaptazodis)
            {
                Console.WriteLine("Vartotojas priregistruotas \n");
                return true;
            }
            else
            {
                Console.WriteLine("Neteisingas slaptazodis \n");
                return false;
            }
        }
        static void Prisijungti(string vardas, string slaptazodis)
        {
            
                List<PersonClass> duomenys = DB.vartotojai;

                var dalykai = duomenys.FirstOrDefault(o => o.vardas == vardas && o.slaptazodis == slaptazodis).ToString();
                if (dalykai != null)
                {
                    Console.Clear();
                    Console.WriteLine("Vartotojas {0}, prisijunge sekmingai \n", vardas);
                    PRISIJUNGIMO_STATUSAS = true;
                    VARTOTOJAS = vardas; 
                }
                
                else
                {
                    Console.Clear();
                    Console.WriteLine("Prisijungti nepavyko. Blogas vartotojo vardas arba slaptazodis \n");
                }
        }
        static void susitikimuSistema()
        {
            if (PRISIJUNGIMO_STATUSAS)
            {
                Console.Clear();
                Console.WriteLine("Susitikmų sistemos meniu \n");

                while (true)
                {
                    MeetingsClass susitikimas = new MeetingsClass();

                    Console.WriteLine(" 1 - Sukurti meetinga \n 2 - Ištrinti meetinga \n 3 - Meetingų sąrašas \n 4 - Prideti žmogų į susitikimą \n 5 - Pašalinti žmogų iš susitikimo \n 6 - Grižti į pagrindinį meniu");
                    Console.Write("Jusu pasirinkimas: ");
                    int pasirinkimas = int.Parse(Console.ReadLine());

                    if (pasirinkimas == 1)
                    {
                        Console.Clear();
                        susitikimas.ID = MeetingsClass.sekantisMeetingas();
                        Console.WriteLine("Jūsų vardas: ");
                        susitikimas.Name = Console.ReadLine();
                        //Console.WriteLine("Atsakingas asmuo: ");
                        susitikimas.ResponsiblePerson = VARTOTOJAS;
                        Console.WriteLine("Trumpas meetingo aprašymas: ");
                        susitikimas.Description = Console.ReadLine();
                        Console.WriteLine("Pasirinkite kategorija 1 - CodeMonkey, 2 - Hub, 3 - Short, 4 - TeamBuilding): ");
                        int kategorija = int.Parse(Console.ReadLine());
                        if (kategorija == 1)
                        {
                            susitikimas.Category = "CodeMonkey";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                        }
                        if (kategorija == 2)
                        {
                            susitikimas.Category = "Hub";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                        }
                        if (kategorija == 3)
                        {
                            susitikimas.Category = "Short";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                        }
                        if (kategorija == 4)
                        {
                            susitikimas.Category = "TeamBuilding";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                        }
                        Console.WriteLine("Pasirinkite susitikimo tipa (1 - Live, 2 - InPerson): ");
                        int meetingoTip = int.Parse(Console.ReadLine());
                        if (meetingoTip == 1)
                        {
                            susitikimas.Type = "Live";
                            Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0}\n", susitikimas.Type);
                        }
                        if (meetingoTip == 2)
                        {
                            susitikimas.Type = "InPerson";
                            Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0} \n", susitikimas.Type);
                        }

                        Console.WriteLine("Įveskite pradžios datą: ");
                        susitikimas.StartDate = Console.ReadLine();
                        Console.WriteLine("Įveskite pabaigos datą: ");
                        susitikimas.EndDate = Console.ReadLine();

                        DB.meetingai.Add(susitikimas);
                        DB.SaveMeetingChanges();

                        Console.WriteLine("Jūsų susitikimas užregistruotas sėkmingai \n");

                    }
                    if (pasirinkimas == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Istrinti meetinga is saraso \n");
                    }
                    if (pasirinkimas == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Susitikimų paieška \n");
                        while (true)
                        {
                            Console.WriteLine(" 1 - Rodyti visus susitikimus \n 2 - Filtruoti pagal aprašymą \n 3 - Filtruoti pagal atsakingą asmenį \n 4 - Filtruoti pagal kategoriją \n 5 - Filtruoti pagal tipą \n 6 - Filtruoti pagal datas \n 7 - Filtruoti pagal žmonių kiekį \n 8 - Grižti atgal");
                            Console.Write("Jusu pasirinkimas: ");
                            int pasirink = int.Parse(Console.ReadLine());

                            if (pasirink == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("MEETINGŲ SĄRAŠAS\n");
                                List<MeetingsClass> duomenys = DB.meetingai;
                                foreach (var item in duomenys)
                                {
                                    Console.WriteLine(
                                        "Dalyviai................{0}\n"+
                                        "Atsakingas asmuo........{1}\n"+
                                        "Aprasymas...............{2}\n"+
                                        "Kategorija..............{3}\n"+
                                        "Susitikimo tipas........{4}\n"+
                                        "Susitikmo pradzia.......{5}\n"+
                                        "Susitikimo pabaiga......{6}\n\n",
                                        item.Name, item.ResponsiblePerson, item.Description, item.Category, item.Type, item.StartDate, item.EndDate);
                                    
                                }
                            }
                            if (pasirink == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite susitikimo aprašymą");
                                string ivestis = Console.ReadLine();
                                List<MeetingsClass> aprasymas = DB.meetingai;
                                var atsakymas = aprasymas.Where(x => x.Description == ivestis).ToString();
                                if (atsakymas != null)
                                {
                                    Console.WriteLine(atsakymas);
                                }
                                else
                                {
                                    Console.WriteLine("Aprašymas nerastas");
                                }
                            }
                            if (pasirink == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite atsakingą asmenį");
                            }
                            if (pasirink == 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite kategoriją");
                            }
                            if (pasirink == 5)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite tipą");
                            }
                            if (pasirink == 6)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite datas");
                            }
                            if (pasirink == 7)
                            {
                                Console.Clear();
                                Console.WriteLine("Įveskite žmonių kiekį");
                            }
                            if (pasirink == 8)
                            {
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    if (pasirinkimas == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Prideti žmogų į susitikimą \n");
                    }
                    if (pasirinkimas == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Pašalinti žmogų iš susitikimo \n");
                    }
                    if (pasirinkimas == 6)
                    {
                        Console.Clear();
                        break;
                    }

                }
            }
        }


    }
    public class Vartotojas
    {
            
            public string vardas { get; set; }
            public string slaptazodis { get; set; }
            

            public Vartotojas()
            {

            }

            public Vartotojas(string avardas)
            {
                vardas = avardas;
                
            }
            public void spausdintiVartotoja()
            {
                Console.WriteLine("{0}", vardas);
            }
    }
    
}

