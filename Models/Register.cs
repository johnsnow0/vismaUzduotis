using System;
namespace vismaUzduotis.Models
{
	public class Register
	{
		public static void RegisterNewUser()
        {
            Console.Clear();
            Console.WriteLine("Enter new login name: ");
            string vardas = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            string slaptazodis = Console.ReadLine();
            Console.WriteLine("Re-enter new password: ");
            string pakartotasSlaptazodis = Console.ReadLine();

            bool registruotas = arSutampaSlaptazodis(slaptazodis, pakartotasSlaptazodis);

            if (registruotas)
            {
                Person naujasVartotojas = new Person();
                naujasVartotojas.vardas = vardas;
                naujasVartotojas.slaptazodis = slaptazodis;

                DB.vartotojai.Add(naujasVartotojas);
                DB.SaveChanges();

            }
        }
        static bool arSutampaSlaptazodis(string slaptazodis, string pakartotasSlaptazodis)
        {
            Console.Clear();
            Console.WriteLine("VISMA MEETINGS MANAGMENT SYSTEM \n");

            if (slaptazodis == pakartotasSlaptazodis)
            {
                Console.WriteLine("User registered \n");
                return true;
            }
            else
            {
                Console.WriteLine("Password no match \n");
                return false;
            }
        }
    }
}

