using System;
namespace vismaUzduotis.Models
{
	public class AddNewMeeting
	{
		public static void AddNewMeetings()
        {
            Meeting susitikimas = new Meeting();
            while (true)
            {
                Console.Clear();
                susitikimas.ID = Meeting.sekantisMeetingas();
                Console.WriteLine("Member name: ");
                susitikimas.Name = Console.ReadLine();
                //Console.WriteLine("Atsakingas asmuo: ");
                susitikimas.ResponsiblePerson = Login.VARTOTOJAS;
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
        }
	}
}

