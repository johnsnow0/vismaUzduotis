using System;
namespace vismaUzduotis.Models
{
	public class MeetingSearch
	{
        public static void SusitikimuPaieska()
        {
            Console.Clear();
            Console.WriteLine("Search for meeting \n");
            while (true)
            {
                Console.WriteLine(" 1 - Display all meetings \n 2 - Filter by description \n 3 - Filter by responsible person \n 4 - Filter by category \n 5 - Filter by type \n 6 - Filter by date \n 7 - Filter by members no \n 8 - Back to main");
                Console.Write("Your choice: ");
                int pasirink = int.Parse(Console.ReadLine());
                switch (pasirink)
                {

                    case 1:

                        Console.Clear();
                        Console.WriteLine("MEETING LIST\n");
                        List<Meeting> duomenys = DB.meetingai;
                        foreach (var item in duomenys)
                        {
                            Console.WriteLine(
                                "Members...................{0}\n" +
                                "Responsible person........{1}\n" +
                                "Description...............{2}\n" +
                                "Category..................{3}\n" +
                                "Meeting type..............{4}\n" +
                                "Start of meeting..........{5}\n" +
                                "End of meeting............{6}\n\n",
                                item.Name, item.ResponsiblePerson, item.Description, item.Category, item.Type, item.StartDate, item.EndDate);

                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter meeting description");
                        string ivestis = Console.ReadLine();
                        List<Meeting> aprasymas = DB.meetingai;
                        var atsakymas = aprasymas.Where(x => x.Description == ivestis).ToString();
                        if (atsakymas != null)
                        {
                            Console.WriteLine(atsakymas);
                        }
                        else
                        {
                            Console.WriteLine("Description not found");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter responsible person");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter category");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Enter type");
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Enter date");
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("enter people no");
                        break;

                    case 8:
                        Console.Clear();
                        MeetingsMenu.Menu();
                        break;
                }

            }

        }
    }
}

