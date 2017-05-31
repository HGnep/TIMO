using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TIMO.Entities {

	public class Relatie {
		//todo: validations voor lengtes van strings etc. 

		public int RelatieId {get; set;}
		public string Voornaam {get; set;}
		public string Tussenvoegsel {get; set;}
		[Required, MinLength(1)]
		public string Achternaam {get; set;}
		[Required]
		public string Straat {get; set;}
		[Required]
		public int Huisnummer {get; set;}
		public string Toevoeging {get; set;}
		[Required]
		public string Postcode {get; set;}
		[Required]
		public string Woonplaats {get; set;}
		public DateTime Geboortedatum {get; set;}
		public string Klas {get; set;}

		[NotMapped]
		public string VolledigeNaam {
			get {
				if (String.IsNullOrEmpty(Voornaam)) {
					return Achternaam;
				}
				else if (String.IsNullOrEmpty(Tussenvoegsel)) {
					return String.Format("{0}, {1}", Achternaam, Voornaam);
				}
				else {
					return String.Format("{0}, {1}, {2}", Achternaam, Voornaam, Tussenvoegsel);
				}
			}
		}

		[NotMapped]
		public string VolledigAdres { 
			get {
				return String.Format("{0} {1}{2} \n {3} {4}", Straat, Huisnummer, Toevoeging, Postcode, Woonplaats); 
			}
		}
	}
}