using System;

namespace TIMO.Entities {

	public class Uur {
		public int UurId {get; set;}
		public int RelatieId {get; set;}
		public Relatie Relatie {get; set;}
		public DateTime Begintijd {get; set;}
		public DateTime Eindtijd {get; set;}
	}
}