using TIMO.Entities;

namespace TIMO.Services {
	public interface IUurService { 
		int Create(Uur uur);
		Uur Read(int id);
		int Update(Uur uur);
		void Delete(int id);
	}
}