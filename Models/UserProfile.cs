﻿using System;
namespace vismaUzduotis.Models
{
	public class UserProfile
	{
		public static void UserProfileInfo()
        {
            Console.Clear();
            Console.WriteLine("Jusu profilio informacija: ");
            if (Login.PRISIJUNGIMO_STATUSAS)
            {
                Console.WriteLine("Vartotojas '{0}' prisijunges", Login.VARTOTOJAS);
            }
            else
            {
                Console.WriteLine("Vartotojas nera prisijunges \n");
            }
        }
	}
}

