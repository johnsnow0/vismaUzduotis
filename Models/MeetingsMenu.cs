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
                Console.WriteLine(
                    " 1 - Create a meeting \n 2 - Delete a meeting \n 3 - Meeting list \n 4 - Add person to a meeting \n 5 - Remove person from a meeting \n 6 - Back to main");
                Console.Write("Your choice: ");
                int selection = 0;
                if (!int.TryParse(Console.ReadLine(), out selection) || selection > 6 || selection < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid key input\n");
                    continue;
                }
                
                switch (selection)
                {
                    case 1:
                        AddNewMeeting.AddNewMeetings();
                        break;


                    case 2:

                        Console.Clear();
                        Console.WriteLine("Delete meeting from the list \n");
                        Console.WriteLine("Enter meeting description \n");
                        string input = Console.ReadLine();
                        List<Meeting> description = DB.meetingai;
                        
                        var selected = description.SingleOrDefault(x => x.Description == input);

                        if (selected != null)
                        {
                            //MeetingSearch.PrintMeetingDetails(selected);
                            //var auth = selected.Select(x => x.ResponsiblePerson).ToString();
                            Console.WriteLine("Do you want to delete this meeting? Y/n\n");
                            string userInput = Console.ReadLine();
                            if (userInput == "y" || userInput == "Y")
                            {
                                if (Login.VARTOTOJAS == selected.ResponsiblePerson)
                                {
                                    description.Remove(selected);
                                    Console.WriteLine("Success! Meeting has been removed.\n");
                                }

                                
                            }
                            else
                            {
                                Console.WriteLine("Access denied. You are not resposible for this meeting.\n");
                            }
                        }
                                                 
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

