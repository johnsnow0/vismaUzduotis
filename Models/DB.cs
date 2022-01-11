﻿using System;
using Newtonsoft.Json;

namespace vismaUzduotis.Models
{
	public class DB
	{
		

		public static List<PersonClass> vartotojai = new();

		public static void SaveChanges()
		{
			var irasyti = JsonConvert.SerializeObject(vartotojai);

			File.WriteAllText("auth.txt", irasyti);
		}
		public static void LoadData()
        {
			var gautiDuomenys = File.ReadAllText("auth.txt");
			vartotojai = JsonConvert.DeserializeObject<List<PersonClass>>(gautiDuomenys);
		}

		public static List<MeetingsClass> meetingai = new();

		public static void SaveMeetingChanges()
		{
			var irasyti = JsonConvert.SerializeObject(meetingai);

			File.WriteAllText("meetingai.txt", irasyti);
		}
		public static void LoadMeetingData()
		{
			var gautiDuomenys = File.ReadAllText("meetingai.txt");
			meetingai = JsonConvert.DeserializeObject<List<MeetingsClass>>(gautiDuomenys);
		}
	}
}

