using System;
namespace vismaUzduotis.Models
{
	
	public class Meeting
	{
		private static int meetingIndex = 0;
		public static int sekantisMeetingas()
		{
			return meetingIndex++;
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string ResponsiblePerson { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Type { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }

		
	}

	


}

