using System;
namespace vismaUzduotis.Models
{
	public class Login
	{
        public static string VARTOTOJAS;
        public static bool PRISIJUNGIMO_STATUSAS = false;

        public static void LoginUser()
        {
            Console.Clear();
            Console.WriteLine("Iveskite prisijungimo varda: ");
            string PrisijungimoVardas = Console.ReadLine();
            Console.WriteLine("Iveskite slaptazodi: ");
            string PrisijungimoSlaptazodis = Console.ReadLine();

            Prisijungti(PrisijungimoVardas, PrisijungimoSlaptazodis);
        }
        public static void Prisijungti(string vardas, string slaptazodis)
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
    }
    
}

