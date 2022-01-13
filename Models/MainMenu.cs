using System;
namespace vismaUzduotis.Models
{
	public class MainMenu
	{
		public static void MainMenuUI()
        {
            while (true)
            {
                Console.WriteLine(" 1 - Register \n 2 - Login \n 3 - Meeting system \n 4 - User info \n 5 - Logout");
                Console.Write("Your choice: ");
                int selection = 0;
                if (!int.TryParse(Console.ReadLine(), out selection) || selection > 5 || selection < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid key input\n");
                    continue;
                }
                

                switch (selection)
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
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please login to proceed\n");
                        }
                        
                        break;

                    case 4:

                        UserProfile.UserProfileInfo();
                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine("Succesful logout \n");
                        break;

                }
                
            }
        }
    }
	
}

