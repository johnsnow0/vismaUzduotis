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
                
                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        AddNewMeeting.AddNewMeetings();
                        break;


                    case "2":

                        Console.Clear();
                        Console.WriteLine("Delete meeting from the list \n");
                        Console.WriteLine("Enter meeting description \n");
                        string input = Console.ReadLine();
                        List<Meeting> description = DB.meetingai;
                        
                        var selected = description.SingleOrDefault(x => x.Description == input);

                        if (selected != null)
                        {
                            Console.WriteLine(
                                "Members...................{0}\n" +
                                "Responsible person........{1}\n" +
                                "Description...............{2}\n" +
                                "Category..................{3}\n" +
                                "Meeting type..............{4}\n" +
                                "Start of meeting..........{5}\n" +
                                "End of meeting............{6}\n\n",
                                selected.Name, selected.ResponsiblePerson, selected.Description, selected.Category, selected.Type, selected.StartDate, selected.EndDate);

                            Console.WriteLine("Do you want to delete this meeting? Y/n\n");
                            string userInput = Console.ReadLine();
                            if (userInput == "y" || userInput == "Y")
                            {
                                if (Login.VARTOTOJAS == selected.ResponsiblePerson)
                                {
                                    description.Remove(selected);
                                    Console.WriteLine("Success! Meeting has been removed.\n");
                                }
                                else
                                {
                                    Console.WriteLine("Access denied. You are not resposible for this meeting.\n");
                                }
                            }
                            
                        }                                                 
                        break;

                    case "3":

                        MeetingSearch.SusitikimuPaieska();
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Add person to a meeting \n");
                        AddPersonToMeeting();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Delete person from a meeting \n");
                        break;
                    case "6":
                        Console.Clear();
                        MainMenu.MainMenuUI();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Enter valid number 1-6\n");
                        break;
                }


            }
        }
        public static void AddPersonToMeeting()
        {
            Console.WriteLine("Enter meeting description \n");
            string input = Console.ReadLine();
            List<Meeting> description = DB.meetingai;

            var selected = description.SingleOrDefault(x => x.Description == input);

            if (selected != null)
            {
                Console.WriteLine(
                    "Members...................{0}\n" +
                    "Responsible person........{1}\n" +
                    "Description...............{2}\n" +
                    "Category..................{3}\n" +
                    "Meeting type..............{4}\n" +
                    "Start of meeting..........{5}\n" +
                    "End of meeting............{6}\n\n",
                    selected.Name, selected.ResponsiblePerson, selected.Description, selected.Category, selected.Type, selected.StartDate, selected.EndDate);

                Console.WriteLine("Do you want to add person to this meeting? Y/n\n");
                string userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    Console.WriteLine("Please enter persons names to add? Y/n\n");
                    string inputPerson = Console.ReadLine();
                    selected.Name = inputPerson;
                }
                       
                

            }
        }




    }
}

