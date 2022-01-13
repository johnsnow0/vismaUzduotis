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
                        PrintMeetingDetails(duomenys);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter meeting description\n");
                        string ivestis = Console.ReadLine();
                        List<Meeting> aprasymas = DB.meetingai;
                        var atsakymas = aprasymas.Where(x => x.Description == ivestis).ToList();
                        if (atsakymas != null)
                        {
                            PrintMeetingDetails(atsakymas);
                            
                        }
                        else
                        {
                            Console.WriteLine("Description not found");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter responsible person");
                        string ivestis1 = Console.ReadLine();
                        List<Meeting> aprasymas1 = DB.meetingai;
                        var atsakymas1 = aprasymas1.Where(x => x.ResponsiblePerson == ivestis1).ToList();
                        if (atsakymas1 != null)
                        {

                            PrintMeetingDetails(atsakymas1);
                            
                        }
                        else
                        {
                            Console.WriteLine("Responsible person not found");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Enter category");
                        string ivestis2 = Console.ReadLine();
                        List<Meeting> aprasymas2 = DB.meetingai;
                        var atsakymas2 = aprasymas2.Where(x => x.Category == ivestis2).ToList();
                        if (atsakymas2 != null)
                        {

                            PrintMeetingDetails(atsakymas2);

                        }
                        else
                        {
                            Console.WriteLine("Category not found");
                        }
                        break;
                        
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Enter type");
                        string ivestis3 = Console.ReadLine();
                        List<Meeting> aprasymas3 = DB.meetingai;
                        var atsakymas3 = aprasymas3.Where(x => x.Type == ivestis3).ToList();
                        if (atsakymas3 != null)
                        {

                            PrintMeetingDetails(atsakymas3);

                        }
                        else
                        {
                            Console.WriteLine("Type not found");
                        }
                        break;
                        
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Enter meeting start date");
                        string ivestis4 = Console.ReadLine();
                        Console.WriteLine("Enter meeting start date");
                        string ivestis44 = Console.ReadLine();
                        List<Meeting> aprasymas4 = DB.meetingai;
                        var atsakymas4 = aprasymas4.Where(x => x.StartDate == ivestis4 && x.EndDate == ivestis44).ToList();
                        if (atsakymas4 != null)
                        {

                            PrintMeetingDetails(atsakymas4);

                        }
                        else
                        {
                            Console.WriteLine("Meetings not found");
                        }
                        break;
                        
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Enter number of meeting members");
                        string ivestis5 = Console.ReadLine();
                        List<Meeting> aprasymas5 = DB.meetingai;
                        var atsakymas5 = aprasymas5.Where(x => x.ResponsiblePerson == ivestis5).ToList();
                        if (atsakymas5 != null)
                        {

                            PrintMeetingDetails(atsakymas5);

                        }
                        else
                        {
                            Console.WriteLine("Responsible person not found");
                        }
                        break;
                        
                    case 8:
                        Console.Clear();
                        MeetingsMenu.Menu();
                        break;
                }

            }

        }
        public static void PrintMeetingDetails(List<Meeting> atsakymas)
        {
            atsakymas.ForEach(x => Console.WriteLine(
                                "Members...................{0}\n" +
                                "Responsible person........{1}\n" +
                                "Description...............{2}\n" +
                                "Category..................{3}\n" +
                                "Meeting type..............{4}\n" +
                                "Start of meeting..........{5}\n" +
                                "End of meeting............{6}\n\n",
                                x.Name, x.ResponsiblePerson, x.Description, x.Category, x.Type, x.StartDate, x.EndDate));
        }
    }
}

