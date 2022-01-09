using System;
using vismaUzduotis.Models;

namespace MetodasRegistracijosSistema
{
    class Program
    {
        static string VARTOTOJAS;
        static string SLAPTAZODIS;
        static bool PRISIJUNGIMO_STATUSAS = false;
        static Vartotojas VARTOTOJAS_PAPILDOMA_INFO = new Vartotojas();

        static void Main(string[] args)
        {
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

                    bool registruotas = Registruotis(vardas, slaptazodis, pakartotasSlaptazodis);

                    if (registruotas)
                    {
                        VARTOTOJAS = vardas;
                        SLAPTAZODIS = slaptazodis;
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
                        VARTOTOJAS_PAPILDOMA_INFO.spausdintiVartotoja();
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
        static bool Registruotis(string vardas, string slaptazodis, string pakartotasSlaptazodis)
        {
            Console.Clear();
            Console.WriteLine("VISMA SUSITIKIMŲ VALDYMO SISTEMA \n");
            Console.WriteLine("Iveskite savo varda: ");
            string vartotojoVardas = Console.ReadLine();
                      

            VARTOTOJAS_PAPILDOMA_INFO = new Vartotojas(vartotojoVardas);

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
            if (vardas == VARTOTOJAS && slaptazodis == SLAPTAZODIS)
            {
                Console.Clear();
                Console.WriteLine("Prisijungete sekmingai \n");
                PRISIJUNGIMO_STATUSAS = true;
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
                    Console.WriteLine(" 1 - Sukurti meetinga \n 2 - Ištrinti meetinga \n 3 - Meetingų sąrašas \n 4 - Prideti žmogų į susitikimą \n 5 - Pašalinti žmogų iš susitikimo \n 6 - Grižti į pagrindinį meniu");
                    Console.Write("Jusu pasirinkimas: ");
                    int pasirinkimas = int.Parse(Console.ReadLine());

                    if (pasirinkimas == 1)
                    {
                        Console.Clear();

                        List<MeetingsClass> susitikimas = new List<MeetingsClass>();

                        Console.WriteLine("Jūsų vardas: ");
                        string vardas = Console.ReadLine();
                        Console.WriteLine("Atsakingas asmuo: ");
                        string atsakingasAsmuo = Console.ReadLine();
                        Console.WriteLine("Trumpas meetingo aprašymas: ");
                        string meetingoAprasymas = Console.ReadLine();
                        Console.WriteLine("Pasirinkite kategorija 1 - CodeMonkey, 2 - Hub, 3 - Short, 4 - TeamBuilding): ");
                        int kategorija = int.Parse(Console.ReadLine());
                        if (kategorija == 1)
                        {
                            string meetingoKategorija = "CodeMonkey";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}", meetingoKategorija);
                        }
                        if (kategorija == 2)
                        {
                            string meetingoKategorija = "Hub";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}", meetingoKategorija);
                        }
                        if (kategorija == 3)
                        {
                            string meetingoKategorija = "Short";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}", meetingoKategorija);
                        }
                        if (kategorija == 4)
                        {
                            string meetingoKategorija = "TeamBuilding";
                            Console.WriteLine("Jūsų pasirinkta kategorija: {0}", meetingoKategorija);
                        }
                        Console.WriteLine("Pasirinkite susitikimo tipa (1 - Live, 2 - InPerson): ");
                        int meetingoTip = int.Parse(Console.ReadLine());
                        if (meetingoTip == 1)
                        {
                            string meetingoTipas = "Live";
                            Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0}", meetingoTipas);
                        }
                        if (meetingoTip == 2)
                        {
                            string meetingoTipas = "InPerson";
                            Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0}", meetingoTipas);
                        }

                        Console.WriteLine("Įveskite pradžios datą: ");
                        string meetingoPradziosData = Console.ReadLine();
                        Console.WriteLine("Įveskite pabaigos datą: ");
                        string meetingoPabaigosData = Console.ReadLine();

                        Console.WriteLine("Jūsų susitikimas užregistruotas sėkmingai");

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
                            Console.Clear();
                            Console.WriteLine(" 1 - Rodyti visus susitikimus \n 2 - Filtruoti pagal aprašymą \n 3 - Filtruoti pagal atsakingą asmenį \n 4 - Filtruoti pagal kategoriją \n 5 - Filtruoti pagal tipą \n 6 - Filtruoti pagal datas \n 7 - Filtruoti pagal žmonių kiekį \n 8 - Grižti atgal");
                            Console.Write("Jusu pasirinkimas: ");
                            int pasirink = int.Parse(Console.ReadLine());

                            if (pasirink == 1)
                            {
                                Console.WriteLine(DB.meetingai);
                            }
                            if (pasirink == 2)
                            {
                                Console.WriteLine("Įveskite susitikimo aprašymą");
                                Console.WriteLine(DB.meetingai.Where(x => x.Description == Console.ReadLine()));
                            }
                            if (pasirink == 3)
                            {
                                Console.WriteLine("Įveskite atsakingą asmenį");
                            }
                            if (pasirink == 4)
                            {
                                Console.WriteLine("Įveskite kategoriją");
                            }
                            if (pasirink == 5)
                            {
                                Console.WriteLine("Įveskite tipą");
                            }
                            if (pasirink == 6)
                            {
                                Console.WriteLine("Įveskite datas");
                            }
                            if (pasirink == 7)
                            {
                                Console.WriteLine("Įveskite žmonių kiekį");
                            }
                            if (pasirink == 8)
                            {
                                break;
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
                            break;
                        }
                    }
                }
            }
        }
        
                    

        public class Vartotojas
        {
            
            public string vardas { get; set; }
            

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
}

