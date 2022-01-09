using System;
namespace vismaUzduotis.Models
{
	public class MeetingsClass
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string ResponsiblePerson { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public string Type { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		public MeetingsClass(string vardas, string atsakingasAsmuo, string meetingoAprasymas, string meetingoKategorija, string meetingoTipas, DateTime meetingoPradziosData, DateTime meetingoPabaigosData)
        {
			Name = vardas;
			ResponsiblePerson = atsakingasAsmuo;
			Description = meetingoAprasymas;
			Category = meetingoKategorija;
			Type = meetingoTipas;
			StartDate = meetingoPradziosData;
			EndDate = meetingoPabaigosData;
        }
	}

	


}

