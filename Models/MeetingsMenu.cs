using System;
using MetodasRegistracijosSistema;

namespace vismaUzduotis.Models
{
	public class MeetingsMenu
	{
		public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Meeting system \n");

            while (true)
            {
                Console.WriteLine(" 1 - Create a meeting \n 2 - Delete a meeting \n 3 - Meeting list \n 4 - Add person to a meeting \n 5 - Remove person from a meeting \n 6 - Back to main");
                Console.Write("Your choice: ");
                int pasirinkimas = int.Parse(Console.ReadLine());
                switch (pasirinkimas)
                {
                    case 1:
                        AddNewMeeting.AddNewMeetings();
                        break;


                    case 2:

                        Console.Clear();
                        Console.WriteLine("Delete meeting from the list \n");
                        break;

                    case 3:

                        MeetingSearch.SusitikimuPaieska();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Add person to a meeting \n");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Delete person from a meeting \n");
                        break;
                    case 6:
                        Console.Clear();
                        MainMenu.MainMenuUI();
                        break;
                }


            }
        }
	}
}

