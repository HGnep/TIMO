using System.Collections.Generic;
using TIMO.Entities;

namespace TIMO.Services {
	public interface IRelatieService { 
		int Create(Relatie relatie);
		Relatie Read(int id);
		int Update(Relatie relatie); // Je haalt eerst de relatie eruit met read, daarna pas update 
		void Delete(Relatie relatie); // Eerst relatie lezen, dan verwijderen
		IEnumerable<Relatie> ReadAll();
	}
}