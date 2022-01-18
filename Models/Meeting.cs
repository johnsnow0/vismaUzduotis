using System;
using System.Text;

namespace vismaUzduotis.Models
{
	
	public class Meeting
	{
		
		private List<string> people = new List<string>();
		public IEnumerable<string> People => people;
		//public string Name { get; set; }
		public string ResponsiblePerson { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Type { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }


		public void AddPersonToMeeting(string name)
		{
			if (people.Contains(name))
			{
				return;
			}
			people.Add(name);
		}

		public string printPeopleList()
        {
			var builder = new StringBuilder();
			people.ForEach(x => builder.Append(x + ","));
			return builder.ToString();
        }
		public void RemovePersonFromMeeting(string name)
        {
			
			people.Remove(name);
		}
	}







}

