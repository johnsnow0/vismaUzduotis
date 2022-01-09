using System;
namespace vismaUzduotis.Models
{
	public class DB
	{
		private static int meetingIndex = 0;
		public static int sekantisMeetingas()
		{
			return meetingIndex++;
		}

		public static List<MeetingsClass> meetingai = new();
	}
}

