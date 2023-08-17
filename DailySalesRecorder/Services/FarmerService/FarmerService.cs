using DailySalesRecorder.Data;
using DailySalesRecorder.Models;

namespace DailySalesRecorder.Services.FarmerService
{
    public class FarmerService : IFarmerService
    {
        private DataContext _dataContext;

        public FarmerService(DataContext dataContext) {
            _dataContext = dataContext;
        }
        
        public async Task<Farmer> AddFarmer(Farmer farmer)
        {
            await _dataContext.Farmers.AddAsync(farmer);
            await _dataContext.SaveChangesAsync();
            return farmer;
        }

        public Farmer AlterFarmer(Farmer farmer)
        {
            throw new NotImplementedException();
        }

        public Farmer DeleteFarmer(Farmer farmer)
        {
            throw new NotImplementedException();
        }

        public async Task<Farmer> View(int id)
        {
            var result = new Farmer();
            result = await  _dataContext.Farmers.FindAsync(id);
            if (result == null)
            {
                return new Farmer();
            }
            else
                return result;
        }

        public List<Farmer> ViewAll()
        {
            throw new NotImplementedException();
        }
    }
}
