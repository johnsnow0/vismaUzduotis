using System;
namespace vismaUzduotis.Models
{
	public class MeetingSearch
	{
        public static void SusitikimuPaieska()
        {
            Console.Clear();
            Console.WriteLine("Susitikimų paieška \n");
            while (true)
            {
                Console.WriteLine(" 1 - Rodyti visus susitikimus \n 2 - Filtruoti pagal aprašymą \n 3 - Filtruoti pagal atsakingą asmenį \n 4 - Filtruoti pagal kategoriją \n 5 - Filtruoti pagal tipą \n 6 - Filtruoti pagal datas \n 7 - Filtruoti pagal žmonių kiekį \n 8 - Grižti atgal");
                Console.Write("Jusu pasirinkimas: ");
                int pasirink = int.Parse(Console.ReadLine());
                switch (pasirink)
                {

                    case 1:

                        Console.Clear();
                        Console.WriteLine("MEETINGŲ SĄRAŠAS\n");
                        List<MeetingsClass> duomenys = DB.meetingai;
                        foreach (var item in duomenys)
                        {
                            Console.WriteLine(
                                "Dalyviai................{0}\n" +
                                "Atsakingas asmuo........{1}\n" +
                                "Aprasymas...............{2}\n" +
                                "Kategorija..............{3}\n" +
                                "Susitikimo tipas........{4}\n" +
                                "Susitikmo pradzia.......{5}\n" +
                                "Susitikimo pabaiga......{6}\n\n",
                                item.Name, item.ResponsiblePerson, item.Description, item.Category, item.Type, item.StartDate, item.EndDate);

                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Įveskite susitikimo aprašymą");
                        string ivestis = Console.ReadLine();
                        List<MeetingsClass> aprasymas = DB.meetingai;
                        var atsakymas = aprasymas.Where(x => x.Description == ivestis).ToString();
                        if (atsakymas != null)
                        {
                            Console.WriteLine(atsakymas);
                        }
                        else
                        {
                            Console.WriteLine("Aprašymas nerastas");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Įveskite atsakingą asmenį");
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Įveskite kategoriją");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Įveskite tipą");
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Įveskite datas");
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Įveskite žmonių kiekį");
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

