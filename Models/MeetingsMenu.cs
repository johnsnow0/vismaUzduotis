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
                Meeting susitikimas = new Meeting();

                Console.WriteLine(" 1 - Create a meeting \n 2 - Delete a meeting \n 3 - Meeting list \n 4 - Add person to a meeting \n 5 - Remove person from a meeting \n 6 - Back to main");
                Console.Write("Your choice: ");
                int pasirinkimas = int.Parse(Console.ReadLine());
                switch (pasirinkimas)
                {
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                            susitikimas.ID = Meeting.sekantisMeetingas();
                            Console.WriteLine("Member name: ");
                            susitikimas.Name = Console.ReadLine();
                            //Console.WriteLine("Atsakingas asmuo: ");
                            susitikimas.ResponsiblePerson = Login.VARTOTOJAS ;
                            Console.WriteLine("Meeting description: ");
                            susitikimas.Description = Console.ReadLine();
                            Console.WriteLine("Choose category: 1 - CodeMonkey, 2 - Hub, 3 - Short, 4 - TeamBuilding): ");
                            int kategorija = int.Parse(Console.ReadLine());
                            switch (kategorija)
                            {
                                case 1:

                                    susitikimas.Category = "CodeMonkey";
                                    Console.WriteLine("Your choice: {0}\n", susitikimas.Category);
                                    break;

                                case 2:

                                    susitikimas.Category = "Hub";
                                    Console.WriteLine("Your choice: {0}\n", susitikimas.Category);
                                    break;

                                case 3:

                                    susitikimas.Category = "Short";
                                    Console.WriteLine("Your choice: {0}\n", susitikimas.Category);
                                    break;

                                case 4:

                                    susitikimas.Category = "TeamBuilding";
                                    Console.WriteLine("JYour choice: {0}\n", susitikimas.Category);
                                    break;
                            }

                            Console.WriteLine("Pasirinkite susitikimo tipa (1 - Live, 2 - InPerson): ");
                            int meetingoTip = int.Parse(Console.ReadLine());
                            switch (meetingoTip)
                            {

                                case 1:

                                    susitikimas.Type = "Live";
                                    Console.WriteLine("Your choice: {0}\n", susitikimas.Type);
                                    break;

                                case 2:

                                    susitikimas.Type = "InPerson";
                                    Console.WriteLine("Your choice: {0} \n", susitikimas.Type);
                                    break;
                            }


                            Console.WriteLine("Enter start date: ");
                            susitikimas.StartDate = Console.ReadLine();
                            Console.WriteLine("Enter end date: ");
                            susitikimas.EndDate = Console.ReadLine();

                            DB.meetingai.Add(susitikimas);
                            DB.SaveMeetingChanges();

                            Console.WriteLine("Your meeting was added succesfully \n");
                            break;
                        }
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

