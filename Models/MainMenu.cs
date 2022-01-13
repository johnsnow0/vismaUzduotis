using System;
namespace vismaUzduotis.Models
{
	public class MainMenu
	{
		public static void MainMenuUI()
        {
            while (true)
            {
                Console.WriteLine(" 1 - Registruotis \n 2 - Prisijungti \n 3 - Susitikimu sistema \n 4 - Profilis \n 5 - Atsijungti");
                Console.Write("Jusu pasirinkimas: ");
                int pasirinkimas = int.Parse(Console.ReadLine());

                switch (pasirinkimas)
                {
                    case 1:
                        Register.RegisterNewUser();
                        break;

                    case 2:

                        Login.LoginUser();
                        break;


                    case 3:
                        if (Login.PRISIJUNGIMO_STATUSAS)
                        {
                            MeetingsMenu.Menu();
                        }
                        
                        break;

                    case 4:

                        UserProfile.UserProfileInfo();
                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine("Sėkmingai atsijungėte nuo sistemos \n");
                        break;

                }
            }
        }
    }
	
}

