using System;
using vismaUzduotis.Models;
using Newtonsoft.Json;

namespace MetodasRegistracijosSistema
{
    class Program
    {
        

        static void Main(string[] args)
        {
            DB.LoadData();
            DB.LoadMeetingData();
            Console.WriteLine("VISMA INTERNAL MEETING SYSTEM: \n");
            MainMenu.MainMenuUI();
        }
    }
     
}

