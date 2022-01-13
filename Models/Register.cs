using System;
namespace vismaUzduotis.Models
{
	public class Register
	{
		public static void RegisterNewUser()
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
                PersonClass naujasVartotojas = new PersonClass();
                naujasVartotojas.vardas = vardas;
                naujasVartotojas.slaptazodis = slaptazodis;

                DB.vartotojai.Add(naujasVartotojas);
                DB.SaveChanges();

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
    }
}

