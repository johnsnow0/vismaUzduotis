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
            Console.WriteLine("VISMA INTERNAL MEETINGS:");

            while (true)
            {
                Console.WriteLine("1 - Registruotis \n 2 - Prisijungti \n 3 - Susitikimu sistema \n 4 - Profilis \n 5 - Atsijungti");
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
                        Console.WriteLine("Vartotojas nera prisijunges");
                    }
                }
                if (pasirinkimas == 5)
                {
                    Console.WriteLine("Sėkmingai atsijungėte nuo sistemos");
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
                Console.WriteLine("Vartotojas priregistruotas");
                return true;
            }
            else
            {
                Console.WriteLine("Neteisingas slaptazodis");
                return false;
            }
        }
        static void Prisijungti(string vardas, string slaptazodis)
        {
            if (vardas == VARTOTOJAS && slaptazodis == SLAPTAZODIS)
            {
                Console.WriteLine("Prisijungete sekmingai");
                PRISIJUNGIMO_STATUSAS = true;
            }
            else
            {
                Console.WriteLine("Prisijungti nepavyko. Blogas vartotojo vardas arba slaptazodis");
            }
        }
        static void susitikimuSistema()
        {
            if (PRISIJUNGIMO_STATUSAS)
            {
                Console.Clear();
                Console.WriteLine("Susitikmų sistemos meniu");

                while (true)
                {
                    Console.WriteLine(" 1 - Sukurti meetinga \n 2 - Ištrinti meetinga \n 3 - Meetingų sąrašas \n 4 - laisvas \n 5 - Atsijungti");
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
                        Console.WriteLine("Pasirinkite kategorija (CodeMonkey, Hub, Short,TeamBuilding): ");
                        string meetingoKategorija = Console.ReadLine();
                        Console.WriteLine("Susitikimo tipas (Live, InPerson): ");
                        string meetingoTipas = Console.ReadLine();
                        Console.WriteLine("Įveskite pradžios datą: ");
                        DateTime meetingoPradziosData = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Įveskite pabaigos datą: ");
                        DateTime meetingoPabaigosData = DateTime.Parse(Console.ReadLine());

                        var meeting = new MeetingsClass(vardas, atsakingasAsmuo, meetingoAprasymas, meetingoKategorija, meetingoTipas, meetingoPradziosData, meetingoPabaigosData);

                        File.WriteAllLines("meetingList.txt", meeting);
                    }
                }

            }
            else
            {
                Console.WriteLine("Neleidziama perziureti, iš pradžių prisijunkite arba registruokitės");
            }
        }

        static bool isaugotiNaujaSusitikima(string vardas, string atsakingasAsmuo, string meetingoAprasymas, string meetingoKategorija, string meetingoTipas, DateTime meetingoPradziosData, DateTime meetingoPabaigosData)
        {

            duomenys.id = DB.sekantisMeetingas();
            DB.meetingai.Add(duomenys);

            System.IO.File.WriteAllLines("SavedLists.txt", DB.meetingai);


            return true;
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

