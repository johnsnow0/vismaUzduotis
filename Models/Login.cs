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
            Console.WriteLine("Enter login name: ");
            string PrisijungimoVardas = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string PrisijungimoSlaptazodis = Console.ReadLine();

            Prisijungti(PrisijungimoVardas, PrisijungimoSlaptazodis);
        }
        public static void Prisijungti(string vardas, string slaptazodis)
        {

            List<Person> duomenys = DB.vartotojai;

            var dalykai = duomenys.FirstOrDefault(o => o.vardas == vardas && o.slaptazodis == slaptazodis).ToString();
            if (dalykai != null)
            {
                Console.Clear();
                Console.WriteLine("User {0}, login succesful \n", vardas);

                PRISIJUNGIMO_STATUSAS = true;
                VARTOTOJAS = vardas;
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Access denied. Bad user name of password \n");
            }
        }
    }
    
}

