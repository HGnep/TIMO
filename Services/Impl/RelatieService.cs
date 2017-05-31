using System;
using System.Collections.Generic;
using System.Linq;
using TIMO.data;
using TIMO.Entities;

namespace TIMO.Services {
	public class RelatieService : IRelatieService {

		private TimoDbContext _db;

		public RelatieService(TimoDbContext dbContext){
			_db = dbContext;
		}


		public int Create(Relatie relatie) {
			_db.Relaties.Add(relatie);

			_db.SaveChanges();

			return relatie.RelatieId;
		}


		public Relatie Read(int id) {
			Relatie relatie = _db.Relaties
				.Where(r => r.RelatieId == id)
				.FirstOrDefault();
			return relatie;
		}


		public int Update(Relatie relatie) {
			throw new NotImplementedException();
		}


		public void Delete(Relatie relatie)	{
			_db.Relaties.Remove(relatie);

			_db.SaveChanges();
		}




		public IEnumerable<Relatie> ReadAll() {
			return _db.Relaties;
		}

	}
}