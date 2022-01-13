using System;
using MetodasRegistracijosSistema;

namespace vismaUzduotis.Models
{
	public class MeetingsMenu
	{
		public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Susitikmų sistemos meniu \n");

            while (true)
            {
                MeetingsClass susitikimas = new MeetingsClass();

                Console.WriteLine(" 1 - Sukurti meetinga \n 2 - Ištrinti meetinga \n 3 - Meetingų sąrašas \n 4 - Prideti žmogų į susitikimą \n 5 - Pašalinti žmogų iš susitikimo \n 6 - Grižti į pagrindinį meniu");
                Console.Write("Jusu pasirinkimas: ");
                int pasirinkimas = int.Parse(Console.ReadLine());
                switch (pasirinkimas)
                {
                    case 1:
                        while (true)
                        {
                            Console.Clear();
                            susitikimas.ID = MeetingsClass.sekantisMeetingas();
                            Console.WriteLine("Jūsų vardas: ");
                            susitikimas.Name = Console.ReadLine();
                            //Console.WriteLine("Atsakingas asmuo: ");
                            susitikimas.ResponsiblePerson = "null" ;
                            Console.WriteLine("Trumpas meetingo aprašymas: ");
                            susitikimas.Description = Console.ReadLine();
                            Console.WriteLine("Pasirinkite kategorija 1 - CodeMonkey, 2 - Hub, 3 - Short, 4 - TeamBuilding): ");
                            int kategorija = int.Parse(Console.ReadLine());
                            switch (kategorija)
                            {
                                case 1:

                                    susitikimas.Category = "CodeMonkey";
                                    Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                                    break;

                                case 2:

                                    susitikimas.Category = "Hub";
                                    Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                                    break;

                                case 3:

                                    susitikimas.Category = "Short";
                                    Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                                    break;

                                case 4:

                                    susitikimas.Category = "TeamBuilding";
                                    Console.WriteLine("Jūsų pasirinkta kategorija: {0}\n", susitikimas.Category);
                                    break;
                            }

                            Console.WriteLine("Pasirinkite susitikimo tipa (1 - Live, 2 - InPerson): ");
                            int meetingoTip = int.Parse(Console.ReadLine());
                            switch (meetingoTip)
                            {

                                case 1:

                                    susitikimas.Type = "Live";
                                    Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0}\n", susitikimas.Type);
                                    break;

                                case 2:

                                    susitikimas.Type = "InPerson";
                                    Console.WriteLine("Jūsų pasirinktas susitikimo tipas: {0} \n", susitikimas.Type);
                                    break;
                            }


                            Console.WriteLine("Įveskite pradžios datą: ");
                            susitikimas.StartDate = Console.ReadLine();
                            Console.WriteLine("Įveskite pabaigos datą: ");
                            susitikimas.EndDate = Console.ReadLine();

                            DB.meetingai.Add(susitikimas);
                            DB.SaveMeetingChanges();

                            Console.WriteLine("Jūsų susitikimas užregistruotas sėkmingai \n");
                            break;
                        }
                        break;


                    case 2:

                        Console.Clear();
                        Console.WriteLine("Istrinti meetinga is saraso \n");
                        break;

                    case 3:

                        MeetingSearch.SusitikimuPaieska();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Prideti žmogų į susitikimą \n");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Pašalinti žmogų iš susitikimo \n");
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

